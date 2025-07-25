using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class ShowtimeControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods allMethods = new AllMethods();    
        private AdminMainForm adminMainForm;
        private string loggedInUser;

        public ShowtimeControl(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            AllMethods.GridCustomization(gcShowtime, gvShowtime, GetShowtimeToday());
            this.loggedInUser = loggedInUser;
        }

        public List<Showtime> GetShowtimeToday()
        {
            string query = GlobalSettings.getShowtime + @"
            WHERE CAST(ShowDate AS DATE) = CAST(GETDATE() AS DATE)";
            return allMethods.GetRecords<Showtime>(query, null);
        }

        public List<Showtime> GetAllShowtimes()
        {
            string query = GlobalSettings.getShowtime;
            return allMethods.GetRecords<Showtime>(query);
        }


        private void ShowtimeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AddShowtime(adminMainForm, loggedInUser));
            //RefreshShowtimeGrid();
        }

        private void repositoryItemActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            string tag = e.Button.Tag?.ToString();

            if (tag == "Edit")
            {
                int showtime = Convert.ToInt32(gvShowtime.GetFocusedRowCellValue("ShowtimeID"));

                if (showtime <= 0)
                {
                    MessageBox.Show("Invalid movie selection.");
                    return;
                }

                AllMethods.ShowModal(home =>
                {
                    EditShowtime details = new EditShowtime(home, showtime, loggedInUser);

                    string where = " WHERE s.ShowtimeID = @ShowtimeID";
                    string query = GlobalSettings.getShowtime + where;
                    var parameters = new { ShowtimeID = showtime };

                    List<string> columns = new List<string>
                    {
                    "ShowtimeID",
                    "Title",
                    "TheaterID",     // aggregated genre names like "Action, Comedy"
                    "TheaterName",
                    "ShowDate",
                    "StartTime",
                    "Price",
                    "StatusID",
                    "MoviePoster"
                    };

                    Dictionary<string, string> record = allMethods.GetRecordById(query, parameters, columns);

                    if (record != null)
                    {
                        // ✅ Set base text fields
                        details.leMovie.Text = record["Title"];
                        details.leHall.EditValue = record["TheaterID"];
                        details.deShowDate.EditValue = record["ShowDate"];
                        details.teStartTime.EditValue = record["StartTime"];
                        details.tePrice.EditValue = record["Price"];
                        details.leStatusDisplay.EditValue = record["StatusID"];

                        // ✅ Handle poster
                        if (!string.IsNullOrEmpty(record["MoviePoster"]))
                        {
                            try
                            {
                                byte[] imageBytes = Convert.FromBase64String(record["MoviePoster"]);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    details.pePoster.Image = Image.FromStream(ms);
                                }
                                details.existingImageData = imageBytes;
                            }
                            catch
                            {
                                MessageBox.Show("Failed to load movie poster image.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No movie found.");
                    }

                    return details;
                });
            }
            
            else if (tag == "Delete")
            {
                int showtime = Convert.ToInt32(gvShowtime.GetFocusedRowCellValue("ShowtimeID"));
                if (showtime <= 0)
                {
                    MessageBox.Show("Invalid movie selection.");
                    return;
                }
                DialogResult confirm = XtraMessageBox.Show($"Delete showtime with ID {showtime}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;
                using (var connection = new SqlConnection(GlobalSettings.connectionString))
                {
                    string deleteQuery = "DELETE FROM Showtimes WHERE ShowtimeID = @ShowtimeID";
                    connection.Execute(deleteQuery, new { ShowtimeID = showtime });
                }

                allMethods.Log(loggedInUser, "Remove Showtime", $"{loggedInUser} removed showtime {showtime}");
                XtraMessageBox.Show("Showtime deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AllMethods.RefreshManagerHome(mh => new ShowtimeControl(adminMainForm, loggedInUser));
            }
        }

        private void teShowFilter_EditValueChanged(object sender, EventArgs e)
        {

            if (teShowFilter.EditValue is DateTime selectedDate)
            {
                gcShowtime.DataSource = GetShowtimeByDate(selectedDate);
            }
            else
            {
                gvShowtime.ActiveFilterString = string.Empty;
            }
        }

        public List<Showtime> GetShowtimeByDate(DateTime selectedDate)
        {
            string query = GlobalSettings.getShowtime + @"
        WHERE CAST(ShowDate AS DATE) = @SelectedDate
    ";

            var param = new { SelectedDate = selectedDate.Date };

            return allMethods.GetRecords<Showtime>(query, param);
        }

        private void btnAllRecords_Click(object sender, EventArgs e)
        {
            AllMethods.GridCustomization(gcShowtime, gvShowtime, GetAllShowtimes());
        }

        private void btnFilterToday_Click(object sender, EventArgs e)
        {
            AllMethods.GridCustomization(gcShowtime, gvShowtime, GetShowtimeToday());
        }
    }
}
    
