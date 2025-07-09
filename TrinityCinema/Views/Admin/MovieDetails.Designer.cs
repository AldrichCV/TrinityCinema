namespace TrinityCinema.Views.Admin
{
    partial class MovieDetails
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.pePosterImage = new DevExpress.XtraEditors.PictureEdit();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.beStatus = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.leGenre = new DevExpress.XtraEditors.LookUpEdit();
            this.teDuration = new DevExpress.XtraEditors.TimeEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Title = new DevExpress.XtraLayout.LayoutControlItem();
            this.Description = new DevExpress.XtraLayout.LayoutControlItem();
            this.peImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Genre = new DevExpress.XtraLayout.LayoutControlItem();
            this.Duration = new DevExpress.XtraLayout.LayoutControlItem();
            this.Status = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePosterImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGenre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(30);
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1149, 728);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teTitle);
            this.layoutControl1.Controls.Add(this.meDescription);
            this.layoutControl1.Controls.Add(this.pePosterImage);
            this.layoutControl1.Controls.Add(this.btnBrowse);
            this.layoutControl1.Controls.Add(this.beStatus);
            this.layoutControl1.Controls.Add(this.groupControl2);
            this.layoutControl1.Controls.Add(this.leGenre);
            this.layoutControl1.Controls.Add(this.teDuration);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(30, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(113, 203, 812, 500);
            this.layoutControl1.OptionsView.ItemBorderColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1089, 601);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teTitle
            // 
            this.teTitle.Location = new System.Drawing.Point(10, 32);
            this.teTitle.Name = "teTitle";
            this.teTitle.Size = new System.Drawing.Size(580, 34);
            this.teTitle.StyleController = this.layoutControl1;
            this.teTitle.TabIndex = 4;
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(82, 150);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(515, 333);
            this.meDescription.StyleController = this.layoutControl1;
            this.meDescription.TabIndex = 4;
            // 
            // pePosterImage
            // 
            this.pePosterImage.Location = new System.Drawing.Point(603, 3);
            this.pePosterImage.Name = "pePosterImage";
            this.pePosterImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePosterImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pePosterImage.Size = new System.Drawing.Size(483, 504);
            this.pePosterImage.StyleController = this.layoutControl1;
            this.pePosterImage.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(610, 520);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(469, 71);
            this.btnBrowse.StyleController = this.layoutControl1;
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // beStatus
            // 
            this.beStatus.EditValue = null;
            this.beStatus.Location = new System.Drawing.Point(290, 518);
            this.beStatus.Name = "beStatus";
            this.beStatus.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.beStatus.Properties.Appearance.Options.UseForeColor = true;
            this.beStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.beStatus.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beStatus.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beStatus.Properties.OffText = "Off";
            this.beStatus.Properties.OnText = "On";
            this.beStatus.Size = new System.Drawing.Size(300, 29);
            this.beStatus.StyleController = this.layoutControl1;
            this.beStatus.TabIndex = 9;
            this.beStatus.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.beStatus_EditValueChanging);
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(3, 669);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1110, 46);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // leGenre
            // 
            this.leGenre.Location = new System.Drawing.Point(10, 108);
            this.leGenre.Name = "leGenre";
            this.leGenre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leGenre.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GenreName", "Name2"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GenreID", "Name3", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.leGenre.Properties.DisplayMember = "GenreName";
            this.leGenre.Properties.NullText = "";
            this.leGenre.Properties.PopupSizeable = false;
            this.leGenre.Properties.ValueMember = "GenreID";
            this.leGenre.Size = new System.Drawing.Size(580, 34);
            this.leGenre.StyleController = this.layoutControl1;
            this.leGenre.TabIndex = 5;
            // 
            // teDuration
            // 
            this.teDuration.EditValue = null;
            this.teDuration.Location = new System.Drawing.Point(10, 518);
            this.teDuration.Name = "teDuration";
            this.teDuration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teDuration.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.teDuration.Properties.MaskSettings.Set("mask", "HH:mm:s");
            this.teDuration.Properties.UseMaskAsDisplayFormat = true;
            this.teDuration.Size = new System.Drawing.Size(260, 34);
            this.teDuration.StyleController = this.layoutControl1;
            this.teDuration.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Title,
            this.Description,
            this.peImage,
            this.layoutControlItem1,
            this.Genre,
            this.Duration,
            this.Status});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1089, 601);
            this.Root.TextVisible = false;
            // 
            // Title
            // 
            this.Title.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.Title.AppearanceItemCaption.Options.UseForeColor = true;
            this.Title.Control = this.teTitle;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.MinSize = new System.Drawing.Size(128, 76);
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.Title.Size = new System.Drawing.Size(600, 76);
            this.Title.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Title.TextLocation = DevExpress.Utils.Locations.Top;
            this.Title.TextSize = new System.Drawing.Size(48, 16);
            // 
            // Description
            // 
            this.Description.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.Description.AppearanceItemCaption.Options.UseForeColor = true;
            this.Description.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Description.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Description.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.Description.Control = this.meDescription;
            this.Description.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Description.CustomizationFormText = "Description";
            this.Description.Location = new System.Drawing.Point(0, 147);
            this.Description.MinSize = new System.Drawing.Size(97, 40);
            this.Description.Name = "Description";
            this.Description.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow;
            this.Description.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow;
            this.Description.Size = new System.Drawing.Size(600, 339);
            this.Description.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Description.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.Description.TextSize = new System.Drawing.Size(63, 16);
            this.Description.TextToControlDistance = 16;
            // 
            // peImage
            // 
            this.peImage.Control = this.pePosterImage;
            this.peImage.Location = new System.Drawing.Point(600, 0);
            this.peImage.Name = "peImage";
            this.peImage.Size = new System.Drawing.Size(489, 510);
            this.peImage.TextSize = new System.Drawing.Size(0, 0);
            this.peImage.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnBrowse;
            this.layoutControlItem1.Location = new System.Drawing.Point(600, 510);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(57, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(489, 91);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Genre
            // 
            this.Genre.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.Genre.AppearanceItemCaption.Options.UseForeColor = true;
            this.Genre.Control = this.leGenre;
            this.Genre.Location = new System.Drawing.Point(0, 76);
            this.Genre.MinSize = new System.Drawing.Size(50, 25);
            this.Genre.Name = "Genre";
            this.Genre.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.Genre.Size = new System.Drawing.Size(600, 71);
            this.Genre.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Genre.TextLocation = DevExpress.Utils.Locations.Top;
            this.Genre.TextSize = new System.Drawing.Size(48, 16);
            // 
            // Duration
            // 
            this.Duration.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.Duration.AppearanceItemCaption.Options.UseForeColor = true;
            this.Duration.Control = this.teDuration;
            this.Duration.Location = new System.Drawing.Point(0, 486);
            this.Duration.MinSize = new System.Drawing.Size(50, 25);
            this.Duration.Name = "Duration";
            this.Duration.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.Duration.Size = new System.Drawing.Size(280, 115);
            this.Duration.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Duration.TextLocation = DevExpress.Utils.Locations.Top;
            this.Duration.TextSize = new System.Drawing.Size(48, 16);
            // 
            // Status
            // 
            this.Status.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.Status.AppearanceItemCaption.Options.UseForeColor = true;
            this.Status.Control = this.beStatus;
            this.Status.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Status.CustomizationFormText = "layoutControlItem2";
            this.Status.Location = new System.Drawing.Point(280, 486);
            this.Status.MinSize = new System.Drawing.Size(99, 49);
            this.Status.Name = "Status";
            this.Status.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.Status.Size = new System.Drawing.Size(320, 115);
            this.Status.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Status.TextLocation = DevExpress.Utils.Locations.Top;
            this.Status.TextSize = new System.Drawing.Size(48, 16);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnEdit);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(30, 631);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(1089, 67);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "groupControl3";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(914, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10);
            this.btnEdit.Size = new System.Drawing.Size(170, 56);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 728);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = global::TrinityCinema.Properties.Resources.bo_role;
            this.Name = "MovieDetails";
            this.Text = "MovieDetails";
            this.Load += new System.EventHandler(this.MovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePosterImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGenre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.TextEdit teTitle;
        public DevExpress.XtraEditors.MemoEdit meDescription;
        public DevExpress.XtraEditors.PictureEdit pePosterImage;
        public DevExpress.XtraEditors.SimpleButton btnBrowse;
        public DevExpress.XtraEditors.ToggleSwitch beStatus;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraEditors.LookUpEdit leGenre;
        public DevExpress.XtraEditors.TimeEdit teDuration;
        public DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraLayout.LayoutControlItem Title;
        public DevExpress.XtraLayout.LayoutControlItem Description;
        public DevExpress.XtraLayout.LayoutControlItem peImage;
        public DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraLayout.LayoutControlItem Genre;
        public DevExpress.XtraLayout.LayoutControlItem Duration;
        public DevExpress.XtraLayout.LayoutControlItem Status;
        public DevExpress.XtraEditors.GroupControl groupControl3;
        public DevExpress.XtraEditors.SimpleButton btnEdit;
    }
}