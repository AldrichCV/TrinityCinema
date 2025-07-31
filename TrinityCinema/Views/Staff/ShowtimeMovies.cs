using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views.Staff
{
    public partial class ShowtimeMovies : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
        private StaffMainForm staffMainForm;
        private string loggedInUser;

        public ShowtimeMovies(StaffMainForm staffMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.staffMainForm = staffMainForm;
            this.loggedInUser = loggedInUser;
            AllMethods.GridCustomization(gcShowMovies, tvShowMovies, GetShowtimeToday());
        }
        public List<Showtime> GetShowtimeToday()
        {
            string query = GlobalSettings.getShowtime + @"
            WHERE CAST(ShowDate AS DATE) = CAST(GETDATE() AS DATE)";
            return allMethods.GetRecords<Showtime>(query, null);
        }
        private void tvShowMovies_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            int showtimeId = Convert.ToInt32(tvShowMovies.GetRowCellValue(e.Item.RowHandle, "ShowtimeID"));
            string hallName = tvShowMovies.GetRowCellValue(e.Item.RowHandle, "TheaterName").ToString();
            SeatLayout chooseSeatLayout = new SeatLayout(loggedInUser,showtimeId,hallName);
            chooseSeatLayout.ShowDialog();
        }
    }
}
