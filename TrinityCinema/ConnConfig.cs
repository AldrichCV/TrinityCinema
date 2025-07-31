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

namespace TrinityCinema
{
    public partial class ConnConfig : DevExpress.XtraEditors.XtraForm
    {
        public ConnConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string input = teConn.Text.Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                GlobalSettings.connectionString = input;
                MessageBox.Show("Connection string updated successfully.");
                this.Close();
                // Example: called when user hits "Apply" or "Connect"
                Properties.Settings.Default.ConnConfig = teConn.Text.Trim(); // or connectionString
                Properties.Settings.Default.Save(); // Saves to user settings file

            }
            else
            {
                MessageBox.Show("Please enter a valid connection string.");
            }
        }
    }
}