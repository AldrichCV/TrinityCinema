using Dapper;
using DevExpress.Utils.Html.Internal;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrinityCinema.Views
{
    public partial class AccountCreation : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        private string loggedInUser;

        public AccountCreation(AdminMainForm adminMainForm, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.loggedInUser = loggedInUser;
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
                string passwordSet = tePassword.Text;
                string confirmPassword = teConfirmedPassword.Text;

                if(PasswordValid(passwordSet) == false)
                {
                    passwordErrorProvider.SetError(tePassword, "Password must be at least 8 characters long, contain at least one uppercase letter, one number, and one special character.");
                    XtraMessageBox.Show("Password must be at least 8 characters long, contain at least one uppercase letter, one number, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!passwordSet.Equals(confirmPassword))
                {
                    passwordErrorProvider.SetError(teConfirmedPassword, "Passwords do not match.");
                    XtraMessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (NameExists(teFullName.Text))
                {
                    XtraMessageBox.Show("Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (UsernameExists(teUserName.Text.Trim()))
                {
                    usernameErrorProvider.SetError(teUserName, "Username already exists.");
                    XtraMessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidBirthday(deDateOfBirth.DateTime))
                {
                    XtraMessageBox.Show("You must be at least 18 years old.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordSet);

                AllMethods allMethods = new AllMethods();
                User createUser = new User
                {
                    UserID = GenerateID(),
                    Username = teUserName.Text,
                    PasswordHash = hashedPassword,
                    Fullname = teFullName.Text,
                    DateOfBirth = deDateOfBirth.DateTime.Date,
                    Phone = tePhone.Text,
                    Role = cbRole.Text,
                    PersonnelImage = imageData,
                    DateCreated = DateTime.Now
                };

                allMethods.InsertMethod(createUser, GlobalSettings.insertQuery);
                XtraMessageBox.Show("Account details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                allMethods.Log(loggedInUser, "Add Employee", $"Added employee: {createUser.Fullname} ({createUser.Username})");

                this.Close();

                var employeeList = adminMainForm.gcHome.Controls.OfType<UsersControl>().FirstOrDefault();

                if (employeeList != null)
                {
                    adminMainForm.gcHome.Controls.Remove(employeeList); // Remove old instance
                }

                UsersControl newEmployeeList = new UsersControl(adminMainForm, loggedInUser)
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        peImage.Image = Image.FromFile(openFileDialog.FileName);
                        peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            peImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can use other image formats
                            imageData = ms.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error: " + ex.Message, "Error Loading Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #region Login Validation
        private bool UsernameExists(string username)
        {
            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username";
                int count = connection.ExecuteScalar<int>(query, new { Username = username });
                return count > 0;
            }
        }

        private bool NameExists(string fullName)
        {
            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Fullname = @Fullname";
                int count = connection.ExecuteScalar<int>(query, new { Fullname = fullName });
                return count > 0;
            }
        }

        private bool PasswordValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;
            return true;
        }

        private bool ValidBirthday(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            DateTime minimumDate = today.AddYears(-18); // Must be born on or before this date

            if (birthdate == null || birthdate > today || birthdate > minimumDate)
            {
                deDateOfBirth.ErrorText = "You must be at least 18 years old.";
                return false;
            }

            return true;
        }

        private void tePassword_EditValueChanged(object sender, EventArgs e)
        {
            string password = tePassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                passwordErrorProvider.SetError(tePassword, "Password is required.");
                return;
            }

            if (password.Length < 8)
            {
                passwordErrorProvider.SetError(tePassword, "Password must be at least 8 characters long.");
                return;
            }

            if (!password.Any(char.IsUpper))
            {
                passwordErrorProvider.SetError(tePassword, "Password must contain at least one uppercase letter.");
                return;
            }

            if (!password.Any(char.IsDigit))
            {
                passwordErrorProvider.SetError(tePassword, "Password must contain at least one number.");
                return;
            }

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                passwordErrorProvider.SetError(tePassword, "Password must contain at least one special character.");
                return;
            }

            // If all checks pass
            passwordErrorProvider.SetError(tePassword, string.Empty);
        }

        private void teUserName_EditValueChanged(object sender, EventArgs e)
        {
            string username = teUserName.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                usernameErrorProvider.SetError(teUserName, "Username is required.");
                return;
            }

            if (UsernameExists(username))
            {
                usernameErrorProvider.SetError(teUserName, "Username already exists.");
            }
            else
            {
                usernameErrorProvider.SetError(teUserName, string.Empty);
            }
        }

        private void teConfirmedPassword_EditValueChanged(object sender, EventArgs e)
        {
            string confirmPassword = teConfirmedPassword.Text.Trim();
            string password = tePassword.Text.Trim();

            if (string.IsNullOrEmpty(confirmPassword))
            {
                confirmPasswordErrorProvider.SetError(teConfirmedPassword, "Please confirm your password.");
                return;
            }

            if (!confirmPassword.Equals(password))
            {
                confirmPasswordErrorProvider.SetError(teConfirmedPassword, "Passwords do not match.");
            }
            else
            {
                confirmPasswordErrorProvider.SetError(teConfirmedPassword, string.Empty);
            }

        }

        private void tePhone_EditValueChanged(object sender, EventArgs e)
        {
            string phone = tePhone.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                phoneErrorProvider.SetError(tePhone, "Phone number is required.");
                return;
            }

            // Remove spaces, dashes, or any non-digit characters
            string digitsOnly = Regex.Replace(phone, @"\D", "");

            if (!Regex.IsMatch(digitsOnly, @"^(09\d{9}|639\d{9})$"))
            {
                phoneErrorProvider.SetError(tePhone, "Phone number must be in valid format: 09123456789 or 639123456789.");
            }
            else
            {
                phoneErrorProvider.SetError(tePhone, string.Empty);
            }
        }

        private void teFullName_EditValueChanged(object sender, EventArgs e)
        {
            string fullName = teFullName.Text.Trim();

            if (string.IsNullOrEmpty(fullName))
            {
                fullNameErrorProvider.SetError(teFullName, "Full name is required.");
            }
            else
            {
                fullNameErrorProvider.SetError(teFullName, string.Empty);

                if (NameExists(fullName))
                {
                    fullNameErrorProvider.SetError(teFullName, "Full name already exists.");
                }
                else
                {
                    fullNameErrorProvider.SetError(teFullName, string.Empty);
                }
            }
            #endregion

        }
    }
}
    

