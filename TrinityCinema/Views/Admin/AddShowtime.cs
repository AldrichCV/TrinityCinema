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
            teStartTime.EditValue = DateTime.Today.AddHours(9); // sets to 9:00 AM today

            teStartTime.EditValueChanging += teStartTime_EditValueChanging;
            this.deShowDate.EditValueChanged += DateOrPriceChanged;
            this.teBasePrice.EditValueChanged += DateOrPriceChanged;

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

            string movieId = leMovie.EditValue.ToString();

            if (string.IsNullOrWhiteSpace(movieId))
            {
                XtraMessageBox.Show("Please select a movie.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate theater selection
            if (!int.TryParse(cbTheater.EditValue?.ToString(), out int theaterId))
            {
                XtraMessageBox.Show("Please select a theater.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validate start time
            if (teStartTime.EditValue == null || !DateTime.TryParse(teStartTime.EditValue.ToString(), out DateTime newStartTime))
            {
                XtraMessageBox.Show("Please select a valid showtime.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan duration;

            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                try
                {
                    // Fetch duration as a string to avoid casting issues
                    string rawDuration = connection.ExecuteScalar<string>(
                        "SELECT CONVERT(VARCHAR(8), Duration, 108) FROM Movies WHERE MovieID = @MovieID",
                        new { MovieID = movieId });

                    if (string.IsNullOrWhiteSpace(rawDuration))
                    {
                        XtraMessageBox.Show("No duration found for the selected movie.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!TimeSpan.TryParse(rawDuration, out duration))
                    {
                        XtraMessageBox.Show("Invalid format for movie duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (duration.TotalMinutes <= 0)
                    {
                        XtraMessageBox.Show("Movie duration must be greater than 0 minutes.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error retrieving movie duration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Later...
                DateTime newEndTime = newStartTime.Add(duration);



                // 6. Check for showtime conflicts
                if (ShowtimeConflicts(theaterId, newStartTime, newEndTime))
                {
                    XtraMessageBox.Show("A conflicting showtime already exists in this theater during that time.",
                                        "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void DateOrPriceChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void CalculateFinalPrice()
        {
            // Make sure date and price are not null or empty
            if (deShowDate.EditValue == null || string.IsNullOrWhiteSpace(teBasePrice.Text))
            {
                tePrice.Text = "";
                return;
            }

            // Try parsing the base price
            if (!decimal.TryParse(teBasePrice.Text.Trim(), out decimal basePrice))
            {
                tePrice.Text = "Invalid";
                return;
            }

            DateTime selectedDate = (DateTime)deShowDate.EditValue;

            // Check if weekend
            bool isWeekend = selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday;

            // Add ₱50 if weekend
            decimal finalPrice = basePrice + (isWeekend ? 50 : 0);

            tePrice.Text = finalPrice.ToString("0.00");
        }

        private void tePrice_EditValueChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void deShowDate_EditValueChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private bool ShowtimeConflicts(int theaterId, DateTime newStartTime, DateTime newEndTime)
        {
            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                string sql = @"SELECT COUNT(1)
FROM Showtimes s
LEFT JOIN Movies m ON m.MovieID = s.MovieID
WHERE s.TheaterID = @TheaterID
  AND (
        @NewStartTime >= DATEADD(SECOND, 0, CAST(s.ShowDate AS DATETIME) + CAST(s.StartTime AS DATETIME))
        AND @NewStartTime < DATEADD(MINUTE, DATEDIFF(MINUTE, 0, m.Duration), DATEADD(SECOND, 0, CAST(s.ShowDate AS DATETIME) + CAST(s.StartTime AS DATETIME))
      )
   OR
        @NewEndTime > DATEADD(SECOND, 0, CAST(s.ShowDate AS DATETIME) + CAST(s.StartTime AS DATETIME))
        AND @NewEndTime <= DATEADD(MINUTE, DATEDIFF(MINUTE, 0, m.Duration), DATEADD(SECOND, 0, CAST(s.ShowDate AS DATETIME) + CAST(s.StartTime AS DATETIME))
      )
   OR
        @NewStartTime <= DATEADD(SECOND, 0, CAST(s.ShowDate AS DATETIME) + CAST(s.StartTime AS DATETIME))
        AND @NewEndTime >= DATEADD(MINUTE, DATEDIFF(MINUTE, 0, m.Duration), DATEADD(SECOND, 0, CAST(s.ShowDate AS DATETIME) + CAST(s.StartTime AS DATETIME))
      )
)

";

                int count = connection.ExecuteScalar<int>(sql, new
                {
                    TheaterID = theaterId,
                    NewStartTime = newStartTime,
                    NewEndTime = newEndTime
                });

                return count > 0;
            }
        }


    }
}
