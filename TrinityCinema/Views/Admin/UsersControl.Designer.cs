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
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.UserID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.PersonnelImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Fullname = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Role = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Status = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.tvUserView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.userTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.headerControl = new DevExpress.XtraEditors.GroupControl();
            this.headerLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.teSearch = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Search = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvUserView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerControl)).BeginInit();
            this.headerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLayoutControl)).BeginInit();
            this.headerLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            // Fullname
            // 
            this.Fullname.FieldName = "Fullname";
            this.Fullname.MinWidth = 27;
            this.Fullname.Name = "Fullname";
            this.Fullname.Visible = true;
            this.Fullname.VisibleIndex = 0;
            this.Fullname.Width = 100;
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
            // Status
            // 
            this.Status.FieldName = "IsLockedDisplay";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 4;
            this.Status.Width = 94;
            // 
            // gcUser
            // 
            this.gcUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcUser.BackgroundImage")));
            this.gcUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUser.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcUser.Location = new System.Drawing.Point(0, 76);
            this.gcUser.MainView = this.tvUserView;
            this.gcUser.Margin = new System.Windows.Forms.Padding(4);
            this.gcUser.Name = "gcUser";
            this.gcUser.Size = new System.Drawing.Size(1151, 494);
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
            this.UserID,
            this.Status});
            this.tvUserView.DetailHeight = 431;
            this.tvUserView.GridControl = this.gcUser;
            this.tvUserView.Name = "tvUserView";
            this.tvUserView.OptionsTiles.ItemSize = new System.Drawing.Size(324, 491);
            this.tvUserView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tvUserView.OptionsTiles.RowCount = 0;
            this.tvUserView.TileColumns.Add(tableColumnDefinition1);
            this.tvUserView.TileColumns.Add(tableColumnDefinition2);
            this.tvUserView.TileColumns.Add(tableColumnDefinition3);
            this.tvUserView.TileRows.Add(tableRowDefinition1);
            this.tvUserView.TileRows.Add(tableRowDefinition2);
            this.tvUserView.TileRows.Add(tableRowDefinition3);
            this.tvUserView.TileRows.Add(tableRowDefinition4);
            this.tvUserView.TileRows.Add(tableRowDefinition5);
            tableSpan1.ColumnSpan = 3;
            tableSpan1.RowSpan = 3;
            tableSpan2.ColumnSpan = 3;
            tableSpan2.RowIndex = 3;
            tableSpan3.ColumnSpan = 3;
            tableSpan3.RowIndex = 4;
            this.tvUserView.TileSpans.Add(tableSpan1);
            this.tvUserView.TileSpans.Add(tableSpan2);
            this.tvUserView.TileSpans.Add(tableSpan3);
            tileViewItemElement1.Column = this.UserID;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "UserID";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.TextVisible = false;
            tileViewItemElement2.Column = this.PersonnelImage;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "PersonnelImage";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Column = this.Fullname;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 3;
            tileViewItemElement3.Text = "Fullname";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.Column = this.Role;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 4;
            tileViewItemElement4.Text = "Role";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.Column = this.Status;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.RowIndex = 4;
            tileViewItemElement5.Text = "Status";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tvUserView.TileTemplate.Add(tileViewItemElement1);
            this.tvUserView.TileTemplate.Add(tileViewItemElement2);
            this.tvUserView.TileTemplate.Add(tileViewItemElement3);
            this.tvUserView.TileTemplate.Add(tileViewItemElement4);
            this.tvUserView.TileTemplate.Add(tileViewItemElement5);
            this.tvUserView.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvUserView_ItemClick);
            // 
            // actionTile
            // 
            this.actionTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Brown;
            this.actionTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.actionTile.BackColor = System.Drawing.Color.Maroon;
            this.actionTile.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
            this.actionTile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.actionTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.actionTile.Groups.Add(this.tileBarGroup2);
            this.actionTile.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.actionTile.ItemPadding = new System.Windows.Forms.Padding(10);
            this.actionTile.ItemSize = 50;
            this.actionTile.Location = new System.Drawing.Point(0, 570);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 11;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.SelectionBorderWidth = 0;
            this.actionTile.ShowItemShadow = true;
            this.actionTile.Size = new System.Drawing.Size(1151, 84);
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
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Add User";
            this.userTile.Elements.Add(tileItemElement1);
            this.userTile.Id = 10;
            this.userTile.Name = "userTile";
            this.userTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.userTile_ItemClick);
            // 
            // headerControl
            // 
            this.headerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.headerControl.Controls.Add(this.headerLayoutControl);
            this.headerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.ShowCaption = false;
            this.headerControl.Size = new System.Drawing.Size(1151, 76);
            this.headerControl.TabIndex = 6;
            this.headerControl.Text = "groupControl1";
            // 
            // headerLayoutControl
            // 
            this.headerLayoutControl.BackColor = System.Drawing.Color.Maroon;
            this.headerLayoutControl.Controls.Add(this.btnFind);
            this.headerLayoutControl.Controls.Add(this.teSearch);
            this.headerLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.headerLayoutControl.Name = "headerLayoutControl";
            this.headerLayoutControl.Root = this.Root;
            this.headerLayoutControl.Size = new System.Drawing.Size(1151, 76);
            this.headerLayoutControl.TabIndex = 0;
            this.headerLayoutControl.Text = "layoutControl1";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(577, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 44);
            this.btnFind.StyleController = this.headerLayoutControl;
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "FIND";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // teSearch
            // 
            this.teSearch.EditValue = "";
            this.teSearch.Location = new System.Drawing.Point(16, 16);
            this.teSearch.Name = "teSearch";
            this.teSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teSearch.Properties.Appearance.Options.UseFont = true;
            this.teSearch.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkGray;
            this.teSearch.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.teSearch.Properties.AutoHeight = false;
            this.teSearch.Properties.NullText = "SEARCH";
            this.teSearch.Properties.NullValuePrompt = "SEARCH";
            this.teSearch.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.teSearch.Size = new System.Drawing.Size(555, 44);
            this.teSearch.StyleController = this.headerLayoutControl;
            this.teSearch.TabIndex = 4;
            this.teSearch.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teSearch_EditValueChanging);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Search,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1151, 76);
            this.Root.TextVisible = false;
            // 
            // Search
            // 
            this.Search.Control = this.teSearch;
            this.Search.Location = new System.Drawing.Point(0, 0);
            this.Search.MinSize = new System.Drawing.Size(68, 40);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(561, 50);
            this.Search.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Search.TextLocation = DevExpress.Utils.Locations.Top;
            this.Search.TextSize = new System.Drawing.Size(0, 0);
            this.Search.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(658, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(467, 50);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnFind;
            this.layoutControlItem1.Location = new System.Drawing.Point(561, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(42, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AppearanceItem.BackColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.OptionsPrint.AppearanceItem.Options.UseBackColor = true;
            this.layoutControlItem1.Size = new System.Drawing.Size(97, 50);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcUser);
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.actionTile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1151, 654);
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvUserView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerControl)).EndInit();
            this.headerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerLayoutControl)).EndInit();
            this.headerLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl headerControl;
        private DevExpress.XtraLayout.LayoutControl headerLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit teSearch;
        private DevExpress.XtraLayout.LayoutControlItem Search;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.TileViewColumn Status;
    }
}