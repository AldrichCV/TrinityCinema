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
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views
{
    public partial class SeatsControl : DevExpress.XtraEditors.XtraUserControl
    {
        public class Seat
        {
            public string SeatId { get; set; }
            public string Status { get; set; }
            public string SeatLabel { get; set; }
            public string Hall { get; set; }
            public bool IsDamaged { get; set; }
        }


        private string currentHall = "Hall1";
        private AdminMainForm adminMainForm;
        private string loggedInUser;

        public SeatsControl(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();

            svgImageBox1.ItemAppearance.Selected.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemAppearance.Hovered.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Black;
            svgImageBox1.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;


            svgImageBox1.ItemAppearance.Selected.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemAppearance.Hovered.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Black;
            svgImageBox1.ItemHitTestType = ItemHitTestType.BoundingBox;

            svgImageBox1.QueryHoveredItem += OnSvgImageBoxQueryHoveredItem;

            cbAction.SelectedIndex = 0; // Default to "Availability"
            cbHall.SelectedIndex = cbHall.Properties.Items.IndexOf("Hall1"); // Default to "Hall1"

            // Set current hall
            currentHall = cbHall.SelectedItem.ToString();



            LoadSeatData(currentHall);
            ApplySeatStyles();
            UpdateSeatCounts();
            this.loggedInUser = loggedInUser;
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

        private void LoadSeatData(string hall)
        {
            seatData.Clear();

            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                // Single valid query
                string query = @" SELECT SeatId, Status, Hall, ISNULL(IsDamaged, 0) AS IsDamaged
                                  FROM Seats
                                  WHERE Hall = @Hall";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hall", hall);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var seat = new Seat
                            {
                                SeatId = reader["SeatId"].ToString(),
                                Status = reader["Status"].ToString(),
                                Hall = reader["Hall"].ToString(),
                                IsDamaged = Convert.ToBoolean(reader["IsDamaged"]) // <- Assign here
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

                // Get action mode
                int selectedAction = cbAction.SelectedIndex;

                if (selectedAction == 0) // Availability mode
                {
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
                }
                else if (selectedAction == 1) // Damaged mode
                {
                    fillColor = seat.IsDamaged ? Color.Black : Color.LightGray;
                }

                item.Appearance.Normal.FillColor = fillColor;
            }

            svgImageBox1.Invalidate(); // Force redraw
        }

        private void ToggleSeatStatus(string seatId, string hall)
        {
            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                string query = @"UPDATE Seats
                                    SET Status = CASE 
                                        WHEN Status = 'Available' THEN 'Taken'
                                        ELSE 'Available'
                                    END
                                    WHERE SeatId = @SeatId AND Hall = @Hall";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SeatId", seatId);
                    cmd.Parameters.AddWithValue("@Hall", hall);
                    cmd.ExecuteNonQuery();
                }
            }

            // Refresh view
            LoadSeatData(hall); // pass the current hall again
            ApplySeatStyles();
        }
        private void svgImageBox1_ItemClick(object sender, SvgImageItemMouseEventArgs e)
        {
            string clickedSeatId = e.Item?.Id;

            if (!string.IsNullOrEmpty(clickedSeatId) && clickedSeatId.StartsWith("seat"))
            {
                if (cbAction.SelectedIndex == 0) // Toggle Availability
                {
                    ToggleSeatStatus(clickedSeatId, currentHall);
                }
                else if (cbAction.SelectedIndex == 1) // Toggle Damaged
                {
                    ToggleSeatDamage(clickedSeatId, currentHall);
                }
                UpdateSeatCounts();
            }
        }

        private void ToggleSeatDamage(string seatId, string hall)
        {
            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                string query = @"UPDATE Seats
                                SET IsDamaged = CASE 
                                    WHEN IsDamaged = 1 THEN 0
                                    ELSE 1
                                END
                                WHERE SeatId = @SeatId AND Hall = @Hall";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SeatId", seatId);
                    cmd.Parameters.AddWithValue("@Hall", hall);
                    cmd.ExecuteNonQuery();
                }
            }

            // Refresh UI
            LoadSeatData(hall);
            ApplySeatStyles();
        }


        private void cbHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentHall = cbHall.SelectedItem.ToString(); // "Hall1" or "Hall2"
            LoadSeatData(currentHall);    // load for this hall only
            ApplySeatStyles();
            UpdateSeatCounts();
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0)
                lcMode.Text = "Mode: Availability Editing";
            else if (cbAction.SelectedIndex == 1)
                lcMode.Text = "Mode: Condition Editing";
            ApplySeatStyles();
            UpdateSeatCounts();
        }

        private void UpdateSeatCounts()
        {
            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                if (cbAction.SelectedIndex == 0) // Availability Mode
                {
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

                                lcStatus.Text = $"Available: {available}, Taken: {taken}";
                            }
                        }
                    }
                }
                else if (cbAction.SelectedIndex == 1) // Condition Mode
                {
                    string query = @"SELECT 
                                COUNT(*) AS DamagedCount
                             FROM Seats
                             WHERE Hall = @Hall AND ISNULL(IsDamaged, 0) = 1";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Hall", currentHall);
                        int damagedCount = (int)cmd.ExecuteScalar();

                        if (damagedCount == 0)
                            lcStatus.Text = "All seats intact";
                        else
                            lcStatus.Text = $"Damaged Seats: {damagedCount}";
                    }
                }
            }
        }

    }
}
