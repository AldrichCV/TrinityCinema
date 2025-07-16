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

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Seats WHERE TheaterID = @TheaterID", conn);
                checkCmd.Parameters.AddWithValue("@TheaterID", theaterID);

                int seatCount = (int)checkCmd.ExecuteScalar();
                if (seatCount > 0) return;

                int[][] seatPlan = new int[][]
                {
                    new int[] { 5, 5 },
                    new int[] { 6, 6 },
                    new int[] { 7, 7 },
                    new int[] { 8, 8 },
                    new int[] { 9, 9 },
                    new int[] {10, 10 }
                };

                int seatCounter = 1;

                for (int row = 0; row < seatPlan.Length; row++)
                {
                    int rowNumber = row + 1;

                    for (int side = 0; side < 2; side++)
                    {
                        for (int i = 1; i <= seatPlan[row][side]; i++)
                        {
                            string seatID = $"Theater{theaterID}-R{rowNumber:D2}S{seatCounter:D3}";

                            SqlCommand insertCmd = new SqlCommand(
                                "INSERT INTO Seats (SeatID, TheaterID, RowNumber, SeatNumber, Status) " +
                                "VALUES (@SeatID, @TheaterID, @RowNumber, @SeatNumber, 'Available')", conn);

                            insertCmd.Parameters.AddWithValue("@SeatID", seatID);
                            insertCmd.Parameters.AddWithValue("@TheaterID", theaterID);
                            insertCmd.Parameters.AddWithValue("@RowNumber", rowNumber);
                            insertCmd.Parameters.AddWithValue("@SeatNumber", seatCounter);

                            insertCmd.ExecuteNonQuery();
                            seatCounter++;
                        }
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

                int buttonWidth = 50;
                int buttonHeight = 50;
                int spacing = 5;
                int aisleSpacing = 30;
                int frontMargin = 50;

                Label screenLabel = new Label();
                screenLabel.Text = "SCREEN";
                screenLabel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                screenLabel.ForeColor = Color.White;
                screenLabel.BackColor = Color.DimGray;
                screenLabel.TextAlign = ContentAlignment.MiddleCenter;
                screenLabel.Width = 200;
                screenLabel.Height = 30;
                screenLabel.Left = (panelSeats.ClientSize.Width - screenLabel.Width) / 2;
                screenLabel.Top = 10;
                panelSeats.Controls.Add(screenLabel);

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

                    for (int i = 0; i < leftSeats.Count; i++)
                    {
                        var seat = leftSeats[i];
                        Button seatButton = CreateSeatButton(seat, buttonWidth, buttonHeight);
                        seatButton.Left = startX + i * (buttonWidth + spacing);
                        seatButton.Top = topY;
                        panelSeats.Controls.Add(seatButton);
                    }

                    for (int i = 0; i < rightSeats.Count; i++)
                    {
                        var seat = rightSeats[i];
                        Button seatButton = CreateSeatButton(seat, buttonWidth, buttonHeight);
                        seatButton.Left = startX + leftSeats.Count * (buttonWidth + spacing) + aisleSpacing + i * (buttonWidth + spacing);
                        seatButton.Top = topY;
                        panelSeats.Controls.Add(seatButton);
                    }
                }
            }
        }

        private Button CreateSeatButton((string SeatID, int SeatNumber, string Status) seat, int width, int height)
        {
            Button btn = new Button();
            btn.Width = width;
            btn.Height = height;
            btn.Text = seat.SeatNumber.ToString();
            btn.BackColor = seat.Status == "Reserved" ? Color.Red : Color.Green;
            btn.Tag = new SeatInfo { SeatID = seat.SeatID, Status = seat.Status };
            btn.Click += SeatButton_Click;
            return btn;
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

        public class SeatInfo
        {
            public string SeatID { get; set; }
            public string Status { get; set; }
            public int TheaterID { get; set; }
            public decimal Pricing { get; set; }
        }
    }
}
