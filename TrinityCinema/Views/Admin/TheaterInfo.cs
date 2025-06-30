using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;

namespace TrinityCinema.Views.Admin
{
    public partial class TheaterInfo : DevExpress.XtraEditors.XtraForm
    {
        private AdminMainForm adminMainForm;
        public TheaterInfo(AdminMainForm adminMainForm)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are You Sure You Want to Add Theater?", "Verify",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                AllMethods allMethods = new AllMethods();
                Theater createTheater = new Theater
                {
                    TheaterName = teName.Text,
                    SeatCapacity = Convert.ToInt32(teSeats.Text),
                };

                allMethods.InsertMethod(createTheater, GlobalSettings.createTheater);
                XtraMessageBox.Show("Account details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                var theaterList = adminMainForm.gcHome.Controls.OfType<TheaterControl>().FirstOrDefault();

                if (theaterList != null)
                {
                    adminMainForm.gcHome.Controls.Remove(theaterList); // Remove old instance
                }

                TheaterControl newTheater = new TheaterControl(adminMainForm)
                {
                    Dock = DockStyle.Fill
                };
                adminMainForm.gcHome.Controls.Add(newTheater);
                newTheater.BringToFront();

            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}