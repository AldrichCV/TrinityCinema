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
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views.Staff
{
    public partial class StaffMainForm : DevExpress.XtraEditors.XtraForm
    {
        private string loggedInUser;
        private Timer clockTimer;

        private Timer fadeInTimer;
        private double fadeStep = 0.05;
        public event EventHandler DashboardLoaded;

        private StaffHome dashboard;

        public StaffMainForm(string loggedInUser, EventHandler dashboardLoadedHandler = null)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            labelControl1.Text = "Welcome back, " + loggedInUser + "!";
            InitializeClock();

            if (dashboardLoadedHandler != null)
                DashboardLoaded += dashboardLoadedHandler;

            dashboard = new StaffHome(this, loggedInUser);
            dashboard.Dock = DockStyle.Fill;
            gcHome.Controls.Add(dashboard);

            this.Shown += StaffMainForm_Shown;

        }


        private async void StaffMainForm_Shown(object sender, EventArgs e)
        {
            // Create a TaskCompletionSource to wait for the DashboardReady event
            var tcs = new TaskCompletionSource<bool>();

            dashboard.DashboardReady += (s, args) =>
            {
                tcs.TrySetResult(true); // Mark the task as completed
                DashboardLoaded?.Invoke(this, EventArgs.Empty); // Optional custom event
            };

            await tcs.Task; // Await until the DashboardReady is raised

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

        private void InitializeClock()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000; // 1 second
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            labelControl2.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
        }


        private void NewTransaction_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowtimeMovies ticketListForm = new ShowtimeMovies(this, loggedInUser);
            ticketListForm.Show();
        }
    }
}