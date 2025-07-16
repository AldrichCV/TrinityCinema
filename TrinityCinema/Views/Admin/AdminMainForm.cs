using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using System.Data.SqlClient;

namespace TrinityCinema.Views.Admin
{
    public partial class AdminMainForm : DevExpress.XtraEditors.XtraForm
    {
        AllMethods a = new AllMethods();

        public AdminMainForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();

                lbTotalAccounts.Text = GetCount(conn, "SELECT COUNT(*) FROM Users").ToString();
                lbTotalStaffs.Text = GetCount(conn, "SELECT COUNT(*) FROM Users WHERE Role = 'Staff'").ToString();
                lbTotalMovies.Text = GetCount(conn, "SELECT COUNT(*) FROM Movies").ToString();
                lbTotalTickets.Text = GetCount(conn, "SELECT COUNT(*) FROM Tickets").ToString();
                lbAvailableMovies.Text = GetCount(conn, "SELECT COUNT(*) FROM Movies WHERE Status = 0").ToString();

                lbAvailableSeats.Text = GetCount(conn, "SELECT COUNT(*) FROM Seats WHERE Status = 'Available'").ToString();
                lbAvailableTickets.Text = GetCount(conn, "SELECT COUNT(*) FROM Tickets WHERE Status = 0").ToString();
                //lbTicketSold.Text = GetCount(conn, "SELECT COUNT(*) FROM Tickets WHERE Status = 'Sold'").ToString();

                conn.Close();
            }
        }

        private int GetCount(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void personnelTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            UsersControl personnelControl = new UsersControl(this);
            gcHome.Controls.Add(personnelControl);
            personnelControl.Dock = DockStyle.Fill;
            personnelControl.Show();
        }

        private void movieTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            MoviesControl movieControl = new MoviesControl(this);
            gcHome.Controls.Add(movieControl);
            movieControl.Dock = DockStyle.Fill;
            movieControl.Show();
        }

        private void theaterTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            TheaterControl theaterControl = new TheaterControl(this);
            gcHome.Controls.Add(theaterControl);
            theaterControl.Dock = DockStyle.Fill;
            theaterControl.Show();
        }

        private void showtimeTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            ShowtimeControl showtimeControl = new ShowtimeControl(this);
            gcHome.Controls.Add(showtimeControl);
            showtimeControl.Dock = DockStyle.Fill;
            showtimeControl.Show();
            showtimeControl.RefreshShowtimeGrid();
        }
    }
}
