namespace TrinityCinema.Views.Staff
{
    partial class StaffMainForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.gcHome = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.NewTransaction = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcHome)).BeginInit();
            this.gcHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcHome
            // 
            this.gcHome.Appearance.BackColor = System.Drawing.Color.White;
            this.gcHome.Appearance.Options.UseBackColor = true;
            this.gcHome.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcHome.Controls.Add(this.groupControl2);
            this.gcHome.Controls.Add(this.groupControl1);
            this.gcHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHome.Location = new System.Drawing.Point(0, 0);
            this.gcHome.Margin = new System.Windows.Forms.Padding(0);
            this.gcHome.Name = "gcHome";
            this.gcHome.ShowCaption = false;
            this.gcHome.Size = new System.Drawing.Size(1940, 829);
            this.gcHome.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1357, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(583, 829);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tileControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1357, 829);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(2, 36);
            this.tileControl1.MaxId = 7;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1353, 791);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.NewTransaction);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem4);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // NewTransaction
            // 
            tileItemElement1.Text = "New Transaction";
            this.NewTransaction.Elements.Add(tileItemElement1);
            this.NewTransaction.Id = 3;
            this.NewTransaction.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.NewTransaction.Name = "NewTransaction";
            this.NewTransaction.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.NewTransaction_ItemClick);
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "tileItem2";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 4;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            tileItemElement3.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 5;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            tileItemElement4.Text = "tileItem4";
            this.tileItem4.Elements.Add(tileItemElement4);
            this.tileItem4.Id = 6;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(583, 829);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // StaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 829);
            this.Controls.Add(this.gcHome);
            this.Name = "StaffMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcHome)).EndInit();
            this.gcHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.GroupControl gcHome;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem NewTransaction;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}