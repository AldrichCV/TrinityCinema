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
    public partial class YearPicker : DevExpress.XtraEditors.XtraForm
    {
        // Property to store the selected year if needed elsewhere
        public int SelectedYear { get; private set; }

        public YearPicker()
        {
            InitializeComponent();
            LoadYears(); // Load current year into the ComboBoxEdit when form initializes
        }

        /// <summary>
        /// Loads the current year only into the ComboBoxEdit to prevent past date selection.
        /// </summary>
        private void LoadYears()
        {
            int currentYear = DateTime.Now.Year;

            // Clear existing items (if any)
            cbeYear.Properties.Items.Clear();

            // Add only the current year as the valid option
            cbeYear.Properties.Items.Add(currentYear.ToString());

            // Set default selection to current year
            cbeYear.SelectedItem = currentYear.ToString();
        }

        /// <summary>
        /// Event handler for Submit button. Validates the year selection and generates the report.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if a year has been selected
            if (cbeYear.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Please select a valid year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse the selected year from the ComboBoxEdit
            int selectedYear = int.Parse(cbeYear.SelectedItem.ToString());

            // Create the report and pass the selected year
            AnnualTicketReport report = new AnnualTicketReport(selectedYear);

            // Use DevExpress ReportPrintTool to preview the report
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog(); // ShowRibbonPreviewDialog() can be used for ribbon layout

            // Close the year picker form after report preview
            this.Close();
        }
    }
}
