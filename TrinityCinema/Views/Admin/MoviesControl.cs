using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class MoviesControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        private string loggedInUser;

        public MoviesControl(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            AllMethods.GridCustomization(gcMovies, tvMovieView, GetMovies());
            this.loggedInUser = loggedInUser;
        }

        public List<Movie> GetMovies()
        {
            string query = GlobalSettings.getMovie;
            return a.GetRecords<Movie>(query);
        }

        private void viewDetails_Click(object sender, EventArgs e)
        {

        }

        private void movieTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AddMovies(home, loggedInUser));
        }

        private void tvMovieView_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {

            var movieID = tvMovieView.GetRowCellValue(e.Item.RowHandle, "MovieID")?.ToString();

            if (string.IsNullOrWhiteSpace(movieID))
            {
                MessageBox.Show("Invalid movie selection.");
                return;
            }

            AllMethods.ShowModal(home =>
            {
                MovieDetails details = new MovieDetails(home, movieID, loggedInUser);

                string where = " WHERE m.MovieID = @MovieID";
                string query = GlobalSettings.getMovie + where;
                var parameters = new { MovieID = movieID };

                List<string> columns = new List<string>
                {
                    "MovieID",
                    "Title",
                    "GenreName",     // aggregated genre names like "Action, Comedy"
                    "Description",
                    "Duration",
                    "Status",
                    "MoviePoster"
                };

                Dictionary<string, string> record = a.GetRecordById(query, parameters, columns);

                if (record != null)
                {
                    // ✅ Set base text fields
                    details.teTitle.Text = record["Title"];
                    details.meDescription.Text = record["Description"];
                    details.teDuration.EditValue = record["Duration"];
                    details.beStatus.IsOn = record["Status"] == "1";

                    string[] genres = record["GenreName"].Split(',');

                    foreach (CheckedListBoxItem item in details.leGenre.Properties.Items)
                    {
                        item.CheckState = genres.Any(g => g.Trim() == item.Description)
                            ? CheckState.Checked
                            : CheckState.Unchecked;
                    }

                    // ✅ Handle poster
                    if (!string.IsNullOrEmpty(record["MoviePoster"]))
                    {
                        try
                        {
                            byte[] imageBytes = Convert.FromBase64String(record["MoviePoster"]);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                details.pePosterImage.Image = Image.FromStream(ms);
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
    }
}