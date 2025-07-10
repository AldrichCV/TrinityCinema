// Import required libraries and namespaces
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // For SQL Server database connection
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper; // Lightweight ORM for database operations
using DevExpress.XtraEditors; // DevExpress controls like XtraForm
using TrinityCinema.Models; // Custom models like Showtime

namespace TrinityCinema.Views.Admin
{
    public partial class EditShowtime : DevExpress.XtraEditors.XtraForm // This form is used to edit existing showtime records
    {
        private AdminMainForm adminMainForm; // Reference to the AdminMainForm (parent)
        private Showtime row; // The specific showtime row being edited


        // Constructor that receives the parent form and selected showtime row
        public EditShowtime(AdminMainForm adminMainForm, Showtime row)
        {
            InitializeComponent(); // Initialize form controls
            this.adminMainForm = adminMainForm; // Assign passed-in admin form
            this.row = row; // Assign the row being edited
            /*LoadMovies();*/ // Load movie options into LookUpEdit

            // Pre-fill input controls with existing showtime data
            teMovie.EditValue = row.MovieID;
            cbTheater.Text = row.TheaterID;
            deShowDate.DateTime = row.ShowDate;
            teStartTime.EditValue = DateTime.Today.Add(row.StartTime); // Convert TimeSpan to DateTime
            tePrice.Text = row.Price.ToString();
            cbStatusDisplay.Text = row.StatusDisplay;
        }

        // Loads movies from the database into the movie LookUpEdit
        //private void LoadMovies()
        //{
        //    AllMethods.LoadLookupData<Movie>(
        //        leMovie, // The movie dropdown control
        //        "SELECT MovieID, Title FROM Movies", // SQL query
        //        GlobalSettings.connectionString // Connection string to DB
        //    );
        //}

        // Event handler for the Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate if any required fields are empty
            if (teMovie.EditValue == null ||
                string.IsNullOrWhiteSpace(tePrice.Text) ||
                string.IsNullOrWhiteSpace(cbTheater.Text) ||
                string.IsNullOrWhiteSpace(cbStatusDisplay.Text) ||
                deShowDate.DateTime == DateTime.MinValue ||
                teStartTime.EditValue == null)
            {
                XtraMessageBox.Show("Please complete all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the price input is a valid decimal
            if (!decimal.TryParse(tePrice.Text.Trim(), out decimal parsedPrice))
            {
                XtraMessageBox.Show("Invalid price format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert status from dropdown text to an integer value
            string statusText = cbStatusDisplay.Text.Trim(); // Get status as string
            int status;
            if (statusText == "Upcoming") status = 0;
            else if (statusText == "Now Showing") status = 1;
            else if (statusText == "Cancelled") status = 2;
            else if (statusText == "Ended") status = 3;
            else
            {
                XtraMessageBox.Show("Invalid status selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm update action with the user
            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to update this showtime?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                // Create a Showtime object with updated values
                var showtime = new Showtime
                {
                    ShowtimeID = row.ShowtimeID, // Maintain original ID
                    MovieID = teMovie.EditValue.ToString(), // Get selected movie ID
                    Price = parsedPrice,
                    ShowDate = deShowDate.DateTime.Date,
                    StartTime = ((DateTime)teStartTime.EditValue).TimeOfDay,
                    TheaterID = cbTheater.Text,
                    Status = status,
                    
                };

                // SQL update query to modify the showtime record in the database
                string updateQuery = @"UPDATE Showtimes SET 
                            MovieID = @MovieID,
                            Price = @Price,
                            ShowDate = @ShowDate,
                            StartTime = @StartTime,
                            TheaterID = @TheaterID,
                            Status = @Status
                            
                            WHERE ShowtimeID = @ShowtimeID";

                // Execute the update using Dapper
                using (var con = new SqlConnection(GlobalSettings.connectionString))
                {
                    con.Execute(updateQuery, showtime); // Run the update
                }

                // Show success message
                XtraMessageBox.Show("Showtime successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the grid to reflect changes
                RefreshShowtimeGrid();
                this.Close(); // Close the edit form
            }
            catch (Exception ex)
            {
                // Display error message if something went wrong
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refresh the showtime grid on the main admin form
        private void RefreshShowtimeGrid()
        {
            // Get the ShowtimeControl inside AdminMainForm
            var showtimeControl = adminMainForm.gcHome.Controls.OfType<ShowtimeControl>().FirstOrDefault();
            if (showtimeControl != null)
            {
                showtimeControl.RefreshShowtimeGrid(); // Reload grid data
                showtimeControl.BringToFront(); // Bring it to front view
            }
            else
            {
                // Show warning if the control is not found
                XtraMessageBox.Show("ShowtimeControl not found. Grid was not refreshed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
