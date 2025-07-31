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

namespace TrinityCinema.Views.Staff
{
    public partial class TicketList : DevExpress.XtraEditors.XtraForm
    {
        private string userID;

        public TicketList()
        {
            InitializeComponent();
        }

        public TicketList(string userID)
        {
            this.userID = userID;
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            //BuyTicket buyTicket = new BuyTicket(this);
            //buyTicket.Show(); // Opens as a separate window
        }
    }
}