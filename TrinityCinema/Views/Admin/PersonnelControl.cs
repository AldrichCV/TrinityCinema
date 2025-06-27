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
    public partial class PersonnelControl : DevExpress.XtraEditors.XtraUserControl
    {
        AllMethods a = new AllMethods();
        private AdminMainForm form;
        public PersonnelControl(AdminMainForm form)
        {
            InitializeComponent();
            this.form = form;
            AllMethods.GridCustomization(gcPersonnel, tvPersonnelView, GetEmployee());
        }

        public List<Personnel> GetEmployee()
        {
            string query = GlobalSettings.getPersonnel;
            return a.GetRecords<Personnel>(query);
        }

        private void newAccountTile_ItemClick_1(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AccountCreation(home));
        }
    }
}
