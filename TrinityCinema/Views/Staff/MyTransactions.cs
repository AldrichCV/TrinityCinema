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

namespace TrinityCinema.Views.Staff
{
    public partial class MyTransactions : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods allMethods = new AllMethods();
        private StaffMainForm staffMainForm;  
        private string loggedInUser;
        public MyTransactions(StaffMainForm staffMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.staffMainForm = staffMainForm;
            this.loggedInUser = loggedInUser;

            // Start async initialization without blocking the UI thread
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            var logs = await GetLogsAsync();
            AllMethods.GridCustomization(gcTransactions, gvTraction, logs);
        }

        public async Task<List<Traction>> GetLogsAsync()
        {
            string query = GlobalSettings.getTraction;
            return await Task.Run(() => allMethods.GetRecords<Traction>(query));
        }

        public async void RefreshList()
        {
            try
            {
                var logs = await GetLogsAsync();
                AllMethods.GridCustomization(gcTransactions, gvTraction, logs);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Failed to refresh user list.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintTransaction_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            staffMainForm.gcHome.Controls.Clear();

            // Create and add StaffHome control
            var staffHome = new StaffHome(staffMainForm, loggedInUser); // make sure you have this UserControl
            staffHome.Dock = DockStyle.Fill;
            staffMainForm.gcHome.Controls.Add(staffHome);
            staffHome.BringToFront();
        }
    }
}
    