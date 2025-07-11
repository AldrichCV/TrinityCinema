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
            AllMethods.GridCustomization(gcLogs, gvActivities, GetMovies());
        }

        public List<ActivityLog> GetMovies()
        {
            string query = GlobalSettings.getActivityLog;
            return allMethods.GetRecords<ActivityLog>(query);
        }
    }
    }

