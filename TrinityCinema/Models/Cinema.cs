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
}
