using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using SvgNet = Svg;

namespace TrinityCinema.Views
{
    public partial class AdminHome : DevExpress.XtraEditors.XtraForm
    {
        public AdminHome()
        {
            InitializeComponent();
            ReflectSeatStatusFromDatabase_SvgNet();
        }

        public void ReflectSeatStatusFromDatabase_SvgNet()
        {
            // STEP 1: Load seat status from DB into dictionary
            var seatStatus = new Dictionary<string, int>();

            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();
                string query = "SELECT seat_Identifier, Status FROM SeatLayouts";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Check for NULL values to avoid exceptions
                        if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                        {
                            string id = reader.GetString(0).Trim();
                            int status = reader.GetInt32(1);
                            seatStatus[id] = status; // If seatStatus is still Dictionary<string, string>

                        }
                        else
                        {
                            Console.WriteLine("Skipped row with NULL seat_Identifier or Status.");
                        }
                    }
                }
            }

            // STEP 2: Load SVG document using Svg.NET
            SvgNet.SvgDocument svgDoc = SvgNet.SvgDocument.Open("seatLayout.svg");
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            Bitmap bmp = new Bitmap(width, height);
            svgDoc.Draw(bmp);

            // PictureBox setup
            pictureBox1.Image = bmp;
            pictureBox1.Dock = DockStyle.Fill;


            // STEP 3: Loop through seat groups by ID and apply color
            foreach (var seatId in seatStatus.Keys)
            {
                SvgNet.SvgElement groupElement = svgDoc.GetElementById(seatId);
                if (groupElement is SvgNet.SvgGroup group)
                {
                    int status = seatStatus[seatId];
                    System.Drawing.Color fillColor = System.Drawing.Color.Gray;

                    if (status == 0)
                        fillColor = System.Drawing.Color.LimeGreen;
                    else if (status == 1)
                        fillColor = System.Drawing.Color.Red;
                  

                    // Apply fill color to all child paths
                    foreach (var child in group.Children)
                    {
                        if (child is SvgNet.SvgPath path)
                        {
                            path.Fill = new SvgNet.SvgColourServer(fillColor);
                        }
                    }
                }
            }

            // STEP 4: Save modified SVG to file
            svgDoc.Write("seatingChart_modified.svg");

            // Optional: Reload into DevExpress SvgImageBox
            // svgImageBox2.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile("seatingChart_modified.svg");
        }





        private void svgImageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}