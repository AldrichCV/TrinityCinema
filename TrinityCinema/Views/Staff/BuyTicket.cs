using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Staff
{
    public partial class BuyTicket : XtraForm
    {
        private string selectedShowtimeId;
        private string selectedSeatId;
        private decimal ticketPrice;

        public BuyTicket(TicketList ticketList)
        {
            InitializeComponent();
            LoadAvailableMovies();
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
                ticketPrice = conn.QueryFirstOrDefault<decimal>(
                    "SELECT Price FROM Showtimes WHERE ShowtimeID = @ShowtimeID",
                    new { ShowtimeID = selectedShowtimeId });

                tePrice.Text = ticketPrice.ToString("0.00");

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

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (leMovieTitle.EditValue == null ||
                leShowtime.EditValue == null ||
                leSeatNumber.EditValue == null ||
                string.IsNullOrWhiteSpace(teBuyerName.Text) ||
                string.IsNullOrWhiteSpace(teBuyerContact.Text) ||
                string.IsNullOrWhiteSpace(teBookedBy.Text) ||
                string.IsNullOrWhiteSpace(tePricePaid.Text))
            {
                XtraMessageBox.Show("Please complete all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tePricePaid.Text, out decimal pricePaid))
            {
                XtraMessageBox.Show("Invalid price paid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            (TicketID, ShowtimeID, SeatID, Price, PricePaid, BuyerName, BuyerContact, BookedBy, BookingTime, Status)
                        VALUES 
                            (@TicketID, @ShowtimeID, @SeatID, @Price, @PricePaid, @BuyerName, @BuyerContact, @BookedBy, GETDATE(), 1);

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
                        PricePaid = pricePaid,
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
                    tePricePaid.Text = "";
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
