namespace TrinityCinema.Views.Staff
{
    partial class MyTransactions
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
            this.gcTransactions = new DevExpress.XtraGrid.GridControl();
            this.gvTraction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.actionTile = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.PrintTransaction = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.TransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TractionDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraction)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTransactions
            // 
            this.gcTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTransactions.Location = new System.Drawing.Point(0, 0);
            this.gcTransactions.MainView = this.gvTraction;
            this.gcTransactions.Name = "gcTransactions";
            this.gcTransactions.Size = new System.Drawing.Size(1205, 628);
            this.gcTransactions.TabIndex = 0;
            this.gcTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTraction});
            // 
            // gvTraction
            // 
            this.gvTraction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TransactionId,
            this.TransactionDate,
            this.CreatedBy,
            this.TractionDetails,
            this.Amount});
            this.gvTraction.GridControl = this.gcTransactions;
            this.gvTraction.Name = "gvTraction";
            this.gvTraction.OptionsView.ShowGroupPanel = false;
            // 
            // actionTile
            // 
            this.actionTile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Brown;
            this.actionTile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.actionTile.BackColor = System.Drawing.Color.Maroon;
            this.actionTile.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
            this.actionTile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.actionTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionTile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.actionTile.Groups.Add(this.tileBarGroup2);
            this.actionTile.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.actionTile.ItemPadding = new System.Windows.Forms.Padding(10);
            this.actionTile.ItemSize = 50;
            this.actionTile.Location = new System.Drawing.Point(0, 628);
            this.actionTile.LookAndFeel.SkinName = "WXI";
            this.actionTile.LookAndFeel.UseDefaultLookAndFeel = false;
            this.actionTile.Margin = new System.Windows.Forms.Padding(0);
            this.actionTile.MaxId = 11;
            this.actionTile.Name = "actionTile";
            this.actionTile.Padding = new System.Windows.Forms.Padding(0);
            this.actionTile.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.actionTile.SelectionBorderWidth = 0;
            this.actionTile.ShowItemShadow = true;
            this.actionTile.Size = new System.Drawing.Size(1205, 84);
            this.actionTile.TabIndex = 8;
            this.actionTile.Text = "tileBar1";
            this.actionTile.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.actionTile.WideTileWidth = 200;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.PrintTransaction);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // PrintTransaction
            // 
            this.PrintTransaction.AppearanceItem.Normal.BackColor = System.Drawing.Color.SandyBrown;
            this.PrintTransaction.AppearanceItem.Normal.Options.UseBackColor = true;
            this.PrintTransaction.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            tileItemElement1.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            tileItemElement1.Text = "PRINT";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.PrintTransaction.Elements.Add(tileItemElement1);
            this.PrintTransaction.Id = 10;
            this.PrintTransaction.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.PrintTransaction.Name = "PrintTransaction";
            this.PrintTransaction.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.PrintTransaction_ItemClick);
            // 
            // TransactionId
            // 
            this.TransactionId.Caption = "TransactionId";
            this.TransactionId.FieldName = "TransactionId";
            this.TransactionId.MinWidth = 25;
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.Visible = true;
            this.TransactionId.VisibleIndex = 0;
            this.TransactionId.Width = 94;
            // 
            // TransactionDate
            // 
            this.TransactionDate.Caption = "Transaction Date";
            this.TransactionDate.FieldName = "TransactionDate";
            this.TransactionDate.MinWidth = 25;
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Visible = true;
            this.TransactionDate.VisibleIndex = 1;
            this.TransactionDate.Width = 94;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Caption = "Created By";
            this.CreatedBy.FieldName = "CreatedBy";
            this.CreatedBy.MinWidth = 25;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Visible = true;
            this.CreatedBy.VisibleIndex = 2;
            this.CreatedBy.Width = 94;
            // 
            // TractionDetails
            // 
            this.TractionDetails.Caption = "Description";
            this.TractionDetails.FieldName = "Description";
            this.TractionDetails.MinWidth = 25;
            this.TractionDetails.Name = "TractionDetails";
            this.TractionDetails.Visible = true;
            this.TractionDetails.VisibleIndex = 3;
            this.TractionDetails.Width = 94;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.FieldName = "Amount";
            this.Amount.MinWidth = 25;
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 4;
            this.Amount.Width = 94;
            // 
            // MyTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcTransactions);
            this.Controls.Add(this.actionTile);
            this.Name = "MyTransactions";
            this.Size = new System.Drawing.Size(1205, 712);
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTraction;
        private DevExpress.XtraBars.Navigation.TileBar actionTile;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem PrintTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn TransactionId;
        private DevExpress.XtraGrid.Columns.GridColumn TransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn TractionDetails;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
    }
}
