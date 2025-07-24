using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class PasswordReset : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        private string loggedInUser;
        private string userID;
        private EditAccount editAccount;
        public PasswordReset(AdminMainForm adminMainForm, string loggedInUser, string userID, EditAccount parentForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.loggedInUser = loggedInUser;
            this.userID = userID;
            teUser.Text = userID;
            teUser.Properties.ReadOnly = true;
            this.editAccount = parentForm;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string newPassword = teNewPassword.Text.Trim();
            string confirmPassword = teConfirmPassword.Text.Trim();

            // Validation checks
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                XtraMessageBox.Show("Both password fields are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 8)
            {
                XtraMessageBox.Show("Password must be at least 8 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(newPassword, @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"))
            {
                XtraMessageBox.Show("Password must include at least 1 uppercase letter, 1 number, and 1 special character.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                XtraMessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                var parameters = new
                {
                    UserID = userID,
                    PasswordHash = hashedPassword,
                    IsLocked = 0,
                    FailedAttempts = 0
                };

                var columns = new List<string> { "PasswordHash", "IsLocked", "FailedAttempts" };

                bool success = new AllMethods().UpdateRecord("Users", parameters, columns, "UserID");

                if (success)
                {
                    allMethods.Log(loggedInUser, "Reset Password", $"Reset password, unlocked account, and cleared attempts for user ID {userID}");
                    XtraMessageBox.Show("Password reset successfully. User unlocked and attempts reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    XtraMessageBox.Show("Password updated and account unlocked.");

                    editAccount?.SetLockStatusButton(userID);
                    this.Close();
                  
                }
                else
                {
                    XtraMessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }
