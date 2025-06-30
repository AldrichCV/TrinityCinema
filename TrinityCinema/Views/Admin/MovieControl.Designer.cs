namespace TrinityCinema.Views.Admin
{
    partial class MovieControl
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieControl));
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.newAccountTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.gcPersonnel = new DevExpress.XtraGrid.GridControl();
            this.tvPersonnelView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.PersonnelImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Role = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPersonnelView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcPersonnel);
            this.groupControl1.Controls.Add(this.actionTile);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(829, 552);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
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
            this.actionTile.Location = new System.Drawing.Point(2, 438);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 11;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.SelectionBorderWidth = 0;
            this.actionTile.ShowItemShadow = true;
            this.actionTile.Size = new System.Drawing.Size(825, 112);
            this.actionTile.TabIndex = 2;
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
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement2.StretchHorizontal = true;
            tileItemElement2.StretchVertical = true;
            tileItemElement2.Text = "";
            this.newAccountTile.Elements.Add(tileItemElement2);
            this.newAccountTile.Id = 10;
            this.newAccountTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.newAccountTile.Name = "newAccountTile";
            // 
            // gcPersonnel
            // 
            this.gcPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPersonnel.Location = new System.Drawing.Point(2, 2);
            this.gcPersonnel.MainView = this.tvPersonnelView;
            this.gcPersonnel.Name = "gcPersonnel";
            this.gcPersonnel.Size = new System.Drawing.Size(825, 436);
            this.gcPersonnel.TabIndex = 3;
            this.gcPersonnel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvPersonnelView});
            // 
            // tvPersonnelView
            // 
            this.tvPersonnelView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PersonnelImage,
            this.FullName,
            this.Role,
            this.UserID});
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
            tileViewItemElement1.Column = this.PersonnelImage;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileViewItemElement1.Text = "PersonnelImage";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.FullName;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "FullName";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.Role;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "Role";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileViewItemElement3.TextLocation = new System.Drawing.Point(0, -35);
            tileViewItemElement4.Column = this.UserID;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.Text = "UserID";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement1);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement2);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement3);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement4);
            // 
            // PersonnelImage
            // 
            this.PersonnelImage.FieldName = "PersonnelImage";
            this.PersonnelImage.Name = "PersonnelImage";
            this.PersonnelImage.OptionsColumn.AllowFocus = false;
            this.PersonnelImage.Visible = true;
            this.PersonnelImage.VisibleIndex = 0;
            // 
            // FullName
            // 
            this.FullName.FieldName = "Fullname";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            // 
            // Role
            // 
            this.Role.FieldName = "Role";
            this.Role.Name = "Role";
            this.Role.Visible = true;
            this.Role.VisibleIndex = 2;
            // 
            // UserID
            // 
            this.UserID.FieldName = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 3;
            // 
            // MovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "MovieControl";
            this.Size = new System.Drawing.Size(829, 552);
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
        public DevExpress.XtraGrid.Views.Tile.TileView tvPersonnelView;
        private DevExpress.XtraGrid.Columns.TileViewColumn PersonnelImage;
        private DevExpress.XtraGrid.Columns.TileViewColumn FullName;
        private DevExpress.XtraGrid.Columns.TileViewColumn Role;
        private DevExpress.XtraGrid.Columns.TileViewColumn UserID;
    }
}
