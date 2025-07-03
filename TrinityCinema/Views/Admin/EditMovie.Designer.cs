namespace TrinityCinema.Views.Admin
{
    partial class EditMovie
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
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePoster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
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
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
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
            this.cbGenre.Properties.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
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
            // tileView1
            // 
            this.tileView1.DetailHeight = 431;
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(860, 768);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(870, 772);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnRemove);
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
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(35, 709);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(211, 50);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 772);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "EditMovie";
            this.Text = "EditMovie";
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePoster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teTitle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deDateCreated;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbGenre;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teDuration;
        private DevExpress.XtraEditors.LabelControl lbTitle;
        private DevExpress.XtraEditors.PictureEdit pePoster;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraEditors.SimpleButton btnRemove;
    }
}