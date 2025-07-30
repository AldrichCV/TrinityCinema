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

        #region DataLoad
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
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {// 1. Field validation
            if (leMovie.EditValue == null ||
                string.IsNullOrWhiteSpace(tePrice.Text) ||
                cbTheater.EditValue == null ||
                leStatusDisplay.EditValue == null ||
                deShowDate.DateTime == DateTime.MinValue ||
                teStartTime.EditValue == null)
            {
                XtraMessageBox.Show("Please complete all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string movieId = leMovie.EditValue.ToString();

            // 2. Parse TheaterID
            if (!int.TryParse(cbTheater.EditValue.ToString(), out int theaterId))
            {
                XtraMessageBox.Show("Please select a valid theater.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Parse StartTime
            if (!DateTime.TryParse(teStartTime.EditValue.ToString(), out DateTime newStartDateTime))
            {
                XtraMessageBox.Show("Please select a valid showtime.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime showDate = deShowDate.DateTime.Date;
            TimeSpan newStartTime = newStartDateTime.TimeOfDay;
            TimeSpan duration;

            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                try
                {
                    connection.Open();

                    // 4. Fetch Duration as string
                    string rawDuration = connection.ExecuteScalar<string>(
                        "SELECT CONVERT(VARCHAR(8), Duration, 108) FROM Movies WHERE MovieID = @MovieID",
                        new { MovieID = movieId });

                    if (string.IsNullOrWhiteSpace(rawDuration) || !TimeSpan.TryParse(rawDuration, out duration) || duration.TotalMinutes <= 0)
                    {
                        XtraMessageBox.Show("Invalid movie duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    TimeSpan newEndTime = newStartTime.Add(duration);

                    // 5. Conflict detection
                    string conflictQuery = @"SELECT 1
                                            FROM Showtimes s
                                            LEFT JOIN Movies m ON m.MovieID = s.MovieID
                                            WHERE 
                                            s.TheaterID = @TheaterID
                                            AND s.ShowDate = @ShowDate
                                            AND (
                                                @NewStartTime < DATEADD(SECOND, DATEDIFF(SECOND, '00:00:00', m.Duration), s.StartTime)
                                                AND s.StartTime < @NewEndTime
                    )";

                    var hasConflict = connection.QueryFirstOrDefault<int>(
                        conflictQuery,
                        new
                        {
                            TheaterID = theaterId,
                            ShowDate = showDate,
                            NewStartTime = newStartTime,
                            NewEndTime = newEndTime
                        });

                    if (hasConflict > 0)
                    {
                        XtraMessageBox.Show("A conflicting showtime already exists in this theater during that time.",
                                            "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 6. Confirm and submit
                    DialogResult confirm = XtraMessageBox.Show("Are you sure you want to save this showtime?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm != DialogResult.Yes)
                        return;

                    var showtime = new Showtime
                    {
                        MovieID = movieId,
                        Price = Convert.ToDecimal(tePrice.Text),
                        ShowDate = showDate,
                        StartTime = newStartTime,
                        TheaterID = theaterId,
                        StatusID = Convert.ToInt32(leStatusDisplay.EditValue),
                        Title = leMovie.Text
                    };

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

        #region ValueChanging Events
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
        #endregion

    }
}
