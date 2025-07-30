using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TrinityCinema.Reports
{
    public partial class XtraTicket : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraTicket()
        {
            InitializeComponent();
        }

        private void xrRating_BeforePrint(object sender, CancelEventArgs e)
        {
            var label = sender as XRLabel;
            var contentRating = GetCurrentColumnValue("RatingCode")?.ToString();
            label.Text = $"Rating: {contentRating}";
        }

        private void xrDateAvailed_BeforePrint(object sender, CancelEventArgs e)
        {
            var label = sender as XRLabel;
            var dateAvailed = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt");
            label.Text = dateAvailed;
        }

        private void xrCinema_BeforePrint(object sender, CancelEventArgs e)
        {
            var label = sender as XRLabel;
            var cinema = GetCurrentColumnValue("TheaterName")?.ToString();
            label.Text = $"Hall: {cinema}";
        }

        private void xrDateReceived_BeforePrint(object sender, CancelEventArgs e)
        {
            var label = sender as XRLabel;
            var dateAvailed = DateTime.Now.ToString("M/d/yy - hh:mm tt");
            label.Text = dateAvailed;
        }

        private void xrSeatLabel_BeforePrint(object sender, CancelEventArgs e)
        {
            var label = sender as XRLabel;
            var seat = GetCurrentColumnValue("SeatLabel")?.ToString();
            label.Text = $"Seat: {seat}";
        }
    }
}
