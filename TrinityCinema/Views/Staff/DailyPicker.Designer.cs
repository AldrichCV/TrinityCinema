namespace TrinityCinema.Views.Staff
{
    partial class DailyPicker
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
            this.deDailyDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deDailyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDailyDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // deDailyDate
            // 
            this.deDailyDate.EditValue = null;
            this.deDailyDate.Location = new System.Drawing.Point(41, 94);
            this.deDailyDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deDailyDate.Name = "deDailyDate";
            this.deDailyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDailyDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDailyDate.Size = new System.Drawing.Size(216, 34);
            this.deDailyDate.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 74);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Select Date";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(65, 179);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 60);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DailyPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 258);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.deDailyDate);
            this.Name = "DailyPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyPicker";
            ((System.ComponentModel.ISupportInitialize)(this.deDailyDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDailyDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deDailyDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
    }
}