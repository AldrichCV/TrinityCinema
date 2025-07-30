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
using TrinityCinema.Views.Admin;
using static DevExpress.Xpo.DB.DataStoreLongrunnersWatch;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TrinityCinema.Views.Staff
{
    public partial class SeatLayout : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
        private string currentHall;
        private StaffMainForm staffMainForm;
        private string loggedInUser;
        private int currentShowtimeId;
        public SeatLayout(string loggedInUser, int showtimeId, string hallName)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.currentShowtimeId = showtimeId;
            this.currentHall = hallName;
            InitSeatSelectionTable();
            SvgImageBoxLoad();
            LoadSeatData(currentHall, currentShowtimeId);
            ApplySeatStyles();
            UpdateSeatCounts();
        }

        public void SvgImageBoxLoad()
        {
            svgImageBox1.ItemAppearance.Selected.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemAppearance.Hovered.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Black;
            svgImageBox1.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;


            svgImageBox1.ItemAppearance.Selected.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemAppearance.Hovered.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Black;
            svgImageBox1.ItemHitTestType = ItemHitTestType.BoundingBox;

            svgImageBox1.QueryHoveredItem += OnSvgImageBoxQueryHoveredItem;
            gridControl1.DataSource = seatSelectionTable;

            gridControl1.DataSource = seatSelectionTable;

            // Optional: Set column captions
            gridView1.Columns["SeatLabel"].Caption = "Selected Seat";
            // SeatLabel column properties
            gridView1.Columns["SeatLabel"].Caption = "Selected Seat";
            gridView1.Columns["SeatLabel"].AppearanceHeader.Font = new Font("Segoe UI", 8F);
            gridView1.Columns["SeatLabel"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["SeatLabel"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["SeatLabel"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["SeatLabel"].VisibleIndex = 0;


            // Hide the other columns
            gridView1.Columns["SeatId"].Visible = false;
            gridView1.Columns["Hall"].Visible = false;
            gridView1.Columns["ShowtimeId"].Visible = false;
            gridView1.Columns["Status"].Visible = false;

            gridView1.Columns["MovieID"].Visible = false;
            gridView1.Columns["RatingCode"].Visible = false;
            gridView1.Columns["TheaterID"].Visible = false;
            gridView1.Columns["Duration"].Visible = false;
            gridView1.Columns["EndTime"].Visible = false;
            gridView1.Columns["StatusID"].Visible = false;

            // Optional: Show these as needed
            gridView1.Columns["Title"].Visible = false;
            gridView1.Columns["GenreName"].Visible = false;
            gridView1.Columns["TheaterName"].Visible = false;
            gridView1.Columns["ShowDate"].Visible = false;
            gridView1.Columns["StartTime"].Visible = false;
            gridView1.Columns["Price"].Visible = false;
            gridView1.Columns["StatusDisplay"].Visible = false;
        }


        public void OnSvgImageBoxQueryHoveredItem(object sender, SvgImageQueryHoveredItemEventArgs e)
        {
            if (e.HoveredItem != null && !CheckSeatId(e.HoveredItem))
                e.HoveredItem = e.HoveredItem.FindAncestors(a => CheckSeatId(a)).FirstOrDefault();
        }
        bool CheckSeatId(SvgImageItem svgImageItem)
        {
            return svgImageItem.Id != null && svgImageItem.Id.StartsWith("seat");
        }

        private Dictionary<string, Seat> seatData = new Dictionary<string, Seat>();

        #region SeatRenderering
        private void LoadSeatData(string hall, int showtimeId)
        {
            seatData.Clear();

            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                string query = @"SELECT s.SeatId, sb.Status, s.SeatLabel, s.Hall, ISNULL(s.IsDamaged, 0) AS IsDamaged
                                FROM Seats s
                                LEFT JOIN SeatBookings sb ON s.SeatId = sb.SeatId AND sb.ShowtimeId = @ShowtimeId
                                WHERE s.Hall = @Hall";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ShowtimeId", showtimeId);
                    cmd.Parameters.AddWithValue("@Hall", hall);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var seat = new Seat
                            {
                                SeatId = reader["SeatId"].ToString(),
                                Status = reader["Status"] == DBNull.Value ? "Available" : reader["Status"].ToString(),
                                SeatLabel = reader["SeatLabel"].ToString(),
                                Hall = reader["Hall"].ToString(),
                                IsDamaged = Convert.ToBoolean(reader["IsDamaged"])
                            };

                            seatData[seat.SeatId] = seat;
                        }
                    }
                }
            }
        }


        private List<SvgImageItem> GetAllItems(IEnumerable<SvgImageItem> items)
        {
            var result = new List<SvgImageItem>();

            foreach (var item in items)
            {
                if (item == null)
                    continue;

                result.Add(item);

                if (item.Items != null && item.Items.Count > 0)
                {
                    result.AddRange(GetAllItems(item.Items));
                }
            }

            return result;
        }
        private void ApplySeatStyles()
        {
            var allItems = GetAllItems(svgImageBox1.RootItems);

            foreach (var item in allItems)
            {
                if (item?.Id == null || !seatData.ContainsKey(item.Id))
                    continue;

                var seat = seatData[item.Id];
                Color fillColor = Color.Gray;

                // Always apply availability mode coloring
                switch (seat.Status)
                {
                    case "Taken":
                        fillColor = Color.Red;
                        break;
                    case "Reserved":
                        fillColor = Color.Orange;
                        break;
                    case "Available":
                        fillColor = Color.Green;
                        break;
                    default:
                        fillColor = Color.Gray;
                        break;
                }

                // Optional: override if damaged
                if (seat.IsDamaged)
                    fillColor = Color.Black;

                item.Appearance.Normal.FillColor = fillColor;
            }

            svgImageBox1.Invalidate(); // Force redraw
        }
        #endregion

        #region ToggleConditions
        private void ToggleSeatStatus(string seatId, string hall, int showtimeId)
        {
            if (seatData.TryGetValue(seatId, out var seat))
            {
                // Check if seat is already selected (ignore if in selection)
                var existing = seatSelectionTable.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("SeatId") == seatId && r.Field<int>("ShowtimeId") == showtimeId);

                if (existing == null && (seat.Status == "Taken" || seat.Status == "Reserved"))
                {
                    XtraMessageBox.Show($"Seat {seat.SeatLabel} is already {seat.Status}.", "Seat Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (existing != null)
                {
                    seatSelectionTable.Rows.Remove(existing);
                    seat.Status = "Available";
                }
                else
                {
                    seatSelectionTable.Rows.Add(seatId, hall, showtimeId, "Taken", seat.SeatLabel);
                    seat.Status = "Taken";
                }

                ApplySeatStyles();
                gridControl1.RefreshDataSource();
            }
        }

        private DataTable seatSelectionTable = new DataTable();
        private void InitSeatSelectionTable()
        {
            seatSelectionTable.Columns.Add("SeatId", typeof(string));
            seatSelectionTable.Columns.Add("Hall", typeof(string));
            seatSelectionTable.Columns.Add("ShowtimeId", typeof(int));
            seatSelectionTable.Columns.Add("Status", typeof(string));
            seatSelectionTable.Columns.Add("SeatLabel", typeof(string));

            // Columns from your showtime query
            seatSelectionTable.Columns.Add("MovieID", typeof(string));
            seatSelectionTable.Columns.Add("Title", typeof(string));
            seatSelectionTable.Columns.Add("GenreName", typeof(string));
            seatSelectionTable.Columns.Add("RatingCode", typeof(string));
            seatSelectionTable.Columns.Add("TheaterID", typeof(string));
            seatSelectionTable.Columns.Add("TheaterName", typeof(string));
            seatSelectionTable.Columns.Add("Price", typeof(decimal));
            seatSelectionTable.Columns.Add("ShowDate", typeof(DateTime));
            seatSelectionTable.Columns.Add("StartTime", typeof(TimeSpan));
            seatSelectionTable.Columns.Add("Duration", typeof(TimeSpan));
            seatSelectionTable.Columns.Add("EndTime", typeof(TimeSpan));
            seatSelectionTable.Columns.Add("StatusID", typeof(int));
            seatSelectionTable.Columns.Add("StatusDisplay", typeof(string));
        }


        #endregion

        #region IndexChangedEvents and UpdateSeatCounts
        private void UpdateSeatCounts()
        {
            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                                SUM(CASE WHEN Status = 'Available' THEN 1 ELSE 0 END) AS AvailableCount,
                                SUM(CASE WHEN Status = 'Taken' THEN 1 ELSE 0 END) AS TakenCount
                             FROM Seats
                             WHERE Hall = @Hall";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hall", currentHall);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int available = Convert.ToInt32(reader["AvailableCount"]);
                            int taken = Convert.ToInt32(reader["TakenCount"]);

                        }
                    }
                }

            }
        }

        private void svgImageBox1_ItemClick_1(object sender, SvgImageItemMouseEventArgs e)
        {
            string clickedSeatId = e.Item?.Id;

            if (!string.IsNullOrEmpty(clickedSeatId) && clickedSeatId.StartsWith("seat"))
            {
                ToggleSeatStatus(clickedSeatId, currentHall, currentShowtimeId);
                UpdateSeatCounts();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (seatSelectionTable.Rows.Count == 0)
            {
                XtraMessageBox.Show("No seats selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = XtraMessageBox.Show("Are you sure you want to confirm this booking?", "Confirm Booking",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            // Fetch full showtime details including price
            var showtime = allMethods.GetRecords<Showtime>(
                GlobalSettings.getShowtime + @"WHERE ShowtimeId = @ShowtimeId",
                new { ShowtimeId = currentShowtimeId }
            ).FirstOrDefault();

            if (showtime == null)
            {
                XtraMessageBox.Show("Failed to load showtime details.", "Error");
                return;
            }

            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                foreach (DataRow row in seatSelectionTable.Rows)
                {
                    string seatId = row.Field<string>("SeatId");
                    int showtimeId = row.Field<int>("ShowtimeId");

                    // Check if already booked
                    string checkQuery = "SELECT COUNT(*) FROM SeatBookings WHERE SeatId = @SeatId AND ShowtimeId = @ShowtimeId";
                    using (var checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@SeatId", seatId);
                        checkCmd.Parameters.AddWithValue("@ShowtimeId", showtimeId);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            string updateQuery = @"UPDATE SeatBookings SET Status = 'Taken' 
                                           WHERE SeatId = @SeatId AND ShowtimeId = @ShowtimeId";
                            using (var updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@SeatId", seatId);
                                updateCmd.Parameters.AddWithValue("@ShowtimeId", showtimeId);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"INSERT INTO SeatBookings (SeatId, ShowtimeId, Status) 
                                           VALUES (@SeatId, @ShowtimeId, 'Taken')";
                            using (var insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@SeatId", seatId);
                                insertCmd.Parameters.AddWithValue("@ShowtimeId", showtimeId);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Insert transaction record
                    string insertTransQuery = @"INSERT INTO BookingTransactions (ShowtimeId, SeatId, Price)
                                        VALUES (@ShowtimeId, @SeatId, @Price)";
                    using (var transCmd = new SqlCommand(insertTransQuery, conn))
                    {
                        transCmd.Parameters.AddWithValue("@ShowtimeId", showtimeId);
                        transCmd.Parameters.AddWithValue("@SeatId", seatId);
                        transCmd.Parameters.AddWithValue("@Price", showtime.Price);
                        transCmd.ExecuteNonQuery();
                    }

                    // Log user action
                    allMethods.Log(loggedInUser, "Showtime Purchase",
                        $"User '{loggedInUser}' booked Seat '{seatId}' for Showtime {showtimeId} at ₱{showtime.Price}."
                    );
                }

                // Show ticket report
                ShowTicketReport();

                // Refresh layout and clear selection
                seatSelectionTable.Clear();
                LoadSeatData(currentHall, currentShowtimeId);
                ApplySeatStyles();
                gridControl1.RefreshDataSource();

                XtraMessageBox.Show("Booking confirmed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ShowTicketReport()
        {
            string query = GlobalSettings.getShowtime + @"WHERE ShowtimeId = @ShowtimeId";

            var showtime = allMethods.GetRecords<Showtime>(
                query,
                new { ShowtimeId = currentShowtimeId }
            ).FirstOrDefault();

            if (showtime == null)
            {
                XtraMessageBox.Show("Failed to load showtime details.", "Error");
                return;
            }

            if (seatSelectionTable.Rows.Count == 0)
            {
                XtraMessageBox.Show("No data to print.", "Error");
                return;
            }

            // Copy and enrich the table with showtime info
            DataTable reportTable = seatSelectionTable.Copy();

            foreach (DataRow row in reportTable.Rows)
            {
                row["Title"] = showtime.Title;
                row["GenreName"] = showtime.GenreName;
                row["RatingCode"] = showtime.RatingCode;
                row["TheaterID"] = showtime.TheaterID;
                row["TheaterName"] = showtime.TheaterName;
                row["Price"] = showtime.Price;
                row["ShowDate"] = showtime.ShowDate;
                row["StartTime"] = showtime.StartTime;
                row["Duration"] = showtime.Duration;
                row["EndTime"] = showtime.EndTime;
                row["StatusID"] = showtime.StatusID;
                row["StatusDisplay"] = showtime.StatusDisplay;
            }

            // Optional: sort for readability
            reportTable.DefaultView.Sort = "SeatLabel ASC";
            reportTable = reportTable.DefaultView.ToTable();

            // Bind to report
            var ticketReport = new XtraTicket();
            ticketReport.DataSource = reportTable;

            new ReportPrintTool(ticketReport).ShowPreviewDialog();
        }

        #endregion
    }
}