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
using TrinityCinema.Views.Admin;
using TrinityCinema.Views.Staff;

namespace TrinityCinema.Views
{
    public partial class StaffMainForm : DevExpress.XtraEditors.XtraForm
    {
        private string _userID;
        public StaffMainForm(string loggedInUser)
        {
            InitializeComponent();
            _userID = loggedInUser;
        }

        private void movieTile_ItemClick(object sender, TileItemEventArgs e)
        {
            gcHome.Controls.Clear();
            ShowtimeMovies showtimeMovies = new ShowtimeMovies(this);
            gcHome.Controls.Add(showtimeMovies);
            showtimeMovies.Dock = DockStyle.Fill;
            showtimeMovies.Show();
        }
    }
}