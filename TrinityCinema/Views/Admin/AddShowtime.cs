using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class AddShowtime : XtraForm
    {
        private AdminMainForm adminMainForm;

        public AddShowtime(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            LoadMovies();
            LoadMoviePoster(null); // Initially empty poster
        }

        private void LoadMovies()
        {
            AllMethods.LoadLookupData<Movie>(
                leMovie,
                "SELECT MovieID, Title, MoviePoster FROM Movies",
                GlobalSettings.connectionString
            );
        }

        private void leMovie_EditValueChanged(object sender, EventArgs e)
        {
            var selectedMovie = leMovie.GetSelectedDataRow() as Movie;

            if (selectedMovie != null && selectedMovie.MoviePoster != null)
            {
                try
                {
                    var ms = new MemoryStream(selectedMovie.MoviePoster);
                    pePoster.Image = Image.FromStream(ms);
                }
                catch
                {
                    pePoster.Image = null;
                }
            }
            else
            {
                pePoster.Image = null;
            }
        }

        private void LoadMoviePoster(byte[] moviePoster)
        {
            if (moviePoster != null)
            {
                var ms = new MemoryStream(moviePoster);
                pePoster.Image = Image.FromStream(ms);
            }
            else
            {
                pePoster.Image = null;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate required fields
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

            // Parse price
            if (!decimal.TryParse(tePrice.Text.Trim(), out decimal parsedPrice))
            {
                XtraMessageBox.Show("Invalid price format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Map status text to int value
            string statusText = cbStatusDisplay.Text.Trim();
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

            // Confirm action
            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to add this showtime?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var showtime = new Showtime
                {
                    MovieID = Convert.ToInt32(leMovie.EditValue),
                    Price = parsedPrice,
                    ShowDate = deShowDate.DateTime.Date,
                    StartTime = ((DateTime)teStartTime.EditValue).TimeOfDay,
                    TheaterName = cbTheater.Text,
                    Status = status,
                    StatusDisplay = statusText
                };

                AllMethods allMethods = new AllMethods();
                allMethods.InsertMethod(showtime, GlobalSettings.insertShowtimeQuery);

                XtraMessageBox.Show("Showtime successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshShowtimeGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshShowtimeGrid()
        {
            var showtimeControl = adminMainForm.gcHome.Controls.OfType<ShowtimeControl>().FirstOrDefault();
            if (showtimeControl != null)
            {
                showtimeControl.RefreshShowtimeGrid();
                showtimeControl.BringToFront();
            }
        }
    }
}
