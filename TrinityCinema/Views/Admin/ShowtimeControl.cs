using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class ShowtimeControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        private byte[] imageData;

        public ShowtimeControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
        }

        internal void RefreshShowtimeGrid()
        {
            throw new NotImplementedException();
        }

        private void ShowtimeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AddShowtime(home));
        }
    }
}
