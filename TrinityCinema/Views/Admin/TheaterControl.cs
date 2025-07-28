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
    public partial class TheaterControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        public TheaterControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            AllMethods.GridCustomization(gcTheater, tvTheaterView, GetTheater());
        }

        public List<Theater> GetTheater()
        {
            string query = GlobalSettings.getTheater;
            return a.GetRecords<Theater>(query);
        }


        private void theaterTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new TheaterInfo(home));
        }

        private void tvTheaterView_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            var theaterID = tvTheaterView.GetFocusedRowCellValue("TheaterID");
            if (theaterID == null || theaterID == DBNull.Value || string.IsNullOrWhiteSpace(theaterID.ToString()))
            {
                MessageBox.Show("No theater selected.");
                return;
            }

            SeatLayout seatLayoutControl = new SeatLayout(adminMainForm, Convert.ToInt32(theaterID));
            seatLayoutControl.Dock = DockStyle.Fill;

            adminMainForm.gcHome.Controls.Clear();
            adminMainForm.gcHome.Controls.Add(seatLayoutControl);
        }
    }
}
