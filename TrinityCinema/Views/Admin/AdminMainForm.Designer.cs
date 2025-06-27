namespace TrinityCinema.Views.Admin
{
    partial class AdminMainForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.accountsTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.movieTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.ticketTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.salesTile = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SuspendLayout();
            // 
            // actionTile
            // 
            this.actionTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Brown;
            this.actionTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.actionTile.BackColor = System.Drawing.Color.Brown;
            this.actionTile.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
            this.actionTile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.actionTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.actionTile.Groups.Add(this.tileBarGroup2);
            this.actionTile.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.actionTile.ItemPadding = new System.Windows.Forms.Padding(0);
            this.actionTile.ItemSize = 500;
            this.actionTile.Location = new System.Drawing.Point(0, 0);
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 6;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.Size = new System.Drawing.Size(1040, 626);
            this.actionTile.TabIndex = 0;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 250;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.accountsTile);
            this.tileBarGroup2.Items.Add(this.movieTile);
            this.tileBarGroup2.Items.Add(this.ticketTile);
            this.tileBarGroup2.Items.Add(this.salesTile);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // accountsTile
            // 
            this.accountsTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.accountsTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.accountsTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "PERSONNEL";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement2.Appearance.Normal.BackColor = System.Drawing.Color.Black;
            tileItemElement2.Appearance.Normal.Options.UseBackColor = true;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement2.StretchHorizontal = true;
            tileItemElement2.StretchVertical = true;
            tileItemElement2.Text = "";
            this.accountsTile.Elements.Add(tileItemElement1);
            this.accountsTile.Elements.Add(tileItemElement2);
            this.accountsTile.Id = 3;
            this.accountsTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.accountsTile.Name = "accountsTile";
            this.accountsTile.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 50);
            // 
            // movieTile
            // 
            this.movieTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.movieTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.movieTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "tileBarItem2";
            this.movieTile.Elements.Add(tileItemElement3);
            this.movieTile.Id = 4;
            this.movieTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.movieTile.Name = "movieTile";
            // 
            // ticketTile
            // 
            this.ticketTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.ticketTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.ticketTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "tileBarItem3";
            this.ticketTile.Elements.Add(tileItemElement4);
            this.ticketTile.Id = 2;
            this.ticketTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.ticketTile.Name = "ticketTile";
            // 
            // salesTile
            // 
            this.salesTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.salesTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.salesTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "tileBarItem4";
            this.salesTile.Elements.Add(tileItemElement5);
            this.salesTile.Id = 5;
            this.salesTile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.salesTile.Name = "salesTile";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 626);
            this.Controls.Add(this.actionTile);
            this.Name = "AdminMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem ticketTile;
        private DevExpress.XtraBars.Navigation.TileBarItem accountsTile;
        private DevExpress.XtraBars.Navigation.TileBarItem movieTile;
        private DevExpress.XtraBars.Navigation.TileBarItem salesTile;
    }
}