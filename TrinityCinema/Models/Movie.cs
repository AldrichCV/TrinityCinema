using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCinema.Models
{
    public class Movie
    {
        public string MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public byte[] MoviePoster { get; set; }
    }
}
