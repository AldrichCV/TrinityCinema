using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Staff
{
    public partial class BuyTicket : DevExpress.XtraEditors.XtraForm
    {
        private readonly StaffMainForm staffMainForm;

        public BuyTicket(StaffMainForm staffMainForm)
        {
            InitializeComponent();
            this.staffMainForm = staffMainForm;

            LoadMovies();
            leMovie.EditValueChanged += leMovie_EditValueChanged;
        }

        // Load available movies
        private void LoadMovies()
        {
            AllMethods.LoadLookupData<Movie>(
                leMovie,
                "SELECT MovieID, Title, MoviePoster FROM Movies WHERE Status = 'Available'",
                GlobalSettings.connectionString
            );
        }

        // When a movie is selected, load corresponding showtimes
        private void leMovie_EditValueChanged(object sender, EventArgs e)
        {
            if (leMovie.EditValue != null)
            {
                int movieId = Convert.ToInt32(leMovie.EditValue);

                string query = $@"
            SELECT ShowtimeID, 
                   CONVERT(varchar, ShowDate, 101) + ' - ' + FORMAT(StartTime, 'hh:mm tt') AS DisplayTime 
            FROM Showtimes 
            WHERE MovieID = {movieId} AND Status = 'Active'";

                AllMethods.LoadLookupData<Showtime>(
                    leShowtime,
                    query,
                    GlobalSettings.connectionString
                );
            }
        }

        // Submit/Book Ticket
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (leMovie.EditValue == null || leShowtime.EditValue == null)
            {
                XtraMessageBox.Show("Please select both a movie and a showtime.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int showtimeId = Convert.ToInt32(leShowtime.EditValue);

            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Tickets (ShowtimeID, Status, DateBooked) VALUES (@ShowtimeID, 'Available', GETDATE())",
                    conn
                );

                cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                cmd.ExecuteNonQuery();

                XtraMessageBox.Show("Ticket booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
