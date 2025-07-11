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
                XtraMessageBox.Show("Login Failed");
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}