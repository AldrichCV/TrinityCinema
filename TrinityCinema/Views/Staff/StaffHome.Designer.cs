namespace TrinityCinema.Views.Staff
{
    partial class StaffHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHome));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.NewTransaction = new DevExpress.XtraEditors.TileItem();
            this.Transactions = new DevExpress.XtraEditors.TileItem();
            this.Accounts = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileControl1.BackgroundImage")));
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 200;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 7;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1010, 660);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.NewTransaction);
            this.tileGroup2.Items.Add(this.Transactions);
            this.tileGroup2.Items.Add(this.Accounts);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // NewTransaction
            // 
            this.NewTransaction.AppearanceItem.Normal.BackColor = System.Drawing.Color.Black;
            this.NewTransaction.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.NewTransaction.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.NewTransaction.AppearanceItem.Normal.Options.UseBackColor = true;
            this.NewTransaction.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.NewTransaction.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement1.Text = "New Transaction";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.NewTransaction.Elements.Add(tileItemElement1);
            this.NewTransaction.Id = 3;
            this.NewTransaction.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.NewTransaction.Name = "NewTransaction";
            this.NewTransaction.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.NewTransaction_ItemClick);
            // 
            // Transactions
            // 
            this.Transactions.AppearanceItem.Normal.BackColor = System.Drawing.Color.Black;
            this.Transactions.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.Transactions.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Transactions.AppearanceItem.Normal.Options.UseBackColor = true;
            this.Transactions.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.Transactions.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement2.Text = "My Transactions";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.Transactions.Elements.Add(tileItemElement2);
            this.Transactions.Id = 4;
            this.Transactions.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.Transactions.Name = "Transactions";
            // 
            // Accounts
            // 
            this.Accounts.AppearanceItem.Normal.BackColor = System.Drawing.Color.Black;
            this.Accounts.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.Accounts.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Accounts.AppearanceItem.Normal.Options.UseBackColor = true;
            this.Accounts.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.Accounts.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement3.Text = "My Account";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.Accounts.Elements.Add(tileItemElement3);
            this.Accounts.Id = 5;
            this.Accounts.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.Accounts.Name = "Accounts";
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileControl1);
            this.Name = "StaffHome";
            this.Size = new System.Drawing.Size(1010, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem NewTransaction;
        private DevExpress.XtraEditors.TileItem Transactions;
        private DevExpress.XtraEditors.TileItem Accounts;
    }
}
