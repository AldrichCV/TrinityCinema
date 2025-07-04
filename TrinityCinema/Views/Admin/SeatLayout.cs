using DevExpress.DXTemplateGallery.Extensions;
using DevExpress.Utils.About;
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
        AllMethods a = new AllMethods();  
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
            AllMethods.GridCustomization(gcSeats, gvSeatView, GetSeats(GlobalSettings.getSeatPrice, theaterID));
        }

        public List<SeatInfo> GetSeats(string query, int theaterID)
        {
            var param = new { TheaterID = theaterID };
            return a.GetRecords<SeatInfo>(query, param).ToList();

        }
        public void RefreshGrid()
        {
            var seats = GetSeats(GlobalSettings.getSeatPrice, theaterID);
            AllMethods.GridCustomization(gcSeats, gvSeatView, seats);
            gvSeatView.RefreshData();
            gcSeats.Refresh();
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

                        string seatID = $"Theater{theaterID}-{row:D2}{seatNumber:D2}";

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
                    int startX = (panelSeats.Width - rowWidth)/3;
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
            Button btn = sender as Button;
            if (btn == null || btn.Tag == null || !(btn.Tag is SeatInfo))
            {
                XtraMessageBox.Show("This seat button is missing SeatInfo.");
                return;
            }

            SeatInfo info = (SeatInfo)btn.Tag;

            PricingForm form = new PricingForm(info.Pricing, info.SeatID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                decimal newPrice = form.NewPrice;

                SqlConnection conn = new SqlConnection(GlobalSettings.connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Seats SET Pricing = @Pricing WHERE SeatID = @SeatID", conn);
                cmd.Parameters.AddWithValue("@Pricing", newPrice);
                cmd.Parameters.AddWithValue("@SeatID", info.SeatID);
                cmd.ExecuteNonQuery();

                conn.Close();
                AllMethods.RefreshManagerHome(mh => new SeatLayout(mh, theaterID));

                info.Pricing = newPrice;
                btn.Tag = info;

                XtraMessageBox.Show("Seat " + info.SeatID + " price updated to ₱" + newPrice);
            }
        }

        //private void SeatButton_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender; // the button that was clicked
        //    if (btn.Tag == null || !(btn.Tag is SeatInfo info))
        //    {
        //        MessageBox.Show("This seat button is missing SeatInfo.");
        //        return;
        //    }

        //    string newStatus = info.Status == "Available" ? "Reserved" : "Available";

        //    using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand(
        //            "UPDATE Seats SET Status = @Status WHERE SeatID = @SeatID", conn);
        //        cmd.Parameters.AddWithValue("@Status", newStatus);
        //        cmd.Parameters.AddWithValue("@SeatID", info.SeatID);

        //        cmd.ExecuteNonQuery();
        //    }

        //    // Update button color and Tag to match new status
        //    btn.BackColor = newStatus == "Reserved" ? Color.Red : Color.Green;
        //    info.Status = newStatus;
        //    btn.Tag = info;
        //}

        public class SeatInfo
        {
            public string SeatID { get; set; }
            public string Status { get; set; }
            public int TheaterID { get; set; }
            public decimal Pricing { get; set; }
        }
    }
}