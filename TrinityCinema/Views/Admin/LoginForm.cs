using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class LoginForm : XtraForm
    {
        private int attempt = 0;                     // Tracks the current failed login attempts
        private Timer delayTimer;                   // Timer used to delay the 3rd attempt
        private int timeLeft = 60;                  // Countdown for the 1-minute delay
        private bool isPasswordVisible = false;     // Tracks visibility toggle state

        public LoginForm()
        {
            InitializeComponent();
            InitializeDelayTimer();

            // Set initial password to hidden
            tePassword.Properties.UseSystemPasswordChar = true;

            // Add button click event manually (or via Designer)
            tePassword.ButtonClick += tePassword_ButtonClick;
        }

        // Setup 1-minute delay timer
        private void InitializeDelayTimer()
        {
            delayTimer = new Timer();
            delayTimer.Interval = 1000; // 1 second
            delayTimer.Tick += DelayTimer_Tick;
        }

        // Called every second during delay
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
                timeLeft = 60; // Reset for next time
            }
        }

        // Login logic
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
                var user = con.QueryFirstOrDefault<User>(
                    "SELECT * FROM Users WHERE Username = @Username", new { Username = username });

                if (user == null)
                {
                    HandleFailedAttempt(); // Invalid username
                    return;
                }

                if (user.Status == 1) // Locked account
                {
                    XtraMessageBox.Show("Your account is locked. Please contact the administrator.",
                        "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

                if (passwordMatch)
                {
                    // Reset failed attempts
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

        // Handles failed login attempts
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
                    // Lock account
                    con.Execute("UPDATE Users SET FailedAttempts = @FailedAttempts, Status = 1 WHERE UserID = @UserID", new
                    {
                        FailedAttempts = newFailed,
                        user.UserID
                    });

                    XtraMessageBox.Show("Your account has been locked due to multiple failed login attempts.",
                        "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    // Just update failed count
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

        // Called after 2 failed attempts to delay before 3rd
        private void StartDelayBeforeFinalAttempt()
        {
            XtraMessageBox.Show("You have 1 attempt left. Please review your credentials carefully.\nWait 1 minute before your final attempt.",
                "Final Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            delayTimer.Start();
        }

        // Handles visibility toggle on eye button click in tePassword
        private void tePassword_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            tePassword.Properties.UseSystemPasswordChar = !isPasswordVisible;

            // Change the button's icon
            var button = tePassword.Properties.Buttons[0];
            button.ImageOptions.Image = isPasswordVisible
                ? DevExpress.Images.ImageResourceCache.Default.GetImage("actions_visibility_16x16")
                : DevExpress.Images.ImageResourceCache.Default.GetImage("actions_visibilityoff_16x16");
        }
    }
}
