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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
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
            this.MovieID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Title = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.MoviePoster = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Rating = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Status = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Genre = new DevExpress.XtraGrid.Columns.TileViewColumn();
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
            // MovieID
            // 
            this.MovieID.FieldName = "MovieID";
            this.MovieID.MinWidth = 25;
            this.MovieID.Name = "MovieID";
            this.MovieID.Visible = true;
            this.MovieID.VisibleIndex = 0;
            this.MovieID.Width = 94;
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
            // MoviePoster
            // 
            this.MoviePoster.FieldName = "MoviePoster";
            this.MoviePoster.MinWidth = 25;
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Visible = true;
            this.MoviePoster.VisibleIndex = 4;
            this.MoviePoster.Width = 94;
            // 
            // Rating
            // 
            this.Rating.FieldName = "ContentRatingCode";
            this.Rating.MinWidth = 25;
            this.Rating.Name = "Rating";
            this.Rating.Visible = true;
            this.Rating.VisibleIndex = 6;
            this.Rating.Width = 94;
            // 
            // Status
            // 
            this.Status.FieldName = "StatusDisplay";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 94;
            // 
            // Genre
            // 
            this.Genre.FieldName = "GenreName";
            this.Genre.MinWidth = 25;
            this.Genre.Name = "Genre";
            this.Genre.Visible = true;
            this.Genre.VisibleIndex = 5;
            this.Genre.Width = 94;
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
            this.Action.VisibleIndex = 2;
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
            this.gcMovies.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcMovies.BackgroundImage")));
            this.gcMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gcMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMovies.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcMovies.Location = new System.Drawing.Point(0, 0);
            this.gcMovies.MainView = this.tvMovieView;
            this.gcMovies.Margin = new System.Windows.Forms.Padding(4);
            this.gcMovies.Name = "gcMovies";
            this.gcMovies.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.viewDetails});
            this.gcMovies.Size = new System.Drawing.Size(1151, 570);
            this.gcMovies.TabIndex = 7;
            this.gcMovies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvMovieView});
            // 
            // tvMovieView
            // 
            this.tvMovieView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MovieID,
            this.Title,
            this.Action,
            this.Status,
            this.MoviePoster,
            this.Genre,
            this.Rating});
            this.tvMovieView.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.None;
            this.tvMovieView.DetailHeight = 431;
            this.tvMovieView.GridControl = this.gcMovies;
            this.tvMovieView.Name = "tvMovieView";
            this.tvMovieView.OptionsKanban.GroupHeaderContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.None;
            this.tvMovieView.OptionsTiles.AllowPressAnimation = false;
            this.tvMovieView.OptionsTiles.IndentBetweenGroups = 28;
            this.tvMovieView.OptionsTiles.IndentBetweenItems = 12;
            this.tvMovieView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(5);
            this.tvMovieView.OptionsTiles.ItemSize = new System.Drawing.Size(280, 481);
            this.tvMovieView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tvMovieView.OptionsTiles.RowCount = 0;
            this.tvMovieView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tvMovieView.TileColumns.Add(tableColumnDefinition1);
            this.tvMovieView.TileColumns.Add(tableColumnDefinition2);
            this.tvMovieView.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 116D;
            tableRowDefinition2.Length.Value = 187D;
            tableRowDefinition3.Length.Value = 90D;
            this.tvMovieView.TileRows.Add(tableRowDefinition1);
            this.tvMovieView.TileRows.Add(tableRowDefinition2);
            this.tvMovieView.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnSpan = 3;
            tableSpan1.RowSpan = 2;
            tableSpan2.ColumnSpan = 3;
            tableSpan2.RowIndex = 2;
            this.tvMovieView.TileSpans.Add(tableSpan1);
            this.tvMovieView.TileSpans.Add(tableSpan2);
            tileViewItemElement1.Column = this.MovieID;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "MovieID";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.TextVisible = false;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.Title;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 2;
            tileViewItemElement2.Text = "Title";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement2.TextLocation = new System.Drawing.Point(15, 0);
            tileViewItemElement3.Column = this.MoviePoster;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement3.Text = "MoviePoster";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.Rating;
            tileViewItemElement4.ColumnIndex = 2;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 2;
            tileViewItemElement4.Text = "Rating";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement4.TextLocation = new System.Drawing.Point(15, 10);
            tileViewItemElement5.Column = this.Status;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.RowIndex = 2;
            tileViewItemElement5.Text = "Status";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileViewItemElement5.TextLocation = new System.Drawing.Point(15, -5);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement1);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement2);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement3);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement4);
            this.tvMovieView.TileTemplate.Add(tileViewItemElement5);
            this.tvMovieView.ItemDoubleClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvMovieView_ItemDoubleClick);
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
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "New Movie";
            this.movieTile.Elements.Add(tileItemElement1);
            this.movieTile.Id = 10;
            this.movieTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.movieTile.Name = "movieTile";
            this.movieTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.movieTile_ItemClick);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private DevExpress.XtraGrid.Columns.TileViewColumn Action;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit viewDetails;
        private DevExpress.XtraGrid.Columns.TileViewColumn Status;
        private DevExpress.XtraGrid.Columns.TileViewColumn MoviePoster;
        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem movieTile;
        private DevExpress.XtraGrid.Columns.TileViewColumn Genre;
        private DevExpress.XtraGrid.Columns.TileViewColumn Rating;
    }
}
