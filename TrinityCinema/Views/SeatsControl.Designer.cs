namespace TrinityCinema.Views
{
    partial class SeatsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatsControl));
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbAction = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbHall = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.hallLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.actionLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcMode = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcStatus = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHall.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svgImageBox1.Location = new System.Drawing.Point(0, 0);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(722, 738);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 0;
            this.svgImageBox1.Text = "svgImageBox1";
            this.svgImageBox1.ItemClick += new DevExpress.XtraEditors.SvgImageItemMouseEventHandler(this.svgImageBox1_ItemClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(722, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(364, 738);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lcStatus);
            this.layoutControl1.Controls.Add(this.lcMode);
            this.layoutControl1.Controls.Add(this.cbAction);
            this.layoutControl1.Controls.Add(this.cbHall);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(360, 734);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbAction
            // 
            this.cbAction.Location = new System.Drawing.Point(16, 156);
            this.cbAction.Name = "cbAction";
            this.cbAction.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAction.Properties.Appearance.Options.UseFont = true;
            this.cbAction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAction.Properties.Items.AddRange(new object[] {
            "Availability",
            "Condition"});
            this.cbAction.Size = new System.Drawing.Size(328, 46);
            this.cbAction.StyleController = this.layoutControl1;
            this.cbAction.TabIndex = 1;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // cbHall
            // 
            this.cbHall.Location = new System.Drawing.Point(16, 60);
            this.cbHall.Name = "cbHall";
            this.cbHall.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbHall.Properties.Appearance.Options.UseFont = true;
            this.cbHall.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHall.Properties.Items.AddRange(new object[] {
            "Hall1",
            "Hall2"});
            this.cbHall.Size = new System.Drawing.Size(328, 46);
            this.cbHall.StyleController = this.layoutControl1;
            this.cbHall.TabIndex = 0;
            this.cbHall.SelectedIndexChanged += new System.EventHandler(this.cbHall_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.hallLayout,
            this.emptySpaceItem1,
            this.actionLayout,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.layoutControlItem7,
            this.emptySpaceItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(360, 734);
            this.Root.TextVisible = false;
            // 
            // hallLayout
            // 
            this.hallLayout.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hallLayout.AppearanceItemCaption.Options.UseFont = true;
            this.hallLayout.Control = this.cbHall;
            this.hallLayout.Location = new System.Drawing.Point(0, 10);
            this.hallLayout.Name = "hallLayout";
            this.hallLayout.Size = new System.Drawing.Size(334, 86);
            this.hallLayout.Text = "Hall";
            this.hallLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.hallLayout.TextSize = new System.Drawing.Size(57, 28);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 268);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(106, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(334, 440);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // actionLayout
            // 
            this.actionLayout.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.actionLayout.AppearanceItemCaption.Options.UseFont = true;
            this.actionLayout.Control = this.cbAction;
            this.actionLayout.Location = new System.Drawing.Point(0, 106);
            this.actionLayout.Name = "actionLayout";
            this.actionLayout.Size = new System.Drawing.Size(334, 86);
            this.actionLayout.Text = "Action";
            this.actionLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.actionLayout.TextSize = new System.Drawing.Size(57, 28);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(334, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 192);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(334, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcMode
            // 
            this.lcMode.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lcMode.Appearance.Options.UseFont = true;
            this.lcMode.Appearance.Options.UseTextOptions = true;
            this.lcMode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcMode.Location = new System.Drawing.Point(16, 218);
            this.lcMode.Name = "lcMode";
            this.lcMode.Size = new System.Drawing.Size(328, 28);
            this.lcMode.StyleController = this.layoutControl1;
            this.lcMode.TabIndex = 2;
            this.lcMode.Text = "--";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lcMode;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 202);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(22, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(334, 34);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 236);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(334, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcStatus
            // 
            this.lcStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lcStatus.Appearance.Options.UseFont = true;
            this.lcStatus.Appearance.Options.UseTextOptions = true;
            this.lcStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcStatus.Location = new System.Drawing.Point(16, 262);
            this.lcStatus.Name = "lcStatus";
            this.lcStatus.Size = new System.Drawing.Size(328, 16);
            this.lcStatus.StyleController = this.layoutControl1;
            this.lcStatus.TabIndex = 2;
            this.lcStatus.Text = "--";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lcStatus;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 246);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(16, 22);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(334, 22);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(334, 10);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SeatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.groupControl1);
            this.Name = "SeatsControl";
            this.Size = new System.Drawing.Size(1086, 738);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbAction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHall.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbHall;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbAction;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem hallLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem actionLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.LabelControl lcMode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.LabelControl lcStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}
