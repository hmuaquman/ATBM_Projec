namespace ATBM_APP
{
    partial class AdminForm
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
            this.saGridView = new System.Windows.Forms.DataGridView();
            this.privGridView = new System.Windows.Forms.DataGridView();
            this.privTabPage = new System.Windows.Forms.TabPage();
            this.objPLComboBox = new System.Windows.Forms.ComboBox();
            this.checkPrivilegeButton = new System.Windows.Forms.Button();
            this.grantUsrButton = new System.Windows.Forms.Button();
            this.revokePrivButton = new System.Windows.Forms.Button();
            this.colPLComboBox = new System.Windows.Forms.ComboBox();
            this.colPLLabel = new System.Windows.Forms.Label();
            this.privPLCheckBox = new System.Windows.Forms.CheckBox();
            this.privPLComboBox = new System.Windows.Forms.ComboBox();
            this.privPLLabel = new System.Windows.Forms.Label();
            this.objPLLabel = new System.Windows.Forms.Label();
            this.userPLLabel = new System.Windows.Forms.Label();
            this.userPLTextBox = new System.Windows.Forms.TextBox();
            this.roleGridView = new System.Windows.Forms.DataGridView();
            this.roleTabPage = new System.Windows.Forms.TabPage();
            this.checkRoleButton = new System.Windows.Forms.Button();
            this.revokeRoleButton = new System.Windows.Forms.Button();
            this.grantRoleButton = new System.Windows.Forms.Button();
            this.dropRoleButton = new System.Windows.Forms.Button();
            this.createRoleButton = new System.Windows.Forms.Button();
            this.userRLLabel = new System.Windows.Forms.Label();
            this.roleRLLabel = new System.Windows.Forms.Label();
            this.userRLTextBox = new System.Windows.Forms.TextBox();
            this.roleRLTextBox = new System.Windows.Forms.TextBox();
            this.saTabPage = new System.Windows.Forms.TabPage();
            this.usrSALabel = new System.Windows.Forms.Label();
            this.saauditSearchTextBox = new System.Windows.Forms.TextBox();
            this.offsaButton = new System.Windows.Forms.Button();
            this.onSAButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.logoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.admTabControl = new System.Windows.Forms.TabControl();
            this.fgaTabPage = new System.Windows.Forms.TabPage();
            this.fgausrPCLabel = new System.Windows.Forms.Label();
            this.fgaPCSearchTextBox = new System.Windows.Forms.TextBox();
            this.fgapcnsGridView = new System.Windows.Forms.DataGridView();
            this.fgausrDKLabel = new System.Windows.Forms.Label();
            this.fgaDKSearchTextBox = new System.Windows.Forms.TextBox();
            this.fgadkGridView = new System.Windows.Forms.DataGridView();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.usrUSTextBox = new System.Windows.Forms.TextBox();
            this.pwUSTextBox = new System.Windows.Forms.TextBox();
            this.usrUSLabel = new System.Windows.Forms.Label();
            this.pwUSLabel = new System.Windows.Forms.Label();
            this.changePassButtton = new System.Windows.Forms.Button();
            this.dropUsButton = new System.Windows.Forms.Button();
            this.createUsButton = new System.Windows.Forms.Button();
            this.userTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.saGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privGridView)).BeginInit();
            this.privTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).BeginInit();
            this.roleTabPage.SuspendLayout();
            this.saTabPage.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.admTabControl.SuspendLayout();
            this.fgaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgapcnsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgadkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.userTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // saGridView
            // 
            this.saGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saGridView.Location = new System.Drawing.Point(25, 55);
            this.saGridView.Name = "saGridView";
            this.saGridView.RowHeadersWidth = 51;
            this.saGridView.RowTemplate.Height = 24;
            this.saGridView.Size = new System.Drawing.Size(888, 371);
            this.saGridView.TabIndex = 2;
            // 
            // privGridView
            // 
            this.privGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.privGridView.Location = new System.Drawing.Point(22, 21);
            this.privGridView.Name = "privGridView";
            this.privGridView.RowHeadersWidth = 51;
            this.privGridView.RowTemplate.Height = 24;
            this.privGridView.Size = new System.Drawing.Size(633, 410);
            this.privGridView.TabIndex = 2;
            // 
            // privTabPage
            // 
            this.privTabPage.Controls.Add(this.objPLComboBox);
            this.privTabPage.Controls.Add(this.checkPrivilegeButton);
            this.privTabPage.Controls.Add(this.grantUsrButton);
            this.privTabPage.Controls.Add(this.revokePrivButton);
            this.privTabPage.Controls.Add(this.colPLComboBox);
            this.privTabPage.Controls.Add(this.colPLLabel);
            this.privTabPage.Controls.Add(this.privPLCheckBox);
            this.privTabPage.Controls.Add(this.privPLComboBox);
            this.privTabPage.Controls.Add(this.privPLLabel);
            this.privTabPage.Controls.Add(this.objPLLabel);
            this.privTabPage.Controls.Add(this.userPLLabel);
            this.privTabPage.Controls.Add(this.userPLTextBox);
            this.privTabPage.Controls.Add(this.privGridView);
            this.privTabPage.Location = new System.Drawing.Point(4, 27);
            this.privTabPage.Name = "privTabPage";
            this.privTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.privTabPage.Size = new System.Drawing.Size(936, 449);
            this.privTabPage.TabIndex = 2;
            this.privTabPage.Text = "Privilege";
            this.privTabPage.UseVisualStyleBackColor = true;
            this.privTabPage.Enter += new System.EventHandler(this.privTabPage_Enter);
            // 
            // objPLComboBox
            // 
            this.objPLComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.objPLComboBox.FormattingEnabled = true;
            this.objPLComboBox.Items.AddRange(new object[] {
            "SINHVIEN",
            "NHANSU",
            "HOCPHAN",
            "DONVI",
            "PHANCONG",
            "KHMO",
            "DANGKY"});
            this.objPLComboBox.Location = new System.Drawing.Point(778, 62);
            this.objPLComboBox.Name = "objPLComboBox";
            this.objPLComboBox.Size = new System.Drawing.Size(121, 30);
            this.objPLComboBox.TabIndex = 38;
            this.objPLComboBox.SelectedIndexChanged += new System.EventHandler(this.objPLComboBox_SelectedIndexChanged);
            // 
            // checkPrivilegeButton
            // 
            this.checkPrivilegeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkPrivilegeButton.Location = new System.Drawing.Point(697, 366);
            this.checkPrivilegeButton.Name = "checkPrivilegeButton";
            this.checkPrivilegeButton.Size = new System.Drawing.Size(203, 39);
            this.checkPrivilegeButton.TabIndex = 37;
            this.checkPrivilegeButton.Text = "Check Privilege";
            this.checkPrivilegeButton.UseVisualStyleBackColor = true;
            this.checkPrivilegeButton.Click += new System.EventHandler(this.checkPrivilegeButton_Click);
            // 
            // grantUsrButton
            // 
            this.grantUsrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grantUsrButton.Location = new System.Drawing.Point(697, 238);
            this.grantUsrButton.Name = "grantUsrButton";
            this.grantUsrButton.Size = new System.Drawing.Size(203, 47);
            this.grantUsrButton.TabIndex = 36;
            this.grantUsrButton.Text = "Grant For User/Role";
            this.grantUsrButton.UseVisualStyleBackColor = true;
            this.grantUsrButton.Click += new System.EventHandler(this.grantUsrButton_Click);
            // 
            // revokePrivButton
            // 
            this.revokePrivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.revokePrivButton.Location = new System.Drawing.Point(697, 303);
            this.revokePrivButton.Name = "revokePrivButton";
            this.revokePrivButton.Size = new System.Drawing.Size(203, 39);
            this.revokePrivButton.TabIndex = 35;
            this.revokePrivButton.Text = "Revoke ";
            this.revokePrivButton.UseVisualStyleBackColor = true;
            this.revokePrivButton.Click += new System.EventHandler(this.revokePrivButton_Click);
            // 
            // colPLComboBox
            // 
            this.colPLComboBox.AllowDrop = true;
            this.colPLComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colPLComboBox.FormattingEnabled = true;
            this.colPLComboBox.Items.AddRange(new object[] {
            "None"});
            this.colPLComboBox.Location = new System.Drawing.Point(778, 180);
            this.colPLComboBox.Name = "colPLComboBox";
            this.colPLComboBox.Size = new System.Drawing.Size(122, 28);
            this.colPLComboBox.TabIndex = 34;
            this.colPLComboBox.SelectedIndexChanged += new System.EventHandler(this.colPLComboBox_SelectedIndexChanged);
            // 
            // colPLLabel
            // 
            this.colPLLabel.AutoSize = true;
            this.colPLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colPLLabel.Location = new System.Drawing.Point(693, 183);
            this.colPLLabel.Name = "colPLLabel";
            this.colPLLabel.Size = new System.Drawing.Size(66, 20);
            this.colPLLabel.TabIndex = 33;
            this.colPLLabel.Text = "Column";
            // 
            // privPLCheckBox
            // 
            this.privPLCheckBox.AutoSize = true;
            this.privPLCheckBox.Location = new System.Drawing.Point(778, 149);
            this.privPLCheckBox.Name = "privPLCheckBox";
            this.privPLCheckBox.Size = new System.Drawing.Size(149, 22);
            this.privPLCheckBox.TabIndex = 32;
            this.privPLCheckBox.Text = "With Grant Option";
            this.privPLCheckBox.UseVisualStyleBackColor = true;
            // 
            // privPLComboBox
            // 
            this.privPLComboBox.AllowDrop = true;
            this.privPLComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.privPLComboBox.FormattingEnabled = true;
            this.privPLComboBox.Items.AddRange(new object[] {
            "Select",
            "Update",
            "Insert",
            "Delete"});
            this.privPLComboBox.Location = new System.Drawing.Point(778, 105);
            this.privPLComboBox.Name = "privPLComboBox";
            this.privPLComboBox.Size = new System.Drawing.Size(122, 28);
            this.privPLComboBox.TabIndex = 31;
            this.privPLComboBox.SelectedIndexChanged += new System.EventHandler(this.privPLComboBox_SelectedIndexChanged);
            // 
            // privPLLabel
            // 
            this.privPLLabel.AutoSize = true;
            this.privPLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.privPLLabel.Location = new System.Drawing.Point(693, 108);
            this.privPLLabel.Name = "privPLLabel";
            this.privPLLabel.Size = new System.Drawing.Size(73, 20);
            this.privPLLabel.TabIndex = 30;
            this.privPLLabel.Text = "Privilege";
            // 
            // objPLLabel
            // 
            this.objPLLabel.AutoSize = true;
            this.objPLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.objPLLabel.Location = new System.Drawing.Point(693, 67);
            this.objPLLabel.Name = "objPLLabel";
            this.objPLLabel.Size = new System.Drawing.Size(58, 20);
            this.objPLLabel.TabIndex = 29;
            this.objPLLabel.Text = "Object";
            // 
            // userPLLabel
            // 
            this.userPLLabel.AutoSize = true;
            this.userPLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userPLLabel.Location = new System.Drawing.Point(682, 26);
            this.userPLLabel.Name = "userPLLabel";
            this.userPLLabel.Size = new System.Drawing.Size(84, 20);
            this.userPLLabel.TabIndex = 28;
            this.userPLLabel.Text = "User/Role";
            // 
            // userPLTextBox
            // 
            this.userPLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.userPLTextBox.Location = new System.Drawing.Point(778, 21);
            this.userPLTextBox.Name = "userPLTextBox";
            this.userPLTextBox.Size = new System.Drawing.Size(122, 28);
            this.userPLTextBox.TabIndex = 27;
            // 
            // roleGridView
            // 
            this.roleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleGridView.Location = new System.Drawing.Point(23, 21);
            this.roleGridView.Name = "roleGridView";
            this.roleGridView.RowHeadersWidth = 51;
            this.roleGridView.RowTemplate.Height = 24;
            this.roleGridView.Size = new System.Drawing.Size(683, 384);
            this.roleGridView.TabIndex = 2;
            // 
            // roleTabPage
            // 
            this.roleTabPage.Controls.Add(this.checkRoleButton);
            this.roleTabPage.Controls.Add(this.revokeRoleButton);
            this.roleTabPage.Controls.Add(this.grantRoleButton);
            this.roleTabPage.Controls.Add(this.dropRoleButton);
            this.roleTabPage.Controls.Add(this.createRoleButton);
            this.roleTabPage.Controls.Add(this.userRLLabel);
            this.roleTabPage.Controls.Add(this.roleRLLabel);
            this.roleTabPage.Controls.Add(this.userRLTextBox);
            this.roleTabPage.Controls.Add(this.roleRLTextBox);
            this.roleTabPage.Controls.Add(this.roleGridView);
            this.roleTabPage.Location = new System.Drawing.Point(4, 27);
            this.roleTabPage.Name = "roleTabPage";
            this.roleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roleTabPage.Size = new System.Drawing.Size(936, 449);
            this.roleTabPage.TabIndex = 1;
            this.roleTabPage.Text = "Role";
            this.roleTabPage.UseVisualStyleBackColor = true;
            this.roleTabPage.Enter += new System.EventHandler(this.roleTabPage_Enter);
            // 
            // checkRoleButton
            // 
            this.checkRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkRoleButton.Location = new System.Drawing.Point(751, 371);
            this.checkRoleButton.Name = "checkRoleButton";
            this.checkRoleButton.Size = new System.Drawing.Size(159, 39);
            this.checkRoleButton.TabIndex = 25;
            this.checkRoleButton.Text = "Check Role";
            this.checkRoleButton.UseVisualStyleBackColor = true;
            this.checkRoleButton.Click += new System.EventHandler(this.checkRoleButton_Click);
            // 
            // revokeRoleButton
            // 
            this.revokeRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.revokeRoleButton.Location = new System.Drawing.Point(751, 309);
            this.revokeRoleButton.Name = "revokeRoleButton";
            this.revokeRoleButton.Size = new System.Drawing.Size(159, 39);
            this.revokeRoleButton.TabIndex = 24;
            this.revokeRoleButton.Text = "Revoke Role";
            this.revokeRoleButton.UseVisualStyleBackColor = true;
            this.revokeRoleButton.Click += new System.EventHandler(this.revokeRoleButton_Click);
            // 
            // grantRoleButton
            // 
            this.grantRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grantRoleButton.Location = new System.Drawing.Point(751, 245);
            this.grantRoleButton.Name = "grantRoleButton";
            this.grantRoleButton.Size = new System.Drawing.Size(159, 39);
            this.grantRoleButton.TabIndex = 23;
            this.grantRoleButton.Text = "Grant Role";
            this.grantRoleButton.UseVisualStyleBackColor = true;
            this.grantRoleButton.Click += new System.EventHandler(this.grantRoleButton_Click);
            // 
            // dropRoleButton
            // 
            this.dropRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dropRoleButton.Location = new System.Drawing.Point(751, 184);
            this.dropRoleButton.Name = "dropRoleButton";
            this.dropRoleButton.Size = new System.Drawing.Size(159, 39);
            this.dropRoleButton.TabIndex = 22;
            this.dropRoleButton.Text = "Drop Role";
            this.dropRoleButton.UseVisualStyleBackColor = true;
            this.dropRoleButton.Click += new System.EventHandler(this.dropRoleButton_Click);
            // 
            // createRoleButton
            // 
            this.createRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createRoleButton.Location = new System.Drawing.Point(751, 121);
            this.createRoleButton.Name = "createRoleButton";
            this.createRoleButton.Size = new System.Drawing.Size(159, 39);
            this.createRoleButton.TabIndex = 21;
            this.createRoleButton.Text = "Create Role";
            this.createRoleButton.UseVisualStyleBackColor = true;
            this.createRoleButton.Click += new System.EventHandler(this.createRoleButton_Click);
            // 
            // userRLLabel
            // 
            this.userRLLabel.AutoSize = true;
            this.userRLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userRLLabel.Location = new System.Drawing.Point(727, 67);
            this.userRLLabel.Name = "userRLLabel";
            this.userRLLabel.Size = new System.Drawing.Size(45, 20);
            this.userRLLabel.TabIndex = 20;
            this.userRLLabel.Text = "User";
            // 
            // roleRLLabel
            // 
            this.roleRLLabel.AutoSize = true;
            this.roleRLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roleRLLabel.Location = new System.Drawing.Point(729, 26);
            this.roleRLLabel.Name = "roleRLLabel";
            this.roleRLLabel.Size = new System.Drawing.Size(43, 20);
            this.roleRLLabel.TabIndex = 19;
            this.roleRLLabel.Text = "Role";
            // 
            // userRLTextBox
            // 
            this.userRLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.userRLTextBox.Location = new System.Drawing.Point(788, 62);
            this.userRLTextBox.Name = "userRLTextBox";
            this.userRLTextBox.Size = new System.Drawing.Size(122, 28);
            this.userRLTextBox.TabIndex = 18;
            // 
            // roleRLTextBox
            // 
            this.roleRLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.roleRLTextBox.Location = new System.Drawing.Point(788, 21);
            this.roleRLTextBox.Name = "roleRLTextBox";
            this.roleRLTextBox.Size = new System.Drawing.Size(122, 28);
            this.roleRLTextBox.TabIndex = 17;
            // 
            // saTabPage
            // 
            this.saTabPage.Controls.Add(this.usrSALabel);
            this.saTabPage.Controls.Add(this.saauditSearchTextBox);
            this.saTabPage.Controls.Add(this.offsaButton);
            this.saTabPage.Controls.Add(this.onSAButton);
            this.saTabPage.Controls.Add(this.saGridView);
            this.saTabPage.Location = new System.Drawing.Point(4, 27);
            this.saTabPage.Name = "saTabPage";
            this.saTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.saTabPage.Size = new System.Drawing.Size(936, 449);
            this.saTabPage.TabIndex = 3;
            this.saTabPage.Text = "Standard Audit";
            this.saTabPage.UseVisualStyleBackColor = true;
            this.saTabPage.Enter += new System.EventHandler(this.saTabPage_Enter);
            // 
            // usrSALabel
            // 
            this.usrSALabel.AutoSize = true;
            this.usrSALabel.Location = new System.Drawing.Point(34, 23);
            this.usrSALabel.Name = "usrSALabel";
            this.usrSALabel.Size = new System.Drawing.Size(40, 18);
            this.usrSALabel.TabIndex = 6;
            this.usrSALabel.Text = "User";
            // 
            // saauditSearchTextBox
            // 
            this.saauditSearchTextBox.Location = new System.Drawing.Point(80, 20);
            this.saauditSearchTextBox.Name = "saauditSearchTextBox";
            this.saauditSearchTextBox.Size = new System.Drawing.Size(179, 24);
            this.saauditSearchTextBox.TabIndex = 5;
            this.saauditSearchTextBox.TextChanged += new System.EventHandler(this.saauditSearchTextBox_TextChanged);
            // 
            // offsaButton
            // 
            this.offsaButton.Location = new System.Drawing.Point(838, 16);
            this.offsaButton.Name = "offsaButton";
            this.offsaButton.Size = new System.Drawing.Size(75, 33);
            this.offsaButton.TabIndex = 4;
            this.offsaButton.Text = "Tắt";
            this.offsaButton.UseVisualStyleBackColor = true;
            this.offsaButton.Click += new System.EventHandler(this.offsaButton_Click);
            // 
            // onSAButton
            // 
            this.onSAButton.Location = new System.Drawing.Point(743, 16);
            this.onSAButton.Name = "onSAButton";
            this.onSAButton.Size = new System.Drawing.Size(75, 33);
            this.onSAButton.TabIndex = 3;
            this.onSAButton.Text = "Bật ";
            this.onSAButton.UseVisualStyleBackColor = true;
            this.onSAButton.Click += new System.EventHandler(this.onSAButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.helloLabel.Location = new System.Drawing.Point(685, 29);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(117, 18);
            this.helloLabel.TabIndex = 19;
            this.helloLabel.Text = "Xin chào ADMIN";
            // 
            // logoutItem
            // 
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(146, 24);
            this.logoutItem.Text = "Đăng xuất";
            this.logoutItem.Click += new System.EventHandler(this.logoutItem_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutItem});
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(147, 28);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(125, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(368, 39);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Quản lý dữ liệu nội bộ";
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.menu;
            this.icon.Location = new System.Drawing.Point(864, 16);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(92, 86);
            this.icon.TabIndex = 16;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(16, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(92, 86);
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // admTabControl
            // 
            this.admTabControl.Controls.Add(this.userTabPage);
            this.admTabControl.Controls.Add(this.roleTabPage);
            this.admTabControl.Controls.Add(this.privTabPage);
            this.admTabControl.Controls.Add(this.saTabPage);
            this.admTabControl.Controls.Add(this.fgaTabPage);
            this.admTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.admTabControl.Location = new System.Drawing.Point(16, 129);
            this.admTabControl.Name = "admTabControl";
            this.admTabControl.SelectedIndex = 0;
            this.admTabControl.Size = new System.Drawing.Size(944, 480);
            this.admTabControl.TabIndex = 18;
            // 
            // fgaTabPage
            // 
            this.fgaTabPage.Controls.Add(this.fgausrPCLabel);
            this.fgaTabPage.Controls.Add(this.fgaPCSearchTextBox);
            this.fgaTabPage.Controls.Add(this.fgapcnsGridView);
            this.fgaTabPage.Controls.Add(this.fgausrDKLabel);
            this.fgaTabPage.Controls.Add(this.fgaDKSearchTextBox);
            this.fgaTabPage.Controls.Add(this.fgadkGridView);
            this.fgaTabPage.Location = new System.Drawing.Point(4, 27);
            this.fgaTabPage.Name = "fgaTabPage";
            this.fgaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fgaTabPage.Size = new System.Drawing.Size(936, 449);
            this.fgaTabPage.TabIndex = 5;
            this.fgaTabPage.Text = "Fine Grained Audit";
            this.fgaTabPage.UseVisualStyleBackColor = true;
            this.fgaTabPage.Enter += new System.EventHandler(this.fgaTabPage_Enter);
            // 
            // fgausrPCLabel
            // 
            this.fgausrPCLabel.AutoSize = true;
            this.fgausrPCLabel.Location = new System.Drawing.Point(33, 237);
            this.fgausrPCLabel.Name = "fgausrPCLabel";
            this.fgausrPCLabel.Size = new System.Drawing.Size(40, 18);
            this.fgausrPCLabel.TabIndex = 14;
            this.fgausrPCLabel.Text = "User";
            // 
            // fgaPCSearchTextBox
            // 
            this.fgaPCSearchTextBox.Location = new System.Drawing.Point(79, 234);
            this.fgaPCSearchTextBox.Name = "fgaPCSearchTextBox";
            this.fgaPCSearchTextBox.Size = new System.Drawing.Size(179, 24);
            this.fgaPCSearchTextBox.TabIndex = 13;
            this.fgaPCSearchTextBox.TextChanged += new System.EventHandler(this.fgaPCSearchTextBox_TextChanged);
            // 
            // fgapcnsGridView
            // 
            this.fgapcnsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fgapcnsGridView.Location = new System.Drawing.Point(24, 264);
            this.fgapcnsGridView.Name = "fgapcnsGridView";
            this.fgapcnsGridView.RowHeadersWidth = 51;
            this.fgapcnsGridView.RowTemplate.Height = 24;
            this.fgapcnsGridView.Size = new System.Drawing.Size(888, 158);
            this.fgapcnsGridView.TabIndex = 12;
            // 
            // fgausrDKLabel
            // 
            this.fgausrDKLabel.AutoSize = true;
            this.fgausrDKLabel.Location = new System.Drawing.Point(33, 22);
            this.fgausrDKLabel.Name = "fgausrDKLabel";
            this.fgausrDKLabel.Size = new System.Drawing.Size(40, 18);
            this.fgausrDKLabel.TabIndex = 11;
            this.fgausrDKLabel.Text = "User";
            // 
            // fgaDKSearchTextBox
            // 
            this.fgaDKSearchTextBox.Location = new System.Drawing.Point(79, 19);
            this.fgaDKSearchTextBox.Name = "fgaDKSearchTextBox";
            this.fgaDKSearchTextBox.Size = new System.Drawing.Size(179, 24);
            this.fgaDKSearchTextBox.TabIndex = 10;
            this.fgaDKSearchTextBox.TextChanged += new System.EventHandler(this.fgaDKSearchTextBox_TextChanged);
            // 
            // fgadkGridView
            // 
            this.fgadkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fgadkGridView.Location = new System.Drawing.Point(24, 54);
            this.fgadkGridView.Name = "fgadkGridView";
            this.fgadkGridView.RowHeadersWidth = 51;
            this.fgadkGridView.RowTemplate.Height = 24;
            this.fgadkGridView.Size = new System.Drawing.Size(888, 158);
            this.fgadkGridView.TabIndex = 7;
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(23, 19);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowHeadersWidth = 51;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(707, 384);
            this.userGridView.TabIndex = 2;
            // 
            // usrUSTextBox
            // 
            this.usrUSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usrUSTextBox.Location = new System.Drawing.Point(753, 61);
            this.usrUSTextBox.Name = "usrUSTextBox";
            this.usrUSTextBox.Size = new System.Drawing.Size(158, 28);
            this.usrUSTextBox.TabIndex = 11;
            // 
            // pwUSTextBox
            // 
            this.pwUSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pwUSTextBox.Location = new System.Drawing.Point(752, 128);
            this.pwUSTextBox.Name = "pwUSTextBox";
            this.pwUSTextBox.Size = new System.Drawing.Size(158, 28);
            this.pwUSTextBox.TabIndex = 12;
            // 
            // usrUSLabel
            // 
            this.usrUSLabel.AutoSize = true;
            this.usrUSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usrUSLabel.Location = new System.Drawing.Point(749, 38);
            this.usrUSLabel.Name = "usrUSLabel";
            this.usrUSLabel.Size = new System.Drawing.Size(0, 20);
            this.usrUSLabel.TabIndex = 13;
            // 
            // pwUSLabel
            // 
            this.pwUSLabel.AutoSize = true;
            this.pwUSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pwUSLabel.Location = new System.Drawing.Point(752, 96);
            this.pwUSLabel.Name = "pwUSLabel";
            this.pwUSLabel.Size = new System.Drawing.Size(0, 20);
            this.pwUSLabel.TabIndex = 14;
            // 
            // changePassButtton
            // 
            this.changePassButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changePassButtton.Location = new System.Drawing.Point(751, 316);
            this.changePassButtton.Name = "changePassButtton";
            this.changePassButtton.Size = new System.Drawing.Size(159, 39);
            this.changePassButtton.TabIndex = 15;
            this.changePassButtton.Text = "Change Password";
            this.changePassButtton.UseVisualStyleBackColor = true;
            this.changePassButtton.Click += new System.EventHandler(this.changePassButtton_Click);
            // 
            // dropUsButton
            // 
            this.dropUsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dropUsButton.Location = new System.Drawing.Point(751, 246);
            this.dropUsButton.Name = "dropUsButton";
            this.dropUsButton.Size = new System.Drawing.Size(159, 39);
            this.dropUsButton.TabIndex = 16;
            this.dropUsButton.Text = "Drop User";
            this.dropUsButton.UseVisualStyleBackColor = true;
            this.dropUsButton.Click += new System.EventHandler(this.dropUsButton_Click);
            // 
            // createUsButton
            // 
            this.createUsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createUsButton.Location = new System.Drawing.Point(751, 176);
            this.createUsButton.Name = "createUsButton";
            this.createUsButton.Size = new System.Drawing.Size(159, 39);
            this.createUsButton.TabIndex = 17;
            this.createUsButton.Text = "Create User";
            this.createUsButton.UseVisualStyleBackColor = true;
            this.createUsButton.Click += new System.EventHandler(this.createUsButton_Click);
            // 
            // userTabPage
            // 
            this.userTabPage.Controls.Add(this.createUsButton);
            this.userTabPage.Controls.Add(this.dropUsButton);
            this.userTabPage.Controls.Add(this.changePassButtton);
            this.userTabPage.Controls.Add(this.pwUSLabel);
            this.userTabPage.Controls.Add(this.usrUSLabel);
            this.userTabPage.Controls.Add(this.pwUSTextBox);
            this.userTabPage.Controls.Add(this.usrUSTextBox);
            this.userTabPage.Controls.Add(this.userGridView);
            this.userTabPage.Location = new System.Drawing.Point(4, 27);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(936, 449);
            this.userTabPage.TabIndex = 0;
            this.userTabPage.Text = "User";
            this.userTabPage.UseVisualStyleBackColor = true;
            this.userTabPage.Enter += new System.EventHandler(this.userTabPage_Enter);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 621);
            this.Controls.Add(this.admTabControl);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.logo);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privGridView)).EndInit();
            this.privTabPage.ResumeLayout(false);
            this.privTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).EndInit();
            this.roleTabPage.ResumeLayout(false);
            this.roleTabPage.PerformLayout();
            this.saTabPage.ResumeLayout(false);
            this.saTabPage.PerformLayout();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.admTabControl.ResumeLayout(false);
            this.fgaTabPage.ResumeLayout(false);
            this.fgaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgapcnsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgadkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.userTabPage.ResumeLayout(false);
            this.userTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView saGridView;
        private System.Windows.Forms.DataGridView privGridView;
        private System.Windows.Forms.TabPage privTabPage;
        private System.Windows.Forms.DataGridView roleGridView;
        private System.Windows.Forms.TabPage roleTabPage;
        private System.Windows.Forms.TabPage saTabPage;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.ToolStripMenuItem logoutItem;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TabControl admTabControl;
        private System.Windows.Forms.Button checkRoleButton;
        private System.Windows.Forms.Button revokeRoleButton;
        private System.Windows.Forms.Button grantRoleButton;
        private System.Windows.Forms.Button dropRoleButton;
        private System.Windows.Forms.Button createRoleButton;
        private System.Windows.Forms.Label userRLLabel;
        private System.Windows.Forms.Label roleRLLabel;
        private System.Windows.Forms.TextBox userRLTextBox;
        private System.Windows.Forms.TextBox roleRLTextBox;
        private System.Windows.Forms.ComboBox objPLComboBox;
        private System.Windows.Forms.Button checkPrivilegeButton;
        private System.Windows.Forms.Button grantUsrButton;
        private System.Windows.Forms.Button revokePrivButton;
        private System.Windows.Forms.ComboBox colPLComboBox;
        private System.Windows.Forms.Label colPLLabel;
        private System.Windows.Forms.CheckBox privPLCheckBox;
        private System.Windows.Forms.ComboBox privPLComboBox;
        private System.Windows.Forms.Label privPLLabel;
        private System.Windows.Forms.Label objPLLabel;
        private System.Windows.Forms.Label userPLLabel;
        private System.Windows.Forms.TextBox userPLTextBox;
        private System.Windows.Forms.Button onSAButton;
        private System.Windows.Forms.Button offsaButton;
        private System.Windows.Forms.Label usrSALabel;
        private System.Windows.Forms.TextBox saauditSearchTextBox;
        private System.Windows.Forms.TabPage fgaTabPage;
        private System.Windows.Forms.Label fgausrDKLabel;
        private System.Windows.Forms.TextBox fgaDKSearchTextBox;
        private System.Windows.Forms.DataGridView fgadkGridView;
        private System.Windows.Forms.Label fgausrPCLabel;
        private System.Windows.Forms.TextBox fgaPCSearchTextBox;
        private System.Windows.Forms.DataGridView fgapcnsGridView;
        private System.Windows.Forms.TabPage userTabPage;
        private System.Windows.Forms.Button createUsButton;
        private System.Windows.Forms.Button dropUsButton;
        private System.Windows.Forms.Button changePassButtton;
        private System.Windows.Forms.Label pwUSLabel;
        private System.Windows.Forms.Label usrUSLabel;
        private System.Windows.Forms.TextBox pwUSTextBox;
        private System.Windows.Forms.TextBox usrUSTextBox;
        private System.Windows.Forms.DataGridView userGridView;
    }
}