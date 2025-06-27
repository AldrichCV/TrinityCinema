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
        private AdminMainForm adminMainForm;
        public PersonnelControl(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
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

        private void tvPersonnelView_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            AllMethods allMethods = new AllMethods();

            // Get selected staffID from the grid
            string accountID = tvPersonnelView.GetFocusedRowCellValue("AccountID")?.ToString();
            if (string.IsNullOrEmpty(accountID))
            {
                MessageBox.Show("No staff selected.");
                return;
            }

            // Set up the form
            EditAccount editAccount = new EditAccount(adminMainForm, accountID);

            // Prepare query and parameters
            string query = @"SELECT * FROM [dbo].[Accounts] WHERE AccountID = @AccountID";
            var parameters = new { accountID };
            List<string> columns = new List<string>
                    {  "FirstName"
                       ,"MiddleName"
                       ,"LastName"
                       ,"Suffix"
                       ,"Role"
                       ,"PersonnelImage"
                    };

            Dictionary<string, string> record = allMethods.GetRecordById(query, parameters, columns);

            if (record != null)
            {
                // Populate fields
                editAccount.teFirstName.Text = record["FirstName"];
                editAccount.teMiddleName.Text = record["MiddleName"];
                editAccount.teLastName.Text = record["LastName"];
                editAccount.teSuffix.Text = record["Suffix"];
                editAccount.cbRole.Text = record["Role"];
         
                // Show the form after populating
                editAccount.ShowDialog();
            }
            else
            {
                MessageBox.Show("No employee found.");
            }
        }
    }
}
