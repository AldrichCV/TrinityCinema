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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.homeTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.movieTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.theaterTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.showtimeTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.ticketTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarGroup3 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.reportsTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.logoutTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.gcHome = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcHome)).BeginInit();
            this.SuspendLayout();
            // 
            // actionTile
            // 
            this.actionTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Brown;
            this.actionTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.actionTile.BackColor = System.Drawing.Color.Brown;
            this.actionTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actionTile.BackgroundImage")));
            this.actionTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actionTile.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
            this.actionTile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.actionTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.actionTile.Groups.Add(this.tileBarGroup2);
            this.actionTile.Groups.Add(this.tileBarGroup3);
            this.actionTile.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.actionTile.ItemPadding = new System.Windows.Forms.Padding(10);
            this.actionTile.ItemSize = 50;
            this.actionTile.Location = new System.Drawing.Point(0, 0);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 18;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.Size = new System.Drawing.Size(1940, 111);
            this.actionTile.TabIndex = 2;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 200;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.homeTile);
            this.tileBarGroup2.Items.Add(this.movieTile);
            this.tileBarGroup2.Items.Add(this.theaterTile);
            this.tileBarGroup2.Items.Add(this.showtimeTile);
            this.tileBarGroup2.Items.Add(this.ticketTile);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // homeTile
            // 
            this.homeTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.homeTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.homeTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Home";
            this.homeTile.Elements.Add(tileItemElement1);
            this.homeTile.Id = 15;
            this.homeTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.homeTile.Name = "homeTile";
            // 
            // movieTile
            // 
            this.movieTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.movieTile.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.movieTile.AppearanceItem.Normal.Options.UseFont = true;
            this.movieTile.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.movieTile.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.movieTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "Movies";
            this.movieTile.Elements.Add(tileItemElement2);
            this.movieTile.Id = 7;
            this.movieTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.movieTile.Name = "movieTile";
            // 
            // theaterTile
            // 
            this.theaterTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.theaterTile.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.theaterTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.theaterTile.AppearanceItem.Normal.Options.UseFont = true;
            this.theaterTile.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.theaterTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Seats";
            this.theaterTile.Elements.Add(tileItemElement3);
            this.theaterTile.Id = 8;
            this.theaterTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.theaterTile.Name = "theaterTile";
            // 
            // showtimeTile
            // 
            this.showtimeTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.showtimeTile.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showtimeTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.showtimeTile.AppearanceItem.Normal.Options.UseFont = true;
            this.showtimeTile.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.showtimeTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "Showtime";
            this.showtimeTile.Elements.Add(tileItemElement4);
            this.showtimeTile.Id = 9;
            this.showtimeTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.showtimeTile.Name = "showtimeTile";
            // 
            // ticketTile
            // 
            this.ticketTile.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.ticketTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "Ticket";
            this.ticketTile.Elements.Add(tileItemElement5);
            this.ticketTile.Id = 16;
            this.ticketTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.ticketTile.Name = "ticketTile";
            this.ticketTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ticketTile_ItemClick);
            // 
            // tileBarGroup3
            // 
            this.tileBarGroup3.Items.Add(this.reportsTile);
            this.tileBarGroup3.Items.Add(this.logoutTile);
            this.tileBarGroup3.Name = "tileBarGroup3";
            // 
            // reportsTile
            // 
            this.reportsTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.reportsTile.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Maroon;
            this.reportsTile.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reportsTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.reportsTile.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.reportsTile.AppearanceItem.Normal.Options.UseFont = true;
            this.reportsTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Text = "Reports";
            this.reportsTile.Elements.Add(tileItemElement6);
            this.reportsTile.Id = 11;
            this.reportsTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.reportsTile.Name = "reportsTile";
            this.reportsTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.reportsTile_ItemClick);
            // 
            // logoutTile
            // 
            this.logoutTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.logoutTile.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Maroon;
            this.logoutTile.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoutTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.logoutTile.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.logoutTile.AppearanceItem.Normal.Options.UseFont = true;
            this.logoutTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.Text = "Logout";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.logoutTile.Elements.Add(tileItemElement7);
            this.logoutTile.Id = 14;
            this.logoutTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.logoutTile.Name = "logoutTile";
            // 
            // gcHome
            // 
            this.gcHome.Appearance.BackColor = System.Drawing.Color.White;
            this.gcHome.Appearance.Options.UseBackColor = true;
            this.gcHome.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHome.Location = new System.Drawing.Point(0, 0);
            this.gcHome.Margin = new System.Windows.Forms.Padding(0);
            this.gcHome.Name = "gcHome";
            this.gcHome.ShowCaption = false;
            this.gcHome.Size = new System.Drawing.Size(1940, 829);
            this.gcHome.TabIndex = 3;
            // 
            // StaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 829);
            this.Controls.Add(this.actionTile);
            this.Controls.Add(this.gcHome);
            this.Name = "StaffMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.gcHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem homeTile;
        private DevExpress.XtraBars.Navigation.TileBarItem movieTile;
        private DevExpress.XtraBars.Navigation.TileBarItem theaterTile;
        private DevExpress.XtraBars.Navigation.TileBarItem showtimeTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup3;
        private DevExpress.XtraBars.Navigation.TileBarItem reportsTile;
        private DevExpress.XtraBars.Navigation.TileBarItem logoutTile;
        public DevExpress.XtraEditors.GroupControl gcHome;
        private DevExpress.XtraBars.Navigation.TileBarItem ticketTile;
    }
}