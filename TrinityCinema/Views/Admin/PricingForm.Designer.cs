namespace TrinityCinema.Views.Admin
{
    partial class PricingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lcSeatID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(54, 101);
            this.tePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tePrice.Name = "tePrice";
            this.tePrice.Size = new System.Drawing.Size(211, 34);
            this.tePrice.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(215, 163);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 28);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 77);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Enter Seat Pricing:";
            // 
            // lcSeatID
            // 
            this.lcSeatID.Location = new System.Drawing.Point(54, 24);
            this.lcSeatID.Margin = new System.Windows.Forms.Padding(4);
            this.lcSeatID.Name = "lcSeatID";
            this.lcSeatID.Size = new System.Drawing.Size(20, 16);
            this.lcSeatID.TabIndex = 3;
            this.lcSeatID.Text = "----";
            // 
            // PricingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 204);
            this.Controls.Add(this.lcSeatID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tePrice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PricingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PricingForm";
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tePrice;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lcSeatID;
    }
}