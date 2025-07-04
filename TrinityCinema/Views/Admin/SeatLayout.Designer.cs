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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcSeats = new DevExpress.XtraGrid.GridControl();
            this.gvSeatView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SeatID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSeatView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSeats
            // 
            this.panelSeats.AutoSize = true;
            this.panelSeats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeats.Location = new System.Drawing.Point(22, 56);
            this.panelSeats.Margin = new System.Windows.Forms.Padding(4);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(838, 657);
            this.panelSeats.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.gcSeats);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(882, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(531, 735);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // gcSeats
            // 
            this.gcSeats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSeats.Location = new System.Drawing.Point(0, 0);
            this.gcSeats.MainView = this.gvSeatView;
            this.gcSeats.Name = "gcSeats";
            this.gcSeats.Size = new System.Drawing.Size(531, 735);
            this.gcSeats.TabIndex = 0;
            this.gcSeats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSeatView});
            // 
            // gvSeatView
            // 
            this.gvSeatView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SeatID,
            this.Status,
            this.Price});
            this.gvSeatView.GridControl = this.gcSeats;
            this.gvSeatView.Name = "gvSeatView";
            this.gvSeatView.OptionsView.ShowGroupPanel = false;
            // 
            // SeatID
            // 
            this.SeatID.FieldName = "SeatID";
            this.SeatID.MinWidth = 25;
            this.SeatID.Name = "SeatID";
            this.SeatID.Visible = true;
            this.SeatID.VisibleIndex = 0;
            this.SeatID.Width = 94;
            // 
            // Status
            // 
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 1;
            this.Status.Width = 94;
            // 
            // Price
            // 
            this.Price.FieldName = "Pricing";
            this.Price.MinWidth = 25;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelSeats);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(20);
            this.groupControl2.Size = new System.Drawing.Size(882, 735);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // SeatLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeatLayout";
            this.Size = new System.Drawing.Size(1413, 735);
            ((System.ComponentModel.ISupportInitialize)(this.panelSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSeatView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelSeats;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcSeats;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSeatView;
        private DevExpress.XtraGrid.Columns.GridColumn SeatID;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}
