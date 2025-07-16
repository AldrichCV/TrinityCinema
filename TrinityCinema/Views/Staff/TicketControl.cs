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
using TrinityCinema.Models;
using TrinityCinema.Views.Staff;// Or wherever BuyTicket is defined
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views.Staff
{
    public partial class TicketControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private StaffMainForm staffMainForm;

        public TicketControl(StaffMainForm staffMainForm)
        {
            InitializeComponent();
            this.staffMainForm = staffMainForm;
            
        }

        private void ticketTile_ItemClick(object sender, TileItemEventArgs e)
        {
            BuyTicket buyTicket = new BuyTicket(staffMainForm);
            buyTicket.ShowDialog();
        }
    }
}
