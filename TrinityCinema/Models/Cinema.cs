using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCinema.Models
{
    public class Cinema
    {
    }

    #region User and Role Models
    public class User
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Fullname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public byte[] PersonnelImage { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }

        public int FailedAttempts { get; set; }
        public bool IsLocked { get; set; }

        public string IsLockedDisplay
        {
            get
            {
                return IsLocked ? "Locked" : "Active";
            }
        }
    }
    public class RoleCounts
    {
        public int ManagerCount { get; set; }
        public int StaffCount { get; set; }

        public int UserStatusCount { get; set; }
    }
    #endregion

    public class ActivityLog
    {
        public DateTime Timestamp { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
    }

    #region Movie and Showtime Models
    public class Movie
    {
        public string MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Genre { get; set; }
        public string GenreName { get; set; }
        public int ContentRating { get; set; }
        public string ContentRatingCode { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public byte[] MoviePoster { get; set; }
        public string StatusDisplay { get; set; }
        public int TheaterID { get; set; }

    }

    public class ContentRating
    {
        public int RatingID { get; set; }
        public string RatingCode { get; set; }
        public string Details { get; set; }
    }

    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
    }

    public class Theater
    {
        public int TheaterID { get; set; }
        public string TheaterName { get; set; }
        public int SeatCapacity { get; set; }
    }

    public class Showtime
    {
        public int ShowtimeID { get; set; }
        public string MovieID { get; set; }
        public string Title { get; set; }
        public string RatingCode { get; set; }
        public byte[] MoviePoster { get; set; }
        public string GenreName { get; set; }
        public int TheaterID { get; set; }
        public string TheaterName { get; set; }
        public decimal Price { get; set; }
        public DateTime ShowDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Status { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public string StatusDisplay { get; set; }
    }
    #endregion


    public class Seat
    {
        public string SeatId { get; set; }
        public string Status { get; set; }
        public string SeatLabel { get; set; }
        public string Hall { get; set; }
        public bool IsDamaged { get; set; }
    }

    public class SeatCounts
    {
        public int Hall1Available { get; set; }
        public int Hall1Damaged { get; set; }
        public int Hall2Available { get; set; }
        public int Hall2Damaged { get; set; }
    }

    public class Ticket
    {
        public int TicketID { get; set; }
        public int ShowtimeID { get; set; }
        public string SeatID { get; set; }
        public decimal Price { get; set; }
        public string BuyerName { get; set; }
        public string BuyerContact { get; set; }
        public decimal PricePaid { get; set; }
        public DateTime BookingTime { get; set; }
        public string Status { get; set; } // e.g., "Purchased", "Cancelled"
    }

    public class Traction
    {
        public int TransactionId { get; set; }
        public int ShowtimeId { get; set; }
        public string SeatId { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }      // Consider using an enum
        public string CreatedBy { get; set; }
    }


}