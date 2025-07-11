namespace TrinityCinema.Views.Admin
{
    partial class UsersControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersControl));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.UserID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.PersonnelImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Role = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Fullname = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.tvUserView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.userTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvUserView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.FieldName = "UserID";
            this.UserID.MinWidth = 27;
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 3;
            this.UserID.Width = 100;
            // 
            // PersonnelImage
            // 
            this.PersonnelImage.FieldName = "PersonnelImage";
            this.PersonnelImage.MinWidth = 27;
            this.PersonnelImage.Name = "PersonnelImage";
            this.PersonnelImage.Visible = true;
            this.PersonnelImage.VisibleIndex = 2;
            this.PersonnelImage.Width = 100;
            // 
            // Role
            // 
            this.Role.FieldName = "Role";
            this.Role.MinWidth = 27;
            this.Role.Name = "Role";
            this.Role.Visible = true;
            this.Role.VisibleIndex = 1;
            this.Role.Width = 100;
            // 
            // Fullname
            // 
            this.Fullname.FieldName = "Fullname";
            this.Fullname.MinWidth = 27;
            this.Fullname.Name = "Fullname";
            this.Fullname.Visible = true;
            this.Fullname.VisibleIndex = 0;
            this.Fullname.Width = 100;
            // 
            // gcUser
            // 
            this.gcUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcUser.BackgroundImage")));
            this.gcUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUser.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcUser.Location = new System.Drawing.Point(0, 0);
            this.gcUser.MainView = this.tvUserView;
            this.gcUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcUser.Name = "gcUser";
            this.gcUser.Size = new System.Drawing.Size(1151, 516);
            this.gcUser.TabIndex = 5;
            this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvUserView});
            // 
            // tvUserView
            // 
            this.tvUserView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fullname,
            this.Role,
            this.PersonnelImage,
            this.UserID});
            this.tvUserView.DetailHeight = 431;
            this.tvUserView.GridControl = this.gcUser;
            this.tvUserView.Name = "tvUserView";
            this.tvUserView.OptionsTiles.ItemSize = new System.Drawing.Size(306, 167);
            this.tvUserView.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 94D;
            tableColumnDefinition2.Length.Value = 58D;
            tableColumnDefinition3.Length.Value = 130D;
            this.tvUserView.TileColumns.Add(tableColumnDefinition1);
            this.tvUserView.TileColumns.Add(tableColumnDefinition2);
            this.tvUserView.TileColumns.Add(tableColumnDefinition3);
            this.tvUserView.TileRows.Add(tableRowDefinition1);
            this.tvUserView.TileRows.Add(tableRowDefinition2);
            this.tvUserView.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnSpan = 2;
            tableSpan1.RowSpan = 3;
            this.tvUserView.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Column = this.UserID;
            tileViewItemElement1.ColumnIndex = 2;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "UserID";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.PersonnelImage;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "PersonnelImage";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.Role;
            tileViewItemElement3.ColumnIndex = 2;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "Role";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.Fullname;
            tileViewItemElement4.ColumnIndex = 2;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "Fullname";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tvUserView.TileTemplate.Add(tileViewItemElement1);
            this.tvUserView.TileTemplate.Add(tileViewItemElement2);
            this.tvUserView.TileTemplate.Add(tileViewItemElement3);
            this.tvUserView.TileTemplate.Add(tileViewItemElement4);
            this.tvUserView.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvUserView_ItemClick);
            // 
            // actionTile
            // 
            this.actionTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Brown;
            this.actionTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.actionTile.BackColor = System.Drawing.Color.Brown;
            this.actionTile.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
            this.actionTile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.actionTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.actionTile.Groups.Add(this.tileBarGroup2);
            this.actionTile.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.actionTile.ItemPadding = new System.Windows.Forms.Padding(10);
            this.actionTile.ItemSize = 80;
            this.actionTile.Location = new System.Drawing.Point(0, 516);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 11;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.SelectionBorderWidth = 0;
            this.actionTile.ShowItemShadow = true;
            this.actionTile.Size = new System.Drawing.Size(1151, 138);
            this.actionTile.TabIndex = 4;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 200;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.userTile);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // userTile
            // 
            this.userTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.userTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.userTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.StretchHorizontal = true;
            tileItemElement1.StretchVertical = true;
            tileItemElement1.Text = "";
            this.userTile.Elements.Add(tileItemElement1);
            this.userTile.Id = 10;
            this.userTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.userTile.Name = "userTile";
            this.userTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.userTile_ItemClick);
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcUser);
            this.Controls.Add(this.actionTile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1151, 654);
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvUserView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcUser;
        public DevExpress.XtraGrid.Views.Tile.TileView tvUserView;
        private DevExpress.XtraGrid.Columns.TileViewColumn Fullname;
        private DevExpress.XtraGrid.Columns.TileViewColumn Role;
        private DevExpress.XtraGrid.Columns.TileViewColumn PersonnelImage;
        private DevExpress.XtraGrid.Columns.TileViewColumn UserID;
        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem userTile;
    }
}