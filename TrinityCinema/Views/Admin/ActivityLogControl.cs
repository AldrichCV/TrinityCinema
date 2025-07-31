using DevExpress.XtraEditors;
using Org.BouncyCastle.Utilities;
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

namespace TrinityCinema.Views.Admin
{
    public partial class ActivityLogControl : DevExpress.XtraEditors.XtraUserControl
    {
        private AdminMainForm adminMainForm;
        AllMethods allMethods = new AllMethods();
        public ActivityLogControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;

            // Start async initialization without blocking the UI thread
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            var logs = await GetLogsAsync();
            AllMethods.GridCustomization(gcLogs, gvActivities, logs);
        }

        public async Task<List<ActivityLog>> GetLogsAsync()
        {
            string query = GlobalSettings.getActivityLog;
            return await Task.Run(() => allMethods.GetRecords<ActivityLog>(query));
        }

        public async void RefreshList()
        {
            try
            {
                var logs = await GetLogsAsync();
                AllMethods.GridCustomization(gcLogs, gvActivities, logs);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Failed to refresh user list.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

