namespace TrinityCinema.Views
{
    partial class AccountCreation
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
            this.components = new System.ComponentModel.Container();
            this.teFullName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.cbRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tePhone = new DevExpress.XtraEditors.TextEdit();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.deDateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teConfirmedPassword = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Fullname = new DevExpress.XtraLayout.LayoutControlItem();
            this.Role = new DevExpress.XtraLayout.LayoutControlItem();
            this.Username = new DevExpress.XtraLayout.LayoutControlItem();
            this.Password = new DevExpress.XtraLayout.LayoutControlItem();
            this.Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.confirmPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DateOfBirth = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.usernameErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.passwordErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.confirmPasswordErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.phoneErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.fullNameErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmedPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fullname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // teFullName
            // 
            this.teFullName.EditValue = "";
            this.teFullName.Location = new System.Drawing.Point(344, 38);
            this.teFullName.Margin = new System.Windows.Forms.Padding(4);
            this.teFullName.Name = "teFullName";
            this.teFullName.Properties.AutoHeight = false;
            this.teFullName.Size = new System.Drawing.Size(302, 45);
            this.teFullName.StyleController = this.layoutControl1;
            this.teFullName.TabIndex = 0;
            this.teFullName.EditValueChanged += new System.EventHandler(this.teFullName_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnBrowse);
            this.layoutControl1.Controls.Add(this.cbRole);
            this.layoutControl1.Controls.Add(this.tePhone);
            this.layoutControl1.Controls.Add(this.teUserName);
            this.layoutControl1.Controls.Add(this.peImage);
            this.layoutControl1.Controls.Add(this.btnSubmit);
            this.layoutControl1.Controls.Add(this.teFullName);
            this.layoutControl1.Controls.Add(this.deDateOfBirth);
            this.layoutControl1.Controls.Add(this.tePassword);
            this.layoutControl1.Controls.Add(this.teConfirmedPassword);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(662, 601);
            this.layoutControl1.TabIndex = 18;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(16, 354);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(308, 55);
            this.btnBrowse.StyleController = this.layoutControl1;
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbRole
            // 
            this.cbRole.Location = new System.Drawing.Point(344, 111);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbRole.Name = "cbRole";
            this.cbRole.Properties.AutoHeight = false;
            this.cbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRole.Properties.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
            this.cbRole.Size = new System.Drawing.Size(148, 34);
            this.cbRole.StyleController = this.layoutControl1;
            this.cbRole.TabIndex = 4;
            // 
            // tePhone
            // 
            this.tePhone.Location = new System.Drawing.Point(344, 173);
            this.tePhone.Margin = new System.Windows.Forms.Padding(4);
            this.tePhone.Name = "tePhone";
            this.tePhone.Properties.AutoHeight = false;
            this.tePhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tePhone.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tePhone.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d-\\d\\d\\d-\\d\\d\\d\\d");
            this.tePhone.Size = new System.Drawing.Size(302, 34);
            this.tePhone.StyleController = this.layoutControl1;
            this.tePhone.TabIndex = 5;
            this.tePhone.EditValueChanged += new System.EventHandler(this.tePhone_EditValueChanged);
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(344, 235);
            this.teUserName.Margin = new System.Windows.Forms.Padding(4);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Size = new System.Drawing.Size(302, 34);
            this.teUserName.StyleController = this.layoutControl1;
            this.teUserName.TabIndex = 2;
            this.teUserName.EditValueChanged += new System.EventHandler(this.teUserName_EditValueChanged);
            // 
            // peImage
            // 
            this.peImage.Location = new System.Drawing.Point(16, 16);
            this.peImage.Margin = new System.Windows.Forms.Padding(4);
            this.peImage.Name = "peImage";
            this.peImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peImage.Size = new System.Drawing.Size(308, 332);
            this.peImage.StyleController = this.layoutControl1;
            this.peImage.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(344, 551);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(302, 34);
            this.btnSubmit.StyleController = this.layoutControl1;
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // deDateOfBirth
            // 
            this.deDateOfBirth.EditValue = null;
            this.deDateOfBirth.Location = new System.Drawing.Point(498, 111);
            this.deDateOfBirth.Name = "deDateOfBirth";
            this.deDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.deDateOfBirth.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.deDateOfBirth.Size = new System.Drawing.Size(148, 34);
            this.deDateOfBirth.StyleController = this.layoutControl1;
            this.deDateOfBirth.TabIndex = 18;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(344, 297);
            this.tePassword.Margin = new System.Windows.Forms.Padding(4);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(302, 34);
            this.tePassword.StyleController = this.layoutControl1;
            this.tePassword.TabIndex = 3;
            this.tePassword.EditValueChanged += new System.EventHandler(this.tePassword_EditValueChanged);
            // 
            // teConfirmedPassword
            // 
            this.teConfirmedPassword.Location = new System.Drawing.Point(344, 359);
            this.teConfirmedPassword.Name = "teConfirmedPassword";
            this.teConfirmedPassword.Properties.UseSystemPasswordChar = true;
            this.teConfirmedPassword.Size = new System.Drawing.Size(302, 34);
            this.teConfirmedPassword.StyleController = this.layoutControl1;
            this.teConfirmedPassword.TabIndex = 19;
            this.teConfirmedPassword.EditValueChanged += new System.EventHandler(this.teConfirmedPassword_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.Fullname,
            this.Role,
            this.Username,
            this.Password,
            this.Phone,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.emptySpaceItem4,
            this.confirmPassword,
            this.layoutControlItem1,
            this.DateOfBirth});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(662, 601);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.peImage;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(26, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(314, 338);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Fullname
            // 
            this.Fullname.Control = this.teFullName;
            this.Fullname.Location = new System.Drawing.Point(328, 0);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(308, 73);
            this.Fullname.TextLocation = DevExpress.Utils.Locations.Top;
            this.Fullname.TextSize = new System.Drawing.Size(104, 16);
            // 
            // Role
            // 
            this.Role.Control = this.cbRole;
            this.Role.Location = new System.Drawing.Point(328, 73);
            this.Role.MinSize = new System.Drawing.Size(110, 62);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(154, 62);
            this.Role.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Role.TextLocation = DevExpress.Utils.Locations.Top;
            this.Role.TextSize = new System.Drawing.Size(104, 16);
            // 
            // Username
            // 
            this.Username.Control = this.teUserName;
            this.Username.Location = new System.Drawing.Point(328, 197);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(308, 62);
            this.Username.TextLocation = DevExpress.Utils.Locations.Top;
            this.Username.TextSize = new System.Drawing.Size(104, 16);
            // 
            // Password
            // 
            this.Password.Control = this.tePassword;
            this.Password.Location = new System.Drawing.Point(328, 259);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(308, 62);
            this.Password.TextLocation = DevExpress.Utils.Locations.Top;
            this.Password.TextSize = new System.Drawing.Size(104, 16);
            // 
            // Phone
            // 
            this.Phone.Control = this.tePhone;
            this.Phone.Location = new System.Drawing.Point(328, 135);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(308, 62);
            this.Phone.TextLocation = DevExpress.Utils.Locations.Top;
            this.Phone.TextSize = new System.Drawing.Size(104, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(328, 383);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(308, 152);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 399);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(314, 176);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnBrowse;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 338);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(57, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(314, 61);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(314, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(14, 575);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Control = this.teConfirmedPassword;
            this.confirmPassword.Location = new System.Drawing.Point(328, 321);
            this.confirmPassword.MinSize = new System.Drawing.Size(110, 62);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(308, 62);
            this.confirmPassword.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.confirmPassword.Text = "Confirm Password";
            this.confirmPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.confirmPassword.TextSize = new System.Drawing.Size(104, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSubmit;
            this.layoutControlItem1.Location = new System.Drawing.Point(328, 535);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(308, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Control = this.deDateOfBirth;
            this.DateOfBirth.Location = new System.Drawing.Point(482, 73);
            this.DateOfBirth.MinSize = new System.Drawing.Size(110, 62);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(154, 62);
            this.DateOfBirth.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.DateOfBirth.Text = "Birthdate";
            this.DateOfBirth.TextLocation = DevExpress.Utils.Locations.Top;
            this.DateOfBirth.TextSize = new System.Drawing.Size(104, 16);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(666, 605);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "groupControl1";
            // 
            // usernameErrorProvider
            // 
            this.usernameErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // confirmPasswordErrorProvider
            // 
            this.confirmPasswordErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // fullNameErrorProvider
            // 
            this.fullNameErrorProvider.ContainerControl = this;
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 605);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountCreation";
            ((System.ComponentModel.ISupportInitialize)(this.teFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmedPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fullname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teFullName;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.TextEdit tePhone;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.ComboBoxEdit cbRole;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem Fullname;
        private DevExpress.XtraLayout.LayoutControlItem Role;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraLayout.LayoutControlItem Username;
        private DevExpress.XtraLayout.LayoutControlItem Password;
        private DevExpress.XtraLayout.LayoutControlItem Phone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DateEdit deDateOfBirth;
        private DevExpress.XtraLayout.LayoutControlItem DateOfBirth;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teConfirmedPassword;
        private DevExpress.XtraLayout.LayoutControlItem confirmPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider usernameErrorProvider;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider passwordErrorProvider;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider confirmPasswordErrorProvider;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider phoneErrorProvider;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider fullNameErrorProvider;
    }
}