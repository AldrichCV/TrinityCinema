using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using Dapper;
using DevExpress.XtraReports.UI;
using TrinityCinema.Models;

namespace TrinityCinema.Reports
{
    public partial class AnnualTicketReport : DevExpress.XtraReports.UI.XtraReport
    {
        // Field to store the year selected by the user
        private int selectedYear;

        // Constructor that receives the year as a parameter
        public AnnualTicketReport(int selectedYear)
        {
            InitializeComponent(); // Initializes the report components
            LoadAnnualData(selectedYear); // Loads ticket data for the given year
        }

        // Method to query and load the ticket data for the specified year
        public void LoadAnnualData(int selectedYear)
        {
            // Define the connection string (retrieved from global settings)
            string connectionString = GlobalSettings.connectionString;

            // Open SQL connection using 'using' statement to ensure it's disposed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to get movie title, show date, number of tickets sold,
                // and total revenue per movie per showdate for the given year
                string query = @"
                    SELECT 
                        m.Title AS MovieTitle,                  -- Movie title
                        s.ShowDate,                             -- Show date
                        COUNT(t.TicketID) AS TotalTicketsSold,  -- Number of tickets sold
                        SUM(t.Price) AS TotalSales              -- Total earnings (revenue)
                    FROM Tickets t
                    INNER JOIN Showtimes s ON t.ShowtimeID = s.ShowtimeID
                    INNER JOIN Movies m ON s.MovieID = m.MovieID
                    WHERE YEAR(s.ShowDate) = @Year             -- Filter by selected year
                    GROUP BY m.Title, s.ShowDate               -- Group data by movie and date
                    ORDER BY s.ShowDate ASC;                   -- Sort results by date
                ";

                // Use Dapper to execute the query and retrieve the result as a list
                var data = connection.Query(query, new { Year = selectedYear }).ToList();

                // Bind the result list to the report's data source
                this.DataSource = data;
            }
        }
    }
}
