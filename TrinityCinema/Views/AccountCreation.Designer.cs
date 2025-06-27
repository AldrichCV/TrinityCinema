namespace TrinityCinema.Views
{
    partial class AccountCreation
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
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teSuffix = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.cbRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSuffix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(29, 111);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Size = new System.Drawing.Size(181, 41);
            this.teFirstName.TabIndex = 0;
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(29, 314);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Size = new System.Drawing.Size(181, 41);
            this.teUserName.TabIndex = 2;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(29, 376);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Size = new System.Drawing.Size(181, 41);
            this.tePassword.TabIndex = 3;
            // 
            // teSuffix
            // 
            this.teSuffix.Location = new System.Drawing.Point(29, 243);
            this.teSuffix.Name = "teSuffix";
            this.teSuffix.Properties.AutoHeight = false;
            this.teSuffix.Size = new System.Drawing.Size(181, 41);
            this.teSuffix.TabIndex = 5;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(29, 177);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Size = new System.Drawing.Size(181, 41);
            this.teLastName.TabIndex = 6;
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(216, 111);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Size = new System.Drawing.Size(181, 41);
            this.teMiddleName.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(216, 376);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 41);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbRole
            // 
            this.cbRole.Location = new System.Drawing.Point(216, 177);
            this.cbRole.Name = "cbRole";
            this.cbRole.Properties.AutoHeight = false;
            this.cbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRole.Properties.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
            this.cbRole.Size = new System.Drawing.Size(181, 41);
            this.cbRole.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(216, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Middle Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Last Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(216, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "First Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 224);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Suffix";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(29, 357);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Password";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(29, 295);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Username";
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 452);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.teMiddleName);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teSuffix);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUserName);
            this.Controls.Add(this.teFirstName);
            this.Controls.Add(this.cbRole);
            this.Name = "AccountCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountCreation";
            this.Load += new System.EventHandler(this.AccountCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSuffix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teSuffix;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.ComboBoxEdit cbRole;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}