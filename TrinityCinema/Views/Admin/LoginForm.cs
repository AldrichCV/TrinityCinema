using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        #region Class Variables
        private SplashScreenManager splashScreenManager;

        private int attempt = 0;                     // Tracks the current failed login attempts
        private Timer delayTimer;                   // Timer used to delay the 3rd attempt
        private int timeLeft = 60;                  // Countdown for the 1-minute delay
        private bool isPasswordVisible = false;     // Tracks visibility toggle state
        private const int MaxFailedAttempts = 3;

        public string UserID { get; private set; }
        public string Role { get; private set; }
        #endregion

        public LoginForm()
        {
            InitializeComponent();
            InitializeDelayTimer();
            splashScreenManager = new SplashScreenManager(this, typeof(LoginSplash), true, true);
            Styles();

        }

        public void Styles()
        {
            btnLogin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            // Default (Normal) Appearance
            btnLogin.Appearance.Font = new Font("Segoe UI", 12);
            btnLogin.Appearance.BackColor = Color.Maroon;
            btnLogin.Appearance.ForeColor = Color.White;
            btnLogin.Appearance.BorderColor = Color.Maroon;
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseForeColor = true;
            btnLogin.Appearance.Options.UseBorderColor = true;

            // Hover Appearance (HotTracked)
            btnLogin.AppearanceHovered.BackColor = Color.FromArgb(180, 0, 0); // darker maroon
            btnLogin.AppearanceHovered.ForeColor = Color.White;
            btnLogin.AppearanceHovered.BorderColor = Color.DarkRed;
            btnLogin.AppearanceHovered.Options.UseBackColor = true;
            btnLogin.AppearanceHovered.Options.UseForeColor = true;
            btnLogin.AppearanceHovered.Options.UseBorderColor = true;
        }
  
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = teUserName.Text.Trim();
            string password = tePassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Please fill up the forms.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AllMethods authService = new AllMethods();

            // Hardcoded Admin Login
            if (username == "admin" && password == "1")
            {
                this.UserID = "admin";
                this.Role = "Manager";

                authService.Log("admin", "Login", "Admin logged in via default credentials");

                this.DialogResult = DialogResult.OK;
                return;
            }

            var userStatus = authService.GetUserLoginStatus(username);

            if (userStatus == null)
            {
                authService.Log(username, "Failed Login", "Attempted login for non-existing user");
                HandleFailedAttempt();
                return;
            }

            if (userStatus.Value.IsLocked)
            {
                XtraMessageBox.Show("Your account is locked.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                authService.Log(username, "Failed Login", "Login attempt on locked account");
                return;
            }

            var loginResult = authService.ValidateLogin(username, password);

            if (!string.IsNullOrEmpty(loginResult.Role))
            {
                authService.ResetLoginAttempts(username);

                this.UserID = loginResult.UserID;
                this.Role = loginResult.Role;

                authService.Log(loginResult.UserID, "Login", $"{loginResult.UserID} successfully logged in");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                authService.Log(username, "Failed Login", "Incorrect password");

                HandleFailedAttempt(new User
                {
                    Username = username,
                    FailedAttempts = userStatus.Value.FailedAttempts

                });
            }
        }

        #region Validation
        private void InitializeDelayTimer()
        {
            delayTimer = new Timer();
            delayTimer.Interval = 1000;
            delayTimer.Tick += DelayTimer_Tick;

        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            btnLogin.Text = $"Wait ({timeLeft}s)";
            btnLogin.Enabled = false;

            if (timeLeft <= 0)
            {
                delayTimer.Stop();
                btnLogin.Text = "Login";
                btnLogin.Enabled = true;
                timeLeft = 60;
            }
        }

        private void HandleFailedAttempt(User user = null)
        {
            attempt++;

            if (user == null)
            {
                XtraMessageBox.Show($"Invalid username or password.\nAttempts left: {3 - attempt}");

                if (attempt == 2)
                    StartDelayBeforeFinalAttempt();
                else if (attempt >= 3)
                {
                    XtraMessageBox.Show("Too many failed attempts. Exiting...");
                    Application.Exit();
                }

                return;
            }

            int newFailed = user.FailedAttempts + 1;
            bool isLocked = newFailed >= 3;

            AllMethods.UpdateLoginAttempts(user.Username, newFailed, isLocked);

            if (isLocked)
            {
                XtraMessageBox.Show("Your account has been locked due to multiple failed login attempts.",
                    "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                XtraMessageBox.Show($"Incorrect password.\nAttempts left: {3 - newFailed}");

                if (newFailed == 2)
                    StartDelayBeforeFinalAttempt();
            }
        }

        private void StartDelayBeforeFinalAttempt()
        {
            XtraMessageBox.Show("You have 1 attempt left. Please review your credentials carefully.\nWait 1 minute before your final attempt.",
                "Final Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            delayTimer.Start();
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
