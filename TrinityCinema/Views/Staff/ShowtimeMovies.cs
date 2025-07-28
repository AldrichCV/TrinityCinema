using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views.Staff
{
    public partial class ShowtimeMovies : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private StaffMainForm staffMainForm;

        public ShowtimeMovies(StaffMainForm staffMainForm)
        {
            InitializeComponent();
            this.staffMainForm = staffMainForm;
            AllMethods.GridCustomization(gcShowMovies, tvShowMovies, GetMovies());
        }

        public List<Movie> GetMovies()
        {
            string query = GlobalSettings.getMovieWithTheater;
            return a.GetRecords<Movie>(query);
        }

        private void tvShowMovies_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            int theaterID = Convert.ToInt32(tvShowMovies.GetRowCellValue(e.Item.RowHandle, "TheaterID"));
            ChooseSeatLayout chooseSeatLayout = new ChooseSeatLayout(theaterID);
            chooseSeatLayout.ShowDialog();
        }
    }
}
