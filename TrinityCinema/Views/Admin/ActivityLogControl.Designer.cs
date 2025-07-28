namespace TrinityCinema.Views.Admin
{
    partial class ActivityLogControl
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
            this.gcLogs = new DevExpress.XtraGrid.GridControl();
            this.gvActivities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.logDescription = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLogs
            // 
            this.gcLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLogs.Location = new System.Drawing.Point(0, 0);
            this.gcLogs.MainView = this.gvActivities;
            this.gcLogs.Name = "gcLogs";
            this.gcLogs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.logDescription});
            this.gcLogs.Size = new System.Drawing.Size(780, 586);
            this.gcLogs.TabIndex = 0;
            this.gcLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvActivities});
            // 
            // gvActivities
            // 
            this.gvActivities.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvActivities.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvActivities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.timeStamp,
            this.User,
            this.Action,
            this.Description});
            this.gvActivities.GridControl = this.gcLogs;
            this.gvActivities.Name = "gvActivities";
            this.gvActivities.OptionsBehavior.ReadOnly = true;
            this.gvActivities.OptionsView.ShowGroupPanel = false;
            // 
            // timeStamp
            // 
            this.timeStamp.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeStamp.AppearanceCell.Options.UseFont = true;
            this.timeStamp.AppearanceCell.Options.UseTextOptions = true;
            this.timeStamp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.timeStamp.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.timeStamp.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.timeStamp.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.timeStamp.AppearanceHeader.Options.UseBackColor = true;
            this.timeStamp.AppearanceHeader.Options.UseFont = true;
            this.timeStamp.AppearanceHeader.Options.UseTextOptions = true;
            this.timeStamp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.timeStamp.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.timeStamp.Caption = "Time Stamp";
            this.timeStamp.DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt";
            this.timeStamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeStamp.FieldName = "Timestamp";
            this.timeStamp.MinWidth = 25;
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.Visible = true;
            this.timeStamp.VisibleIndex = 0;
            this.timeStamp.Width = 94;
            // 
            // User
            // 
            this.User.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.User.AppearanceCell.Options.UseFont = true;
            this.User.AppearanceCell.Options.UseTextOptions = true;
            this.User.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.User.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.User.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.User.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.User.AppearanceHeader.Options.UseBackColor = true;
            this.User.AppearanceHeader.Options.UseFont = true;
            this.User.AppearanceHeader.Options.UseTextOptions = true;
            this.User.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.User.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.User.Caption = "User";
            this.User.FieldName = "Username";
            this.User.MinWidth = 25;
            this.User.Name = "User";
            this.User.Visible = true;
            this.User.VisibleIndex = 1;
            this.User.Width = 94;
            // 
            // Action
            // 
            this.Action.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Action.AppearanceCell.Options.UseFont = true;
            this.Action.AppearanceCell.Options.UseTextOptions = true;
            this.Action.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Action.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Action.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.Action.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Action.AppearanceHeader.Options.UseBackColor = true;
            this.Action.AppearanceHeader.Options.UseFont = true;
            this.Action.AppearanceHeader.Options.UseTextOptions = true;
            this.Action.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Action.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Action.Caption = "Action";
            this.Action.FieldName = "Action";
            this.Action.MinWidth = 25;
            this.Action.Name = "Action";
            this.Action.Visible = true;
            this.Action.VisibleIndex = 2;
            this.Action.Width = 94;
            // 
            // Description
            // 
            this.Description.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Description.AppearanceCell.Options.UseFont = true;
            this.Description.AppearanceCell.Options.UseTextOptions = true;
            this.Description.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Description.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Description.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.Description.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Description.AppearanceHeader.Options.UseBackColor = true;
            this.Description.AppearanceHeader.Options.UseFont = true;
            this.Description.AppearanceHeader.Options.UseTextOptions = true;
            this.Description.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Description.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Description.Caption = "Description";
            this.Description.ColumnEdit = this.logDescription;
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 25;
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 3;
            this.Description.Width = 94;
            // 
            // logDescription
            // 
            this.logDescription.Name = "logDescription";
            // 
            // ActivityLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcLogs);
            this.Name = "ActivityLogControl";
            this.Size = new System.Drawing.Size(780, 586);
            ((System.ComponentModel.ISupportInitialize)(this.gcLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActivities;
        private DevExpress.XtraGrid.Columns.GridColumn timeStamp;
        private DevExpress.XtraGrid.Columns.GridColumn User;
        private DevExpress.XtraGrid.Columns.GridColumn Action;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit logDescription;
    }
}
