namespace TrinityCinema.Views.Admin
{
    partial class EditShowtime
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.pePoster = new DevExpress.XtraEditors.PictureEdit();
            this.teStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.deShowDate = new DevExpress.XtraEditors.DateEdit();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.leHall = new DevExpress.XtraEditors.LookUpEdit();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.leMovie = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.movieTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.moviePoster = new DevExpress.XtraLayout.LayoutControlItem();
            this.showDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.theaterName = new DevExpress.XtraLayout.LayoutControlItem();
            this.showPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.startTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.showStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePoster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leHall.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMovie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theaterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSubmit);
            this.layoutControl1.Controls.Add(this.pePoster);
            this.layoutControl1.Controls.Add(this.teStartTime);
            this.layoutControl1.Controls.Add(this.deShowDate);
            this.layoutControl1.Controls.Add(this.cbStatus);
            this.layoutControl1.Controls.Add(this.leHall);
            this.layoutControl1.Controls.Add(this.tePrice);
            this.layoutControl1.Controls.Add(this.leMovie);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1054, 576);
            this.layoutControl1.TabIndex = 28;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Appearance.Options.UseBackColor = true;
            this.btnSubmit.Location = new System.Drawing.Point(449, 526);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(589, 34);
            this.btnSubmit.StyleController = this.layoutControl1;
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "SAVE CHANGES";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pePoster
            // 
            this.pePoster.Location = new System.Drawing.Point(16, 16);
            this.pePoster.Name = "pePoster";
            this.pePoster.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePoster.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pePoster.Size = new System.Drawing.Size(427, 544);
            this.pePoster.StyleController = this.layoutControl1;
            this.pePoster.TabIndex = 14;
            // 
            // teStartTime
            // 
            this.teStartTime.EditValue = new System.DateTime(2025, 7, 7, 0, 0, 0, 0);
            this.teStartTime.Location = new System.Drawing.Point(746, 162);
            this.teStartTime.Name = "teStartTime";
            this.teStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teStartTime.Properties.MaskSettings.Set("mask", "t");
            this.teStartTime.Size = new System.Drawing.Size(292, 34);
            this.teStartTime.StyleController = this.layoutControl1;
            this.teStartTime.TabIndex = 3;
            // 
            // deShowDate
            // 
            this.deShowDate.EditValue = null;
            this.deShowDate.Location = new System.Drawing.Point(449, 162);
            this.deShowDate.Name = "deShowDate";
            this.deShowDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deShowDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deShowDate.Properties.MaskSettings.Set("mask", "d");
            this.deShowDate.Size = new System.Drawing.Size(291, 34);
            this.deShowDate.StyleController = this.layoutControl1;
            this.deShowDate.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(746, 224);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Upcoming",
            "Now Showing",
            "Cancelled",
            "Ended"});
            this.cbStatus.Size = new System.Drawing.Size(292, 34);
            this.cbStatus.StyleController = this.layoutControl1;
            this.cbStatus.TabIndex = 5;
            // 
            // leHall
            // 
            this.leHall.Location = new System.Drawing.Point(449, 100);
            this.leHall.Name = "leHall";
            this.leHall.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leHall.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TheaterID", ""),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TheaterName", "")});
            this.leHall.Properties.DisplayMember = "TheaterName";
            this.leHall.Properties.NullText = "";
            this.leHall.Properties.PopupSizeable = false;
            this.leHall.Properties.ValueMember = "TheaterID";
            this.leHall.Size = new System.Drawing.Size(589, 34);
            this.leHall.StyleController = this.layoutControl1;
            this.leHall.TabIndex = 4;
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(449, 224);
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tePrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tePrice.Properties.MaskSettings.Set("mask", "c");
            this.tePrice.Size = new System.Drawing.Size(291, 34);
            this.tePrice.StyleController = this.layoutControl1;
            this.tePrice.TabIndex = 1;
            // 
            // leMovie
            // 
            this.leMovie.Location = new System.Drawing.Point(449, 38);
            this.leMovie.Name = "leMovie";
            this.leMovie.Properties.NullText = "--Select Movie--";
            this.leMovie.Size = new System.Drawing.Size(589, 34);
            this.leMovie.StyleController = this.layoutControl1;
            this.leMovie.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.movieTitle,
            this.moviePoster,
            this.showDate,
            this.theaterName,
            this.showPrice,
            this.layoutControlItem2,
            this.startTime,
            this.showStatus,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1054, 576);
            this.Root.TextVisible = false;
            // 
            // movieTitle
            // 
            this.movieTitle.Control = this.leMovie;
            this.movieTitle.Location = new System.Drawing.Point(433, 0);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(595, 62);
            this.movieTitle.Text = "Movie";
            this.movieTitle.TextLocation = DevExpress.Utils.Locations.Top;
            this.movieTitle.TextSize = new System.Drawing.Size(66, 16);
            // 
            // moviePoster
            // 
            this.moviePoster.Control = this.pePoster;
            this.moviePoster.Location = new System.Drawing.Point(0, 0);
            this.moviePoster.MinSize = new System.Drawing.Size(26, 26);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(433, 550);
            this.moviePoster.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.moviePoster.TextSize = new System.Drawing.Size(0, 0);
            this.moviePoster.TextVisible = false;
            // 
            // showDate
            // 
            this.showDate.Control = this.deShowDate;
            this.showDate.Location = new System.Drawing.Point(433, 124);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(297, 62);
            this.showDate.Text = "Show Date";
            this.showDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.showDate.TextSize = new System.Drawing.Size(66, 16);
            // 
            // theaterName
            // 
            this.theaterName.Control = this.leHall;
            this.theaterName.Location = new System.Drawing.Point(433, 62);
            this.theaterName.Name = "theaterName";
            this.theaterName.Size = new System.Drawing.Size(595, 62);
            this.theaterName.Text = "Hall";
            this.theaterName.TextLocation = DevExpress.Utils.Locations.Top;
            this.theaterName.TextSize = new System.Drawing.Size(66, 16);
            // 
            // showPrice
            // 
            this.showPrice.Control = this.tePrice;
            this.showPrice.Location = new System.Drawing.Point(433, 186);
            this.showPrice.Name = "showPrice";
            this.showPrice.Size = new System.Drawing.Size(297, 62);
            this.showPrice.Text = "Price";
            this.showPrice.TextLocation = DevExpress.Utils.Locations.Top;
            this.showPrice.TextSize = new System.Drawing.Size(66, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSubmit;
            this.layoutControlItem2.Location = new System.Drawing.Point(433, 510);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(595, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // startTime
            // 
            this.startTime.Control = this.teStartTime;
            this.startTime.Location = new System.Drawing.Point(730, 124);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(298, 62);
            this.startTime.Text = "Start Time";
            this.startTime.TextLocation = DevExpress.Utils.Locations.Top;
            this.startTime.TextSize = new System.Drawing.Size(66, 16);
            // 
            // showStatus
            // 
            this.showStatus.Control = this.cbStatus;
            this.showStatus.Location = new System.Drawing.Point(730, 186);
            this.showStatus.Name = "showStatus";
            this.showStatus.Size = new System.Drawing.Size(298, 62);
            this.showStatus.TextLocation = DevExpress.Utils.Locations.Top;
            this.showStatus.TextSize = new System.Drawing.Size(66, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(433, 248);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(595, 262);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // EditShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 576);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditShowtime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Showtime";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pePoster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leHall.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMovie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theaterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.SimpleButton btnSubmit;
        public DevExpress.XtraEditors.PictureEdit pePoster;
        public DevExpress.XtraEditors.TimeEdit teStartTime;
        public DevExpress.XtraEditors.DateEdit deShowDate;
        public DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        public DevExpress.XtraEditors.LookUpEdit leHall;
        public DevExpress.XtraEditors.TextEdit tePrice;
        public DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraLayout.LayoutControlItem movieTitle;
        public DevExpress.XtraLayout.LayoutControlItem moviePoster;
        public DevExpress.XtraLayout.LayoutControlItem showDate;
        public DevExpress.XtraLayout.LayoutControlItem theaterName;
        public DevExpress.XtraLayout.LayoutControlItem showPrice;
        public DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        public DevExpress.XtraLayout.LayoutControlItem startTime;
        public DevExpress.XtraLayout.LayoutControlItem showStatus;
        public DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        public DevExpress.XtraEditors.TextEdit leMovie;
    }
}