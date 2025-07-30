using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using TrinityCinema.Models;

namespace TrinityCinema.Reports
{
    public partial class MonthlyTicketReport : DevExpress.XtraReports.UI.XtraReport
    {
        public MonthlyTicketReport(int month, int year)
        {
            InitializeComponent();

            // Set report parameters if you want to display them on the report (optional)
            //this.Parameters["ReportMonth"].Value = month;
            //this.Parameters["ReportYear"].Value = year;

            // Load the data into the report based on selected Month and Year
            LoadMonthlyData(month, year);
        }

        /// <summary>
        /// Fetches ticket sales data grouped by movie and show date for the specified month and year.
        /// </summary>
        private void LoadMonthlyData(int month, int year)
        {
            string connectionString = GlobalSettings.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        m.Title AS MovieTitle,
                        CONVERT(date, s.ShowDate) AS ShowDate,
                        COUNT(t.TicketID) AS TicketsSold,
                        SUM(t.Price) AS TotalRevenue
                    FROM Tickets t
                    JOIN Showtimes s ON t.ShowtimeID = s.ShowtimeID
                    JOIN Movies m ON s.MovieID = m.MovieID
                    WHERE MONTH(s.ShowDate) = @Month AND YEAR(s.ShowDate) = @Year
                    GROUP BY m.Title, s.ShowDate
                    ORDER BY s.ShowDate
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Assign parameters to the SQL query
                adapter.SelectCommand.Parameters.AddWithValue("@Month", month);
                adapter.SelectCommand.Parameters.AddWithValue("@Year", year);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "MonthlyData");

                // Bind the dataset to the report
                this.DataSource = ds.Tables["MonthlyData"];
                this.DataMember = "MonthlyData";
            }
        }
    }
}
