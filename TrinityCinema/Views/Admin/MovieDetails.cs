using Dapper;
using DevExpress.Data.Filtering.Helpers;
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
    public partial class MovieDetails : DevExpress.XtraEditors.XtraForm
    {
        private bool isEditing = false;
        private bool isInitializing = true;

        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        public byte[] existingImageData;
        private string movieID;
        private string loggedInUser;

        public MovieDetails(AdminMainForm adminMainForm, string movieID, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.movieID = movieID;
            LoadGenre();
            this.loggedInUser = loggedInUser;
        }

        private void LoadGenre()
        {
            AllMethods.LoadCheckedComboBoxData<Genre>(
                leGenre,
                "SELECT GenreID, GenreName FROM Genre",
                GlobalSettings.connectionString
            );
        }

        private void MovieDetails_Load(object sender, EventArgs e)
        {
            teTitle.Properties.ReadOnly = true;
            leGenre.Properties.ReadOnly = true;
            meDescription.Properties.ReadOnly = true;
            teDuration.Properties.ReadOnly = true;
            btnBrowse.Enabled = false;
            isInitializing = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;

            teTitle.Properties.ReadOnly =
            leGenre.Properties.ReadOnly =
            meDescription.Properties.ReadOnly =
            teDuration.Properties.ReadOnly = !isEditing;

            teTitle.TabStop =
            leGenre.TabStop =
            meDescription.TabStop =
            teDuration.TabStop = isEditing;
            btnBrowse.Enabled = isEditing;
            beStatus.Enabled = isEditing;
            btnEdit.Text = isEditing ? "Save" : "Edit";

            if (!isEditing)
                SaveMovieChanges(); // Optional save method
        }

        private void SaveMovieChanges()
        {

            if (XtraMessageBox.Show("Update movie?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (string.IsNullOrWhiteSpace(teTitle.Text))
            {
                XtraMessageBox.Show("Please fill up all required fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (imageData == null)
            {
                imageData = existingImageData;
            }

            TimeSpan duration = TimeSpan.Zero;
            if (teDuration.EditValue is DateTime dt)
                duration = dt.TimeOfDay;
            else if (teDuration.EditValue != null)
                TimeSpan.TryParse(teDuration.EditValue.ToString(), out duration);

            string checkedValues = leGenre.EditValue as string;

            if (string.IsNullOrWhiteSpace(checkedValues))
            {
                MessageBox.Show("Please select at least one genre.");
                return;
            }

            List<int> genreIDs = new List<int>();
            foreach (var genreIdStr in checkedValues.Split(','))
            {
                if (int.TryParse(genreIdStr.Trim(), out int genreID))
                {
                    genreIDs.Add(genreID);
                }
                else
                {
                    MessageBox.Show($"Invalid genre selected: {genreIdStr}");
                    return;
                }
            }

            var parameters = new
            {
                movieID,
                Title = teTitle.Text,
                Description = meDescription.Text,
                Duration = duration,
                Status = beStatus.IsOn,
                MoviePoster = imageData
            };

            var columns = new List<string>
            {
                "Title",
                "Description",
                "Duration",
                "Status",
                "MoviePoster"
            };

            var db = new AllMethods();

            // Update main movie record
            if (!db.UpdateRecord("Movies", parameters, columns, "movieID"))
            {
                XtraMessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Junction table update without ExecuteNonQuery ---
            // Step 1: Delete all existing genre links for the movie

            bool deleteSuccess = db.RemoveRecordByKey("MovieID", movieID.ToString(), new List<string> { "MovieGenres" }, GlobalSettings.connectionString);

            if (!deleteSuccess)
            {
                XtraMessageBox.Show("Failed to clear existing genres!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Insert new genre links one by one
            foreach (int genreID in genreIDs)
            {
                var genreLinkParams = new
                {
                    MovieID = movieID,
                    GenreID = genreID
                };

                bool insertSuccess = db.InsertMovieGenre(movieID, genreID);
                if (!insertSuccess)
                {
                    XtraMessageBox.Show($"Failed to insert genre ID {genreID}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            XtraMessageBox.Show("Movie updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            allMethods.Log(loggedInUser, "Edit Movie", $"Updated movie: {teTitle.Text}");

            this.Close();

            AllMethods.RefreshManagerHome(mh => new MoviesControl(mh, loggedInUser));
        }

        private void beStatus_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (isInitializing)
                return;

            bool newStatus = Convert.ToBoolean(e.NewValue);

            string message = newStatus
                ? "Make the movie active?"
                : "Make the movie inactive?";

            var result = XtraMessageBox.Show(message, "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            var parameters = new
            {
                movieID,
                Status = newStatus
            };

            var columns = new List<string> { "Status" };

            if (!new AllMethods().UpdateRecord("Movies", parameters, columns, "movieID"))
            {
                XtraMessageBox.Show("Failed to update status!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            allMethods.Log(loggedInUser, "Edit Movie Status", $"Updated movie status of {teTitle.Text} to {(newStatus ? "Active" : "Inactive")}");

            AllMethods.RefreshManagerHome(mh => new MoviesControl(mh, loggedInUser));
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pePosterImage.Image = Image.FromFile(openFileDialog.FileName);
                        pePosterImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            pePosterImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can use other image formats
                            imageData = ms.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error: " + ex.Message, "Error Loading Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

    }
}
