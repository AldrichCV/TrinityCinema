namespace TrinityCinema.Views.Admin
{
    partial class HallControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HallControl));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.gcTheater = new DevExpress.XtraGrid.GridControl();
            this.tvTheaterView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.SeatCapacity = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.TheaterName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.TheaterID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvTheaterView)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTheater
            // 
            this.gcTheater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcTheater.BackgroundImage")));
            this.gcTheater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gcTheater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTheater.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcTheater.Location = new System.Drawing.Point(0, 0);
            this.gcTheater.MainView = this.tvTheaterView;
            this.gcTheater.Margin = new System.Windows.Forms.Padding(4);
            this.gcTheater.Name = "gcTheater";
            this.gcTheater.Size = new System.Drawing.Size(1131, 645);
            this.gcTheater.TabIndex = 5;
            this.gcTheater.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvTheaterView});
            // 
            // tvTheaterView
            // 
            this.tvTheaterView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SeatCapacity,
            this.TheaterName,
            this.TheaterID});
            this.tvTheaterView.DetailHeight = 431;
            this.tvTheaterView.GridControl = this.gcTheater;
            this.tvTheaterView.Name = "tvTheaterView";
            this.tvTheaterView.OptionsTiles.ItemSize = new System.Drawing.Size(306, 451);
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
            tileViewItemElement2.Column = this.TheaterID;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "TheaterID";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tvTheaterView.TileTemplate.Add(tileViewItemElement1);
            this.tvTheaterView.TileTemplate.Add(tileViewItemElement2);
            this.tvTheaterView.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvTheaterView_ItemClick_1);
            // 
            // SeatCapacity
            // 
            this.SeatCapacity.FieldName = "SeatCapacity";
            this.SeatCapacity.MinWidth = 23;
            this.SeatCapacity.Name = "SeatCapacity";
            this.SeatCapacity.Visible = true;
            this.SeatCapacity.VisibleIndex = 0;
            this.SeatCapacity.Width = 87;
            // 
            // TheaterName
            // 
            this.TheaterName.FieldName = "TheaterName";
            this.TheaterName.MinWidth = 23;
            this.TheaterName.Name = "TheaterName";
            this.TheaterName.Visible = true;
            this.TheaterName.VisibleIndex = 1;
            this.TheaterName.Width = 87;
            // 
            // TheaterID
            // 
            this.TheaterID.FieldName = "TheaterID";
            this.TheaterID.MinWidth = 23;
            this.TheaterID.Name = "TheaterID";
            this.TheaterID.Visible = true;
            this.TheaterID.VisibleIndex = 2;
            this.TheaterID.Width = 87;
            // 
            // HallControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcTheater);
            this.Name = "HallControl";
            this.Size = new System.Drawing.Size(1131, 645);
            ((System.ComponentModel.ISupportInitialize)(this.gcTheater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvTheaterView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcTheater;
        public DevExpress.XtraGrid.Views.Tile.TileView tvTheaterView;
        private DevExpress.XtraGrid.Columns.TileViewColumn SeatCapacity;
        private DevExpress.XtraGrid.Columns.TileViewColumn TheaterName;
        private DevExpress.XtraGrid.Columns.TileViewColumn TheaterID;
    }
}
