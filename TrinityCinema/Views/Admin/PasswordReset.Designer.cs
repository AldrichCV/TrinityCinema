namespace TrinityCinema.Views.Admin
{
    partial class PasswordReset
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.teNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.newPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.teConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.confirmPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teUser = new DevExpress.XtraEditors.TextEdit();
            this.userName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userName)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teNewPassword);
            this.layoutControl1.Controls.Add(this.teConfirmPassword);
            this.layoutControl1.Controls.Add(this.btnSubmit);
            this.layoutControl1.Controls.Add(this.teUser);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(423, 307);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.newPassword,
            this.confirmPassword,
            this.layoutControlItem3,
            this.userName});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(423, 307);
            this.Root.TextVisible = false;
            // 
            // teNewPassword
            // 
            this.teNewPassword.Location = new System.Drawing.Point(16, 78);
            this.teNewPassword.Name = "teNewPassword";
            this.teNewPassword.Properties.UseSystemPasswordChar = true;
            this.teNewPassword.Size = new System.Drawing.Size(391, 34);
            this.teNewPassword.StyleController = this.layoutControl1;
            this.teNewPassword.TabIndex = 4;
            // 
            // newPassword
            // 
            this.newPassword.Control = this.teNewPassword;
            this.newPassword.Location = new System.Drawing.Point(0, 40);
            this.newPassword.MinSize = new System.Drawing.Size(110, 62);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(397, 62);
            this.newPassword.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.newPassword.Text = "New Password";
            this.newPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.newPassword.TextSize = new System.Drawing.Size(104, 16);
            // 
            // teConfirmPassword
            // 
            this.teConfirmPassword.Location = new System.Drawing.Point(16, 140);
            this.teConfirmPassword.Name = "teConfirmPassword";
            this.teConfirmPassword.Properties.UseSystemPasswordChar = true;
            this.teConfirmPassword.Size = new System.Drawing.Size(391, 34);
            this.teConfirmPassword.StyleController = this.layoutControl1;
            this.teConfirmPassword.TabIndex = 5;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Control = this.teConfirmPassword;
            this.confirmPassword.Location = new System.Drawing.Point(0, 102);
            this.confirmPassword.MinSize = new System.Drawing.Size(110, 62);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(397, 139);
            this.confirmPassword.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.confirmPassword.Text = "Confirm Password";
            this.confirmPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.confirmPassword.TextSize = new System.Drawing.Size(104, 16);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 257);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(391, 34);
            this.btnSubmit.StyleController = this.layoutControl1;
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Save changes";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSubmit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 241);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(397, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // teUser
            // 
            this.teUser.Location = new System.Drawing.Point(16, 16);
            this.teUser.Name = "teUser";
            this.teUser.Size = new System.Drawing.Size(391, 34);
            this.teUser.StyleController = this.layoutControl1;
            this.teUser.TabIndex = 7;
            // 
            // userName
            // 
            this.userName.Control = this.teUser;
            this.userName.Location = new System.Drawing.Point(0, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(397, 40);
            this.userName.TextSize = new System.Drawing.Size(0, 0);
            this.userName.TextVisible = false;
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 307);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PasswordReset";
            this.Text = "PasswordReset";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit teNewPassword;
        private DevExpress.XtraEditors.TextEdit teConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.TextEdit teUser;
        private DevExpress.XtraLayout.LayoutControlItem newPassword;
        private DevExpress.XtraLayout.LayoutControlItem confirmPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem userName;
    }
}