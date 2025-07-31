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

namespace TrinityCinema.Views.Admin
{
    public partial class ReportsControl : DevExpress.XtraEditors.XtraUserControl
    {
        
        private AdminMainForm adminMainForm;
        private string loggedInUser;

        public ReportsControl(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.loggedInUser = loggedInUser;
        }

        private void allRecordsTile_ItemClick(object sender, TileItemEventArgs e)
        {
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
    }
}
