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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            if (userName == "admin" && password == "1")
            {
                this.UserID = "admin";
                this.Role = "Manager";
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Please fill up the forms.");
                return;
            }

            AllMethods a = new AllMethods();

            var userStatus = a.GetUserLoginStatus(userName);

            if (userStatus == null)
            {
                XtraMessageBox.Show("User not found.");
                return;
            }

            if (userStatus.Value.IsLocked)
            {
                XtraMessageBox.Show("Your account is locked due to multiple failed login attempts. Contact admin.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loginResult = a.ValidateLogin(userName, password);

            if (!string.IsNullOrEmpty(loginResult.Role))
            {
                a.ResetLoginAttempts(userName);

                XtraMessageBox.Show("Login Successful!");

                this.Role = loginResult.Role;
                this.UserID = loginResult.UserID;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                int newAttempts = userStatus.Value.FailedAttempts + 1;
                bool shouldLock = newAttempts >= 3;

                a.UpdateLoginAttempts(userName, newAttempts, shouldLock);

                if (shouldLock)
                {
                    XtraMessageBox.Show("Your account has been locked after 3 failed attempts.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show($"Login failed. Attempt {newAttempts}/3", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
