using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class ShowtimeControl : DevExpress.XtraEditors.XtraUserControl
    {
        private AdminMainForm adminMainForm;

        public ShowtimeControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;

            // Wire up button click events for action column
            //repositoryItemActionButtons.ButtonClick += repositoryItemActionButtons_ButtonClick;

            // Load grid initially
            RefreshShowtimeGrid();
        }

        public void RefreshShowtimeGrid()
        {
            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                
                var showtimes = connection.Query<Showtime>(GlobalSettings.getShowtime).ToList();
                gcShowtime.DataSource = showtimes;
            }
        }

        private void ShowtimeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AddShowtime(adminMainForm));
            RefreshShowtimeGrid();
        }

        private void repositoryItemActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GridView view = gvShowtime as GridView;
            Showtime row = view.GetFocusedRow() as Showtime;

            if (row == null) return;

            string tag = e.Button.Tag?.ToString();

            if (tag == "Edit")
            {
                EditShowtime(row);
            }
            else if (tag == "Delete")
            {
                DeleteShowtime(row);
            }
        }

        private void EditShowtime(Showtime row)
        {
            EditShowtime editForm = new EditShowtime(adminMainForm, row);
            editForm.ShowDialog();
            RefreshShowtimeGrid();
        }

        private void DeleteShowtime(Showtime row)
        {
            DialogResult confirm = XtraMessageBox.Show($"Delete showtime for movie ID {row.MovieID} on {row.ShowDate:yyyy-MM-dd}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                string deleteQuery = "DELETE FROM Showtimes WHERE ShowtimeID = @ShowtimeID";
                connection.Execute(deleteQuery, new { row.ShowtimeID });
            }

            XtraMessageBox.Show("Showtime deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshShowtimeGrid();
        }
    }
}
