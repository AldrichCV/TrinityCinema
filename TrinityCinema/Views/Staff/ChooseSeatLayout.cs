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
        AllMethods a = new AllMethods();
        private int theaterID;
        int seatWidth = 40;
        int seatHeight = 40;
        int margin = 5;
        public ChooseSeatLayout()
        {
            InitializeComponent();
            LoadSeats();
        }
     

        private void LoadSeats()
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

                // Group seats by row
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

                int buttonWidth = 80;
                int buttonHeight = 80;
                int spacing = 5;

                foreach (var row in seatsByRow)
                {
                    int rowNumber = row.Key;
                    var seats = row.Value.OrderBy(s => s.SeatNumber).ToList();

                    int seatsInRow = seats.Count;
                    int rowWidth = seatsInRow * (buttonWidth + spacing) - spacing;
                    int startX = (panelSeats.Width - rowWidth) / 3;
                    int topY = (rowNumber - 1) * (buttonHeight + spacing);

                    for (int i = 0; i < seats.Count; i++)
                    {
                        var seat = seats[i];

                        Button seatButton = new Button();
                        seatButton.Width = buttonWidth;
                        seatButton.Height = buttonHeight;

                        seatButton.Left = startX + i * (buttonWidth + spacing);
                        seatButton.Top = topY;

                        seatButton.Text = seat.SeatNumber.ToString();
                        seatButton.BackColor = seat.Status == "Reserved" ? Color.Red : Color.Green;
                        seatButton.Tag = new SeatInfo { SeatID = seat.SeatID, Status = seat.Status };
                        seatButton.Click += SeatButton_Click;

                        panelSeats.Controls.Add(seatButton);
                    }
                }
            }
        }
            
             private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // the button that was clicked
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
