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
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.MoviePoster = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Title = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Genre = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.MovieID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPersonnel = new DevExpress.XtraGrid.GridControl();
            this.tvPersonnelView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.movieTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.viewDescription = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Description = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPersonnelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.FieldName = "MoviePoster";
            this.MoviePoster.MinWidth = 23;
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.OptionsColumn.AllowFocus = false;
            this.MoviePoster.Visible = true;
            this.MoviePoster.VisibleIndex = 0;
            this.MoviePoster.Width = 87;
            // 
            // Title
            // 
            this.Title.FieldName = "Title";
            this.Title.MinWidth = 23;
            this.Title.Name = "Title";
            this.Title.Visible = true;
            this.Title.VisibleIndex = 1;
            this.Title.Width = 87;
            // 
            // Genre
            // 
            this.Genre.FieldName = "Genre";
            this.Genre.MinWidth = 23;
            this.Genre.Name = "Genre";
            this.Genre.Visible = true;
            this.Genre.VisibleIndex = 2;
            this.Genre.Width = 87;
            // 
            // MovieID
            // 
            this.MovieID.FieldName = "MovieID";
            this.MovieID.MinWidth = 23;
            this.MovieID.Name = "MovieID";
            this.MovieID.Visible = true;
            this.MovieID.VisibleIndex = 3;
            this.MovieID.Width = 87;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcPersonnel);
            this.groupControl1.Controls.Add(this.actionTile);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(967, 679);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gcPersonnel
            // 
            this.gcPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPersonnel.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPersonnel.Location = new System.Drawing.Point(2, 2);
            this.gcPersonnel.MainView = this.tvPersonnelView;
            this.gcPersonnel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPersonnel.Name = "gcPersonnel";
            this.gcPersonnel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.viewDescription});
            this.gcPersonnel.Size = new System.Drawing.Size(963, 537);
            this.gcPersonnel.TabIndex = 3;
            this.gcPersonnel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvPersonnelView});
            // 
            // tvPersonnelView
            // 
            this.tvPersonnelView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MoviePoster,
            this.Title,
            this.Genre,
            this.MovieID,
            this.Description});
            this.tvPersonnelView.DetailHeight = 431;
            this.tvPersonnelView.GridControl = this.gcPersonnel;
            this.tvPersonnelView.Name = "tvPersonnelView";
            this.tvPersonnelView.OptionsTiles.ItemSize = new System.Drawing.Size(336, 189);
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
            tileViewItemElement1.Column = this.MoviePoster;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileViewItemElement1.Text = "MoviePoster";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.Title;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "Title";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.Genre;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "Genre";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileViewItemElement3.TextLocation = new System.Drawing.Point(0, -50);
            tileViewItemElement4.Column = this.MovieID;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.Text = "MovieID";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileViewItemElement5.Column = this.Description;
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.Text = "Description";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement1);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement2);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement3);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement4);
            this.tvPersonnelView.TileTemplate.Add(tileViewItemElement5);
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
            this.actionTile.Location = new System.Drawing.Point(2, 539);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 11;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.SelectionBorderWidth = 0;
            this.actionTile.ShowItemShadow = true;
            this.actionTile.Size = new System.Drawing.Size(963, 138);
            this.actionTile.TabIndex = 2;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 200;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.movieTile);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // movieTile
            // 
            this.movieTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.movieTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.movieTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.StretchHorizontal = true;
            tileItemElement1.StretchVertical = true;
            tileItemElement1.Text = "";
            this.movieTile.Elements.Add(tileItemElement1);
            this.movieTile.Id = 10;
            this.movieTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.movieTile.Name = "movieTile";
            this.movieTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.movieTile_ItemClick);
            // 
            // viewDescription
            // 
            this.viewDescription.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.viewDescription.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.viewDescription.Name = "viewDescription";
            this.viewDescription.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Description
            // 
            this.Description.ColumnEdit = this.viewDescription;
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 25;
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            this.Description.Width = 87;
            // 
            // MovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MovieControl";
            this.Size = new System.Drawing.Size(967, 679);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPersonnelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem movieTile;
        public DevExpress.XtraGrid.GridControl gcPersonnel;
        public DevExpress.XtraGrid.Views.Tile.TileView tvPersonnelView;
        private DevExpress.XtraGrid.Columns.TileViewColumn MoviePoster;
        private DevExpress.XtraGrid.Columns.TileViewColumn Title;
        private DevExpress.XtraGrid.Columns.TileViewColumn Genre;
        private DevExpress.XtraGrid.Columns.TileViewColumn MovieID;
        private DevExpress.XtraGrid.Columns.TileViewColumn Description;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit viewDescription;
    }
}
