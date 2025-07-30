using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using Dapper;
using DevExpress.XtraReports.UI;
using TrinityCinema.Models;

namespace TrinityCinema.Reports
{
    public partial class DailyTicketReport : DevExpress.XtraReports.UI.XtraReport
    {
        // Constructor that accepts a selected date and loads the data for that day
        public DailyTicketReport(DateTime selectedDate)
        {
            InitializeComponent();
            LoadDailyData(selectedDate); // Load the report data for the given date
        }

        // Method to retrieve and bind ticket sales data for the selected day
        private void LoadDailyData(DateTime selectedDate)
        {
            // Get the connection string from your global settings
            string connectionString = GlobalSettings.connectionString;

            // SQL query to get movie title, show date, total tickets sold, and total revenue
            // for the given date
            string query = @"
                SELECT 
                    m.Title AS MovieTitle,
                    s.ShowDate,
                    COUNT(t.TicketID) AS TicketsSold,
                    SUM(t.Price) AS TotalRevenue
                FROM Tickets t
                INNER JOIN Showtimes s ON t.ShowtimeID = s.ShowtimeID
                INNER JOIN Movies m ON s.MovieID = m.MovieID
                WHERE CAST(s.ShowDate AS DATETIME) = @SelectedDate
                GROUP BY m.Title, s.ShowDate
                ORDER BY m.Title;
            ";

            // Use Dapper to execute the query and fetch the result
            using (var connection = new SqlConnection(connectionString))
            {
                var result = connection.Query(query, new { SelectedDate = selectedDate });

                // Set the data source of the report to the query result
                this.DataSource = result;
            }
        }
    }
}
