namespace TrinityCinema.Views.Admin
{
    partial class ReportsControl
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
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.dailyTile = new DevExpress.XtraEditors.TileItem();
            this.weeklyReport = new DevExpress.XtraEditors.TileItem();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.allRecordsTile = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.monthlyTile = new DevExpress.XtraEditors.TileItem();
            this.annualTile = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup1);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.ItemSize = 200;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 5;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1613, 727);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.dailyTile);
            this.tileGroup2.Items.Add(this.weeklyReport);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // dailyTile
            // 
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Daily Report";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.dailyTile.Elements.Add(tileItemElement1);
            this.dailyTile.Id = 1;
            this.dailyTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.dailyTile.Name = "dailyTile";
            // 
            // weeklyReport
            // 
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Weekly Report";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.weeklyReport.Elements.Add(tileItemElement2);
            this.weeklyReport.Id = 2;
            this.weeklyReport.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.weeklyReport.Name = "weeklyReport";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.allRecordsTile);
            this.tileGroup1.Name = "tileGroup1";
            // 
            // allRecordsTile
            // 
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Text = "All Records";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.allRecordsTile.Elements.Add(tileItemElement3);
            this.allRecordsTile.Id = 0;
            this.allRecordsTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.allRecordsTile.Name = "allRecordsTile";
            this.allRecordsTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.allRecordsTile_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.monthlyTile);
            this.tileGroup3.Items.Add(this.annualTile);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // monthlyTile
            // 
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Monthly Report";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.monthlyTile.Elements.Add(tileItemElement4);
            this.monthlyTile.Id = 3;
            this.monthlyTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.monthlyTile.Name = "monthlyTile";
            // 
            // annualTile
            // 
            tileItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Text = "Annual Report";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.annualTile.Elements.Add(tileItemElement5);
            this.annualTile.Id = 4;
            this.annualTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.annualTile.Name = "annualTile";
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileControl1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(1613, 727);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem allRecordsTile;
        private DevExpress.XtraEditors.TileItem dailyTile;
        private DevExpress.XtraEditors.TileItem weeklyReport;
        private DevExpress.XtraEditors.TileItem monthlyTile;
        private DevExpress.XtraEditors.TileItem annualTile;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
    }
}
