using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views
{
    public partial class MovieControl : DevExpress.XtraEditors.XtraUserControl
    {
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        private AllMethods allMethods;
        private string insertMovieQuery = GlobalSettings.insertMovieQuery; // Use the insert query from GlobalSettings
        private string selectMoviesQuery = "SELECT * FROM [dbo].[Movies]"; // Adjust as necessary

        public MovieControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            allMethods = new AllMethods();
            LoadMovies();
        }

        private void LoadMovies()
        {
            var movies = allMethods.GetRecords<Movie>(selectMoviesQuery);
            AllMethods.GridCustomization(gcMovieList, tvMovies, movies);
        }


        private static string GenerateMovieID()
        {
            Random rand = new Random();
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return "MID-" + new string(Enumerable.Range(0, 6).Select(i => i % 2 == 0
                    ? letters[rand.Next(letters.Length)]
                    : (char)('0' + rand.Next(10))).ToArray());
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
                        XtraMessageBox.Show("Error: " + ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teTitle.Text) || string.IsNullOrWhiteSpace(teDuration.Text) || imageData == null)
            {
                XtraMessageBox.Show("Please fill in all fields and select a poster image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var movie = new Movie
            {
                //MovieID = Guid.NewGuid().ToString(), // Generate a new MovieID
                MovieID = GenerateMovieID(),
                Title = teTitle.Text,
                Description = meDescription.Text,
                Genre = cbGenre.Text,
                Duration = teDuration.Text,
                Status = cbStatus.Text,
                DateCreated = deDateCreated.DateTime,
                MoviePoster = imageData
            };

            allMethods.InsertMethod(movie, insertMovieQuery);
            XtraMessageBox.Show("Movie details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMovies();
            ClearFields();
        }

        private void ClearFields()
        {
            teTitle.Text = string.Empty;
            teDuration.Text = string.Empty;
            cbGenre.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            meDescription.Text = string.Empty;
            deDateCreated.EditValue = null;
            pePoster.Image = null;
            imageData = null;
        }
    }
}
