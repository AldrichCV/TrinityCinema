namespace TrinityCinema.Views.Admin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.teUser = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUser
            // 
            this.teUser.EditValue = "";
            this.teUser.Location = new System.Drawing.Point(70, 221);
            this.teUser.Margin = new System.Windows.Forms.Padding(4);
            this.teUser.Name = "teUser";
            this.teUser.Properties.AutoHeight = false;
            this.teUser.Size = new System.Drawing.Size(289, 68);
            this.teUser.TabIndex = 0;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(70, 320);
            this.tePassword.Margin = new System.Windows.Forms.Padding(4);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(289, 68);
            this.tePassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.AllowFocus = false;
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.Location = new System.Drawing.Point(101, 420);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(236, 47);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "SIGN IN";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(182, 164);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 22);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "LOGIN";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(158, 30);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseBorderColor = true;
            this.pictureEdit1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.pictureEdit1.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.pictureEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.pictureEdit1.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.pictureEdit1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.pictureEdit1.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomPercent = 20D;
            this.pictureEdit1.Size = new System.Drawing.Size(129, 116);
            this.pictureEdit1.TabIndex = 17;
            // 
            // LoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 638);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUser);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teUser;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        public DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}