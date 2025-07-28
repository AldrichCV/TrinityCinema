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
using static TrinityCinema.Views.Admin.SeatLayout;

namespace TrinityCinema.Views.Staff
{
    public partial class ChooseSeatLayout : DevExpress.XtraEditors.XtraForm
    {
        private int theaterID;
        int seatWidth = 60;
        int seatHeight = 60;
        int margin = 5;
        public ChooseSeatLayout(int theaterID)
        {
            InitializeComponent();
            LoadSeats(theaterID);
            this.theaterID = theaterID;
        }
     

        private void LoadSeats(int theaterID)
        {
            panelSeats.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT SeatID, RowNumber, SeatNumber, Status FROM Seats WHERE TheaterID = @TheaterID",
                    conn);
                cmd.Parameters.AddWithValue("@TheaterID", theaterID);

                SqlDataReader reader = cmd.ExecuteReader();

                // Organize seats by row
                var seatsByRow = new Dictionary<int, List<(string SeatID, int SeatNumber, string Status)>>();

                while (reader.Read())
                {
                    string seatID = reader.GetString(0);
                    int rowNumber = reader.GetInt32(1);
                    int seatNumber = reader.GetInt32(2);
                    string status = reader.GetString(3);

                    if (!seatsByRow.ContainsKey(rowNumber))
                        seatsByRow[rowNumber] = new List<(string, int, string)>();

                    seatsByRow[rowNumber].Add((seatID, seatNumber, status));
                }
                reader.Close();

                // Layout configuration
                int buttonWidth = seatWidth;
                int buttonHeight = seatHeight;
                int spacing = 10;
                int aisleSpacing = 40;
                int frontMargin = 70;

                // Add "SCREEN" label
                Label screenLabel = new Label();
                screenLabel.Text = "SCREEN";
                screenLabel.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                screenLabel.ForeColor = Color.White;
                screenLabel.BackColor = Color.DimGray;
                screenLabel.TextAlign = ContentAlignment.MiddleCenter;
                screenLabel.Width = 250;
                screenLabel.Height = 35;
                screenLabel.Left = (panelSeats.ClientSize.Width - screenLabel.Width) / 2;
                screenLabel.Top = 10;
                panelSeats.Controls.Add(screenLabel);

                // Draw each row of seats
                foreach (var row in seatsByRow.OrderBy(r => r.Key))
                {
                    int rowNumber = row.Key;
                    var seats = row.Value.OrderBy(s => s.SeatNumber).ToList();

                    int mid = seats.Count / 2;
                    var leftSeats = seats.Take(mid).ToList();
                    var rightSeats = seats.Skip(mid).ToList();

                    int totalRowWidth = leftSeats.Count * (buttonWidth + spacing)
                                      + aisleSpacing
                                      + rightSeats.Count * (buttonWidth + spacing);
                    int startX = (panelSeats.ClientSize.Width - totalRowWidth) / 2;
                    int topY = frontMargin + 50 + (rowNumber - 1) * (buttonHeight + spacing);

                    // Add left side seats
                    for (int i = 0; i < leftSeats.Count; i++)
                    {
                        var seat = leftSeats[i];
                        SimpleButton seatButton = CreateSeatButton(seat, rowNumber, i + 1, buttonWidth, buttonHeight);
                        seatButton.Left = startX + i * (buttonWidth + spacing);
                        seatButton.Top = topY;
                        panelSeats.Controls.Add(seatButton);
                    }

                    // Add right side seats
                    for (int i = 0; i < rightSeats.Count; i++)
                    {
                        var seat = rightSeats[i];
                        SimpleButton seatButton = CreateSeatButton(seat, rowNumber, mid + i + 1, buttonWidth, buttonHeight);
                        seatButton.Left = startX + leftSeats.Count * (buttonWidth + spacing) + aisleSpacing + i * (buttonWidth + spacing);
                        seatButton.Top = topY;
                        panelSeats.Controls.Add(seatButton);
                    }
                }
            }
        }

        // Creates a styled button for each seat with hover and status color
        private SimpleButton CreateSeatButton((string SeatID, int SeatNumber, string Status) seat, int row, int seatIndex, int width, int height)
        {
            SimpleButton btn = new SimpleButton();
            btn.Width = width;
            btn.Height = height;
            btn.Text = $"{(char)('A' + row - 1)}{seatIndex}";
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            btn.LookAndFeel.UseDefaultLookAndFeel = false;
            btn.Appearance.BackColor = Color.FromArgb(45, 45, 48); // optional dark gray
            btn.Appearance.Options.UseBackColor = true;
            btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            btn.LookAndFeel.SkinName = "WXI"; // Apply WXI theme

            // Set color based on seat status
            switch (seat.Status)
            {
                case "Reserved":
                    btn.Appearance.BackColor = Color.Red;
                    break;
                case "Booked":
                    btn.Appearance.BackColor = Color.Gray;
                    break;
                default:
                    btn.Appearance.BackColor = Color.Green;
                    break;
            }

            // Hover effect (darkens color)
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = ControlPaint.Dark(btn.BackColor);
            };

            // Revert to original color after hover
            btn.MouseLeave += (s, e) =>
            {
                switch (seat.Status)
                {
                    case "Reserved":
                        btn.BackColor = Color.Red;
                        break;
                    case "Booked":
                        btn.BackColor = Color.Gray;
                        break;
                    default:
                        btn.BackColor = Color.Green;
                        break;
                }
            };

            btn.Tag = new SeatInfo { SeatID = seat.SeatID, Status = seat.Status };
            btn.Click += SeatButton_Click;
            return btn;
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender; // the button that was clicked
            if (btn.Tag == null || !(btn.Tag is SeatInfo info))
            {
                MessageBox.Show("This seat button is missing SeatInfo.");
                return;
            }

            string newStatus = info.Status == "Available" ? "Reserved" : "Available";

            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Seats SET Status = @Status WHERE SeatID = @SeatID", conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@SeatID", info.SeatID);

                cmd.ExecuteNonQuery();
            }

            // Update button color and Tag to match new status
            btn.BackColor = newStatus == "Reserved" ? Color.Red : Color.Green;
            info.Status = newStatus;
            btn.Tag = info;
        }

        public class SeatInfo
        {
            public string SeatID { get; set; }
            public string Status { get; set; }
            public int TheaterID { get; set; }
            public decimal Pricing { get; set; }
        }
    }
    }
