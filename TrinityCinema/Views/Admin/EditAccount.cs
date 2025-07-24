using Dapper;
using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class EditAccount : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
        private AdminMainForm adminMainForm;
        private string loggedInUser;
        private string userID;
        private byte[] imageData;
        public byte[] existingImageData;
      

        public EditAccount(AdminMainForm adminMainForm, string userID, string loggedInUser)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.userID = userID;
            this.loggedInUser = loggedInUser;
            SetLockStatusButton(userID);
          
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



        public void SetLockStatusButton(string userID)
        {
            var userStatus = new AllMethods().GetUserLoginStatusByUserID(userID);

            if (userStatus == null)
            {
                btnIsLocked.Text = "User Not Found";
                btnIsLocked.Enabled = false;
                btnIsLocked.BackColor = Color.Gray;
                return;
            }
            bool isLocked = userStatus.Value.IsLocked;

            if (isLocked)
            {
                btnIsLocked.Text = "Locked";
                btnIsLocked.Enabled = true;

                btnIsLocked.Appearance.BackColor = Color.Red;
                btnIsLocked.Appearance.ForeColor = Color.White;
                btnIsLocked.Appearance.Options.UseBackColor = true;
                btnIsLocked.Appearance.Options.UseForeColor = true;

                btnIsLocked.LookAndFeel.UseDefaultLookAndFeel = false;
                btnIsLocked.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            }
            else
            {
                btnIsLocked.Text = "Active";
                btnIsLocked.Enabled = false;

                btnIsLocked.AppearanceDisabled.BackColor = Color.Green;
                btnIsLocked.AppearanceDisabled.ForeColor = Color.White;
                btnIsLocked.AppearanceDisabled.Options.UseBackColor = true;
                btnIsLocked.AppearanceDisabled.Options.UseForeColor = true;

                btnIsLocked.LookAndFeel.UseDefaultLookAndFeel = false;
                btnIsLocked.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to update this employee?", "Confirm",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (string.IsNullOrWhiteSpace(teFullName.Text))
            {
                XtraMessageBox.Show("Please fill up all required fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!ValidBirthday(deDateOfBirth.DateTime))
            {
                XtraMessageBox.Show("You must be at least 18 years old.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (imageData == null)
                imageData = existingImageData;

            // Step 1: Fetch the current (original) values from the database
            DataRow original = allMethods.GetRecord("Users", "userID", userID); // Implement this if not existing

            if (original == null)
            {
                XtraMessageBox.Show("Original user record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Compare values
            bool isModified =
                original["Fullname"].ToString() != teFullName.Text ||
                original["DateOfBirth"].ToString() != deDateOfBirth.DateTime.ToString("yyyy-MM-dd") || 
                original["Phone"].ToString() != tePhone.Text ||
                original["Role"].ToString() != cbRole.Text ||
                !imageData.SequenceEqual((byte[])original["PersonnelImage"]);

            if (!isModified)
            {
                XtraMessageBox.Show("No changes detected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Step 3: Proceed with update
            var parameters = new
            {
                userID,
                Fullname = teFullName.Text,
                Phone = tePhone.Text,
                Role = cbRole.Text,
                PersonnelImage = imageData,
                DateOfBirth = deDateOfBirth.DateTime.ToString("yyyy-MM-dd") 
            };

            var columns = new List<string>
    {
        "Fullname", "Phone", "Role","DateOfBirth", "PersonnelImage"
    };

            if (!new AllMethods().UpdateRecord("Users", parameters, columns, "userID"))
            {
                XtraMessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("User updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string logDetails = "Modified ";
            if (original["Fullname"].ToString() != teFullName.Text)
                logDetails += $" Fullname ({original["Fullname"]} -> {teFullName.Text});";
            if (original["Phone"].ToString() != tePhone.Text)
                logDetails += $" Phone ({original["Phone"]} -> {tePhone.Text});";
            if (original["Role"].ToString() != cbRole.Text)
                logDetails += $" Role ({original["Role"]} -> {cbRole.Text});";
            DateTime originalDob = Convert.ToDateTime(original["DateOfBirth"]);
            DateTime newDob = deDateOfBirth.DateTime;

            if (originalDob.Date != newDob.Date)
            {
                logDetails += $" DateOfBirth of {userID} ({originalDob:yyyy-MM-dd} -> {newDob:yyyy-MM-dd});";
            }


            allMethods.Log(loggedInUser, "Modified Employee", logDetails);

            this.Close();
            AllMethods.RefreshManagerHome(mh => new UsersControl(mh, userID));
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
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

            // Get selected row and account ID
            int rowHandle = employeeList.tvUserView.FocusedRowHandle;
            if (rowHandle < 0)
            {
                XtraMessageBox.Show("No employee selected.");
                return;
            }

            string accountID = employeeList.tvUserView.GetRowCellValue(rowHandle, "UserID")?.ToString();
            string fullname = employeeList.tvUserView.GetRowCellValue(rowHandle, "Fullname")?.ToString();
            string username = employeeList.tvUserView.GetRowCellValue(rowHandle, "Username")?.ToString();

            if (string.IsNullOrWhiteSpace(accountID))
            {
                XtraMessageBox.Show("Invalid UserID.");
                return;
            }

            // Perform deletion
            allMethods.RemoveRecordByKey(
                primaryKeyColumn: "UserID",
                primaryKeyValue: accountID,
                tablesToDeleteFrom: new List<string> { "Users" },
                connectionString: GlobalSettings.connectionString
            );

            // Log the deletion
            allMethods.Log(loggedInUser, "Remove Employee", $"Removed employee: {fullname} ({username})");

            // Close current form and reload user list
            Close();
            AllMethods.RefreshManagerHome(mh => new UsersControl(mh, loggedInUser));
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            AllMethods.ShowModal(mh => new PasswordReset(mh, loggedInUser, userID, this));
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

    }
}

    
