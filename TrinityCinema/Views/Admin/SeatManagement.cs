using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using Svg.Transforms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TrinityCinema.Models;
using SvgNet = Svg;


namespace TrinityCinema.Views.Admin
{
    public partial class SeatManagement : DevExpress.XtraEditors.XtraForm
    {
        AllMethods allMethods = new AllMethods();
        public string Id { get; set; }
        private AdminMainForm adminMainForm;
        private int theaterID;
        private SvgNet.SvgDocument svgDoc;
        private const string svgSourcePath = "seatLayout.svg";
        private const string svgModifiedPath = "coloredSeats.svg";


        public SeatManagement(AdminMainForm adminMainForm, int theaterID)
        {
            InitializeComponent();
            this.adminMainForm = adminMainForm;
            this.theaterID = theaterID;
            svgImageBox2.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            LoadSeats();
        }

        public void LoadSeats()
        {
            DataTable seatTable = new DataTable();

            // Step 1: Load seat status from database
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
                {
                    conn.Open();
                    string query = "SELECT ISNULL(seat_Identifier, '') AS SeatID, Status FROM SeatLayouts WHERE HallID = @TheaterID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TheaterID", theaterID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(seatTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return;
            }

            // Step 2: Load original SVG layout
            try
            {
                if (!File.Exists(svgSourcePath))
                {
                    MessageBox.Show("SVG file not found.");
                    return;
                }

                svgDoc = SvgNet.SvgDocument.Open(svgSourcePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load SVG: " + ex.Message);
                return;
            }

            // Step 3: Apply seat status colors
            foreach (DataRow row in seatTable.Rows)
            {
                string seatId = row["SeatID"].ToString().Trim();
                if (seatId == "")
                    continue;

                int status;
                try
                {
                    status = Convert.ToInt32(row["Status"]);
                }
                catch
                {
                    continue;
                }

                SvgNet.SvgElement element = FindElementById(svgDoc, "seat_6");
                if (element == null)
                    continue;

                Color fillColor = Color.Gray;
                if (status == 0)
                    fillColor = Color.LimeGreen;
                else if (status == 1)
                    fillColor = Color.Red;

                SvgNet.SvgGroup group = element as SvgNet.SvgGroup;
                if (group != null)
                {
                    foreach (object child in group.Children)
                    {
                        SvgNet.SvgVisualElement visual = child as SvgNet.SvgVisualElement;
                        if (visual != null)
                        {
                            visual.Fill = new SvgNet.SvgColourServer(fillColor);
                        }
                    }
                }
                else
                {
                    SvgNet.SvgVisualElement visual = element as SvgNet.SvgVisualElement;
                    if (visual != null)
                    {
                        visual.Fill = new SvgNet.SvgColourServer(fillColor);
                    }
                }
            }

            // Step 4: Display updated SVG directly
            try
            {
                using (MemoryStream mem = new MemoryStream())
                {
                    svgDoc.Write(mem);
                    mem.Position = 0;
                    SvgImage image = SvgImage.FromStream(mem);
                    svgImageBox2.SvgImage = image;
                }

                svgImageBox2.Invalidate();
                svgImageBox2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to display SVG: " + ex.Message);
            }
        }



        private SvgNet.SvgElement FindElementById(SvgNet.SvgElement root, string id)
        {
            if (root.ID == id)
                return root;

            foreach (object child in root.Children)
            {
                SvgNet.SvgElement element = child as SvgNet.SvgElement;
                if (element != null)
                {
                    SvgNet.SvgElement found = FindElementById(element, id);
                    if (found != null)
                        return found;
                }
            }

            return null;
        }



        private void svgImageBox2_ItemClick(object sender, SvgImageItemMouseEventArgs e)
        {
            SvgImageItem clickedItem = e.Item;

            SvgImageItem parent = clickedItem;

            // Traverse upwards to find a group with id like "seat_#"
            while (parent != null && !parent.Id.StartsWith("seat_"))
            {
                parent = parent.Parent;
            }

            string seatGroupId = parent?.Id;

            if (!string.IsNullOrEmpty(seatGroupId))
            {
                MessageBox.Show($"Seat Group ID clicked: {seatGroupId}");
            }
            else
            {
                MessageBox.Show("No seat group ID found.");
            }


        }
    }

    }

