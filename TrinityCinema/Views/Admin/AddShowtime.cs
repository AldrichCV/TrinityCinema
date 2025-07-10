// Importing required libraries and namespaces
using System; // Base .NET library for core types
using System.Data; // For working with DataTable and DataSet
using System.Drawing; // For image handling
using System.IO; // For working with file and memory streams
using System.Linq; // For LINQ operations like FirstOrDefault()
using System.Windows.Forms; // For Windows Forms controls
using Dapper; // Lightweight ORM for executing SQL queries
using DevExpress.XtraEditors; // DevExpress UI components
using TrinityCinema.Models; // Custom model classes
using System.Data.SqlClient; // SQL Server connection support

namespace TrinityCinema.Views.Admin // Namespace for organizing admin-related forms
{
    public partial class AddShowtime : XtraForm // Inherits from DevExpress XtraForm
    {
        private AdminMainForm adminMainForm; // Reference to the main admin form
  

        // Constructor that accepts the admin main form
        public AddShowtime(AdminMainForm adminMainForm)
        {
            InitializeComponent(); // Initialize UI components
            this.adminMainForm = adminMainForm; // Store passed form for later reference
            LoadMovies(); // Load movies into lookup control
            LoadMoviePoster(null); // Set initial poster to empty
        }

        // Loads movies from the database into the LookUpEdit control
        private void LoadMovies()
        {
            AllMethods.LoadLookupData<Movie>( // Reusable method for populating lookup
                leMovie, // The LookUpEdit control
                "SELECT MovieID, Title, MoviePoster FROM Movies", // SQL query
                GlobalSettings.connectionString // Database connection string
            );
        }

        // Event handler for when a movie is selected from the dropdown
        private void leMovie_EditValueChanged(object sender, EventArgs e)
        {
            var selectedMovie = leMovie.GetSelectedDataRow() as Movie; // Get selected movie

            if (selectedMovie != null && selectedMovie.MoviePoster != null)
            {
                try
                {
                    // Load movie poster from byte[] and display it
                    var ms = new MemoryStream(selectedMovie.MoviePoster);
                    pePoster.Image = Image.FromStream(ms);
                }
                catch
                {
                    pePoster.Image = null; // Clear image on error
                }
            }
            else
            {
                pePoster.Image = null; // Clear image if no poster
            }
        }

        // Manually load a movie poster image into the PictureEdit
        private void LoadMoviePoster(byte[] moviePoster)
        {
            if (moviePoster != null)
            {
                var ms = new MemoryStream(moviePoster); // Convert byte[] to stream
                pePoster.Image = Image.FromStream(ms); // Set image from stream
            }
            else
            {
                pePoster.Image = null; // Clear image if null
            }
        }

        // Handler for the Submit button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validation: Check for required fields
            if (leMovie.EditValue == null ||
                string.IsNullOrWhiteSpace(tePrice.Text) ||
                string.IsNullOrWhiteSpace(cbTheater.Text) ||
                string.IsNullOrWhiteSpace(cbStatusDisplay.Text) ||
                deShowDate.DateTime == DateTime.MinValue ||
                teStartTime.EditValue == null)
            {
                XtraMessageBox.Show("Please complete all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate price input
            if (!decimal.TryParse(tePrice.Text.Trim(), out decimal parsedPrice))
            {
                XtraMessageBox.Show("Invalid price format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert status text into an integer value
            string statusText = cbStatusDisplay.Text.Trim(); // Get status text
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

            // Ask the user to confirm saving
            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to save this showtime?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                // Create and fill Showtime object with form data
                var showtime = new Showtime
                {
                    MovieID = leMovie.EditValue.ToString(),
                    Price = parsedPrice,
                    ShowDate = deShowDate.DateTime.Date,
                    StartTime = ((DateTime)teStartTime.EditValue).TimeOfDay,
                    TheaterID = cbTheater.Text,
                    Status = status,
                    StatusDisplay = statusText
                };

                // Insert the new showtime into the database
                AllMethods allMethods = new AllMethods();
                allMethods.InsertMethod(showtime, GlobalSettings.insertShowtimeQuery);

                // Show success message and refresh grid
                XtraMessageBox.Show("Showtime successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshShowtimeGrid(); // Refresh grid after insert
                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                // Show error message if insert fails
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refreshes the showtime grid on the main form
        private void RefreshShowtimeGrid()
        {
            // Try to get the ShowtimeControl inside the AdminMainForm
            var showtimeControl = adminMainForm.gcHome.Controls.OfType<ShowtimeControl>().FirstOrDefault();

            if (showtimeControl != null)
            {
                showtimeControl.RefreshShowtimeGrid(); // Reload data in grid
                showtimeControl.BringToFront(); // Bring the control into view
            }
            else
            {
                // Show warning if the control wasn't found
                XtraMessageBox.Show("ShowtimeControl not found. Grid was not refreshed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
