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
    public partial class UsersControl : UserControl 
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        private string loggedInUser;
     
        public UsersControl(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            AllMethods.GridCustomization(gcUser, tvUserView, GetEmployee());
           
            this.loggedInUser = loggedInUser;
        }

        public List<User> GetEmployee()
        {
            string query = GlobalSettings.getPersonnel;
            return a.GetRecords<User>(query);
        }

        private void tvUserView_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            AllMethods allMethods = new AllMethods();

            string userID = tvUserView.GetFocusedRowCellValue("UserID")?.ToString();
            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("No staff selected.");
                return;
            }

            EditAccount editAccount = new EditAccount(adminMainForm, userID, loggedInUser);

            string query = @"SELECT * FROM [dbo].[Users] WHERE UserID = @UserID";
            var parameters = new { userID };
            List<string> columns = new List<string>
                {
                    "Fullname", "Phone", "Role", "PersonnelImage", "DateOfBirth"
                };

            Dictionary<string, string> record = allMethods.GetRecordById(query, parameters, columns);

            if (record != null)
            {
                editAccount.teFullName.Text = record["Fullname"];
                editAccount.tePhone.Text = record["Phone"];
                editAccount.cbRole.Text = record["Role"];
                editAccount.deDateOfBirth.DateTime = Convert.ToDateTime(record["DateOfBirth"]);


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

        private void userTile_ItemClick(object sender, TileItemEventArgs e)
        {
            AllMethods.ShowModal(home => new AccountCreation(home,loggedInUser));
        }
    }
}