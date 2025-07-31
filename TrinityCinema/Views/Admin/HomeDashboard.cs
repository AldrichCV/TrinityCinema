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
        private bool hasLoaded = false;
        private Timer dashboardRefreshTimer;


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

        #region Initialization
        public async Task InitializeDashboardAsync()
        {
            await LoadDashboardAsync();
            await Task.Delay(100); // Allow UI to breathe

            StartAutoRefresh(); // <- start periodic refresh
            DashboardReady?.Invoke(this, EventArgs.Empty);
        }

        private async Task LoadDashboardAsync()
        {
            var showtimes = await GetShowtimeTodayAsync();
            AllMethods.GridCustomization(gcShowtime, gvShow, showtimes);

            var counts = await GetUserRoleCountsAsync();
            var seats = await GetSeatCountsAsync();
            UpdateUserTileElements(counts);
            UpdateHallTileElements(seats);
        }

        private void StartAutoRefresh()
        {
            dashboardRefreshTimer = new Timer();
            dashboardRefreshTimer.Interval = 10000; // refresh every 10 seconds
            dashboardRefreshTimer.Tick += async (s, e) =>
            {
                await LoadDashboardAsync();
            };
            dashboardRefreshTimer.Start();
        }
        #endregion

        #region SummaryTiles
        private void UpdateUserTileElements(RoleCounts counts)
        {
            userTile.Elements.ElementAt(1).Text = $"{counts.ManagerCount} Managers";
            userTile.Elements.ElementAt(2).Text = $"{counts.StaffCount} Staffs";

            if (counts.UserStatusCount == 0)
            {
                userTile.Elements.ElementAt(3).Text = "✔ All users active";
            }
            else
            {
                string label = counts.UserStatusCount == 1 ? "user" : "users";
                userTile.Elements.ElementAt(3).Text = $"🔒 {counts.UserStatusCount} {label} locked";
            }
        }

        private void UpdateHallTileElements(SeatCounts seats)
        {
            hallTile.Elements.ElementAt(1).Text = $"Hall1: {seats.Hall1Available} Available | Hall2: {seats.Hall2Available} Available";

            if (seats.Hall1Damaged == 0 && seats.Hall2Damaged == 0)
            {
                hallTile.Elements.ElementAt(2).Text = "✔ No seats were damaged";
            }
            else
            {
                string hall1 = seats.Hall1Damaged > 0 ? $"Hall1: {seats.Hall1Damaged}" : "";
                string hall2 = seats.Hall2Damaged > 0 ? $"Hall2: {seats.Hall2Damaged}" : "";

                string damageInfo = "";

                if (!string.IsNullOrEmpty(hall1) && !string.IsNullOrEmpty(hall2))
                    damageInfo = $"{hall1} | {hall2}";
                else
                    damageInfo = hall1 + hall2;


                hallTile.Elements.ElementAt(2).Text = $"🔒 Damaged seats - {damageInfo}";

            }
        }

        private async Task<SeatCounts> GetSeatCountsAsync()
        {
            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                string query = @"
            SELECT Hall,
                   SUM(CASE WHEN Status = 'Available' THEN 1 ELSE 0 END) AS AvailableCount,
                   SUM(CASE WHEN IsDamaged = 1 THEN 1 ELSE 0 END) AS DamagedCount
            FROM Seats
            WHERE Hall IN ('Hall1', 'Hall2')
            GROUP BY Hall";

                var results = await conn.QueryAsync(query);

                var counts = new SeatCounts();

                foreach (var row in results)
                {
                    string hall = row.Hall?.ToString();
                    int available = row.AvailableCount;
                    int damaged = row.DamagedCount;

                    if (hall == "Hall1")
                    {
                        counts.Hall1Available = available;
                        counts.Hall1Damaged = damaged;
                    }
                    else if (hall == "Hall2")
                    {
                        counts.Hall2Available = available;
                        counts.Hall2Damaged = damaged;
                    }
                }

                return counts;
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
        #endregion
    }
}
