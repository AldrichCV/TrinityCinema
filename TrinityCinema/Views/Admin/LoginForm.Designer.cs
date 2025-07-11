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
            this.teUser = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUser
            // 
            this.teUser.Location = new System.Drawing.Point(70, 194);
            this.teUser.Margin = new System.Windows.Forms.Padding(4);
            this.teUser.Name = "teUser";
            this.teUser.Properties.AutoHeight = false;
            this.teUser.Size = new System.Drawing.Size(289, 68);
            this.teUser.TabIndex = 0;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(70, 298);
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
            this.btnLogin.Location = new System.Drawing.Point(70, 418);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(289, 79);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 638);
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teUser;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}