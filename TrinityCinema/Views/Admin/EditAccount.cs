using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using Dapper;

namespace TrinityCinema.Views.Admin
{
    public partial class EditAccount : DevExpress.XtraEditors.XtraForm
    {
        AllMethods a = new AllMethods();
        private AdminMainForm adminMainForm;
        private string userID;
        private byte[] imageData;
        public byte[] existingImageData;
        public EditAccount(AdminMainForm adminMainForm, string userID)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.userID = userID;
        }
        private T FindControl<T>(Control parent) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T foundControl)
                    return foundControl;

                var result = FindControl<T>(control);
                if (result != null)
                    return result;
            }
            return null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {  // Confirm action
            if (XtraMessageBox.Show("Are you sure you want to remove this employee?", "Confirm Removal",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                Close();
                return;
            }

            // Get ManagerHome and EmployeeList
            var managerHome = Application.OpenForms.OfType<AdminMainForm>().FirstOrDefault();
            var employeeList = managerHome?.gcHome.Controls.OfType<UsersControl>().FirstOrDefault();

            if (managerHome == null || employeeList == null)
            {
                XtraMessageBox.Show("Required components not found.");
                return;
            }

            // Get selected staffID
            int rowHandle = employeeList.tvUserView.FocusedRowHandle;
            string accountID = employeeList.tvUserView.GetRowCellValue(rowHandle, "AccountID")?.ToString();

            if (rowHandle < 0 || string.IsNullOrWhiteSpace(accountID))
            {
                XtraMessageBox.Show("No valid employee selected.");
                return;
            }

            // Perform deletion
            AllMethods.RemoveRecordByKey(
                primaryKeyColumn: "UserID",
                primaryKeyValue: accountID,
                tablesToDeleteFrom: new List<string> { "Users" },
                connectionString: GlobalSettings.connectionString
            );

            // Close current form and reload EmployeeList
            Close();
            AllMethods.RefreshManagerHome(mh => new UsersControl(mh));
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

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to update this employee?", "Confirm",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (string.IsNullOrWhiteSpace(teFullName.Text))

            {
                XtraMessageBox.Show("Please fill up all required fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(tePassword.Text);
            if (imageData == null)
            {
                imageData = existingImageData;
            }
            var parameters = new
            {
                userID,
                Username = teUserName.Text,
                PasswordHash = hashedPassword,
                Fullname = teFullName.Text,
                Phone = tePhone.Text,
                Role = cbRole.Text,
                PersonnelImage = imageData
            };

            var columns = new List<string>
                {
                    "UserName", "PasswordHash", "Fullname", "Phone", "Role","PersonnelImage"
                };

            if (!new AllMethods().UpdateRecord("Users", parameters, columns, "userID"))
            {
                XtraMessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("Employee updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Close the current form

            AllMethods.RefreshManagerHome(mh => new UsersControl(mh));
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
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
    }
    }

    
