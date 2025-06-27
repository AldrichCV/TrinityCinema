namespace TrinityCinema.Views.Admin
{
    partial class PersonnelControl
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelControl));
            this.AccountID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.PersonnelImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Role = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPersonnel = new DevExpress.XtraGrid.GridControl();
            this.tvPersonnelView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.newAccountTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPersonnelView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountID
            // 
            this.AccountID.FieldName = "AccountID";
            this.AccountID.Name = "AccountID";
            this.AccountID.OptionsColumn.AllowFocus = false;
            this.AccountID.Visible = true;
            this.AccountID.VisibleIndex = 0;
            // 
            // PersonnelImage
            // 
            this.PersonnelImage.FieldName = "PersonnelImage";
            this.PersonnelImage.Name = "PersonnelImage";
            this.PersonnelImage.OptionsColumn.AllowFocus = false;
            this.PersonnelImage.Visible = true;
            this.PersonnelImage.VisibleIndex = 1;
            // 
            // FullName
            // 
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 2;
            // 
            // Role
            // 
            this.Role.FieldName = "Role";
            this.Role.Name = "Role";
            this.Role.Visible = true;
            this.Role.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcPersonnel);
            this.groupControl1.Controls.Add(this.actionTile);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "WXI";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(834, 551);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gcPersonnel
            // 
            this.gcPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPersonnel.Location = new System.Drawing.Point(2, 2);
            this.gcPersonnel.MainView = this.tvPersonnelView;
            this.gcPersonnel.Name = "gcPersonnel";
            this.gcPersonnel.Size = new System.Drawing.Size(830, 435);
            this.gcPersonnel.TabIndex = 2;
            this.gcPersonnel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvPersonnelView});
            // 
            // tvPersonnelView
            // 
            this.tvPersonnelView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AccountID,
            this.PersonnelImage,
            this.FullName,
            this.Role});
            this.tvPersonnelView.GridControl = this.gcPersonnel;
            this.tvPersonnelView.Name = "tvPersonnelView";
            this.tvPersonnelView.OptionsTiles.ItemSize = new System.Drawing.Size(306, 147);
            this.tvPersonnelView.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 125D;
            tableColumnDefinition2.Length.Value = 131D;
            this.tvPersonnelView.TileColumns.Add(tableColumnDefinition1);
            this.tvPersonnelView.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 32D;
            tableRowDefinition2.Length.Value = 68D;
            tableRowDefinition3.Length.Value = 31D;
            this.tvPersonnelView.TileRows.Add(tableRowDefinition1);
            this.tvPersonnelView.TileRows.Add(tableRowDefinition2);
            this.tvPersonnelView.TileRows.Add(tableRowDefinition3);
            tableSpan1.RowSpan = 3;
            tableSpan2.ColumnIndex = 1;
            tableSpan2.RowSpan = 3;
            this.tvPersonnelView.TileSpans.Add(tableSpan1);
            this.tvPersonnelView.TileSpans.Add(tableSpan2);
            tileViewItemElement1.Column = this.AccountID;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "AccountID";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileViewItemElement2.Column = this.PersonnelImage;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileViewItemElement2.Text = "PersonnelImage";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.FullName;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "FullName";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.Role;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 2;
            tileViewItemElement4.Text = "Role";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileViewItemElement4.TextLocation = new System.Drawing.Point(0, -35);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement1);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement2);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement3);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement4);
            this.tvPersonnelView.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvPersonnelView_ItemClick);
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
            this.actionTile.Location = new System.Drawing.Point(2, 437);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 11;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.SelectionBorderWidth = 0;
            this.actionTile.ShowItemShadow = true;
            this.actionTile.Size = new System.Drawing.Size(830, 112);
            this.actionTile.TabIndex = 1;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 200;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.newAccountTile);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // newAccountTile
            // 
            this.newAccountTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.newAccountTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.newAccountTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.StretchHorizontal = true;
            tileItemElement1.StretchVertical = true;
            tileItemElement1.Text = "";
            this.newAccountTile.Elements.Add(tileItemElement1);
            this.newAccountTile.Id = 10;
            this.newAccountTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.newAccountTile.Name = "newAccountTile";
            this.newAccountTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.newAccountTile_ItemClick_1);
            // 
            // PersonnelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "WXI";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PersonnelControl";
            this.Size = new System.Drawing.Size(834, 551);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPersonnelView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem newAccountTile;
        public DevExpress.XtraGrid.GridControl gcPersonnel;
        private DevExpress.XtraGrid.Columns.TileViewColumn AccountID;
        private DevExpress.XtraGrid.Columns.TileViewColumn PersonnelImage;
        private DevExpress.XtraGrid.Columns.TileViewColumn FullName;
        public DevExpress.XtraGrid.Views.Tile.TileView tvPersonnelView;
        private DevExpress.XtraGrid.Columns.TileViewColumn Role;
    }
}
