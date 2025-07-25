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
        private string currentHall = "Hall1";
        private AdminMainForm adminMainForm;
        private string loggedInUser;

        public SeatsControl(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();

            svgImageBox1.ItemAppearance.Selected.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemAppearance.Hovered.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;


            svgImageBox1.ItemAppearance.Selected.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemAppearance.Hovered.FillColor = DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue;
            svgImageBox1.ItemHitTestType = ItemHitTestType.BoundingBox;

            svgImageBox1.QueryHoveredItem += OnSvgImageBoxQueryHoveredItem;

            LoadSeatData(currentHall);
            ApplySeatStyles();
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

        public class Seat
        {
            public string SeatId { get; set; }
            public string Status { get; set; }
            public string SeatLabel { get; set; }
            public string Hall { get; set; }
        }

        private Dictionary<string, Seat> seatData = new Dictionary<string, Seat>();

        private void LoadSeatData(string hall)
        {
            seatData.Clear();

            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();
                string query = "SELECT SeatId, Status, Hall FROM Seats WHERE Hall = @Hall";

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
                                Hall = reader["Hall"].ToString()
                            };

                            // Store by SeatId only, since SVG uses seat_1..seat_82
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
                Color fillColor;

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

                // ✅ This should still be available even in limited versions
                item.Appearance.Normal.FillColor = fillColor;
            }

            svgImageBox1.Invalidate(); // Force redraw
        }
        private void ToggleSeatStatus(string seatId, string hall)
        {
            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                string query = @" UPDATE Seats
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
                ToggleSeatStatus(clickedSeatId, currentHall);
            }
        }

        private void cbHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentHall = cbHall.SelectedItem.ToString(); // "Hall1" or "Hall2"
            LoadSeatData(currentHall);    // load for this hall only
            ApplySeatStyles();
        }
    }
}
