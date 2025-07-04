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
    public partial class PricingForm : DevExpress.XtraEditors.XtraForm
    {
        private string seatID;
        private int theaterID;
        public decimal NewPrice { get; private set; }
        public PricingForm(decimal currentPrice, string seatID)
        {
            InitializeComponent();
            tePrice.EditValue = currentPrice;
            this.seatID = seatID;
            lcSeatID.Text = seatID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tePrice.Text, out decimal price))
            {
                NewPrice = price;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                XtraMessageBox.Show("Invalid price. Please enter a valid number.");
            }
        }
    }
}