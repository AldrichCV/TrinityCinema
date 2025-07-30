namespace TrinityCinema.Views.Staff
{
    partial class MonthYearPicker
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
            this.cbeMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.cbeYear = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbeMonth
            // 
            this.cbeMonth.Location = new System.Drawing.Point(26, 109);
            this.cbeMonth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbeMonth.Name = "cbeMonth";
            this.cbeMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeMonth.Size = new System.Drawing.Size(161, 34);
            this.cbeMonth.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 88);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Month";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(216, 88);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Year";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(116, 231);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 60);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbeYear
            // 
            this.cbeYear.Location = new System.Drawing.Point(216, 109);
            this.cbeYear.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbeYear.Name = "cbeYear";
            this.cbeYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeYear.Size = new System.Drawing.Size(114, 34);
            this.cbeYear.TabIndex = 5;
            // 
            // MonthYearPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 327);
            this.Controls.Add(this.cbeYear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbeMonth);
            this.Name = "MonthYearPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatePicker";
            ((System.ComponentModel.ISupportInitialize)(this.cbeMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbeMonth;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.ComboBoxEdit cbeYear;
    }
}