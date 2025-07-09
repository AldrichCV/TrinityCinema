namespace TrinityCinema.Views.Admin
{
    partial class ShowtimeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowtimeControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcShowtime = new DevExpress.XtraGrid.GridControl();
            this.gvShowtime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcShowtimeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMovieID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTheaterID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcShowDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.ShowtimeTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcShowtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowtime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEdit.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnEdit.Name = "btnEdit";
            // 
            // gcShowtime
            // 
            this.gcShowtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcShowtime.Location = new System.Drawing.Point(0, 0);
            this.gcShowtime.MainView = this.gvShowtime;
            this.gcShowtime.Name = "gcShowtime";
            this.gcShowtime.Size = new System.Drawing.Size(1151, 654);
            this.gcShowtime.TabIndex = 0;
            this.gcShowtime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShowtime});
            // 
            // gvShowtime
            // 
            this.gvShowtime.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcShowtimeID,
            this.gcMovieID,
            this.gcTheaterID,
            this.gcShowDate,
            this.gcStartDate,
            this.gcPrice,
            this.gcStatus,
            this.gcAction});
            this.gvShowtime.GridControl = this.gcShowtime;
            this.gvShowtime.Name = "gvShowtime";
            // 
            // gcShowtimeID
            // 
            this.gcShowtimeID.Caption = "Showtime ID";
            this.gcShowtimeID.FieldName = "ShowtimeID";
            this.gcShowtimeID.MinWidth = 25;
            this.gcShowtimeID.Name = "gcShowtimeID";
            this.gcShowtimeID.Visible = true;
            this.gcShowtimeID.VisibleIndex = 0;
            this.gcShowtimeID.Width = 94;
            // 
            // gcMovieID
            // 
            this.gcMovieID.Caption = "Movie ID";
            this.gcMovieID.FieldName = "MovieID";
            this.gcMovieID.MinWidth = 25;
            this.gcMovieID.Name = "gcMovieID";
            this.gcMovieID.Visible = true;
            this.gcMovieID.VisibleIndex = 1;
            this.gcMovieID.Width = 94;
            // 
            // gcTheaterID
            // 
            this.gcTheaterID.Caption = "Theater ID";
            this.gcTheaterID.FieldName = "TheaterID";
            this.gcTheaterID.MinWidth = 25;
            this.gcTheaterID.Name = "gcTheaterID";
            this.gcTheaterID.Visible = true;
            this.gcTheaterID.VisibleIndex = 2;
            this.gcTheaterID.Width = 94;
            // 
            // gcShowDate
            // 
            this.gcShowDate.Caption = "Show Date";
            this.gcShowDate.FieldName = "ShowDate";
            this.gcShowDate.MinWidth = 25;
            this.gcShowDate.Name = "gcShowDate";
            this.gcShowDate.Visible = true;
            this.gcShowDate.VisibleIndex = 3;
            this.gcShowDate.Width = 94;
            // 
            // gcStartDate
            // 
            this.gcStartDate.Caption = "Start Date";
            this.gcStartDate.FieldName = "StartDate";
            this.gcStartDate.MinWidth = 25;
            this.gcStartDate.Name = "gcStartDate";
            this.gcStartDate.Visible = true;
            this.gcStartDate.VisibleIndex = 4;
            this.gcStartDate.Width = 94;
            // 
            // gcPrice
            // 
            this.gcPrice.Caption = "Price";
            this.gcPrice.FieldName = "Price";
            this.gcPrice.MinWidth = 25;
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.Visible = true;
            this.gcPrice.VisibleIndex = 5;
            this.gcPrice.Width = 94;
            // 
            // gcStatus
            // 
            this.gcStatus.Caption = "Status";
            this.gcStatus.FieldName = "Status";
            this.gcStatus.MinWidth = 25;
            this.gcStatus.Name = "gcStatus";
            this.gcStatus.Visible = true;
            this.gcStatus.VisibleIndex = 6;
            this.gcStatus.Width = 94;
            // 
            // gcAction
            // 
            this.gcAction.Caption = "Action";
            this.gcAction.ColumnEdit = this.btnEdit;
            this.gcAction.FieldName = "Action";
            this.gcAction.MinWidth = 25;
            this.gcAction.Name = "gcAction";
            this.gcAction.Visible = true;
            this.gcAction.VisibleIndex = 7;
            this.gcAction.Width = 94;
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
            this.actionTile.TabIndex = 7;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 200;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.ShowtimeTile);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // ShowtimeTile
            // 
            this.ShowtimeTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.ShowtimeTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.ShowtimeTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.StretchHorizontal = true;
            tileItemElement1.StretchVertical = true;
            tileItemElement1.Text = "";
            this.ShowtimeTile.Elements.Add(tileItemElement1);
            this.ShowtimeTile.Id = 10;
            this.ShowtimeTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.ShowtimeTile.Name = "ShowtimeTile";
            this.ShowtimeTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ShowtimeTile_ItemClick);
            // 
            // ShowtimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionTile);
            this.Controls.Add(this.gcShowtime);
            this.Name = "ShowtimeControl";
            this.Size = new System.Drawing.Size(1151, 654);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcShowtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowtime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gvShowtime;
        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem ShowtimeTile;
        private DevExpress.XtraGrid.Columns.GridColumn gcShowtimeID;
        private DevExpress.XtraGrid.Columns.GridColumn gcMovieID;
        private DevExpress.XtraGrid.Columns.GridColumn gcTheaterID;
        private DevExpress.XtraGrid.Columns.GridColumn gcShowDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcStatus;
        public DevExpress.XtraGrid.Columns.GridColumn gcAction;
        public DevExpress.XtraGrid.GridControl gcShowtime;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
    }
}
