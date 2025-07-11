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
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        private string loggedInUser;
        public AddMovies(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
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
            DialogResult result = XtraMessageBox.Show("Are You Sure You Want to Add This Movie?", "Verify",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                // Get selected genres as comma-separated string from CheckedComboBoxEdit
                string checkedValues = leGenre.EditValue as string;

                if (string.IsNullOrWhiteSpace(checkedValues))
                {
                    MessageBox.Show("Please select at least one genre.");
                    return;
                }

                // Split the string into individual genre IDs and trim spaces
                var selectedGenreIDs = checkedValues
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToList();

                // Validate parsed genre IDs
                List<int> genreIDs = new List<int>();
                foreach (var genreIdStr in selectedGenreIDs)
                {
                    if (int.TryParse(genreIdStr, out int genreID))
                    {
                        genreIDs.Add(genreID);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid genre selected: {genreIdStr}");
                        return;
                    }
                }

                // Validate Title
                if (string.IsNullOrWhiteSpace(teTitle.Text))
                {
                    MessageBox.Show("Please enter a movie title.");
                    return;
                }

                // Validate Description
                if (string.IsNullOrWhiteSpace(meDescription.Text))
                {
                    MessageBox.Show("Please enter a movie description.");
                    return;
                }

                // Validate Duration
                if (!(teDuration.EditValue is DateTime durationValue))
                {
                    MessageBox.Show("Please enter a valid duration.");
                    return;
                }

                // Validate Image Data (poster)
                if (imageData == null)
                {
                    MessageBox.Show("Please upload a movie poster.");
                    return;
                }

                string movieID = "MID-" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();

                AllMethods allMethods = new AllMethods();

                Movie createMovie = new Movie
                {
                    MovieID = movieID,
                    Title = teTitle.Text,
                    Description = meDescription.Text,
                    Duration = durationValue.TimeOfDay,
                    Status = beStatus.IsOn,
                    DateAdded = DateTime.Now,
                    MoviePoster = imageData
                };

                // Insert the movie record
                allMethods.InsertMethod(createMovie, GlobalSettings.insertMovieQuery);

                // Insert the selected genres into the junction table
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
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

    }
    }
