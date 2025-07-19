namespace TrinityCinema.Views.Admin
{
    partial class SeatManagement
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
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // svgImageBox2
            // 
            this.svgImageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svgImageBox2.ItemAppearance.Hovered.BorderColor = System.Drawing.Color.Red;
            this.svgImageBox2.ItemAppearance.Hovered.FillColor = System.Drawing.Color.Red;
            this.svgImageBox2.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.svgImageBox2.Location = new System.Drawing.Point(0, 0);
            this.svgImageBox2.LookAndFeel.SkinName = "WXI";
            this.svgImageBox2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.svgImageBox2.Name = "svgImageBox2";
            this.svgImageBox2.Size = new System.Drawing.Size(1175, 802);
            this.svgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox2.TabIndex = 5;
            this.svgImageBox2.Text = "svgImageBox2";
            this.svgImageBox2.ItemClick += new DevExpress.XtraEditors.SvgImageItemMouseEventHandler(this.svgImageBox2_ItemClick);
            // 
            // SeatManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 802);
            this.Controls.Add(this.svgImageBox2);
            this.Name = "SeatManagement";
            this.Text = "SeatManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
    }
}