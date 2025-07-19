using DevExpress.XtraBars.Navigation;
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
using System.Xml.Linq;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class AdminMainForm : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
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
            HallControl hallControl = new HallControl(this, loggedInUser);
            gcHome.Controls.Add(hallControl);
            hallControl.Dock = DockStyle.Fill;
            hallControl.Show();
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

        private void gcHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutTile_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                allMethods.Log(loggedInUser, "Logout", $"{loggedInUser} has been logged out");
                Application.Restart();
            }
            else
            {
                return;
            }
        }
    }
}