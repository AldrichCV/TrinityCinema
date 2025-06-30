using DevExpress.DXTemplateGallery.Extensions;
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

namespace TrinityCinema.Views.Admin
{
    public partial class SeatLayout : DevExpress.XtraEditors.XtraUserControl
    {
        private AdminMainForm adminMainForm;
        private int theaterID;
        int seatWidth = 40;
        int seatHeight = 40;
        int margin = 5;
        public SeatLayout(AdminMainForm adminMainForm, int theaterID)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.theaterID = theaterID;

            GenerateSeatsIfNotExist(theaterID);
            LoadSeats();
        }

        private void GenerateSeatsIfNotExist(int theaterID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                // 1) Check if seats exist
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Seats WHERE TheaterID = @TheaterID", conn);
                checkCmd.Parameters.AddWithValue("@TheaterID", theaterID);

                int seatCount = (int)checkCmd.ExecuteScalar();
                if (seatCount > 0)
                {
                    // Seats already exist
                    return;
                }

                // 2) Get theater capacity
                SqlCommand capacityCmd = new SqlCommand("SELECT SeatCapacity FROM Theaters WHERE TheaterID = @TheaterID", conn);
                capacityCmd.Parameters.AddWithValue("@TheaterID", theaterID);

                int capacity = (int)capacityCmd.ExecuteScalar();

                // 3) Generate seat layout (e.g., 10 seats per row)
                int seatsPerRow = 10;
                int rows = (int)Math.Ceiling((double)capacity / seatsPerRow);

                for (int row = 1; row <= rows; row++)
                {
                    for (int seat = 1; seat <= seatsPerRow; seat++)
                    {
                        int seatNumber = ((row - 1) * seatsPerRow) + seat;

                        if (seatNumber > capacity)
                            break;

                        string seatID = Guid.NewGuid().ToString();

                        SqlCommand insertCmd = new SqlCommand(
                            "INSERT INTO Seats (SeatID, TheaterID, RowNumber, SeatNumber, Status) " +
                            "VALUES (@SeatID, @TheaterID, @RowNumber, @SeatNumber, 'Available')", conn);

                        insertCmd.Parameters.AddWithValue("@SeatID", seatID);
                        insertCmd.Parameters.AddWithValue("@TheaterID", theaterID);
                        insertCmd.Parameters.AddWithValue("@RowNumber", row);
                        insertCmd.Parameters.AddWithValue("@SeatNumber", seatNumber);

                        insertCmd.ExecuteNonQuery();

                    }
                }
            }
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

                    while (reader.Read())
                    {
                        string seatID = reader.GetString(0);
                        int rowNumber = reader.GetInt32(1);
                        int seatNumber = reader.GetInt32(2);
                        string status = reader.GetString(3);

                        Button seatButton = new Button();
                        seatButton.Width = 40;
                        seatButton.Height = 40;

                        int seatIndexInRow = (seatNumber - 1) % 10; // seats per row
                        int rowIndex = rowNumber - 1;

                        seatButton.Left = seatIndexInRow * (seatButton.Width + 5);
                        seatButton.Top = rowIndex * (seatButton.Height + 5);

                        seatButton.Text = seatNumber.ToString();
                        seatButton.BackColor = status == "Reserved" ? Color.Red : Color.Green;
                    seatButton.Tag = new SeatInfo { SeatID = seatID, Status = status };
                    seatButton.Click += SeatButton_Click;
                       

                        panelSeats.Controls.Add(seatButton);
                    }
                    reader.Close();
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
        }
    }
}