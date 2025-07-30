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
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views.Staff
{
    public partial class StaffMainForm : DevExpress.XtraEditors.XtraForm
    {
        private string loggedInUser;

        public StaffMainForm(string userID)
        {
            InitializeComponent();
            this.loggedInUser = userID;
        }

        private void ticketTile_ItemClick(object sender, TileItemEventArgs e)
        {
            TicketList ticketListForm = new TicketList();
            ticketListForm.Show(); // Opens as a separate window
        }

        private void NewTransaction_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowtimeMovies ticketListForm = new ShowtimeMovies(this,loggedInUser);
            ticketListForm.Show();
            this.Hide();// Opens as a separate window
        }
    }
}