using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class AddMovies : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        private string loggedInUser;
        public AddMovies(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            LoadGenre();
            LoadRating();
            this.loggedInUser = loggedInUser;
            beStatus.Properties.OnText = "Available";
            beStatus.Properties.OffText = "Unavailable";
        }
        private void LoadGenre()
        {
            AllMethods.LoadCheckedComboBoxData<Genre>(
                leGenre,
                "SELECT GenreID, GenreName FROM Genre",
                GlobalSettings.connectionString
            );
        }

        private void LoadRating()
        {
            AllMethods.LoadLookupData<ContentRating>(
              leRating,
              "SELECT RatingID, RatingCode FROM MovieRating",
              GlobalSettings.connectionString
          );
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teTitle.Text) ||
       string.IsNullOrWhiteSpace(meDescription.Text) ||
       !(teDuration.EditValue is DateTime) ||
       imageData == null ||
       string.IsNullOrWhiteSpace(leGenre.EditValue as string))
            {
                XtraMessageBox.Show("Please fill in the required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = XtraMessageBox.Show("Are you sure you want to add this movie?", "Verify",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Parse genre IDs
                var selectedGenreIDs = (leGenre.EditValue as string)
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToList();

                List<int> genreIDs = new List<int>();
                foreach (var genreIdStr in selectedGenreIDs)
                {
                    if (int.TryParse(genreIdStr, out int genreID))
                    {
                        genreIDs.Add(genreID);
                    }
                    else
                    {
                        XtraMessageBox.Show($"Invalid genre selected: {genreIdStr}", "Invalid Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string movieID = "MID-" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();

                Movie createMovie = new Movie
                {
                    MovieID = movieID,
                    Title = teTitle.Text.Trim(),
                    Description = meDescription.Text.Trim(),
                    Duration = ((DateTime)teDuration.EditValue).TimeOfDay,
                    Status = beStatus.IsOn,
                    DateAdded = DateTime.Now,
                    MoviePoster = imageData,
                    ContentRating = Convert.ToInt32(leRating.EditValue)
                };

                allMethods.InsertMethod(createMovie, GlobalSettings.insertMovieQuery);

                foreach (int genreID in genreIDs)
                {
                    allMethods.InsertMovieGenre(movieID, genreID);
                }

                XtraMessageBox.Show("Movie and genres added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                allMethods.Log(loggedInUser, "Add Movie", $"Added movie: {createMovie.Title}");

                this.Close();

                // Refresh movie list UI
                var movieList = adminMainForm.gcHome.Controls.OfType<MoviesControl>().FirstOrDefault();
                if (movieList != null)
                    adminMainForm.gcHome.Controls.Remove(movieList);

                MoviesControl newMoviesControl = new MoviesControl(adminMainForm, loggedInUser)
                {
                    Dock = DockStyle.Fill
                };
                adminMainForm.gcHome.Controls.Add(newMoviesControl);
                newMoviesControl.BringToFront();
            }
            else
            {
                this.Close();
            }
        }
    }
    }
