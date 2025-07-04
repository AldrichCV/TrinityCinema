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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private string userType = "";
        private string userName = "";
        public string UserID { get; private set; }
        public string Role { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = teUserName.Text.Trim();
            string password = tePassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Please fill up the forms");
                return;
            }

            AllMethods a = new AllMethods();
            var loginResult = a.ValidateLogin(userName, password);

            if (!string.IsNullOrEmpty(loginResult.Role))
            {
                XtraMessageBox.Show("Login Successful!");

                Role = loginResult.Role;
                UserID = loginResult.UserID;

                // Set DialogResult to OK and close login form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

            }

            //        private bool UserLogin(string username, string password)
            //        {
            //            try
            //            {
            //                var user = await _accRepo.ValidateLoginAsync(username);

            //                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            //                {
            //                    userName = user.Name;
            //                    userType = user.UserType.ToString();
            //                    return true;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                XtraMessageBox.Show("An error occurred: " + ex.Message);
            //            }

            //            return false;
            //        }

            //        private async void btnLogin_Click(object sender, EventArgs e)
            //        {
            //            string username = txtUsername.Text.Trim();
            //            string password = bePassword.Text;

            //            bool success = await UserLoginAsync(username, password);

            //            if (success)
            //            {
            //                AccountCreation form = new AccountCreation();
            //                form.ShowDialog();

            //            }
            //            else
            //            {
            //                XtraMessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }


            //        }
            //    }
            //}
        }
    }
}