using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using Dapper;

namespace TrinityCinema.Views.Admin
{
    public partial class HomeDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        public class RoleCounts
        {
            public int ManagerCount { get; set; }
            public int StaffCount { get; set; }

            public int UserStatusCount { get; set; }
        }
        private bool hasLoaded = false;


        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        private string loggedInUser;
        public event EventHandler DashboardReady;

        public HomeDashboard(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.loggedInUser = loggedInUser;
            labelControl1.Text = $"Welcome back, {loggedInUser}";
        }

        public async Task InitializeDashboardAsync()
        {
            await LoadDashboardAsync();
            await Task.Delay(100); // Allow UI to breathe
            DashboardReady?.Invoke(this, EventArgs.Empty);
        }


        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (!hasLoaded)
            {
                hasLoaded = true;

                // Let the form fully load before starting async logic
                BeginInvoke(new Action(async () =>
                {
                    await LoadDashboardAsync();
                    await Task.Delay(100); // Let rendering finish
                    DashboardReady?.Invoke(this, EventArgs.Empty);
                }));
            }
        }
        private async Task LoadDashboardAsync()
        {
            var showtimes = await GetShowtimeTodayAsync();
            AllMethods.GridCustomization(gcShowtime, gvShow, showtimes);

            var counts = await GetUserRoleCountsAsync();
            UpdateUserTileElements(counts);
        }

        private void UpdateUserTileElements(RoleCounts counts)
        {
            userTile.Elements.ElementAt(4).Text = $"{counts.ManagerCount}";
            userTile.Elements.ElementAt(3).Text = $"{counts.StaffCount}";

            if (counts.UserStatusCount == 0)
            {
                userTile.Elements.ElementAt(5).Text = "✔ All users active";
            }
            else
            {
                string label = counts.UserStatusCount == 1 ? "user" : "users";
                userTile.Elements.ElementAt(5).Text = $"🔒 {counts.UserStatusCount} {label} locked";
            }
        }

        private async Task<RoleCounts> GetUserRoleCountsAsync()
        {
            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                string query = @"
                    SELECT
                        SUM(CASE WHEN Role = 'Manager' THEN 1 ELSE 0 END) AS ManagerCount,
                        SUM(CASE WHEN Role = 'Staff' THEN 1 ELSE 0 END) AS StaffCount,
                        SUM(CASE WHEN IsLocked = 1 THEN 1 ELSE 0 END) AS UserStatusCount
                    FROM Users";

                return await conn.QueryFirstOrDefaultAsync<RoleCounts>(query);
            }
        }

        public async Task<List<Showtime>> GetShowtimeTodayAsync()
        {
            string query = GlobalSettings.getShowtime + @"
                WHERE CAST(ShowDate AS DATE) = CAST(GETDATE() AS DATE)";
            return await Task.Run(() => allMethods.GetRecords<Showtime>(query, null));
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void dashBoard_Click(object sender, EventArgs e)
        {

        }
    }
}
