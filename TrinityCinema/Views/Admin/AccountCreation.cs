using DevExpress.Utils.Html.Internal;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views.Admin;
using Dapper;

namespace TrinityCinema.Views
{
    public partial class AccountCreation : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        private byte[] imageData;
        public AccountCreation(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm; 
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
                User createUser = new User
                {
                    UserID = GenerateID(),
                    Username = teUserName.Text,
                    PasswordHash = hashedPassword,
                    Fullname = teFullName.Text,
                    Phone = tePhone.Text,
                    Role = cbRole.Text,
                    PersonnelImage = imageData,
                    DateCreated = DateTime.Now
                };

                allMethods.InsertMethod(createUser, GlobalSettings.insertQuery);
                XtraMessageBox.Show("Account details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                var employeeList = adminMainForm.gcHome.Controls.OfType<UsersControl>().FirstOrDefault();

                if (employeeList != null)
                {
                    adminMainForm.gcHome.Controls.Remove(employeeList); // Remove old instance
                }

                UsersControl newEmployeeList = new UsersControl(adminMainForm)
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

        private void teUserName_EditValueChanged(object sender, EventArgs e)
        {
            string username = teUserName.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                errorProvider.SetError(teUserName, "Username is required.");
                return;
            }

            if (UsernameExists(username))
            {
                errorProvider.SetError(teUserName, "Username already exists.");
            }
            else
            {
                errorProvider.SetError(teUserName, string.Empty);
            }
        }
        private bool UsernameExists(string username)
        {
            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username";
                int count = connection.ExecuteScalar<int>(query, new { Username = username });
                return count > 0;
            }
        }

     
    }
}
