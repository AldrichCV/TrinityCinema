using DevExpress.XtraBars.Navigation;
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
using System.Xml.Linq;

namespace TrinityCinema.Views.Admin
{
    public partial class AdminMainForm : DevExpress.XtraEditors.XtraForm
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void personnelTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            UsersControl personnelControl = new UsersControl(this);
            gcHome.Controls.Add(personnelControl);
            personnelControl.Dock = DockStyle.Fill;
            personnelControl.Show();

        }

        private void movieTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            MovieControl movieControl = new MovieControl();
            gcHome.Controls.Add(movieControl);
            movieControl.Dock = DockStyle.Fill;
            movieControl.Show();
        }

        private void theaterTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            TheaterControl theaterControl = new TheaterControl(this);
            gcHome.Controls.Add(theaterControl);
            theaterControl.Dock = DockStyle.Fill;
            theaterControl.Show();
        }
    }
}