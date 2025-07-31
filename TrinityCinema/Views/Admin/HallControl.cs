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

namespace TrinityCinema.Views.Admin
{
    public partial class HallControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        private string loggedInUser;

        public HallControl(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.loggedInUser = loggedInUser;
            AllMethods.GridCustomization(gcTheater, tvTheaterView, GetTheater());
        }

        public List<Theater> GetTheater()
        {
            string query = GlobalSettings.getTheater;
            return allMethods.GetRecords<Theater>(query);
        }


        private void theaterTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new TheaterInfo(home));
        }

        private void tvTheaterView_ItemClick_1(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            var theaterID = tvTheaterView.GetFocusedRowCellValue("TheaterID");
            if (theaterID == null || theaterID == DBNull.Value || string.IsNullOrWhiteSpace(theaterID.ToString()))
            {
                MessageBox.Show("No theater selected.");
                return;
            }

            SeatManagement seatLayoutControl = new SeatManagement(adminMainForm, Convert.ToInt32(theaterID));
            seatLayoutControl.Show();
            seatLayoutControl.BringToFront();
        }
    }
}
