using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Views
{
    public partial class AccountCreation : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        public AccountCreation(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm; 
        }

        private void AccountCreation_Load(object sender, EventArgs e)
        {

        }

        private static string GenerateID()
        {
            Random rand = new Random();
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return "EID-" + new string(Enumerable.Range(0, 6).Select(i => i % 2 == 0
                    ? letters[rand.Next(letters.Length)]
                    : (char)('0' + rand.Next(10))).ToArray());
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {

            DialogResult result = XtraMessageBox.Show("Are You Sure You Want to Add This Employee?", "Verify",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(tePassword.Text);
                AllMethods allMethods = new AllMethods();
                Personnel createAccounts = new Personnel
                {
                    AccountID = GenerateID(),
                    FirstName = teFirstName.Text,
                    MiddleName = teMiddleName.Text,
                    LastName = teLastName.Text,
                    Suffix = teSuffix.Text,
                    Role = cbRole.Text,
                    UserName = teUserName.Text,
                    PasswordHash = hashedPassword
                };
                allMethods.InsertMethod(createAccounts, GlobalSettings.insertQuery);
                XtraMessageBox.Show("Account details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                var employeeList = adminMainForm.gcHome.Controls.OfType<PersonnelControl>().FirstOrDefault();

                if (employeeList != null)
                {
                    adminMainForm.gcHome.Controls.Remove(employeeList); // Remove old instance
                }

                PersonnelControl newEmployeeList = new PersonnelControl(adminMainForm)
                {
                    Dock = DockStyle.Fill
                };
                adminMainForm.gcHome.Controls.Add(newEmployeeList);
                newEmployeeList.BringToFront();

            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }

        }
    }
}