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
        private string accountID;
        private byte[] imageData;

        public EditAccount(AdminMainForm adminMainForm, string accountID)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.accountID = accountID;
            RetrieveImage(accountID);
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

        private void RetrieveImage(string accountID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalSettings.connectionString))
                {
                    connection.Open();

                    string query = "SELECT PersonnelImage FROM [Accounts] WHERE AccountID = @AccountID";

                    byte[] imageData = connection.QueryFirstOrDefault<byte[]>(
                        query,
                        new { AccountID = accountID }
                    );

                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            peImage.Image = Image.FromStream(ms);
                        }
                    }
                    // Optional: else show message or set peEmployeePicture.Image = null
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error Loading Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to update this employee?", "Confirm",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                string.IsNullOrWhiteSpace(teMiddleName.Text) ||
                string.IsNullOrWhiteSpace(teLastName.Text))

            {
                XtraMessageBox.Show("Please fill up all required fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parameters = new
            {
                accountID,
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                Suffix = string.IsNullOrWhiteSpace(teSuffix.Text) ? null : teSuffix.Text,
                Role = cbRole.Text
            };

            var columns = new List<string>
                {
                    "FirstName", "MiddleName", "LastName", "Suffix", "Role"
                };

            if (!new AllMethods().UpdateRecord("Accounts", parameters, columns, "accountID"))
            {
                XtraMessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("Employee updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Close the current form

            AllMethods.RefreshManagerHome(mh => new PersonnelControl(mh));

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
            var employeeList = managerHome?.gcHome.Controls.OfType<PersonnelControl>().FirstOrDefault();

            if (managerHome == null || employeeList == null)
            {
                XtraMessageBox.Show("Required components not found.");
                return;
            }

            // Get selected staffID
            int rowHandle = employeeList.tvPersonnelView.FocusedRowHandle;
            string accountID = employeeList.tvPersonnelView.GetRowCellValue(rowHandle, "AccountID")?.ToString();

            if (rowHandle < 0 || string.IsNullOrWhiteSpace(accountID))
            {
                XtraMessageBox.Show("No valid employee selected.");
                return;
            }

            // Perform deletion
            AllMethods.RemoveRecordByKey(
                primaryKeyColumn: "AccountID",
                primaryKeyValue: accountID,
                tablesToDeleteFrom: new List<string> { "Accounts" },
                connectionString: GlobalSettings.connectionString
            );

            // Close current form and reload EmployeeList
            Close();
            AllMethods.RefreshManagerHome(mh => new PersonnelControl(mh));
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
        }
    }

    
