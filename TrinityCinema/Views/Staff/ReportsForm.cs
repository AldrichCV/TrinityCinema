using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TrinityCinema.Reports;

namespace TrinityCinema.Views.Staff
{
    public partial class ReportsForm : DevExpress.XtraEditors.XtraUserControl
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            TicketReport ticketReport = new TicketReport();
            ticketReport.ShowPreviewDialog(); // Opens the report preview dialog
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            DailyPicker dailyPicker = new DailyPicker(DateTime.Now);
            dailyPicker.ShowDialog(); // Show the daily picker dialog to select date
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            WeekPicker weekPicker = new WeekPicker();
            weekPicker.ShowDialog(); // Show the week picker dialog to select start and end dates
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            MonthYearPicker datePicker = new MonthYearPicker(DateTime.Now.Month, DateTime.Now.Year);
            datePicker.ShowDialog(); // Show the date picker dialog to select month and year

          
        }

        private void btnAnnualReport_Click(object sender, EventArgs e)
        {
            YearPicker yearPicker = new YearPicker();
            yearPicker.ShowDialog(); // Show the year picker dialog to select year
        }
    }
}
