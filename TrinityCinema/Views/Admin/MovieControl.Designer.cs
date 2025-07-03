namespace TrinityCinema.Views
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
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcMovieList = new DevExpress.XtraGrid.GridControl();
            this.tvMovies = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tvTitle = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tvDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tvGenre = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tvDuration = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tvStatus = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tvDateCreated = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tvPoster = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbGenre = new DevExpress.XtraEditors.ComboBoxEdit();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teDuration = new DevExpress.XtraEditors.TextEdit();
            this.lbTitle = new DevExpress.XtraEditors.LabelControl();
            this.pePoster = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovieList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePoster.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcMovieList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(870, 772);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gcMovieList
            // 
            this.gcMovieList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcMovieList.Location = new System.Drawing.Point(2, 2);
            this.gcMovieList.MainView = this.tvMovies;
            this.gcMovieList.Margin = new System.Windows.Forms.Padding(4);
            this.gcMovieList.Name = "gcMovieList";
            this.gcMovieList.Size = new System.Drawing.Size(860, 768);
            this.gcMovieList.TabIndex = 0;
            this.gcMovieList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvMovies});
            // 
            // tvMovies
            // 
            this.tvMovies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tvTitle,
            this.tvDescription,
            this.tvGenre,
            this.tvDuration,
            this.tvStatus,
            this.tvDateCreated,
            this.tvPoster});
            this.tvMovies.DetailHeight = 431;
            this.tvMovies.GridControl = this.gcMovieList;
            this.tvMovies.Name = "tvMovies";
            this.tvMovies.OptionsTiles.ItemSize = new System.Drawing.Size(340, 218);
            this.tvMovies.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tvMovies.OptionsTiles.RowCount = 0;
            this.tvMovies.TileColumns.Add(tableColumnDefinition1);
            this.tvMovies.TileColumns.Add(tableColumnDefinition2);
            this.tvMovies.TileRows.Add(tableRowDefinition1);
            this.tvMovies.TileRows.Add(tableRowDefinition2);
            this.tvMovies.TileRows.Add(tableRowDefinition3);
            tableSpan1.RowSpan = 3;
            this.tvMovies.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Column = this.tvPoster;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "tvPoster";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.tvTitle;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "tvTitle";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.tvGenre;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "tvGenre";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tvMovies.TileTemplate.Add(tileViewItemElement1);
            this.tvMovies.TileTemplate.Add(tileViewItemElement2);
            this.tvMovies.TileTemplate.Add(tileViewItemElement3);
            // 
            // tvTitle
            // 
            this.tvTitle.Caption = "Title: ";
            this.tvTitle.FieldName = "Title";
            this.tvTitle.MinWidth = 25;
            this.tvTitle.Name = "tvTitle";
            this.tvTitle.Visible = true;
            this.tvTitle.VisibleIndex = 0;
            this.tvTitle.Width = 94;
            // 
            // tvDescription
            // 
            this.tvDescription.Caption = "Description:";
            this.tvDescription.FieldName = "Description";
            this.tvDescription.MinWidth = 25;
            this.tvDescription.Name = "tvDescription";
            this.tvDescription.Visible = true;
            this.tvDescription.VisibleIndex = 1;
            this.tvDescription.Width = 94;
            // 
            // tvGenre
            // 
            this.tvGenre.Caption = "Genre:";
            this.tvGenre.FieldName = "Genre";
            this.tvGenre.MinWidth = 25;
            this.tvGenre.Name = "tvGenre";
            this.tvGenre.Visible = true;
            this.tvGenre.VisibleIndex = 2;
            this.tvGenre.Width = 94;
            // 
            // tvDuration
            // 
            this.tvDuration.Caption = "Duration:";
            this.tvDuration.FieldName = "Duration";
            this.tvDuration.MinWidth = 25;
            this.tvDuration.Name = "tvDuration";
            this.tvDuration.Visible = true;
            this.tvDuration.VisibleIndex = 3;
            this.tvDuration.Width = 94;
            // 
            // tvStatus
            // 
            this.tvStatus.Caption = "Status:";
            this.tvStatus.FieldName = "Status";
            this.tvStatus.MinWidth = 25;
            this.tvStatus.Name = "tvStatus";
            this.tvStatus.Visible = true;
            this.tvStatus.VisibleIndex = 4;
            this.tvStatus.Width = 94;
            // 
            // tvDateCreated
            // 
            this.tvDateCreated.Caption = "Date Created:";
            this.tvDateCreated.FieldName = "DateCreated";
            this.tvDateCreated.MinWidth = 25;
            this.tvDateCreated.Name = "tvDateCreated";
            this.tvDateCreated.Visible = true;
            this.tvDateCreated.VisibleIndex = 5;
            this.tvDateCreated.Width = 94;
            // 
            // tvPoster
            // 
            this.tvPoster.Caption = "Poster";
            this.tvPoster.FieldName = "MoviePoster";
            this.tvPoster.MinWidth = 25;
            this.tvPoster.Name = "tvPoster";
            this.tvPoster.Visible = true;
            this.tvPoster.VisibleIndex = 6;
            this.tvPoster.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.teTitle);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.deDateCreated);
            this.groupControl2.Controls.Add(this.btnSubmit);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.cbStatus);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.btnBrowse);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.cbGenre);
            this.groupControl2.Controls.Add(this.meDescription);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.teDuration);
            this.groupControl2.Controls.Add(this.lbTitle);
            this.groupControl2.Controls.Add(this.pePoster);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(870, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(578, 772);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // teTitle
            // 
            this.teTitle.Location = new System.Drawing.Point(35, 86);
            this.teTitle.Margin = new System.Windows.Forms.Padding(4);
            this.teTitle.Name = "teTitle";
            this.teTitle.Properties.AutoHeight = false;
            this.teTitle.Size = new System.Drawing.Size(318, 50);
            this.teTitle.TabIndex = 25;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 602);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 16);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Date Created";
            // 
            // deDateCreated
            // 
            this.deDateCreated.EditValue = null;
            this.deDateCreated.Location = new System.Drawing.Point(33, 625);
            this.deDateCreated.Name = "deDateCreated";
            this.deDateCreated.Properties.AutoHeight = false;
            this.deDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateCreated.Size = new System.Drawing.Size(240, 50);
            this.deDateCreated.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(346, 709);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(211, 50);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(317, 501);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 16);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(317, 525);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.AutoHeight = false;
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.DropDownRows = 3;
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Now Showing",
            "Coming Soon",
            "Ended"});
            this.cbStatus.Size = new System.Drawing.Size(240, 50);
            this.cbStatus.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 501);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 16);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Duration";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(384, 294);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(174, 30);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 171);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 16);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Genre";
            // 
            // cbGenre
            // 
            this.cbGenre.Location = new System.Drawing.Point(35, 195);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Properties.AutoHeight = false;
            this.cbGenre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGenre.Properties.DropDownRows = 20;
            this.cbGenre.Properties.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Biography",
            "Comedy",
            "Crime",
            "Documentary",
            "Drama",
            "Family",
            "Fantasy",
            "History",
            "Horror",
            "Musical",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Sport",
            "Thriller",
            "War",
            "Western"});
            this.cbGenre.Properties.Sorted = true;
            this.cbGenre.Size = new System.Drawing.Size(318, 50);
            this.cbGenre.TabIndex = 14;
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(33, 384);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(525, 96);
            this.meDescription.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 361);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Description";
            // 
            // teDuration
            // 
            this.teDuration.Location = new System.Drawing.Point(33, 525);
            this.teDuration.Margin = new System.Windows.Forms.Padding(4);
            this.teDuration.Name = "teDuration";
            this.teDuration.Properties.AutoHeight = false;
            this.teDuration.Size = new System.Drawing.Size(240, 50);
            this.teDuration.TabIndex = 11;
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(35, 62);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(25, 16);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Title";
            // 
            // pePoster
            // 
            this.pePoster.Location = new System.Drawing.Point(383, 62);
            this.pePoster.Name = "pePoster";
            this.pePoster.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePoster.Size = new System.Drawing.Size(174, 212);
            this.pePoster.TabIndex = 0;
            // 
            // MovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieControl";
            this.Size = new System.Drawing.Size(1448, 772);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMovieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePoster.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcMovieList;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PictureEdit pePoster;
        private DevExpress.XtraEditors.LabelControl lbTitle;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teDuration;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbGenre;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.DateEdit deDateCreated;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit teTitle;
        private DevExpress.XtraGrid.Columns.TileViewColumn tvTitle;
        private DevExpress.XtraGrid.Columns.TileViewColumn tvDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn tvGenre;
        private DevExpress.XtraGrid.Columns.TileViewColumn tvDuration;
        private DevExpress.XtraGrid.Columns.TileViewColumn tvStatus;
        private DevExpress.XtraGrid.Columns.TileViewColumn tvDateCreated;
        private DevExpress.XtraGrid.Columns.TileViewColumn tvPoster;
        public DevExpress.XtraGrid.Views.Tile.TileView tvMovies;
    }
}
