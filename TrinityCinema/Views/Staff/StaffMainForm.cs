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
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views.Staff
{
    public partial class StaffMainForm : DevExpress.XtraEditors.XtraForm
    {
        AllMethods a = new AllMethods();

        public StaffMainForm()
        {
            InitializeComponent();
        }

        private void movieTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            MoviesControl movieControl = new MoviesControl(this);
            gcHome.Controls.Add(movieControl);
            movieControl.Dock = DockStyle.Fill;
            movieControl.Show();
        }

        private void ticketTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            TicketControl ticketControl = new TicketControl(this);
            gcHome.Controls.Add(ticketControl);
            ticketControl.Dock = DockStyle.Fill;
            ticketControl.Show();
        }
    }
}