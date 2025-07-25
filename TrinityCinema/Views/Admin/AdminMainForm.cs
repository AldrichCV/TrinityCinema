using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
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

        private Timer fadeInTimer;
        private double fadeStep = 0.05;
        public event EventHandler DashboardLoaded;

        private HomeDashboard dashboard;

        public AdminMainForm(string loggedInUser, EventHandler dashboardLoadedHandler = null)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;

            if (dashboardLoadedHandler != null)
                DashboardLoaded += dashboardLoadedHandler;

            dashboard = new HomeDashboard(this, loggedInUser);
            dashboard.Dock = DockStyle.Fill;
            gcHome.Controls.Add(dashboard);

            this.Shown += AdminMainForm_Shown;
        }

        private async void AdminMainForm_Shown(object sender, EventArgs e)
        {
            dashboard.DashboardReady += (s, args) =>
            {
                DashboardLoaded?.Invoke(this, EventArgs.Empty);
            };

            // Defer loading until form is visible
            await dashboard.InitializeDashboardAsync();
        }

        public void StartFadeIn()
        {
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 5; // Smoother animation
            fadeInTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += fadeStep;
                }
                else
                {
                    this.Opacity = 1;
                    fadeInTimer.Stop();
                    fadeInTimer.Dispose();
                }
            };
            fadeInTimer.Start();
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
            SeatsControl hallControl = new SeatsControl(this, loggedInUser);
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

        private async void logoutTile_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
    
            if (result == DialogResult.Yes)
            {
                // ✅ Show splash screen
                var splash = new SplashScreenManager(null, typeof(LoginSplash), true, true);
                splash.ShowWaitForm();
                splash.SetWaitFormDescription("Logging out...");

                // Optional: simulate a short delay for UX polish
                await Task.Delay(1000);

                // ✅ Log the logout activity
                allMethods.Log(loggedInUser, "Logout", $"{loggedInUser} has been logged out");

                // ✅ Close splash (optional since app is restarting)
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();

                // ✅ Restart the app
                Application.Restart();
            }
        }

        

        private void homeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            HomeDashboard homeDashboard = new HomeDashboard(this, loggedInUser);
            gcHome.Controls.Add(homeDashboard);
            homeDashboard.Dock = DockStyle.Fill;
            homeDashboard.Show();
        }
    }
}