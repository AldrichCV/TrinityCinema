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
        private string loggedInUser;

        public AddShowtime(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            LoadMovies();
            LoadTheaters();
            LoadShowStatus();
            LoadMoviePoster(null);
            deShowDate.Properties.MinValue = DateTime.Today;
            teStartTime.EditValueChanging += teStartTime_EditValueChanging;

            this.loggedInUser = loggedInUser;
        }

        private void LoadMovies()
        {
            AllMethods.LoadLookupData<Movie>(
                leMovie,
                "SELECT MovieID, Title, MoviePoster FROM Movies WHERE Status=1",
                GlobalSettings.connectionString
            );
        }

        private void LoadTheaters()
        {
            // Assuming you have a method to load theaters into the ComboBox
            AllMethods.LoadLookupData<Theater>(
                cbTheater,
                "SELECT TheaterID, TheaterName FROM Theaters",
                GlobalSettings.connectionString
            );
        }

        private void LoadShowStatus()
        {
            AllMethods.LoadLookupData<Showtime>(
                leStatusDisplay,
                "SELECT StatusID, StatusName FROM ShowtimeStatus",
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
                string.IsNullOrWhiteSpace(leStatusDisplay.Text) ||
                deShowDate.DateTime == DateTime.MinValue ||
                teStartTime.EditValue == null)
            {
                XtraMessageBox.Show("Please complete all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Price = Convert.ToDecimal(tePrice.Text),
                    ShowDate = deShowDate.DateTime.Date,
                    StartTime = ((DateTime)teStartTime.EditValue).TimeOfDay,
                    TheaterID = Convert.ToInt32(cbTheater.EditValue),
                    StatusID = Convert.ToInt32(leStatusDisplay.EditValue)
                }; 
                
                var selectedMovieTitle = leMovie.Text;
                showtime.Title = selectedMovieTitle;


                AllMethods allMethods = new AllMethods();
                        allMethods.InsertMethod(showtime, GlobalSettings.insertShowtimeQuery);
                        XtraMessageBox.Show("Showtime successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                allMethods.Log(loggedInUser, "Add Showtime", $"Add showtime for {showtime.Title}");
                this.Close();
                AllMethods.RefreshManagerHome(mh => new ShowtimeControl(mh, loggedInUser));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teStartTime_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue is DateTime newTime)
            {
                TimeSpan min = new TimeSpan(9, 0, 0);   // 9:00 AM
                TimeSpan max = new TimeSpan(17, 0, 0);  // 5:00 PM
                TimeSpan inputTime = newTime.TimeOfDay;

                if (inputTime < min || inputTime > max)
                {
                    e.Cancel = true;
                    teStartTime.ErrorText = "Please select a time between 9:00 AM and 5:00 PM.";
                }
                else
                {
                    teStartTime.ErrorText = string.Empty;
                }
            }
        }
    }
}
