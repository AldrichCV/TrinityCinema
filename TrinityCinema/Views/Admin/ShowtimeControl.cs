// Import necessary libraries
using System; // For core .NET functionality
using System.Collections.Generic; // For using List<T>
using System.Data.SqlClient; // For SQL Server connection
using System.Linq; // For LINQ methods like FirstOrDefault()
using System.Windows.Forms; // For Windows Forms components
using Dapper; // Lightweight ORM for database operations
using DevExpress.XtraEditors; // DevExpress UI components like XtraUserControl
using DevExpress.XtraEditors.Controls; // For DevExpress button click events
using DevExpress.XtraGrid.Views.Grid; // For GridView access
using TrinityCinema.Models; // Custom data models like Showtime

namespace TrinityCinema.Views.Admin // Namespace for admin-related views
{
    // Partial class for the custom UserControl to manage showtimes
    public partial class ShowtimeControl : DevExpress.XtraEditors.XtraUserControl
    {
        private AdminMainForm adminMainForm; // Reference to the parent admin form

        // Constructor with dependency injection of the AdminMainForm
        public ShowtimeControl(AdminMainForm adminMainForm)
        {
            InitializeComponent(); // Initialize all controls and layout
            this.adminMainForm = adminMainForm; // Store reference to the admin form

            // Optional: Attach custom event handler for action buttons in the grid (currently commented out)
            // repositoryItemActionButtons.ButtonClick += repositoryItemActionButtons_ButtonClick;

            // Load showtime data into the grid when the control is initialized
            RefreshShowtimeGrid();
        }

        // Loads all showtime records into the GridControl
        public void RefreshShowtimeGrid()
        {
            using (var connection = new SqlConnection(GlobalSettings.connectionString)) // Open DB connection
            {
                // Execute SQL query to get all showtimes and map to List<Showtime>
                var showtimes = connection.Query<Showtime>(GlobalSettings.getShowtime).ToList();

                // Bind the result list to the grid control's data source
                gcShowtime.DataSource = showtimes;
            }
        }

        // Event handler: triggered when a tile (button) is clicked to add new showtime
        private void ShowtimeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            // Open the AddShowtime modal form
            AllMethods.ShowModal(home => new AddShowtime(adminMainForm));

            // Refresh the grid after adding
            RefreshShowtimeGrid();
        }

        // Handles clicks on action buttons inside the GridView (e.g., Edit/Delete)
        private void repositoryItemActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GridView view = gvShowtime as GridView; // Cast to GridView
            Showtime row = view.GetFocusedRow() as Showtime; // Get the focused (selected) row

            if (row == null) return; // Exit if no row is selected

            string tag = e.Button.Tag?.ToString(); // Get the action tag ("Edit" or "Delete")

            if (tag == "Edit")
            {
                EditShowtime(row); // Call method to open edit form
            }
            else if (tag == "Delete")
            {
                DeleteShowtime(row); // Call method to delete the row
            }
        }

        // Opens the EditShowtime form and passes the selected row to it
        private void EditShowtime(Showtime row)
        {
            EditShowtime editForm = new EditShowtime(adminMainForm, row); // Create form instance
            editForm.ShowDialog(); // Show the form as a modal dialog
            RefreshShowtimeGrid(); // Refresh grid after update
        }

        // Deletes the selected showtime after confirmation
        private void DeleteShowtime(Showtime row)
        {
            // Ask user to confirm deletion
            DialogResult confirm = XtraMessageBox.Show(
                $"Delete showtime for movie ID {row.MovieID} on {row.ShowDate:yyyy-MM-dd}?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return; // Cancel if not confirmed

            using (var connection = new SqlConnection(GlobalSettings.connectionString)) // Open DB connection
            {
                // Define and execute delete query using Dapper
                string deleteQuery = "DELETE FROM Showtimes WHERE ShowtimeID = @ShowtimeID";
                connection.Execute(deleteQuery, new { row.ShowtimeID });
            }

            // Notify user of successful deletion
            XtraMessageBox.Show("Showtime deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the grid to reflect the deletion
            RefreshShowtimeGrid();
        }
    }
}
