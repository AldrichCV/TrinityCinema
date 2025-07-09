namespace TrinityCinema.Views.Admin
{
    partial class EditShowtime
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.cbStatusDisplay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTheater = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.deShowDate = new DevExpress.XtraEditors.DateEdit();
            this.leMovie = new DevExpress.XtraEditors.LookUpEdit();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusDisplay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTheater.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMovie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(259, 230);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 16);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Status";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(45, 230);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 16);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Theater";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(474, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Start Time";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(259, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Show Date";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(42, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Price";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(42, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Movie";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Appearance.Options.UseBackColor = true;
            this.btnSubmit.Location = new System.Drawing.Point(457, 397);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 56);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            // 
            // cbStatusDisplay
            // 
            this.cbStatusDisplay.Location = new System.Drawing.Point(259, 252);
            this.cbStatusDisplay.Name = "cbStatusDisplay";
            this.cbStatusDisplay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatusDisplay.Properties.Items.AddRange(new object[] {
            "Upcoming",
            "Now Showing",
            "Cancelled",
            "Ended"});
            this.cbStatusDisplay.Size = new System.Drawing.Size(154, 34);
            this.cbStatusDisplay.TabIndex = 20;
            // 
            // cbTheater
            // 
            this.cbTheater.Location = new System.Drawing.Point(45, 252);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTheater.Properties.Items.AddRange(new object[] {
            "Cinema 1",
            "Cinema 2",
            "Cinema 3",
            "Cinema 4"});
            this.cbTheater.Size = new System.Drawing.Size(154, 34);
            this.cbTheater.TabIndex = 19;
            // 
            // teStartTime
            // 
            this.teStartTime.EditValue = new System.DateTime(2025, 7, 7, 0, 0, 0, 0);
            this.teStartTime.Location = new System.Drawing.Point(474, 158);
            this.teStartTime.Name = "teStartTime";
            this.teStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teStartTime.Properties.MaskSettings.Set("mask", "t");
            this.teStartTime.Size = new System.Drawing.Size(154, 34);
            this.teStartTime.TabIndex = 18;
            // 
            // deShowDate
            // 
            this.deShowDate.EditValue = null;
            this.deShowDate.Location = new System.Drawing.Point(259, 158);
            this.deShowDate.Name = "deShowDate";
            this.deShowDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deShowDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deShowDate.Properties.MaskSettings.Set("mask", "d");
            this.deShowDate.Size = new System.Drawing.Size(154, 34);
            this.deShowDate.TabIndex = 17;
            // 
            // leMovie
            // 
            this.leMovie.Location = new System.Drawing.Point(42, 74);
            this.leMovie.Name = "leMovie";
            this.leMovie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leMovie.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MovieID", "Movie ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title")});
            this.leMovie.Properties.DisplayMember = "Title";
            this.leMovie.Properties.NullText = "--Select Movie--";
            this.leMovie.Properties.ValueMember = "MovieID";
            this.leMovie.Size = new System.Drawing.Size(589, 34);
            this.leMovie.TabIndex = 15;
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(42, 158);
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tePrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tePrice.Properties.MaskSettings.Set("mask", "c");
            this.tePrice.Size = new System.Drawing.Size(157, 34);
            this.tePrice.TabIndex = 16;
            // 
            // EditShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 474);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbStatusDisplay);
            this.Controls.Add(this.cbTheater);
            this.Controls.Add(this.teStartTime);
            this.Controls.Add(this.deShowDate);
            this.Controls.Add(this.leMovie);
            this.Controls.Add(this.tePrice);
            this.Name = "EditShowtime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Showtime";
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusDisplay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTheater.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deShowDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMovie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatusDisplay;
        private DevExpress.XtraEditors.ComboBoxEdit cbTheater;
        private DevExpress.XtraEditors.TimeEdit teStartTime;
        private DevExpress.XtraEditors.DateEdit deShowDate;
        private DevExpress.XtraEditors.LookUpEdit leMovie;
        private DevExpress.XtraEditors.TextEdit tePrice;
    }
}