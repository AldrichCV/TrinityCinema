using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class EditShowtime : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        public byte[] existingImageData;
        private int showtime;
        private string loggedInUser;

        public EditShowtime(AdminMainForm adminMainForm, int showtime, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.showtime = showtime;
            LoadTheaters();
            LoadShowStatus();
            this.loggedInUser = loggedInUser;
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

        private void LoadShowStatus()
        {
            AllMethods.LoadLookupData<Showtime>(
                leStatusDisplay,
                "SELECT StatusID, StatusName FROM ShowtimeStatus",
                GlobalSettings.connectionString
         );
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (leMovie.EditValue == null ||
              string.IsNullOrWhiteSpace(tePrice.Text) ||
              string.IsNullOrWhiteSpace(leHall.Text) ||
              string.IsNullOrWhiteSpace(leStatusDisplay.Text) ||
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

            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to update this showtime?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var parameters = new Showtime
                {
                    ShowtimeID = showtime,
                    Price = parsedPrice,
                    ShowDate = deShowDate.DateTime.Date,
                    StartTime = teStartTime.Time.TimeOfDay,
                    TheaterID = Convert.ToInt32(leHall.EditValue),
                    Status = Convert.ToInt32(leStatusDisplay.EditValue)
                };

                var columns = new List<string>
            {
                "Price", "ShowDate", "StartTime", "TheaterID", "Status"
            };

                bool success = allMethods.UpdateRecord("Showtimes", parameters, columns, "ShowtimeID");

                if (success)
                {
                    XtraMessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    allMethods.Log(loggedInUser, "Modified Showtime", $"Modified showtime with showtime ID of {showtime}");
                    this.Close();
                    AllMethods.RefreshManagerHome(mh => new ShowtimeControl(mh, loggedInUser));
                }
                else
                {
                    XtraMessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
