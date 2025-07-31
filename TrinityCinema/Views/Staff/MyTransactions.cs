using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
using TrinityCinema.Reports;

namespace TrinityCinema.Views.Staff
{
    public partial class MyTransactions : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods allMethods = new AllMethods();
        private StaffMainForm staffMainForm;  
        private string loggedInUser;
        public MyTransactions(StaffMainForm staffMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.staffMainForm = staffMainForm;
            this.loggedInUser = loggedInUser;

            // Start async initialization without blocking the UI thread
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            var logs = await GetLogsAsync();
            AllMethods.GridCustomization(gcTransactions, gvTraction, logs);
        }

        public async Task<List<Traction>> GetLogsAsync()
        {
            string query = GlobalSettings.getTraction;
            return await Task.Run(() => allMethods.GetRecords<Traction>(query));
        }

        public async void RefreshList()
        {
            try
            {
                var logs = await GetLogsAsync();
                AllMethods.GridCustomization(gcTransactions, gvTraction, logs);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Failed to refresh user list.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintTransaction_ItemClick(object sender, TileItemEventArgs e)
        {
            // 2. Query data
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                string query = @"SELECT
                                bt.TransactionId AS TicketID,
                                m.MovieId,
                                m.Title,
                                t.TheaterName,
                                s.ShowDate,
                                s.StartTime,
                                se.SeatLabel AS SeatNumber,
                                bt.Price
                            FROM BookingTransactions bt
                            JOIN Showtimes s ON bt.ShowtimeId = s.ShowtimeId
                            JOIN Movies m ON s.MovieId = m.MovieId
                            JOIN Theaters t ON s.TheaterId = t.TheaterId
                            JOIN Seats se ON bt.SeatId = se.SeatId
                            ORDER BY m.Title, s.ShowDate, s.StartTime;
                            ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    da.Fill(dt);
                }
            }

            // 3. Load into report or preview
            if (dt.Rows.Count > 0)
            {
                // Option A: Show in DevExpress XtraReport
                var report = new TicketReport(); // You need to create this
                report.DataSource = dt;
                report.ShowPreviewDialog();

                // Option B: Show in custom form (e.g., GridControl in PrintTransactionForm)
                /*
                var form = new PrintTransactionForm();
                form.LoadData(dt);
                form.ShowDialog();
                */
            }
            else
            {
                XtraMessageBox.Show("No transactions found to print.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            staffMainForm.gcHome.Controls.Clear();

            // Create and add StaffHome control
            var staffHome = new StaffHome(staffMainForm, loggedInUser); // make sure you have this UserControl
            staffHome.Dock = DockStyle.Fill;
            staffMainForm.gcHome.Controls.Add(staffHome);
            staffHome.BringToFront();
        }
    }
}
    