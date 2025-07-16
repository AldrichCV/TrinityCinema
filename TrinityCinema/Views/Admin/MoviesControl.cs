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
using TrinityCinema.Views.Staff;

namespace TrinityCinema.Views.Admin
{
    public partial class MoviesControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        

        public MoviesControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            AllMethods.GridCustomization(gcMovies, tvMovieView, GetMovies());
        }

        public MoviesControl(StaffMainForm staffMainForm)
        {
        }

        public List<Movie> GetMovies()
        {
            string query = GlobalSettings.getMovie;
            return a.GetRecords<Movie>(query);
        }

        private void viewDetails_Click(object sender, EventArgs e)
        {

        }

        private void movieTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AddMovies(home));
        }
    }
}
