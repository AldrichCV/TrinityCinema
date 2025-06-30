namespace TrinityCinema.Views.Admin
{
    partial class SeatLayout
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
            this.panelSeats = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSeats
            // 
            this.panelSeats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeats.Location = new System.Drawing.Point(0, 0);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Padding = new System.Windows.Forms.Padding(50);
            this.panelSeats.Size = new System.Drawing.Size(772, 521);
            this.panelSeats.TabIndex = 0;
            // 
            // SeatLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSeats);
            this.Name = "SeatLayout";
            this.Size = new System.Drawing.Size(772, 521);
            ((System.ComponentModel.ISupportInitialize)(this.panelSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelSeats;
    }
}
