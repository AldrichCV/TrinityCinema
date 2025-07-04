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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.personnelTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.movieTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.theaterTile = new DevExpress.XtraBars.Navigation.TileBarItem();
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
            this.actionTile.Size = new System.Drawing.Size(1213, 164);
            this.actionTile.TabIndex = 0;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 300;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.personnelTile);
            this.tileBarGroup2.Items.Add(this.movieTile);
            this.tileBarGroup2.Items.Add(this.theaterTile);
            this.tileBarGroup2.Items.Add(this.tileBarItem4);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // personnelTile
            // 
            this.personnelTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.personnelTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.personnelTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personnelTile.BackgroundImage")));
            this.personnelTile.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.personnelTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.personnelTile.Elements.Add(tileItemElement1);
            this.personnelTile.Id = 6;
            this.personnelTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.personnelTile.Name = "personnelTile";
            this.personnelTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.personnelTile_ItemClick);
            // 
            // movieTile
            // 
            this.movieTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.movieTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.movieTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movieTile.BackgroundImage")));
            this.movieTile.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.movieTile.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.movieTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.movieTile.Elements.Add(tileItemElement2);
            this.movieTile.Id = 7;
            this.movieTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.movieTile.Name = "movieTile";
            this.movieTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.movieTile_ItemClick);
            // 
            // theaterTile
            // 
            this.theaterTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.theaterTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.theaterTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theaterTile.BackgroundImage")));
            this.theaterTile.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.theaterTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.theaterTile.Elements.Add(tileItemElement3);
            this.theaterTile.Id = 8;
            this.theaterTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.theaterTile.Name = "theaterTile";
            this.theaterTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.theaterTile_ItemClick);
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.tileBarItem4.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileBarItem4.BackgroundImage")));
            this.tileBarItem4.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem4.Elements.Add(tileItemElement4);
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
            this.gcHome.Location = new System.Drawing.Point(0, 164);
            this.gcHome.Margin = new System.Windows.Forms.Padding(0);
            this.gcHome.Name = "gcHome";
            this.gcHome.ShowCaption = false;
            this.gcHome.Size = new System.Drawing.Size(1213, 606);
            this.gcHome.TabIndex = 1;
            this.gcHome.Text = "groupControl1";
            // 
            // AdminMainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 770);
            this.Controls.Add(this.gcHome);
            this.Controls.Add(this.actionTile);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "WXI";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private DevExpress.XtraBars.Navigation.TileBarItem theaterTile;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
        public DevExpress.XtraEditors.GroupControl gcHome;
    }
}