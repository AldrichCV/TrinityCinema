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

namespace TrinityCinema.Views.Admin
{
    public partial class EditShowtime : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        private Showtime row;


        public EditShowtime(AdminMainForm adminMainForm, Showtime row)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.row = row;
        }
    }
}