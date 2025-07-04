using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using TrinityCinema.Views;
using TrinityCinema.Views.Admin;

namespace TrinityCinema
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var userID = string.Empty;
            //Application.Run(new AdminMainForm(userID));
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK) // You have to set this on successful login
                {
                    // After loginAdmin closes, retrieve staffID and role from it
                    string userID = loginForm.UserID;
                    string role = loginForm.Role;

                    Form nextForm;

                    if (role == "Manager")
                        nextForm = new AdminMainForm(userID);
                    else if (role == "Staff")
                        nextForm = new StaffMainForm(userID);
                    else
                        return; // Unknown role, exit app

                    Application.Run(nextForm);
                }
                else
                {
                    // Login cancelled or failed, exit app
                    return;
                }
            }
        }

    }
}
