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

    public class User
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Fullname { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public byte[] PersonnelImage { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class Movie
    {
        public string MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Genre { get; set; }
        public string GenreName { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public byte[] MoviePoster { get; set; }
        public string StatusDisplay { get; set; }

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
        public string TheaterID { get; set; }
        public decimal Price { get; set; }
        public DateTime ShowDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public int Status { get; set; }
        public string StatusDisplay { get; set; }
    }

}
