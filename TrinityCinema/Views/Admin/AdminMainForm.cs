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
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class AdminMainForm : DevExpress.XtraEditors.XtraForm
    {
        private string loggedInUser;
        private string username;

        public AdminMainForm(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void personnelTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            UsersControl personnelControl = new UsersControl(this, loggedInUser);
            gcHome.Controls.Add(personnelControl);
            personnelControl.Dock = DockStyle.Fill;
            personnelControl.Show();

        }

        private void movieTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            MoviesControl movieControl = new MoviesControl(this,loggedInUser);
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

        private void showtimeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            ShowtimeControl showtimeControl = new ShowtimeControl(this, loggedInUser);
            gcHome.Controls.Add(showtimeControl);
            showtimeControl.Dock = DockStyle.Fill;
            showtimeControl.Show();
            //showtimeControl.RefreshShowtimeGrid();

        }

        private void logsTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            ActivityLogControl activityControl = new ActivityLogControl(this);
            gcHome.Controls.Add(activityControl);
            activityControl.Dock = DockStyle.Fill;
            activityControl.Show();
        }
    }
}