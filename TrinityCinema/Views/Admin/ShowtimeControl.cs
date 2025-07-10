using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TrinityCinema.Models;
using System.Drawing;

namespace TrinityCinema.Views.Admin
{
    public partial class ShowtimeControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();    
        private AdminMainForm adminMainForm;

        public ShowtimeControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            AllMethods.GridCustomization(gcShowtime, gvShowtime, GetMovies());
        }

        public List<Showtime> GetMovies()
        {
            string query = GlobalSettings.getShowtime;
            return a.GetRecords<Showtime>(query);
        }


        private void ShowtimeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AddShowtime(adminMainForm));
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
                    EditShowtime details = new EditShowtime(home, showtime);

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
                    "Status",
                    "MoviePoster"
                    };

                    Dictionary<string, string> record = a.GetRecordById(query, parameters, columns);

                    if (record != null)
                    {
                        // ✅ Set base text fields
                        details.leMovie.Text = record["Title"];
                        details.leHall.EditValue = record["TheaterID"];
                        details.deShowDate.EditValue = record["ShowDate"];
                        details.teStartTime.EditValue = record["StartTime"];
                        details.tePrice.EditValue = record["Price"];
                        details.cbStatus.EditValue = record["Status"];

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
                XtraMessageBox.Show("Showtime deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AllMethods.RefreshManagerHome(mh => new ShowtimeControl(adminMainForm));
            }
        }
    }
}