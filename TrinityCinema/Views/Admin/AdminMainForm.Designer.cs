namespace TrinityCinema.Views.Admin
{
    partial class AdminMainForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement25 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement26 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement27 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement28 = new DevExpress.XtraEditors.TileItemElement();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.personnelTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.movieTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.gcHome = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcHome)).BeginInit();
            this.SuspendLayout();
            // 
            // actionTile
            // 
            this.actionTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Brown;
            this.actionTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.actionTile.BackColor = System.Drawing.Color.Brown;
            this.actionTile.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
            this.actionTile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.actionTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.actionTile.Groups.Add(this.tileBarGroup2);
            this.actionTile.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.actionTile.ItemPadding = new System.Windows.Forms.Padding(10);
            this.actionTile.ItemSize = 100;
            this.actionTile.Location = new System.Drawing.Point(0, 0);
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 10;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.Size = new System.Drawing.Size(1040, 133);
            this.actionTile.TabIndex = 0;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 300;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.personnelTile);
            this.tileBarGroup2.Items.Add(this.movieTile);
            this.tileBarGroup2.Items.Add(this.tileBarItem3);
            this.tileBarGroup2.Items.Add(this.tileBarItem4);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // personnelTile
            // 
            this.personnelTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.personnelTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.personnelTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement25.Text = "tileBarItem1";
            this.personnelTile.Elements.Add(tileItemElement25);
            this.personnelTile.Id = 6;
            this.personnelTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.personnelTile.Name = "personnelTile";
            this.personnelTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.personnelTile_ItemClick);
            // 
            // movieTile
            // 
            this.movieTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.movieTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.movieTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement26.Text = "tileBarItem2";
            this.movieTile.Elements.Add(tileItemElement26);
            this.movieTile.Id = 7;
            this.movieTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.movieTile.Name = "movieTile";
            this.movieTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.movieTile_ItemClick);
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.tileBarItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement27.Text = "tileBarItem3";
            this.tileBarItem3.Elements.Add(tileItemElement27);
            this.tileBarItem3.Id = 8;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.tileBarItem4.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement28.Text = "tileBarItem4";
            this.tileBarItem4.Elements.Add(tileItemElement28);
            this.tileBarItem4.Id = 9;
            this.tileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem4.Name = "tileBarItem4";
            // 
            // gcHome
            // 
            this.gcHome.Appearance.BackColor = System.Drawing.Color.Brown;
            this.gcHome.Appearance.Options.UseBackColor = true;
            this.gcHome.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHome.Location = new System.Drawing.Point(0, 133);
            this.gcHome.Margin = new System.Windows.Forms.Padding(0);
            this.gcHome.Name = "gcHome";
            this.gcHome.ShowCaption = false;
            this.gcHome.Size = new System.Drawing.Size(1040, 493);
            this.gcHome.TabIndex = 1;
            this.gcHome.Text = "groupControl1";
            // 
            // AdminMainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 626);
            this.Controls.Add(this.gcHome);
            this.Controls.Add(this.actionTile);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "WXI";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "AdminMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem personnelTile;
        private DevExpress.XtraBars.Navigation.TileBarItem movieTile;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem3;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
        public DevExpress.XtraEditors.GroupControl gcHome;
    }
}