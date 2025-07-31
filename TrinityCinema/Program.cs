using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TrinityCinema.Models;
using TrinityCinema.Views;
using TrinityCinema.Views.Admin;
using TrinityCinema.Views.Staff;
using System.Media;

namespace TrinityCinema
{
    internal static class Program
    {
        static SoundPlayer splashPlayer;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SeatManagement());
            //var userID = string.Empty;


            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    string userID = loginForm.UserID;
                    string role = loginForm.Role;

                    var splash = new SplashScreenManager(null, typeof(LoginSplash), true, true);
                    splash.ShowWaitForm();
                    //PlaySplashMusic();
                    splash.SetWaitFormDescription("Loading interface...");

                    Form mainForm = null;

                    if (role == "Manager")
                    {
                        var dashboardReadyTcs = new TaskCompletionSource<object>();

                        var adminForm = new AdminMainForm(userID, (s, e) =>
                        {
                            dashboardReadyTcs.TrySetResult(null);
                        });

                        adminForm.Opacity = 0;
                        mainForm = adminForm; // assign to the shared mainForm variable

                        // Run background wait task
                        Task.Run(async () =>
                        {
                            var fiveSecondDelay = Task.Delay(5000);
                            await Task.WhenAll(fiveSecondDelay, dashboardReadyTcs.Task);

                            if (adminForm.IsHandleCreated)
                            {
                                adminForm.Invoke(new MethodInvoker(() =>
                                {
                                    if (splash.IsSplashFormVisible)
                                        splash.CloseWaitForm();
                                                StopSplashMusic();

                                    adminForm.StartFadeIn();
                                }));
                            }

                        });
                    }
                    else if (role == "Staff")
                    {
                        mainForm = new StaffMainForm(userID);

                        // Simple 5s splash delay
                        Task.Run(async () =>
                        {
                            await Task.Delay(5000);

                            if (splash.IsSplashFormVisible)
                                splash.CloseWaitForm();
                                   StopSplashMusic();
                        });
                    }
                    else
                    {
                        return;
                    }

                    // ✅ Only one Application.Run call — consistent
                    Application.Run(mainForm);
                }
            }
        }
            static void PlaySplashMusic()
            {
                try
                {
                    splashPlayer = new SoundPlayer("rbd.wav"); // Make sure file exists
                    splashPlayer.Play(); // Or use .PlayLooping() if needed
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to play splash sound: " + ex.Message);
                }
            }

            // 🛑 Stop music if looping
            static void StopSplashMusic()
            {
                try
                {
                    splashPlayer?.Stop();
                }
                catch { /* Silently ignore */ }
            }
        }

    }

    

    
        
   

    


       