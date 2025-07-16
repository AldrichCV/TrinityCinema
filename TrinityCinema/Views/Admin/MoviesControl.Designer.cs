namespace TrinityCinema.Views.Admin
{
    partial class MoviesControl
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.Title = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.MovieID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Genre = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.MoviePoster = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Status = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Action = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.viewDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcMovies = new DevExpress.XtraGrid.GridControl();
            this.tvMovieView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.movieTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMovieView)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.FieldName = "Title";
            this.Title.MinWidth = 25;
            this.Title.Name = "Title";
            this.Title.Visible = true;
            this.Title.VisibleIndex = 1;
            this.Title.Width = 94;
            // 
            // MovieID
            // 
            this.MovieID.FieldName = "MovieID";
            this.MovieID.MinWidth = 25;
            this.MovieID.Name = "MovieID";
            this.MovieID.Visible = true;
            this.MovieID.VisibleIndex = 0;
            this.MovieID.Width = 94;
            // 
            // Genre
            // 
            this.Genre.FieldName = "GenreName";
            this.Genre.MinWidth = 25;
            this.Genre.Name = "Genre";
            this.Genre.Visible = true;
            this.Genre.VisibleIndex = 2;
            this.Genre.Width = 94;
            // 
            // MoviePoster
            // 
            this.MoviePoster.FieldName = "MoviePoster";
            this.MoviePoster.MinWidth = 25;
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Visible = true;
            this.MoviePoster.VisibleIndex = 5;
            this.MoviePoster.Width = 94;
            // 
            // Status
            // 
            this.Status.FieldName = "StatusDisplay";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 4;
            this.Status.Width = 94;
            // 
            // Action
            // 
            this.Action.Caption = "Action";
            this.Action.ColumnEdit = this.viewDetails;
            this.Action.FieldName = "Action";
            this.Action.MinWidth = 25;
            this.Action.Name = "Action";
            this.Action.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.Action.Visible = true;
            this.Action.VisibleIndex = 3;
            this.Action.Width = 94;
            // 
            // viewDetails
            // 
            this.viewDetails.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(25, 25);
            this.viewDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.viewDetails.LookAndFeel.SkinName = "WXI";
            this.viewDetails.LookAndFeel.UseDefaultLookAndFeel = false;
            this.viewDetails.Name = "viewDetails";
            this.viewDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.viewDetails.Click += new System.EventHandler(this.viewDetails_Click);
            // 
            // gcMovies
            // 
            this.gcMovies.BackgroundImage = global::TrinityCinema.Properties.Resources._516777173_1087917039937354_651591537518408061_n;
            this.gcMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gcMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMovies.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcMovies.Location = new System.Drawing.Point(0, 0);
            this.gcMovies.MainView = this.tvMovieView;
            this.gcMovies.Margin = new System.Windows.Forms.Padding(4);
            this.gcMovies.Name = "gcMovies";
            this.gcMovies.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.viewDetails});
            this.gcMovies.Size = new System.Drawing.Size(1151, 516);
            this.gcMovies.TabIndex = 7;
            this.gcMovies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvMovieView});
            // 
            // tvMovieView
            // 
            this.tvMovieView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MovieID,
            this.Title,
            this.Genre,
            this.Action,
            this.Status,
            this.MoviePoster});
            this.tvMovieView.DetailHeight = 431;
            this.tvMovieView.GridControl = this.gcMovies;
            this.tvMovieView.Name = "tvMovieView";
            this.tvMovieView.OptionsTiles.ItemSize = new System.Drawing.Size(564, 430);
            this.tvMovieView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tvMovieView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tvMovieView.OptionsTiles.RowCount = 0;
            this.tvMovieView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            tableColumnDefinition1.Length.Value = 239D;
            tableColumnDefinition2.Length.Value = 159D;
            this.tvMovieView.TileColumns.Add(tableColumnDefinition1);
            this.tvMovieView.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 27D;
            tableRowDefinition2.Length.Value = 147D;
            tableRowDefinition3.Length.Value = 87D;
            this.tvMovieView.TileRows.Add(tableRowDefinition1);
            this.tvMovieView.TileRows.Add(tableRowDefinition2);
            this.tvMovieView.TileRows.Add(tableRowDefinition3);
            tableSpan1.RowSpan = 3;
            this.tvMovieView.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.Title;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "Title";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.MovieID;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "MovieID";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Column = this.Genre;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "Genre";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileViewItemElement4.Column = this.MoviePoster;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.Text = "MoviePoster";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.Column = this.Status;
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.RowIndex = 2;
            tileViewItemElement5.Text = "Status";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tvMovieView.TileTemplate.Add(tileViewItemElement1);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement2);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement3);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement4);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement5);
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
            this.actionTile.TabIndex = 6;
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
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrinityCinema.Properties.Resources._516777173_1087917039937354_651591537518408061_n;
            this.Controls.Add(this.gcMovies);
            this.Controls.Add(this.actionTile);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(1151, 654);
            ((System.ComponentModel.ISupportInitialize)(this.viewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMovieView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcMovies;
        public DevExpress.XtraGrid.Views.Tile.TileView tvMovieView;
        private DevExpress.XtraGrid.Columns.TileViewColumn MovieID;
        private DevExpress.XtraGrid.Columns.TileViewColumn Title;
        private DevExpress.XtraGrid.Columns.TileViewColumn Genre;
        private DevExpress.XtraGrid.Columns.TileViewColumn Action;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit viewDetails;
        private DevExpress.XtraGrid.Columns.TileViewColumn Status;
        private DevExpress.XtraGrid.Columns.TileViewColumn MoviePoster;
        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem movieTile;
    }
}
