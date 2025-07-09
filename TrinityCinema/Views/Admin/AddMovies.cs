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
        public AddMovies(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            LoadGenre();
        }

        private void LoadGenre()
        {
            AllMethods.LoadLookupData<Genre>(
            leGenre,
            "SELECT * FROM Genre",
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
            DialogResult result = XtraMessageBox.Show("Are You Sure You Want to Add This Employee?", "Verify",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string movieID = "MID-" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
                AllMethods allMethods = new AllMethods();
                Movie createMovie = new Movie
                {
                    MovieID = movieID,
                    Title = teTitle.Text,
                    Description = meDescription.Text,
                    Genre = Convert.ToInt32(leGenre.EditValue),
                    Duration = ((DateTime)teDuration.EditValue).TimeOfDay,
                    Status = beStatus.IsOn,
                    DateAdded = DateTime.Now,
                    MoviePoster = imageData
                };

                allMethods.InsertMethod(createMovie, GlobalSettings.insertMovieQuery);
                XtraMessageBox.Show("Movie added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                var movieList = adminMainForm.gcHome.Controls.OfType<MoviesControl>().FirstOrDefault();

                if (movieList != null)
                {
                    adminMainForm.gcHome.Controls.Remove(movieList); // Remove old instance
                }

                MoviesControl newMoviesControl = new MoviesControl(adminMainForm)
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