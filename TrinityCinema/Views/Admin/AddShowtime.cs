using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using TrinityCinema.Models;
using System.Data.SqlClient;

namespace TrinityCinema.Views.Admin
{
    public partial class AddShowtime : XtraForm
    {
        private AdminMainForm adminMainForm;
        private Showtime editingRow;

        public AddShowtime(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            LoadMovies();
            LoadMoviePoster(null); // Initially empty poster
        }

        //public AddShowtime(AdminMainForm adminMainForm, Showtime row)
        //{
        //    InitializeComponent();
        //    this.adminMainForm = adminMainForm;
        //    this.editingRow = row;
        //    LoadMovies();
        //    LoadMoviePoster(null);

        //    // Pre-fill data for editing
        //    leMovie.EditValue = row.MovieID;
        //    cbTheater.Text = row.TheaterID;
        //    deShowDate.DateTime = row.ShowDate;
        //    teStartTime.EditValue = DateTime.Today.Add(row.StartTime);
        //    tePrice.Text = row.Price.ToString();
        //    cbStatusDisplay.Text = row.StatusDisplay;
        //}

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

            if (!decimal.TryParse(tePrice.Text.Trim(), out decimal parsedPrice))
            {
                XtraMessageBox.Show("Invalid price format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to save this showtime?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
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

                using (var con = new SqlConnection(GlobalSettings.connectionString))
                {
                    if (editingRow != null)
                    {
                        showtime.ShowtimeID = editingRow.ShowtimeID;
                        string updateQuery = @"UPDATE Showtimes SET 
                            MovieID = @MovieID,
                            TheaterID = @TheaterID,
                            ShowDate = @ShowDate,
                            StartTime = @StartTime,
                            Price = @Price,
                            Status = @Status,
                            StatusDisplay = @StatusDisplay
                            WHERE ShowtimeID = @ShowtimeID";

                        con.Execute(updateQuery, showtime);
                        XtraMessageBox.Show("Showtime successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AllMethods allMethods = new AllMethods();
                        allMethods.InsertMethod(showtime, GlobalSettings.insertShowtimeQuery);
                        XtraMessageBox.Show("Showtime successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

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
            else
            {
                XtraMessageBox.Show("ShowtimeControl not found. Grid was not refreshed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
