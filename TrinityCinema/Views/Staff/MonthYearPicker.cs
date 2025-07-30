using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TrinityCinema.Reports;

namespace TrinityCinema.Views.Staff
{
    public partial class MonthYearPicker : DevExpress.XtraEditors.XtraForm
    {
        public MonthYearPicker(int month, int year)
        {
            InitializeComponent();
            LoadMonthAndYear(); // Populate combo boxes
        }

        // Loads only the current year and all 12 months
        private void LoadMonthAndYear()
        {
            // Load month names (January to December)
            string[] months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            cbeMonth.Properties.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                cbeMonth.Properties.Items.Add(months[i]);
            }

            // Set current month
            cbeMonth.SelectedIndex = DateTime.Now.Month - 1;

            // Only show the current year (no past/future)
            int currentYear = DateTime.Now.Year;
            cbeYear.Properties.Items.Clear();
            cbeYear.Properties.Items.Add(currentYear.ToString());

            // Set current year
            cbeYear.SelectedIndex = 0;
        }

        // On submit, generate and show the report
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbeMonth.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbeYear.Text))
            {
                XtraMessageBox.Show("Please select both Month and Year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedMonth = cbeMonth.SelectedIndex + 1;
            int selectedYear = int.Parse(cbeYear.Text);

            // Generate and preview the Monthly Ticket Report
            MonthlyTicketReport report = new MonthlyTicketReport(selectedMonth, selectedYear);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
