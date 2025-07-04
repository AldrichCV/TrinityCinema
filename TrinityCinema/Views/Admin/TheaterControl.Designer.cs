namespace TrinityCinema.Views.Admin
{
    partial class TheaterControl
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheaterControl));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.theaterTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tvTheaterView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.SeatCapacity = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.TheaterName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.TheaterID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gcTheater = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.tvTheaterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheater)).BeginInit();
            this.SuspendLayout();
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
            this.actionTile.Location = new System.Drawing.Point(0, 439);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 11;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.SelectionBorderWidth = 0;
            this.actionTile.ShowItemShadow = true;
            this.actionTile.Size = new System.Drawing.Size(831, 112);
            this.actionTile.TabIndex = 2;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 200;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.theaterTile);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // theaterTile
            // 
            this.theaterTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.theaterTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.theaterTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.StretchHorizontal = true;
            tileItemElement1.StretchVertical = true;
            tileItemElement1.Text = "";
            this.theaterTile.Elements.Add(tileItemElement1);
            this.theaterTile.Id = 10;
            this.theaterTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.theaterTile.Name = "theaterTile";
            this.theaterTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.theaterTile_ItemClick);
            // 
            // tvTheaterView
            // 
            this.tvTheaterView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SeatCapacity,
            this.TheaterName,
            this.TheaterID});
            this.tvTheaterView.GridControl = this.gcTheater;
            this.tvTheaterView.Name = "tvTheaterView";
            this.tvTheaterView.OptionsTiles.ItemSize = new System.Drawing.Size(306, 147);
            this.tvTheaterView.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 125D;
            this.tvTheaterView.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 32D;
            tableRowDefinition2.Length.Value = 68D;
            tableRowDefinition3.Length.Value = 31D;
            this.tvTheaterView.TileRows.Add(tableRowDefinition1);
            this.tvTheaterView.TileRows.Add(tableRowDefinition2);
            this.tvTheaterView.TileRows.Add(tableRowDefinition3);
            tableSpan1.RowSpan = 3;
            this.tvTheaterView.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.TheaterName;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "TheaterName";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.SeatCapacity;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "SeatCapacity";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileViewItemElement3.Column = this.TheaterID;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.Text = "TheaterID";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tvTheaterView.TileTemplate.Add(tileViewItemElement1);
            this.tvTheaterView.TileTemplate.Add(tileViewItemElement2);
            this.tvTheaterView.TileTemplate.Add(tileViewItemElement3);
            this.tvTheaterView.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvTheaterView_ItemClick);
            // 
            // SeatCapacity
            // 
            this.SeatCapacity.FieldName = "SeatCapacity";
            this.SeatCapacity.Name = "SeatCapacity";
            this.SeatCapacity.Visible = true;
            this.SeatCapacity.VisibleIndex = 0;
            // 
            // TheaterName
            // 
            this.TheaterName.FieldName = "TheaterName";
            this.TheaterName.Name = "TheaterName";
            this.TheaterName.Visible = true;
            this.TheaterName.VisibleIndex = 1;
            // 
            // TheaterID
            // 
            this.TheaterID.FieldName = "TheaterID";
            this.TheaterID.Name = "TheaterID";
            this.TheaterID.Visible = true;
            this.TheaterID.VisibleIndex = 2;
            // 
            // gcTheater
            // 
            this.gcTheater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTheater.Location = new System.Drawing.Point(0, 0);
            this.gcTheater.MainView = this.tvTheaterView;
            this.gcTheater.Name = "gcTheater";
            this.gcTheater.Size = new System.Drawing.Size(831, 439);
            this.gcTheater.TabIndex = 3;
            this.gcTheater.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvTheaterView});
            // 
            // TheaterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcTheater);
            this.Controls.Add(this.actionTile);
            this.Name = "TheaterControl";
            this.Size = new System.Drawing.Size(831, 551);
            ((System.ComponentModel.ISupportInitialize)(this.tvTheaterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem theaterTile;
        public DevExpress.XtraGrid.Views.Tile.TileView tvTheaterView;
        private DevExpress.XtraGrid.Columns.TileViewColumn SeatCapacity;
        private DevExpress.XtraGrid.Columns.TileViewColumn TheaterName;
        private DevExpress.XtraGrid.Columns.TileViewColumn TheaterID;
        public DevExpress.XtraGrid.GridControl gcTheater;
    }
}
