namespace TrinityCinema.Views.Staff
{
    partial class TicketList
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
            this.gcTickets = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TicketID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MovieTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShowtimeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SeatNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BuyerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BuyerContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuyTicket = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTickets
            // 
            this.gcTickets.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTickets.Location = new System.Drawing.Point(15, 52);
            this.gcTickets.MainView = this.gridView1;
            this.gcTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTickets.Name = "gcTickets";
            this.gcTickets.Size = new System.Drawing.Size(1656, 714);
            this.gcTickets.TabIndex = 0;
            this.gcTickets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TicketID,
            this.MovieTitle,
            this.ShowtimeID,
            this.Price,
            this.SeatNumber,
            this.BuyerName,
            this.BuyerContact,
            this.BookedBy,
            this.BookingTime});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcTickets;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1000;
            // 
            // TicketID
            // 
            this.TicketID.Caption = "Ticket ID";
            this.TicketID.FieldName = "TicketID";
            this.TicketID.MinWidth = 31;
            this.TicketID.Name = "TicketID";
            this.TicketID.Visible = true;
            this.TicketID.VisibleIndex = 0;
            this.TicketID.Width = 117;
            // 
            // MovieTitle
            // 
            this.MovieTitle.Caption = "Movie Title";
            this.MovieTitle.FieldName = "Title";
            this.MovieTitle.MinWidth = 31;
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Visible = true;
            this.MovieTitle.VisibleIndex = 1;
            this.MovieTitle.Width = 117;
            // 
            // ShowtimeID
            // 
            this.ShowtimeID.Caption = "Showtime";
            this.ShowtimeID.FieldName = "ShowtimeID";
            this.ShowtimeID.MinWidth = 31;
            this.ShowtimeID.Name = "ShowtimeID";
            this.ShowtimeID.Visible = true;
            this.ShowtimeID.VisibleIndex = 2;
            this.ShowtimeID.Width = 117;
            // 
            // Price
            // 
            this.Price.Caption = "Price";
            this.Price.FieldName = "PricePaid";
            this.Price.MinWidth = 31;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            this.Price.Width = 117;
            // 
            // SeatNumber
            // 
            this.SeatNumber.Caption = "Seat Number";
            this.SeatNumber.FieldName = "SeatNumber";
            this.SeatNumber.MinWidth = 31;
            this.SeatNumber.Name = "SeatNumber";
            this.SeatNumber.Visible = true;
            this.SeatNumber.VisibleIndex = 4;
            this.SeatNumber.Width = 117;
            // 
            // BuyerName
            // 
            this.BuyerName.Caption = "Customer Name";
            this.BuyerName.FieldName = "BuyerName";
            this.BuyerName.MinWidth = 31;
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Visible = true;
            this.BuyerName.VisibleIndex = 5;
            this.BuyerName.Width = 117;
            // 
            // BuyerContact
            // 
            this.BuyerContact.Caption = "Customer Contact";
            this.BuyerContact.FieldName = "BuyerContact";
            this.BuyerContact.MinWidth = 31;
            this.BuyerContact.Name = "BuyerContact";
            this.BuyerContact.Visible = true;
            this.BuyerContact.VisibleIndex = 6;
            this.BuyerContact.Width = 117;
            // 
            // BookedBy
            // 
            this.BookedBy.Caption = "Booked By";
            this.BookedBy.FieldName = "BookedBy";
            this.BookedBy.MinWidth = 31;
            this.BookedBy.Name = "BookedBy";
            this.BookedBy.Visible = true;
            this.BookedBy.VisibleIndex = 7;
            this.BookedBy.Width = 117;
            // 
            // BookingTime
            // 
            this.BookingTime.Caption = "Booking Time";
            this.BookingTime.FieldName = "BookingTime";
            this.BookingTime.MinWidth = 31;
            this.BookingTime.Name = "BookingTime";
            this.BookingTime.Visible = true;
            this.BookingTime.VisibleIndex = 8;
            this.BookingTime.Width = 117;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(768, 810);
            this.btnBuyTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(168, 59);
            this.btnBuyTicket.TabIndex = 1;
            this.btnBuyTicket.Text = "Buy Ticket";
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 905);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.gcTickets);
            this.Name = "TicketList";
            this.Text = "TicketList";
            ((System.ComponentModel.ISupportInitialize)(this.gcTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTickets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TicketID;
        private DevExpress.XtraGrid.Columns.GridColumn ShowtimeID;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn SeatNumber;
        private DevExpress.XtraGrid.Columns.GridColumn BuyerName;
        private DevExpress.XtraGrid.Columns.GridColumn BuyerContact;
        private DevExpress.XtraGrid.Columns.GridColumn BookedBy;
        private DevExpress.XtraGrid.Columns.GridColumn BookingTime;
        private DevExpress.XtraGrid.Columns.GridColumn MovieTitle;
        private DevExpress.XtraEditors.SimpleButton btnBuyTicket;
    }
}