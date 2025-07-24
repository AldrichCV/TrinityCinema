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
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnCloseWindow = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUserName
            // 
            this.teUserName.EditValue = "";
            this.teUserName.Location = new System.Drawing.Point(72, 295);
            this.teUserName.Margin = new System.Windows.Forms.Padding(4);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Properties.NullValuePrompt = "Username";
            this.teUserName.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.teUserName.Size = new System.Drawing.Size(358, 46);
            this.teUserName.TabIndex = 0;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(72, 374);
            this.tePassword.Margin = new System.Windows.Forms.Padding(4);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Properties.NullValuePrompt = "Password";
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(358, 48);
            this.tePassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.AllowFocus = false;
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(96, 470);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(302, 55);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "SIGN IN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(493, 638);
            this.pictureEdit1.TabIndex = 3;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCloseWindow.Appearance.Options.UseFont = true;
            this.btnCloseWindow.Location = new System.Drawing.Point(449, 12);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(32, 28);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.Text = "X";
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 638);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUserName);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnCloseWindow;
    }
}