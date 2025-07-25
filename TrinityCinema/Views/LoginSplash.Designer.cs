namespace TrinityCinema.Views
{
    partial class LoginSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSplash));
            this.loadPicture = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPicture
            // 
            this.loadPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPicture.EditValue = ((object)(resources.GetObject("loadPicture.EditValue")));
            this.loadPicture.Location = new System.Drawing.Point(0, 0);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loadPicture.Properties.Appearance.Options.UseBackColor = true;
            this.loadPicture.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.loadPicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.loadPicture.Size = new System.Drawing.Size(960, 594);
            this.loadPicture.TabIndex = 0;
            // 
            // LoginSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 594);
            this.Controls.Add(this.loadPicture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginSplash";
            this.Text = "LoginSplash";
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit loadPicture;
    }
}
