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
    public partial class DailyPicker : DevExpress.XtraEditors.XtraForm
    {
        // Constructor for the DailyPicker form
        public DailyPicker(DateTime now)
        {
            InitializeComponent(); // Initializes UI components of the form
        }

        // Event triggered when the Submit button is clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if a date has been selected in the DateEdit control
            if (deDailyDate.EditValue != null)
            {
                // Convert the selected date to DateTime
                DateTime selectedDate = Convert.ToDateTime(deDailyDate.EditValue);

                // Create a new report instance using the selected date
                var report = new DailyTicketReport(selectedDate);

                // Create a print tool to show the report preview
                var printTool = new ReportPrintTool(report);

                // Show the report preview in a dialog window
                printTool.ShowPreviewDialog();
            }
            else
            {
                // Show a message if no date was selected
                XtraMessageBox.Show("Please select a date.");
            }
        }
    }
}
