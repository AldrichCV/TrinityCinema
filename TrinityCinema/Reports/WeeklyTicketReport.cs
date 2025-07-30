using System;
using System.Data.SqlClient;
using Dapper;
using DevExpress.XtraReports.UI;
using TrinityCinema.Models;

namespace TrinityCinema.Reports
{
    // Represents a report that displays ticket sales for a specific week
    public partial class WeeklyTicketReport : XtraReport
    {
        // Constructor that takes the start and end date of the week as parameters
        public WeeklyTicketReport(DateTime startDate, DateTime endDate)
        {
            InitializeComponent(); // Initializes the components of the report

            // Loads the ticket sales data for the given date range
            LoadWeeklyData(startDate, endDate);
        }

        // Method to load and bind data for the weekly ticket report
        private void LoadWeeklyData(DateTime startDate, DateTime endDate)
        {
            // Uses the connection string from global settings
            string connectionString = GlobalSettings.connectionString;

            // SQL query to get movie title, show date, total tickets sold, and revenue within the selected week
            string query = @"
                SELECT 
                    m.Title AS MovieTitle,
                    s.ShowDate,
                    COUNT(t.TicketID) AS TicketsSold,
                    SUM(t.Price) AS TotalRevenue
                FROM Tickets t
                INNER JOIN Showtimes s ON t.ShowtimeID = s.ShowtimeID
                INNER JOIN Movies m ON s.MovieID = m.MovieID
                WHERE s.ShowDate BETWEEN @StartDate AND @EndDate
                GROUP BY m.Title, s.ShowDate
                ORDER BY s.ShowDate, m.Title;
            ";

            // Opens the database connection and executes the query
            using (var connection = new SqlConnection(connectionString))
            {
                // Executes the query with parameters and gets the result
                var result = connection.Query(query, new { StartDate = startDate, EndDate = endDate });

                // Binds the result to the report as its data source
                this.DataSource = result;
            }
        }
    }
}
