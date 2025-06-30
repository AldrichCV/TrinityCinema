using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views
{
    public partial class MovieControl : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        private byte[] imageData;

        public MovieControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
        }

        private static string GenerateMovieID()
        {
            Random rand = new Random();
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return "MID-" + new string(Enumerable.Range(0, 6)
                .Select(i => i % 2 == 0
                    ? letters[rand.Next(letters.Length)]
                    : (char)('0' + rand.Next(10))).ToArray());
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

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are you sure you want to add this movie?", "Verify",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                AllMethods allMethods = new AllMethods();
                Movie newMovie = new Movie
                {
                    MovieID = GenerateMovieID(),
                    Title = teTitle.Text,
                    Description = meDescription.Text,
                    Genre = cbGenre.Text,
                    Duration = teDuration.Text,
                    Status = cbStatus.Text,
                    DateCreated = deDateCreated.DateTime, // Use selected date from DateEdit
                    MoviePoster = imageData
                };

                
                allMethods.InsertMethod(newMovie, GlobalSettings.insertMovieQuery);

                XtraMessageBox.Show("Movie added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                var movieList = adminMainForm.gcHome.Controls.OfType<MovieControl>().FirstOrDefault();
                if (movieList != null)
                {
                    adminMainForm.gcHome.Controls.Remove(movieList);
                }

                MovieControl newMovieControl = new MovieControl(adminMainForm)
                {
                    Dock = DockStyle.Fill
                };
                adminMainForm.gcHome.Controls.Add(newMovieControl);
                newMovieControl.BringToFront();
            }
            else
            {
                this.Close();
            }
        }
    }
}
