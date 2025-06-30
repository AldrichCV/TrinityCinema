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

namespace TrinityCinema.Views.Admin
{
    public partial class PricingForm : DevExpress.XtraEditors.XtraForm
    {
        public decimal NewPrice { get; private set; }
        public PricingForm(decimal currentPrice)
        {
            InitializeComponent();
            tePrice.EditValue = currentPrice;
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