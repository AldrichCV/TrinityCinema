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

namespace TrinityCinema.Views.Admin
{
    public partial class AddMovies : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        public AddMovies(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
        }
    }
}