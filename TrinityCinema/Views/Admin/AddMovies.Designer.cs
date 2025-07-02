namespace TrinityCinema.Views.Admin
{
    partial class AddMovies
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
            this.pePosterImage = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.Title = new DevExpress.XtraLayout.LayoutControlItem();
            this.Genre = new DevExpress.XtraLayout.LayoutControlItem();
            this.teGenre = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Description = new DevExpress.XtraLayout.LayoutControlItem();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.teDuration = new DevExpress.XtraEditors.TextEdit();
            this.Duration = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePosterImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGenre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.btnBrowse);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Controls.Add(this.pePosterImage);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(30);
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1149, 728);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // pePosterImage
            // 
            this.pePosterImage.Location = new System.Drawing.Point(32, 30);
            this.pePosterImage.Name = "pePosterImage";
            this.pePosterImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePosterImage.Size = new System.Drawing.Size(465, 581);
            this.pePosterImage.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teTitle);
            this.layoutControl1.Controls.Add(this.teGenre);
            this.layoutControl1.Controls.Add(this.meDescription);
            this.layoutControl1.Controls.Add(this.teDuration);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.layoutControl1.Location = new System.Drawing.Point(568, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(113, 203, 812, 500);
            this.layoutControl1.OptionsView.ItemBorderColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(551, 668);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Title,
            this.Genre,
            this.Description,
            this.Duration});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(551, 668);
            this.Root.TextVisible = false;
            // 
            // teTitle
            // 
            this.teTitle.Location = new System.Drawing.Point(67, 3);
            this.teTitle.Name = "teTitle";
            this.teTitle.Size = new System.Drawing.Size(481, 34);
            this.teTitle.StyleController = this.layoutControl1;
            this.teTitle.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.Control = this.teTitle;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(551, 40);
            this.Title.TextSize = new System.Drawing.Size(48, 16);
            // 
            // Genre
            // 
            this.Genre.Control = this.teGenre;
            this.Genre.Location = new System.Drawing.Point(0, 40);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(551, 40);
            this.Genre.TextSize = new System.Drawing.Size(48, 16);
            // 
            // teGenre
            // 
            this.teGenre.Location = new System.Drawing.Point(67, 43);
            this.teGenre.Name = "teGenre";
            this.teGenre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teGenre.Size = new System.Drawing.Size(481, 34);
            this.teGenre.StyleController = this.layoutControl1;
            this.teGenre.TabIndex = 5;
            // 
            // Description
            // 
            this.Description.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Description.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Description.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.Description.Control = this.meDescription;
            this.Description.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Description.CustomizationFormText = "Description";
            this.Description.Location = new System.Drawing.Point(0, 80);
            this.Description.MinSize = new System.Drawing.Size(97, 40);
            this.Description.Name = "Description";
            this.Description.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow;
            this.Description.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow;
            this.Description.Size = new System.Drawing.Size(551, 548);
            this.Description.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Description.Text = "Description";
            this.Description.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.Description.TextSize = new System.Drawing.Size(63, 16);
            this.Description.TextToControlDistance = 16;
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(82, 83);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(466, 542);
            this.meDescription.StyleController = this.layoutControl1;
            this.meDescription.TabIndex = 4;
            // 
            // teDuration
            // 
            this.teDuration.Location = new System.Drawing.Point(67, 631);
            this.teDuration.Name = "teDuration";
            this.teDuration.Size = new System.Drawing.Size(481, 34);
            this.teDuration.StyleController = this.layoutControl1;
            this.teDuration.TabIndex = 6;
            // 
            // Duration
            // 
            this.Duration.Control = this.teDuration;
            this.Duration.Location = new System.Drawing.Point(0, 628);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(551, 40);
            this.Duration.TextSize = new System.Drawing.Size(48, 16);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Location = new System.Drawing.Point(346, 642);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(151, 56);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            // 
            // AddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 728);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddMovies";
            this.Text = "AddMovies";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pePosterImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGenre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pePosterImage;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit teTitle;
        private DevExpress.XtraEditors.ComboBoxEdit teGenre;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Title;
        private DevExpress.XtraLayout.LayoutControlItem Genre;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraEditors.TextEdit teDuration;
        private DevExpress.XtraLayout.LayoutControlItem Description;
        private DevExpress.XtraLayout.LayoutControlItem Duration;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
    }
}