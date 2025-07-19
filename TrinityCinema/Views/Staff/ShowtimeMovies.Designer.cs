namespace TrinityCinema.Views.Staff
{
    partial class ShowtimeMovies
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
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition6 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.MoviePoster = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Title = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.MovieID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Genre = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gcShowMovies = new DevExpress.XtraGrid.GridControl();
            this.tvShowMovies = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.TheaterID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcShowMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvShowMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.FieldName = "MoviePoster";
            this.MoviePoster.MinWidth = 25;
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Visible = true;
            this.MoviePoster.VisibleIndex = 0;
            this.MoviePoster.Width = 94;
            // 
            // Title
            // 
            this.Title.FieldName = "Title";
            this.Title.MinWidth = 25;
            this.Title.Name = "Title";
            this.Title.Visible = true;
            this.Title.VisibleIndex = 3;
            this.Title.Width = 94;
            // 
            // MovieID
            // 
            this.MovieID.FieldName = "MovieID";
            this.MovieID.MinWidth = 25;
            this.MovieID.Name = "MovieID";
            this.MovieID.Visible = true;
            this.MovieID.VisibleIndex = 1;
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
            // gcShowMovies
            // 
            this.gcShowMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcShowMovies.Location = new System.Drawing.Point(0, 0);
            this.gcShowMovies.MainView = this.tvShowMovies;
            this.gcShowMovies.Name = "gcShowMovies";
            this.gcShowMovies.Size = new System.Drawing.Size(1151, 654);
            this.gcShowMovies.TabIndex = 8;
            this.gcShowMovies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvShowMovies});
            // 
            // tvShowMovies
            // 
            this.tvShowMovies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MoviePoster,
            this.MovieID,
            this.Genre,
            this.Title,
            this.TheaterID});
            this.tvShowMovies.GridControl = this.gcShowMovies;
            this.tvShowMovies.Name = "tvShowMovies";
            this.tvShowMovies.OptionsTiles.ItemSize = new System.Drawing.Size(344, 584);
            this.tvShowMovies.OptionsTiles.RowCount = 0;
            this.tvShowMovies.TileColumns.Add(tableColumnDefinition1);
            this.tvShowMovies.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 67D;
            tableRowDefinition2.Length.Value = 67D;
            tableRowDefinition3.Length.Value = 68D;
            tableRowDefinition4.Length.Value = 103D;
            tableRowDefinition5.Length.Value = 49D;
            tableRowDefinition6.Length.Value = 52D;
            this.tvShowMovies.TileRows.Add(tableRowDefinition1);
            this.tvShowMovies.TileRows.Add(tableRowDefinition2);
            this.tvShowMovies.TileRows.Add(tableRowDefinition3);
            this.tvShowMovies.TileRows.Add(tableRowDefinition4);
            this.tvShowMovies.TileRows.Add(tableRowDefinition5);
            this.tvShowMovies.TileRows.Add(tableRowDefinition6);
            tableSpan1.ColumnSpan = 2;
            tableSpan1.RowSpan = 4;
            tableSpan2.ColumnSpan = 2;
            tableSpan2.RowIndex = 4;
            tableSpan2.RowSpan = 2;
            this.tvShowMovies.TileSpans.Add(tableSpan1);
            this.tvShowMovies.TileSpans.Add(tableSpan2);
            tileViewItemElement1.Column = this.MoviePoster;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "MoviePoster";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Hovered.Font = new System.Drawing.Font("Arial", 12F);
            tileViewItemElement2.Appearance.Hovered.Options.UseFont = true;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.Title;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 4;
            tileViewItemElement2.Text = "Title";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.MovieID;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 3;
            tileViewItemElement3.Text = "MovieID";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileViewItemElement3.TextVisible = false;
            tileViewItemElement4.Column = this.Genre;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 4;
            tileViewItemElement4.Text = "Genre";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileViewItemElement5.Column = this.TheaterID;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.Text = "TheaterID";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileViewItemElement5.TextVisible = false;
            this.tvShowMovies.TileTemplate.Add(tileViewItemElement1);
            this.tvShowMovies.TileTemplate.Add(tileViewItemElement2);
            this.tvShowMovies.TileTemplate.Add(tileViewItemElement3);
            this.tvShowMovies.TileTemplate.Add(tileViewItemElement4);
            this.tvShowMovies.TileTemplate.Add(tileViewItemElement5);
            this.tvShowMovies.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvShowMovies_ItemClick);
            // 
            // TheaterID
            // 
            this.TheaterID.FieldName = "TheaterID";
            this.TheaterID.MinWidth = 25;
            this.TheaterID.Name = "TheaterID";
            this.TheaterID.Visible = true;
            this.TheaterID.VisibleIndex = 4;
            this.TheaterID.Width = 94;
            // 
            // ShowtimeMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcShowMovies);
            this.Name = "ShowtimeMovies";
            this.Size = new System.Drawing.Size(1151, 654);
            ((System.ComponentModel.ISupportInitialize)(this.gcShowMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvShowMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcShowMovies;
        private DevExpress.XtraGrid.Views.Tile.TileView tvShowMovies;
        private DevExpress.XtraGrid.Columns.TileViewColumn MoviePoster;
        private DevExpress.XtraGrid.Columns.TileViewColumn MovieID;
        private DevExpress.XtraGrid.Columns.TileViewColumn Genre;
        private DevExpress.XtraGrid.Columns.TileViewColumn Title;
        private DevExpress.XtraGrid.Columns.TileViewColumn TheaterID;
    }
}
