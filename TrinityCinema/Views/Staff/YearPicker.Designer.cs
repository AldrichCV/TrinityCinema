namespace TrinityCinema.Views.Staff
{
    partial class YearPicker
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
            this.cbeYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbeYear
            // 
            this.cbeYear.Location = new System.Drawing.Point(78, 98);
            this.cbeYear.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cbeYear.Name = "cbeYear";
            this.cbeYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeYear.Size = new System.Drawing.Size(142, 34);
            this.cbeYear.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 72);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Year";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(78, 187);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 60);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // YearPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 274);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbeYear);
            this.Controls.Add(this.labelControl2);
            this.Name = "YearPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YearPicker";
            ((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbeYear;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
    }
}