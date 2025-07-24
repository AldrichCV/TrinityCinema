using Dapper;
using DevExpress.XtraEditors;
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
        private SplashScreenManager splashScreenManager;

        private int attempt = 0;                     // Tracks the current failed login attempts
        private Timer delayTimer;                   // Timer used to delay the 3rd attempt
        private int timeLeft = 60;                  // Countdown for the 1-minute delay
        private bool isPasswordVisible = false;     // Tracks visibility toggle state
        private const int MaxFailedAttempts = 3;

        private string userType = "";
        private string userName = "";
        public string UserID { get; private set; }
        public string Role { get; private set; }
      
        public LoginForm()
        {
            InitializeComponent();
            InitializeDelayTimer();
            splashScreenManager = new SplashScreenManager(this, typeof(LoginSplash), true, true);

        }

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
                this.DialogResult = DialogResult.OK;
                return;
            }

            var userStatus = authService.GetUserLoginStatus(username);

            if (userStatus == null)
            {
                HandleFailedAttempt();
                return;
            }

            if (userStatus.Value.IsLocked)
            {
                XtraMessageBox.Show("Your account is locked.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loginResult = authService.ValidateLogin(username, password);

            if (!string.IsNullOrEmpty(loginResult.Role))
            {
                authService.ResetLoginAttempts(username);

                this.UserID = loginResult.UserID;
                this.Role = loginResult.Role;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                HandleFailedAttempt(new User
                {
                    Username = username,
                    FailedAttempts = userStatus.Value.FailedAttempts
                });
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

            using (var con = new SqlConnection(GlobalSettings.connectionString))
            {
                if (newFailed >= 3)
                {
                    con.Execute("UPDATE Users SET FailedAttempts = @FailedAttempts, Status = 1 WHERE Username = @Username", new
                    {
                        FailedAttempts = newFailed,
                        user.Username
                    });

                    XtraMessageBox.Show("Your account has been locked due to multiple failed login attempts.",
                        "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    con.Execute("UPDATE Users SET FailedAttempts = @FailedAttempts WHERE Username = @Username", new
                    {
                        FailedAttempts = newFailed,
                        user.Username
                    });

                    XtraMessageBox.Show($"Incorrect password.\nAttempts left: {3 - newFailed}");

                    if (newFailed == 2)
                        StartDelayBeforeFinalAttempt();
                }
            }
        }

        private void StartDelayBeforeFinalAttempt()
        {
            XtraMessageBox.Show("You have 1 attempt left. Please review your credentials carefully.\nWait 1 minute before your final attempt.",
                "Final Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            delayTimer.Start();
        }


        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
