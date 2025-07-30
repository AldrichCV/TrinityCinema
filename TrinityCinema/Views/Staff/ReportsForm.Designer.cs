namespace TrinityCinema.Views.Staff
{
    partial class ReportsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAllRecord = new DevExpress.XtraEditors.SimpleButton();
            this.btnDailyReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnWeeklyReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnMonthlyReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnnualReport = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnAllRecord
            // 
            this.btnAllRecord.Location = new System.Drawing.Point(85, 76);
            this.btnAllRecord.Name = "btnAllRecord";
            this.btnAllRecord.Size = new System.Drawing.Size(176, 214);
            this.btnAllRecord.TabIndex = 0;
            this.btnAllRecord.Text = "All Record";
            this.btnAllRecord.Click += new System.EventHandler(this.btnAllRecord_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(366, 76);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(176, 214);
            this.btnDailyReport.TabIndex = 1;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(653, 76);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(176, 214);
            this.btnWeeklyReport.TabIndex = 2;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(932, 76);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(176, 214);
            this.btnMonthlyReport.TabIndex = 3;
            this.btnMonthlyReport.Text = "Monthly Report";
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnAnnualReport
            // 
            this.btnAnnualReport.Location = new System.Drawing.Point(1198, 76);
            this.btnAnnualReport.Name = "btnAnnualReport";
            this.btnAnnualReport.Size = new System.Drawing.Size(176, 214);
            this.btnAnnualReport.TabIndex = 4;
            this.btnAnnualReport.Text = "Annual Report";
            this.btnAnnualReport.Click += new System.EventHandler(this.btnAnnualReport_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnnualReport);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnWeeklyReport);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.btnAllRecord);
            this.Name = "ReportsForm";
            this.Size = new System.Drawing.Size(1447, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAllRecord;
        private DevExpress.XtraEditors.SimpleButton btnDailyReport;
        private DevExpress.XtraEditors.SimpleButton btnWeeklyReport;
        private DevExpress.XtraEditors.SimpleButton btnMonthlyReport;
        private DevExpress.XtraEditors.SimpleButton btnAnnualReport;
    }
}
