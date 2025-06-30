using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public List<User> GetEmployee()
        {
            string query = GlobalSettings.getPersonnel;
            return a.GetRecords<User>(query);
        }

        private void newAccountTile_ItemClick_1(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AccountCreation(home));
        }

        private void tvPersonnelView_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            AllMethods allMethods = new AllMethods();

            string userID = tvPersonnelView.GetFocusedRowCellValue("UserID")?.ToString();
            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("No staff selected.");
                return;
            }

            EditAccount editAccount = new EditAccount(adminMainForm, userID);

            string query = @"SELECT * FROM [dbo].[Users] WHERE UserID = @UserID";
            var parameters = new { userID };
            List<string> columns = new List<string>
                {
                    "Fullname", "Username", "Phone", "Role", "PersonnelImage"
                };

            Dictionary<string, string> record = allMethods.GetRecordById(query, parameters, columns);

            if (record != null)
            {
                editAccount.teFullName.Text = record["Fullname"];
                editAccount.tePhone.Text = record["Phone"];
                editAccount.teUserName.Text = record["Username"];
                editAccount.cbRole.Text = record["Role"];

                if (!string.IsNullOrEmpty(record["PersonnelImage"]))
                {
                    byte[] imageBytes = Convert.FromBase64String(record["PersonnelImage"]);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        editAccount.peImage.Image = Image.FromStream(ms);
                    }
                    editAccount.existingImageData = imageBytes;
                }

                editAccount.ShowDialog();
            }
            else
            {
                MessageBox.Show("No employee found.");
            }

        }
    }
}