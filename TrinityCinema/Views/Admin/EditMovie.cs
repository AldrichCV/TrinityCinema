using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TrinityCinema.Models;
using Dapper;

namespace TrinityCinema.Views.Admin
{
    public partial class EditMovie : DevExpress.XtraEditors.XtraForm
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        private string movieID;
        private byte[] imageData;

        public EditMovie(AdminMainForm adminMainForm, string movieID)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.movieID = movieID;
            RetrieveMovieDetails(movieID);
        }

        private T FindControl<T>(Control parent) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T foundControl)
                    return foundControl;

                var result = FindControl<T>(control);
                if (result != null)
                    return result;
            }
            return null;
        }

        private void RetrieveMovieDetails(string movieID)
        {
            string query = "SELECT * FROM Movies WHERE MovieID = @MovieID";
            var columns = new List<string> { "Title", "Description", "Genre", "Duration", "Status", "DateCreated" };
            var data = a.GetRecordById(query, new { MovieID = movieID }, columns);

            if (data != null)
            {
                FindControl<TextEdit>(this).Text = data["Title"];
                meDescription.Text = data["Description"];
                cbGenre.Text = data["Genre"];
                teDuration.Text = data["Duration"];
                cbStatus.Text = data["Status"];
                if (DateTime.TryParse(data["DateCreated"], out DateTime dateCreated))
                    deDateCreated.DateTime = dateCreated;
            }

            RetrieveImage(movieID);
        }

        private void RetrieveImage(string movieID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalSettings.connectionString))
                {
                    connection.Open();
                    string query = "SELECT MoviePoster FROM Movies WHERE MovieID = @MovieID";
                    byte[] imgData = connection.QueryFirstOrDefault<byte[]>(query, new { MovieID = movieID });
                    if (imgData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            pePoster.Image = Image.FromStream(ms);
                            imageData = imgData;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        pePoster.Image = Image.FromFile(openFileDialog.FileName);
                        pePoster.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            pePoster.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to update this movie?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (string.IsNullOrWhiteSpace(teTitle.Text))
            {
                XtraMessageBox.Show("Please complete all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parameters = new
            {
                MovieID = movieID,
                Title = teTitle.Text,
                Description = meDescription.Text,
                Genre = cbGenre.Text,
                Duration = teDuration.Text,
                Status = cbStatus.Text,
                DateCreated = deDateCreated.DateTime
            };

            var columns = new List<string>
            {
                "Title", "Description", "Genre", "Duration", "Status", "DateCreated"
            };

            bool success = a.UpdateRecord("Movies", parameters, columns, "MovieID");

            if (success)
            {
                XtraMessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                AllMethods.RefreshManagerHome(mh => new MoviesControl(mh));
            }
            else
            {
                XtraMessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to remove this movie?", "Confirm Removal",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                this.Close();
                return;
            }

           a.RemoveRecordByKey(
                primaryKeyColumn: "MovieID",
                primaryKeyValue: movieID,
                tablesToDeleteFrom: new List<string> { "Movies" },
                connectionString: GlobalSettings.connectionString
            );

            this.Close();
            AllMethods.RefreshManagerHome(mh => new MoviesControl(mh));
        }
    }
}
