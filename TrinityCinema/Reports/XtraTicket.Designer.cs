namespace TrinityCinema.Reports
{
    partial class XtraTicket
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDateAvailed = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRating = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCinema = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSeatLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDateReceived = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 6.491488F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrDateReceived,
            this.xrSeatLabel,
            this.xrLabel3,
            this.xrCinema,
            this.xrLabel4,
            this.xrDateAvailed,
            this.xrRating,
            this.xrTitle,
            this.xrLine1,
            this.xrTable1});
            this.Detail.HeightF = 200F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Title]")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Roboto", 10F);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 58.38945F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(133.6991F, 20.61905F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel1";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrDateAvailed
            // 
            this.xrDateAvailed.BackColor = System.Drawing.Color.Transparent;
            this.xrDateAvailed.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DateAvailed]")});
            this.xrDateAvailed.Font = new DevExpress.Drawing.DXFont("Roboto", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrDateAvailed.ForeColor = System.Drawing.Color.Black;
            this.xrDateAvailed.LocationFloat = new DevExpress.Utils.PointFloat(171F, 126.5085F);
            this.xrDateAvailed.Multiline = true;
            this.xrDateAvailed.Name = "xrDateAvailed";
            this.xrDateAvailed.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDateAvailed.SizeF = new System.Drawing.SizeF(253.4227F, 20.61905F);
            this.xrDateAvailed.StylePriority.UseBackColor = false;
            this.xrDateAvailed.StylePriority.UseFont = false;
            this.xrDateAvailed.StylePriority.UseForeColor = false;
            this.xrDateAvailed.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrDateAvailed_BeforePrint);
            // 
            // xrRating
            // 
            this.xrRating.BackColor = System.Drawing.Color.Transparent;
            this.xrRating.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RatingCode]")});
            this.xrRating.Font = new DevExpress.Drawing.DXFont("Roboto", 10F);
            this.xrRating.ForeColor = System.Drawing.Color.Black;
            this.xrRating.LocationFloat = new DevExpress.Utils.PointFloat(171F, 91.50851F);
            this.xrRating.Multiline = true;
            this.xrRating.Name = "xrRating";
            this.xrRating.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRating.SizeF = new System.Drawing.SizeF(90.4762F, 20.61905F);
            this.xrRating.StylePriority.UseBackColor = false;
            this.xrRating.StylePriority.UseFont = false;
            this.xrRating.StylePriority.UseForeColor = false;
            this.xrRating.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrRating_BeforePrint);
            // 
            // xrTitle
            // 
            this.xrTitle.BackColor = System.Drawing.Color.Transparent;
            this.xrTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Title]")});
            this.xrTitle.Font = new DevExpress.Drawing.DXFont("Roboto", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTitle.ForeColor = System.Drawing.Color.Black;
            this.xrTitle.LocationFloat = new DevExpress.Utils.PointFloat(171F, 58.38945F);
            this.xrTitle.Multiline = true;
            this.xrTitle.Name = "xrTitle";
            this.xrTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitle.SizeF = new System.Drawing.SizeF(179.5387F, 33.11904F);
            this.xrTitle.StylePriority.UseBackColor = false;
            this.xrTitle.StylePriority.UseFont = false;
            this.xrTitle.StylePriority.UseForeColor = false;
            this.xrTitle.StylePriority.UseTextAlignment = false;
            this.xrTitle.Text = "xrTitle";
            this.xrTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.BackColor = System.Drawing.Color.Transparent;
            this.xrLine1.ForeColor = System.Drawing.Color.Black;
            this.xrLine1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine1.LineStyle = DevExpress.Drawing.DXDashStyle.Dash;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(134.0952F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(23.37236F, 190F);
            this.xrLine1.StylePriority.UseBackColor = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20.88946F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(541.9999F, 24.99999F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "TICKET";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.54112565017692982D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "CINEMA TICKET";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 1.4588743498230703D;
            // 
            // xrCinema
            // 
            this.xrCinema.BackColor = System.Drawing.Color.Transparent;
            this.xrCinema.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TheaterName]")});
            this.xrCinema.Font = new DevExpress.Drawing.DXFont("Roboto", 10F);
            this.xrCinema.ForeColor = System.Drawing.Color.Black;
            this.xrCinema.LocationFloat = new DevExpress.Utils.PointFloat(0F, 79.00849F);
            this.xrCinema.Multiline = true;
            this.xrCinema.Name = "xrCinema";
            this.xrCinema.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCinema.SizeF = new System.Drawing.SizeF(133.6991F, 20.61905F);
            this.xrCinema.StylePriority.UseBackColor = false;
            this.xrCinema.StylePriority.UseFont = false;
            this.xrCinema.StylePriority.UseForeColor = false;
            this.xrCinema.StylePriority.UseTextAlignment = false;
            this.xrCinema.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrCinema.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrCinema_BeforePrint);
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TheaterName]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Roboto", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(422.6666F, 58.38945F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(90.4762F, 33.11904F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrSeatLabel
            // 
            this.xrSeatLabel.BackColor = System.Drawing.Color.Transparent;
            this.xrSeatLabel.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SeatLabel]")});
            this.xrSeatLabel.Font = new DevExpress.Drawing.DXFont("Roboto", 10F);
            this.xrSeatLabel.ForeColor = System.Drawing.Color.Black;
            this.xrSeatLabel.LocationFloat = new DevExpress.Utils.PointFloat(422.6666F, 91.50851F);
            this.xrSeatLabel.Multiline = true;
            this.xrSeatLabel.Name = "xrSeatLabel";
            this.xrSeatLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrSeatLabel.SizeF = new System.Drawing.SizeF(90.4762F, 20.61905F);
            this.xrSeatLabel.StylePriority.UseBackColor = false;
            this.xrSeatLabel.StylePriority.UseFont = false;
            this.xrSeatLabel.StylePriority.UseForeColor = false;
            this.xrSeatLabel.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrSeatLabel_BeforePrint);
            // 
            // xrDateReceived
            // 
            this.xrDateReceived.BackColor = System.Drawing.Color.Transparent;
            this.xrDateReceived.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DateAvailed]")});
            this.xrDateReceived.Font = new DevExpress.Drawing.DXFont("Roboto", 10F);
            this.xrDateReceived.ForeColor = System.Drawing.Color.Black;
            this.xrDateReceived.LocationFloat = new DevExpress.Utils.PointFloat(0.3961563F, 126.5085F);
            this.xrDateReceived.Multiline = true;
            this.xrDateReceived.Name = "xrDateReceived";
            this.xrDateReceived.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDateReceived.SizeF = new System.Drawing.SizeF(133.6991F, 20.61905F);
            this.xrDateReceived.StylePriority.UseBackColor = false;
            this.xrDateReceived.StylePriority.UseFont = false;
            this.xrDateReceived.StylePriority.UseForeColor = false;
            this.xrDateReceived.StylePriority.UseTextAlignment = false;
            this.xrDateReceived.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrDateReceived.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrDateReceived_BeforePrint);
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Roboto", 10F);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0.3961563F, 105.8895F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(133.6991F, 20.61905F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "DATE : TIME";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // XtraTicket
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margins = new DevExpress.Drawing.DXMargins(4F, 4F, 6.491488F, 0F);
            this.PageHeight = 200;
            this.PageWidth = 550;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.Version = "23.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.Add(xrWatermark1);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrDateAvailed;
        private DevExpress.XtraReports.UI.XRLabel xrRating;
        private DevExpress.XtraReports.UI.XRLabel xrTitle;
        private DevExpress.XtraReports.UI.XRLabel xrCinema;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrSeatLabel;
        private DevExpress.XtraReports.UI.XRLabel xrDateReceived;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
