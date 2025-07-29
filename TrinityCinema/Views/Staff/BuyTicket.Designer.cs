namespace TrinityCinema.Views.Staff
{
    partial class BuyTicket
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
            this.leMovieTitle = new DevExpress.XtraEditors.LookUpEdit();
            this.leShowtime = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.leSeatNumber = new DevExpress.XtraEditors.LookUpEdit();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuyTicket = new DevExpress.XtraEditors.SimpleButton();
            this.teBuyerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teBuyerContact = new DevExpress.XtraEditors.TextEdit();
            this.teBookedBy = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tePricePaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.leMovieTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leShowtime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSeatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBuyerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBuyerContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBookedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePricePaid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // leMovieTitle
            // 
            this.leMovieTitle.Location = new System.Drawing.Point(44, 125);
            this.leMovieTitle.Name = "leMovieTitle";
            this.leMovieTitle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leMovieTitle.Properties.DisplayMember = "Title";
            this.leMovieTitle.Properties.ValueMember = "MovieID";
            this.leMovieTitle.Size = new System.Drawing.Size(473, 34);
            this.leMovieTitle.TabIndex = 0;
            this.leMovieTitle.EditValueChanged += new System.EventHandler(this.leMovieTitle_EditValueChanged);
            // 
            // leShowtime
            // 
            this.leShowtime.Location = new System.Drawing.Point(48, 211);
            this.leShowtime.Name = "leShowtime";
            this.leShowtime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leShowtime.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Showtime", "Showtime")});
            this.leShowtime.Properties.DisplayMember = "Showtime";
            this.leShowtime.Properties.ValueMember = "ShowtimeID";
            this.leShowtime.Size = new System.Drawing.Size(469, 34);
            this.leShowtime.TabIndex = 1;
            this.leShowtime.EditValueChanged += new System.EventHandler(this.leShowtime_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Movie Title";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 189);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Showtime";
            // 
            // leSeatNumber
            // 
            this.leSeatNumber.Location = new System.Drawing.Point(567, 125);
            this.leSeatNumber.Name = "leSeatNumber";
            this.leSeatNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSeatNumber.Size = new System.Drawing.Size(125, 34);
            this.leSeatNumber.TabIndex = 4;
            this.leSeatNumber.EditValueChanged += new System.EventHandler(this.leSeatNumber_EditValueChanged);
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(567, 211);
            this.tePrice.Name = "tePrice";
            this.tePrice.Size = new System.Drawing.Size(125, 34);
            this.tePrice.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(567, 189);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Price";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(567, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Seat Number";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(1187, 618);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(140, 51);
            this.btnBuyTicket.TabIndex = 8;
            this.btnBuyTicket.Text = "Submit";
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // teBuyerName
            // 
            this.teBuyerName.Location = new System.Drawing.Point(48, 329);
            this.teBuyerName.Name = "teBuyerName";
            this.teBuyerName.Size = new System.Drawing.Size(228, 34);
            this.teBuyerName.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(48, 307);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Customer Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(297, 307);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Customer Contact";
            // 
            // teBuyerContact
            // 
            this.teBuyerContact.Location = new System.Drawing.Point(297, 329);
            this.teBuyerContact.Name = "teBuyerContact";
            this.teBuyerContact.Size = new System.Drawing.Size(220, 34);
            this.teBuyerContact.TabIndex = 11;
            // 
            // teBookedBy
            // 
            this.teBookedBy.Location = new System.Drawing.Point(48, 579);
            this.teBookedBy.Name = "teBookedBy";
            this.teBookedBy.Size = new System.Drawing.Size(205, 34);
            this.teBookedBy.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(48, 557);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 16);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Booked By:";
            // 
            // tePricePaid
            // 
            this.tePricePaid.Location = new System.Drawing.Point(567, 579);
            this.tePricePaid.Name = "tePricePaid";
            this.tePricePaid.Size = new System.Drawing.Size(220, 34);
            this.tePricePaid.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(567, 557);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 16);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Amount";
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 697);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tePricePaid);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.teBookedBy);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.teBuyerContact);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.teBuyerName);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tePrice);
            this.Controls.Add(this.leSeatNumber);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.leShowtime);
            this.Controls.Add(this.leMovieTitle);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            ((System.ComponentModel.ISupportInitialize)(this.leMovieTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leShowtime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSeatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBuyerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBuyerContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBookedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePricePaid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit leSeatNumber;
        private DevExpress.XtraEditors.TextEdit tePrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnBuyTicket;
        private DevExpress.XtraEditors.TextEdit teBuyerName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit teBuyerContact;
        private DevExpress.XtraEditors.TextEdit teBookedBy;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.LookUpEdit leMovieTitle;
        public DevExpress.XtraEditors.LookUpEdit leShowtime;
        private DevExpress.XtraEditors.TextEdit tePricePaid;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}