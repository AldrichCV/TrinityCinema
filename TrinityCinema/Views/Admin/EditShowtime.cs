using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class EditShowtime : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        public byte[] existingImageData;
        private int showtime;

        public EditShowtime(AdminMainForm adminMainForm, int showtime)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.showtime = showtime;
            LoadTheaters();
        }
        private void LoadTheaters()
        {
            // Assuming you have a method to load theaters into the ComboBox
            AllMethods.LoadLookupData<Theater>(
                leHall,
                "SELECT TheaterID, TheaterName FROM Theaters",
                GlobalSettings.connectionString
            );
        }

        private void RefreshShowtimeGrid()
            {
                var showtimeControl = adminMainForm.gcHome.Controls.OfType<ShowtimeControl>().FirstOrDefault();
                if (showtimeControl != null)
                {
                    //showtimeControl.RefreshShowtimeGrid();
                    showtimeControl.BringToFront();
                }
                else
                {
                    XtraMessageBox.Show("ShowtimeControl not found. Grid was not refreshed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (leMovie.EditValue == null ||
              string.IsNullOrWhiteSpace(tePrice.Text) ||
              string.IsNullOrWhiteSpace(leHall.Text) ||
              string.IsNullOrWhiteSpace(cbStatus.Text) ||
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

            string statusText = cbStatus.Text.Trim();
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

            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to update this showtime?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                Showtime show = new Showtime
                {
                    ShowtimeID = showtime,
                    MovieID = leMovie.EditValue.ToString(),
                    Price = parsedPrice,
                    ShowDate = deShowDate.DateTime.Date,
                    StartTime = ((DateTime)teStartTime.EditValue).TimeOfDay,
                    TheaterID = Convert.ToInt32(leHall.EditValue),
                    Status = status,
                    StatusDisplay = statusText
                };

                string updateQuery = @"UPDATE Showtimes SET 
                            MovieID = @MovieID,
                            Price = @Price,
                            ShowDate = @ShowDate,
                            StartTime = @StartTime,
                            TheaterID = @TheaterID,
                            Status = @Status,
                            StatusDisplay = @StatusDisplay
                            WHERE ShowtimeID = @ShowtimeID";

                using (var con = new SqlConnection(GlobalSettings.connectionString))
                {
                    con.Execute(updateQuery, showtime);
                }

                XtraMessageBox.Show("Showtime successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshShowtimeGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
