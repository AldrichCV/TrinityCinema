namespace TrinityCinema.Views.Staff
{
    partial class WeekPicker
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
            this.deStartDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deEndDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // deStartDate
            // 
            this.deStartDate.EditValue = null;
            this.deStartDate.Location = new System.Drawing.Point(26, 92);
            this.deStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Size = new System.Drawing.Size(173, 34);
            this.deStartDate.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(121, 244);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 60);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 74);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Start Date";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(220, 74);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "End Date";
            // 
            // deEndDate
            // 
            this.deEndDate.EditValue = null;
            this.deEndDate.Location = new System.Drawing.Point(220, 92);
            this.deEndDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Size = new System.Drawing.Size(173, 34);
            this.deEndDate.TabIndex = 8;
            // 
            // WeekPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 321);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deEndDate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.deStartDate);
            this.Name = "WeekPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeekPicker";
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deStartDate;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deEndDate;
    }
}