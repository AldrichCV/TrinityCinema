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
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views.Staff
{
    public partial class StaffHome : DevExpress.XtraEditors.XtraUserControl
    {
        private StaffMainForm staffMainForm;
        private string loggedInUser;
        private bool hasLoaded = false;
        private Timer dashboardRefreshTimer;


        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        public event EventHandler DashboardReady;
        public StaffHome(StaffMainForm staffMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.staffMainForm = staffMainForm;
            this.loggedInUser = loggedInUser;
        }

        private void NewTransaction_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowtimeMovies ticketListForm = new ShowtimeMovies(staffMainForm, loggedInUser);
            ticketListForm.Show();
        }

        private void Transactions_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.RefreshStaffHome<MyTransactions>(
           createNewControl: form => new MyTransactions(staffMainForm, loggedInUser),
           refreshIfExists: control => control.RefreshList());
        }
    }
}
