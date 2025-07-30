using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TrinityCinema.Reports;

namespace TrinityCinema.Views.Staff
{
    public partial class WeekPicker : DevExpress.XtraEditors.XtraForm
    {
        public WeekPicker()
        {
            InitializeComponent();
        }

        // Handles the 'Submit' button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if both start and end dates are selected
            if (deStartDate.EditValue != null && deEndDate.EditValue != null)
            {
                // Convert the selected values to DateTime
                DateTime startDate = Convert.ToDateTime(deStartDate.EditValue);
                DateTime endDate = Convert.ToDateTime(deEndDate.EditValue);

                // Validate: Ensure the start date is not after the end date
                if (startDate > endDate)
                {
                    XtraMessageBox.Show("Start date cannot be after the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the weekly report instance with date range
                var report = new WeeklyTicketReport(startDate, endDate);

                // Use DevExpress print tool to preview the report
                var printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog(); // Show preview
            }
            else
            {
                // Show warning if any date is not selected
                XtraMessageBox.Show("Please select both start and end dates.", "Missing Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
