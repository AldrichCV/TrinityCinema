using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private int attempt = 0;
        private Timer delayTimer;
        private int timeLeft = 60; // 60 seconds (1 minute)

        public LoginForm()
        {
            InitializeComponent();
            InitializeDelayTimer();
        }

        private void InitializeDelayTimer()
        {
            delayTimer = new Timer();
            delayTimer.Interval = 1000; // 1 second
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
                timeLeft = 60; // Reset for future use
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = teUser.Text.Trim();
            string password = tePassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Please enter both username and password.");
                return;
            }

            using (var con = new SqlConnection(GlobalSettings.connectionString))
            {
                var user = con.QueryFirstOrDefault<User>("SELECT * FROM Users WHERE Username = @Username", new { Username = username });

                if (user == null)
                {
                    HandleFailedAttempt(); // No user found
                    return;
                }

                if (user.Status == 1) // 1 = Locked
                {
                    XtraMessageBox.Show("Your account is locked. Please contact the administrator.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

                if (passwordMatch)
                {
                    con.Execute("UPDATE Users SET FailedAttempts = 0 WHERE UserID = @UserID", new { user.UserID });
                    XtraMessageBox.Show("Login successful!");
                    this.Hide();
                    new AdminMainForm().Show();
                }
                else
                {
                    HandleFailedAttempt(user);
                }
            }
        }

        private void HandleFailedAttempt(User user = null)
        {
            attempt++;

            if (user == null)
            {
                XtraMessageBox.Show($"Invalid username or password.\nAttempts left: {3 - attempt}");
                if (attempt == 2)
                {
                    StartDelayBeforeFinalAttempt();
                }
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
                    con.Execute("UPDATE Users SET FailedAttempts = @FailedAttempts, Status = 1 WHERE UserID = @UserID", new
                    {
                        FailedAttempts = newFailed,
                        user.UserID
                    });

                    XtraMessageBox.Show("Your account has been locked due to multiple failed login attempts.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    con.Execute("UPDATE Users SET FailedAttempts = @FailedAttempts WHERE UserID = @UserID", new
                    {
                        FailedAttempts = newFailed,
                        user.UserID
                    });

                    XtraMessageBox.Show($"Incorrect password.\nAttempts left: {3 - newFailed}");

                    if (newFailed == 2)
                        StartDelayBeforeFinalAttempt();
                }
            }
        }

        private void StartDelayBeforeFinalAttempt()
        {
            XtraMessageBox.Show("You have 1 attempt left. Please review your credentials carefully.\nWait 1 minute before your final attempt.", "Final Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            delayTimer.Start();
        }
    }
}
