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
    public partial class MoviesControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        public MoviesControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            AllMethods.GridCustomization(gcMovies, tvMovieView, GetMovies());
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
            AllMethods.ShowModal(home => new AddMovies(home));
        }

        private void tvMovieView_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {

            var movieID = tvMovieView.GetRowCellValue(e.Item.RowHandle, "MovieID")?.ToString();

            AllMethods.ShowModal(home =>
            {
                MovieDetails details = new MovieDetails(home, movieID);

                // Prepare query and parameters
                string query = @"SELECT * FROM [dbo].[Movies] WHERE MovieID = @MovieID";
                var parameters = new { movieID };
                List<string> columns = new List<string>
        {
            "MovieID",
            "Title",
            "Genre",
            "Description",
            "Duration",
            "Status",
            "MoviePoster"
        };

                Dictionary<string, string> record = a.GetRecordById(query, parameters, columns);

                if (record != null)
                {
                    // Populate fields
                    details.teTitle.Text = record["Title"];
                    details.leGenre.EditValue = record["Genre"];
                    details.meDescription.Text = record["Description"];
                    details.teDuration.EditValue = record["Duration"];
                    details.beStatus.IsOn = record["Status"] == "1";

                    if (!string.IsNullOrEmpty(record["MoviePoster"]))
                    {
                        byte[] imageBytes = Convert.FromBase64String(record["MoviePoster"]);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            details.pePosterImage.Image = Image.FromStream(ms);
                        }
                        details.existingImageData = imageBytes;
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