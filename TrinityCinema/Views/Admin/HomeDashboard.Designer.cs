namespace TrinityCinema.Views.Admin
{
    partial class HomeDashboard
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDashboard));
            this.dashBoard = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.userTile = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcShowtime = new DevExpress.XtraGrid.GridControl();
            this.gvShow = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHeader = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcShowtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHeader)).BeginInit();
            this.gcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // dashBoard
            // 
            this.dashBoard.AllowItemHover = true;
            this.dashBoard.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.dashBoard.AppearanceItem.Normal.Options.UseBackColor = true;
            this.dashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoard.Groups.Add(this.tileGroup1);
            this.dashBoard.Groups.Add(this.tileGroup2);
            this.dashBoard.IndentBetweenItems = 50;
            this.dashBoard.ItemSize = 200;
            this.dashBoard.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive;
            this.dashBoard.Location = new System.Drawing.Point(0, 117);
            this.dashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.dashBoard.MaxId = 8;
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.dashBoard.Padding = new System.Windows.Forms.Padding(60, 80, 40, 80);
            this.dashBoard.Size = new System.Drawing.Size(892, 638);
            this.dashBoard.TabIndex = 0;
            this.dashBoard.Text = "tileControl1";
            this.dashBoard.Click += new System.EventHandler(this.dashBoard_Click);
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.userTile);
            this.tileGroup1.Name = "tileGroup1";
            // 
            // userTile
            // 
            this.userTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.userTile.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Maroon;
            this.userTile.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.userTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.userTile.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.userTile.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Users";
            tileItemElement2.Text = "Manager";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement3.Text = "Staff";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement4.Text = "--";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement4.TextLocation = new System.Drawing.Point(300, 0);
            tileItemElement5.Text = "--";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement5.TextLocation = new System.Drawing.Point(300, 0);
            tileItemElement6.Text = "Status";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.userTile.Elements.Add(tileItemElement1);
            this.userTile.Elements.Add(tileItemElement2);
            this.userTile.Elements.Add(tileItemElement3);
            this.userTile.Elements.Add(tileItemElement4);
            this.userTile.Elements.Add(tileItemElement5);
            this.userTile.Elements.Add(tileItemElement6);
            this.userTile.Id = 2;
            this.userTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.userTile.Name = "userTile";
            this.userTile.Padding = new System.Windows.Forms.Padding(20);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem4);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.tileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Maroon;
            this.tileItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement7.Text = "Halls";
            this.tileItem2.Elements.Add(tileItemElement7);
            this.tileItem2.Id = 3;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.Padding = new System.Windows.Forms.Padding(20);
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.tileItem4.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Maroon;
            this.tileItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tileItem4.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem4.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem4.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement8.Text = "Revenue";
            this.tileItem4.Elements.Add(tileItemElement8);
            this.tileItem4.Id = 5;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.Padding = new System.Windows.Forms.Padding(20);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.gcShowtime);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(892, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.groupControl1.Size = new System.Drawing.Size(676, 755);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // gcShowtime
            // 
            this.gcShowtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcShowtime.Location = new System.Drawing.Point(20, 0);
            this.gcShowtime.MainView = this.gvShow;
            this.gcShowtime.Name = "gcShowtime";
            this.gcShowtime.Size = new System.Drawing.Size(636, 735);
            this.gcShowtime.TabIndex = 0;
            this.gcShowtime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShow});
            // 
            // gvShow
            // 
            this.gvShow.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvShow.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvShow.ColumnPanelRowHeight = 10;
            this.gvShow.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Time,
            this.Title});
            this.gvShow.GridControl = this.gcShowtime;
            this.gvShow.Name = "gvShow";
            this.gvShow.OptionsBehavior.ReadOnly = true;
            this.gvShow.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gvShow.OptionsView.ShowGroupPanel = false;
            this.gvShow.RowHeight = 12;
            // 
            // Time
            // 
            this.Time.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Time.AppearanceCell.Options.UseFont = true;
            this.Time.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.Time.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Time.AppearanceHeader.Options.UseBackColor = true;
            this.Time.AppearanceHeader.Options.UseFont = true;
            this.Time.Caption = "Time";
            this.Time.FieldName = "StartTime";
            this.Time.MinWidth = 25;
            this.Time.Name = "Time";
            this.Time.OptionsColumn.AllowEdit = false;
            this.Time.Visible = true;
            this.Time.VisibleIndex = 0;
            this.Time.Width = 94;
            // 
            // Title
            // 
            this.Title.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Title.AppearanceCell.Options.UseFont = true;
            this.Title.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.Title.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Title.AppearanceHeader.Options.UseBackColor = true;
            this.Title.AppearanceHeader.Options.UseFont = true;
            this.Title.Caption = "Movie";
            this.Title.FieldName = "Title";
            this.Title.MinWidth = 25;
            this.Title.Name = "Title";
            this.Title.OptionsColumn.AllowEdit = false;
            this.Title.Visible = true;
            this.Title.VisibleIndex = 1;
            this.Title.Width = 94;
            // 
            // gcHeader
            // 
            this.gcHeader.Controls.Add(this.labelControl1);
            this.gcHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHeader.Location = new System.Drawing.Point(0, 0);
            this.gcHeader.Name = "gcHeader";
            this.gcHeader.ShowCaption = false;
            this.gcHeader.Size = new System.Drawing.Size(892, 117);
            this.gcHeader.TabIndex = 2;
            this.gcHeader.Text = "groupControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Black;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 755);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1568, 97);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // HomeDashboard
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dashBoard);
            this.Controls.Add(this.gcHeader);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "HomeDashboard";
            this.Size = new System.Drawing.Size(1568, 852);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcShowtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHeader)).EndInit();
            this.gcHeader.ResumeLayout(false);
            this.gcHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl dashBoard;
        private DevExpress.XtraEditors.TileItem userTile;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcShowtime;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShow;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraEditors.GroupControl gcHeader;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
    }
}
