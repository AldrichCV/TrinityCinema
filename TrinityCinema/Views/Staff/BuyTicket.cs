using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.SvgImageBox;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Staff
{
    public partial class BuyTicket : XtraForm
    {
        AllMethods allMethods = new AllMethods();
        private string loggedInUser;
        private string selectedShowtimeId;
        private string currentHall;
        private string selectedSeatId;
        private decimal ticketPrice;

        public BuyTicket(TicketList ticketList, string loggedInUser)
        {
            InitializeComponent();
            LoadAvailableMovies();
            SvgImageBoxLoad();
            LoadSeatData(currentHall);
            ApplySeatStyles();

            this.loggedInUser = loggedInUser;
            this.AcceptButton = btnBuyTicket;
        }

        private void LoadAvailableMovies()
        {
            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                var movies = conn.Query("SELECT MovieID, Title FROM Movies WHERE Status = 1").ToList();
                leMovieTitle.Properties.DataSource = movies;
                leMovieTitle.Properties.DisplayMember = "Title";
                leMovieTitle.Properties.ValueMember = "MovieID";
                leMovieTitle.EditValue = null;
            }
        }

        private void leMovieTitle_EditValueChanged(object sender, EventArgs e)
        {
            if (leMovieTitle.EditValue == null) return;

            string movieId = leMovieTitle.EditValue.ToString();

            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                var showtimes = conn.Query(@"
                    SELECT 
                        s.ShowtimeID,
                        t.TheaterID,
                        t.TheaterName,
                        t.TheaterName + ' - ' +
                        ISNULL(FORMAT(s.ShowDate, 'MMM dd yyyy'), '[No Date]') + ' - ' +
                        ISNULL(FORMAT(CAST(s.StartTime AS DATETIME), 'hh:mm tt'), '[No Time]') AS Showtime,
                        s.Price
                    FROM Showtimes s
                    LEFT JOIN Theaters t ON s.TheaterID = t.TheaterID
                    WHERE s.MovieID = @MovieID AND s.Status = 1;",
                    new { MovieID = movieId }).ToList();

                leShowtime.Properties.DataSource = showtimes;
                leShowtime.Properties.DisplayMember = "Showtime";
                leShowtime.Properties.ValueMember = "ShowtimeID";

                leShowtime.EditValue = null;
                tePrice.Text = "";
                leSeatNumber.Properties.DataSource = null;
                leSeatNumber.EditValue = null;
            }
        }

        private void leShowtime_EditValueChanged(object sender, EventArgs e)
        {
            if (leShowtime.EditValue == null) return;

            selectedShowtimeId = leShowtime.EditValue.ToString();

            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                // Get Showtime Price
                ticketPrice = conn.QueryFirstOrDefault<decimal>(
                    "SELECT Price FROM Showtimes WHERE ShowtimeID = @ShowtimeID",
                    new { ShowtimeID = selectedShowtimeId });

                tePrice.Text = ticketPrice.ToString("0.00");

                // 🟨 Get TheaterName and display it in teTheaterHall
                var theaterName = conn.QueryFirstOrDefault<string>(@"
            SELECT t.TheaterName
            FROM Showtimes s
            JOIN Theaters t ON s.TheaterID = t.TheaterID
            WHERE s.ShowtimeID = @ShowtimeID",
                    new { ShowtimeID = selectedShowtimeId });

                teTheaterHall.Text = theaterName ?? "";

                // Load Available Seats
                var seats = conn.Query(@"
            SELECT s.SeatID, s.SeatNumber, s.RowNumber
            FROM Seats s
            INNER JOIN Showtimes st ON st.TheaterID = s.TheaterID
            WHERE st.ShowtimeID = @ShowtimeID AND s.Status = 'Available'",
                    new { ShowtimeID = selectedShowtimeId }).ToList();

                leSeatNumber.Properties.DataSource = seats;
                leSeatNumber.Properties.DisplayMember = "SeatNumber";
                leSeatNumber.Properties.ValueMember = "SeatID";
                leSeatNumber.EditValue = null;
            }
        }

        private void leSeatNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (leSeatNumber.EditValue != null)
            {
                selectedSeatId = leSeatNumber.EditValue.ToString();
            }
        }

        private string GenerateNextTicketID(SqlConnection connection)
        {
            string lastId = connection.ExecuteScalar<string>("SELECT TOP 1 TicketID FROM Tickets ORDER BY TicketID DESC");

            if (string.IsNullOrEmpty(lastId))
                return "TID-0001";

            int lastNumber = int.Parse(lastId.Substring(4));
            return $"TID-{(lastNumber + 1).ToString("D4")}";
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

            cbeActions.SelectedIndex = 0; // Default to "Availability"
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

        //SeatRenderering
        private void LoadSeatData(string hall)
        {
            seatData.Clear();

            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                // Single valid query
                string query = @" SELECT SeatId, Status, Hall, ISNULL(IsDamaged, 0) AS IsDamaged, SeatLabel
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
                                SeatLabel = reader["SeatLabel"].ToString(),
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
                int selectedAction = cbeActions.SelectedIndex;

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

        private void svgImageBox1_Click(object sender, EventArgs e)
        {
            string clickedSeatId = e.Item?.Id;

            if (!string.IsNullOrEmpty(clickedSeatId) && clickedSeatId.StartsWith("seat"))
            {
                // Set the LookUpEdit (leSeatNumber) to this clicked seat
                leSeatNumber.EditValue = clickedSeatId;

                // Update the selectedSeatId field as well
                selectedSeatId = clickedSeatId;

                // Optional: Log or display seat label if needed
                if (seatData.TryGetValue(clickedSeatId, out var seat))
                {
                    Console.WriteLine($"Seat clicked: {seat.SeatLabel}");
                }

                // Continue with existing toggle logic
                if (cbeActions.SelectedIndex == 0) // Toggle Availability
                {
                    ToggleSeatStatus(clickedSeatId, currentHall);
                }
                else if (cbeActions.SelectedIndex == 1) // Toggle Damaged
                {
                    ToggleSeatDamage(clickedSeatId, currentHall);
                }

                UpdateSeatCounts();
            }
        }


        // ToggleConditions
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

            // Refresh data so we can get the updated status and label
            LoadSeatData(hall);

            if (seatData.TryGetValue(seatId, out var seat))
            {
                string label = seat.SeatLabel;
                string newStatus = seat.Status; // Now contains "Taken" or "Available"
                allMethods.Log(loggedInUser, "Seat Availability Changed",
                    $"Seat {label} (ID: {seatId}) in {hall} was changed to '{newStatus}' by {loggedInUser}.");
            }

            ApplySeatStyles();
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

            // Refresh data
            LoadSeatData(currentHall);

            if (seatData.TryGetValue(seatId, out var seat))
            {
                string label = seat.SeatLabel;
                string newCondition = seat.IsDamaged ? "marked as DAMAGED" : "marked as RESTORED";
                allMethods.Log(loggedInUser, "Seat Condition Changed",
                    $"Seat {label} (ID: {seatId}) in {hall} was {newCondition} by {loggedInUser}.");
            }

            ApplySeatStyles();
        }

        

        private void cbeActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbeActions.SelectedIndex == 0)
                lcMode.Text = "Mode: Availability Editing";
            else if (cbeActions.SelectedIndex == 1)
                lcMode.Text = "Mode: Condition Editing";
            ApplySeatStyles();
            UpdateSeatCounts();
        }

        private void UpdateSeatCounts()
        {
            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                if (cbeActions.SelectedIndex == 0) // Availability Mode
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
                else if (cbeActions.SelectedIndex == 1) // Condition Mode
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

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (leMovieTitle.EditValue == null ||
                leShowtime.EditValue == null ||
                leSeatNumber.EditValue == null ||
                string.IsNullOrWhiteSpace(teBuyerName.Text) ||
                string.IsNullOrWhiteSpace(teBuyerContact.Text) ||
                string.IsNullOrWhiteSpace(teBookedBy.Text))

            {
                XtraMessageBox.Show("Please complete all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();
                string newTicketId = GenerateNextTicketID(conn);

                var query = @"
                    IF EXISTS (SELECT 1 FROM Seats WHERE SeatID = @SeatID AND Status = 'Available')
                    BEGIN
                        INSERT INTO Tickets 
                            (TicketID, ShowtimeID, SeatID, Price, BuyerName, BuyerContact, BookedBy, BookingTime, Status)
                        VALUES 
                            (@TicketID, @ShowtimeID, @SeatID, @Price, @BuyerName, @BuyerContact, @BookedBy, GETDATE(), 1);

                        UPDATE Seats SET Status = 'Booked' WHERE SeatID = @SeatID;
                    END
                    ELSE
                    BEGIN
                        RAISERROR('Seat already booked.', 16, 1);
                    END";

                try
                {
                    conn.Execute(query, new
                    {
                        TicketID = newTicketId,
                        ShowtimeID = selectedShowtimeId,
                        SeatID = selectedSeatId,
                        Price = ticketPrice,

                        BuyerName = teBuyerName.Text.Trim(),
                        BuyerContact = teBuyerContact.Text.Trim(),
                        BookedBy = teBookedBy.Text.Trim()
                    });

                    XtraMessageBox.Show("Ticket purchased successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset form
                    leMovieTitle.EditValue = null;
                    leShowtime.EditValue = null;
                    leSeatNumber.EditValue = null;
                    tePrice.Text = "";

                    teBuyerName.Text = "";
                    teBuyerContact.Text = "";
                    teBookedBy.Text = "";
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}


