namespace ATBM_APP
{
    partial class SVienForm
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
            this.khmoGridView = new System.Windows.Forms.DataGridView();
            this.hpGridView = new System.Windows.Forms.DataGridView();
            this.hpTabPage = new System.Windows.Forms.TabPage();
            this.khmoTabPage = new System.Windows.Forms.TabPage();
            this.helloLabel = new System.Windows.Forms.Label();
            this.logoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.gvTabControl = new System.Windows.Forms.TabControl();
            this.dkTabPage = new System.Windows.Forms.TabPage();
            this.savedkButton = new System.Windows.Forms.Button();
            this.editdkButton = new System.Windows.Forms.Button();
            this.mhpTextBox = new System.Windows.Forms.TextBox();
            this.thpTextBox = new System.Windows.Forms.TextBox();
            this.hkTextBox = new System.Windows.Forms.TextBox();
            this.nhTextBox = new System.Windows.Forms.TextBox();
            this.mctTextBox = new System.Windows.Forms.TextBox();
            this.dgkTextBox = new System.Windows.Forms.TextBox();
            this.dqtTextBox = new System.Windows.Forms.TextBox();
            this.dckTextBox = new System.Windows.Forms.TextBox();
            this.dtkTextBox = new System.Windows.Forms.TextBox();
            this.magvTextBox = new System.Windows.Forms.TextBox();
            this.mctLabel = new System.Windows.Forms.Label();
            this.dgkLabel = new System.Windows.Forms.Label();
            this.dqtLabel = new System.Windows.Forms.Label();
            this.dckLabel = new System.Windows.Forms.Label();
            this.dtkLabel = new System.Windows.Forms.Label();
            this.mhpLabel = new System.Windows.Forms.Label();
            this.thpLabel = new System.Windows.Forms.Label();
            this.hkLabel = new System.Windows.Forms.Label();
            this.nhLabel = new System.Windows.Forms.Label();
            this.mgvLabel = new System.Windows.Forms.Label();
            this.dkGridView = new System.Windows.Forms.DataGridView();
            this.temp6 = new System.Windows.Forms.Label();
            this.temp5 = new System.Windows.Forms.Label();
            this.temp3 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.temp4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deldkDKButton = new System.Windows.Forms.Button();
            this.adddkDKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.khmoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpGridView)).BeginInit();
            this.hpTabPage.SuspendLayout();
            this.khmoTabPage.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.gvTabControl.SuspendLayout();
            this.dkTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dkGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // khmoGridView
            // 
            this.khmoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khmoGridView.Location = new System.Drawing.Point(25, 22);
            this.khmoGridView.Name = "khmoGridView";
            this.khmoGridView.RowHeadersWidth = 51;
            this.khmoGridView.RowTemplate.Height = 24;
            this.khmoGridView.Size = new System.Drawing.Size(887, 384);
            this.khmoGridView.TabIndex = 2;
            // 
            // hpGridView
            // 
            this.hpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hpGridView.Location = new System.Drawing.Point(22, 21);
            this.hpGridView.Name = "hpGridView";
            this.hpGridView.RowHeadersWidth = 51;
            this.hpGridView.RowTemplate.Height = 24;
            this.hpGridView.Size = new System.Drawing.Size(887, 384);
            this.hpGridView.TabIndex = 2;
            // 
            // hpTabPage
            // 
            this.hpTabPage.Controls.Add(this.hpGridView);
            this.hpTabPage.Location = new System.Drawing.Point(4, 27);
            this.hpTabPage.Name = "hpTabPage";
            this.hpTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hpTabPage.Size = new System.Drawing.Size(936, 420);
            this.hpTabPage.TabIndex = 2;
            this.hpTabPage.Text = "Học phần";
            this.hpTabPage.UseVisualStyleBackColor = true;
            this.hpTabPage.Enter += new System.EventHandler(this.hpTabPage_Enter);
            // 
            // khmoTabPage
            // 
            this.khmoTabPage.Controls.Add(this.khmoGridView);
            this.khmoTabPage.Location = new System.Drawing.Point(4, 27);
            this.khmoTabPage.Name = "khmoTabPage";
            this.khmoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.khmoTabPage.Size = new System.Drawing.Size(936, 420);
            this.khmoTabPage.TabIndex = 3;
            this.khmoTabPage.Text = "Kế hoạch mở";
            this.khmoTabPage.UseVisualStyleBackColor = true;
            this.khmoTabPage.Enter += new System.EventHandler(this.khmoTabPage_Enter);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.helloLabel.Location = new System.Drawing.Point(630, 28);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(69, 18);
            this.helloLabel.TabIndex = 19;
            this.helloLabel.Text = "Xin Chào";
            // 
            // logoutItem
            // 
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(210, 24);
            this.logoutItem.Text = "Đăng xuất";
            this.logoutItem.Click += new System.EventHandler(this.logoutItem_Click);
            // 
            // noticeItem
            // 
            this.noticeItem.Name = "noticeItem";
            this.noticeItem.Size = new System.Drawing.Size(210, 24);
            this.noticeItem.Text = "Thông báo";
            this.noticeItem.Click += new System.EventHandler(this.noticeItem_Click);
            // 
            // infoItem
            // 
            this.infoItem.Name = "infoItem";
            this.infoItem.Size = new System.Drawing.Size(210, 24);
            this.infoItem.Text = "Thông tin cá nhân";
            this.infoItem.Click += new System.EventHandler(this.infoItem_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoItem,
            this.noticeItem,
            this.logoutItem});
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(197, 76);
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
            // gvTabControl
            // 
            this.gvTabControl.Controls.Add(this.hpTabPage);
            this.gvTabControl.Controls.Add(this.khmoTabPage);
            this.gvTabControl.Controls.Add(this.dkTabPage);
            this.gvTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gvTabControl.Location = new System.Drawing.Point(16, 129);
            this.gvTabControl.Name = "gvTabControl";
            this.gvTabControl.SelectedIndex = 0;
            this.gvTabControl.Size = new System.Drawing.Size(944, 451);
            this.gvTabControl.TabIndex = 18;
            // 
            // dkTabPage
            // 
            this.dkTabPage.Controls.Add(this.label1);
            this.dkTabPage.Controls.Add(this.label2);
            this.dkTabPage.Controls.Add(this.label3);
            this.dkTabPage.Controls.Add(this.label4);
            this.dkTabPage.Controls.Add(this.label5);
            this.dkTabPage.Controls.Add(this.label6);
            this.dkTabPage.Controls.Add(this.deldkDKButton);
            this.dkTabPage.Controls.Add(this.adddkDKButton);
            this.dkTabPage.Controls.Add(this.savedkButton);
            this.dkTabPage.Controls.Add(this.editdkButton);
            this.dkTabPage.Controls.Add(this.mhpTextBox);
            this.dkTabPage.Controls.Add(this.thpTextBox);
            this.dkTabPage.Controls.Add(this.hkTextBox);
            this.dkTabPage.Controls.Add(this.nhTextBox);
            this.dkTabPage.Controls.Add(this.mctTextBox);
            this.dkTabPage.Controls.Add(this.dgkTextBox);
            this.dkTabPage.Controls.Add(this.dqtTextBox);
            this.dkTabPage.Controls.Add(this.dckTextBox);
            this.dkTabPage.Controls.Add(this.dtkTextBox);
            this.dkTabPage.Controls.Add(this.magvTextBox);
            this.dkTabPage.Controls.Add(this.mctLabel);
            this.dkTabPage.Controls.Add(this.dgkLabel);
            this.dkTabPage.Controls.Add(this.dqtLabel);
            this.dkTabPage.Controls.Add(this.dckLabel);
            this.dkTabPage.Controls.Add(this.dtkLabel);
            this.dkTabPage.Controls.Add(this.mhpLabel);
            this.dkTabPage.Controls.Add(this.thpLabel);
            this.dkTabPage.Controls.Add(this.hkLabel);
            this.dkTabPage.Controls.Add(this.nhLabel);
            this.dkTabPage.Controls.Add(this.mgvLabel);
            this.dkTabPage.Controls.Add(this.dkGridView);
            this.dkTabPage.Location = new System.Drawing.Point(4, 27);
            this.dkTabPage.Name = "dkTabPage";
            this.dkTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dkTabPage.Size = new System.Drawing.Size(936, 420);
            this.dkTabPage.TabIndex = 4;
            this.dkTabPage.Text = "Đăng ký";
            this.dkTabPage.UseVisualStyleBackColor = true;
            this.dkTabPage.Enter += new System.EventHandler(this.dkTabPage_Enter);
            // 
            // savedkButton
            // 
            this.savedkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.savedkButton.Location = new System.Drawing.Point(791, 336);
            this.savedkButton.Name = "savedkButton";
            this.savedkButton.Size = new System.Drawing.Size(115, 50);
            this.savedkButton.TabIndex = 82;
            this.savedkButton.Text = "Lưu";
            this.savedkButton.UseVisualStyleBackColor = true;
            this.savedkButton.Click += new System.EventHandler(this.savedkButton_Click);
            // 
            // editdkButton
            // 
            this.editdkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.editdkButton.Location = new System.Drawing.Point(791, 264);
            this.editdkButton.Name = "editdkButton";
            this.editdkButton.Size = new System.Drawing.Size(115, 49);
            this.editdkButton.TabIndex = 80;
            this.editdkButton.Text = "Sửa";
            this.editdkButton.UseVisualStyleBackColor = true;
            this.editdkButton.Click += new System.EventHandler(this.editdkButton_Click);
            // 
            // mhpTextBox
            // 
            this.mhpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mhpTextBox.Location = new System.Drawing.Point(652, 116);
            this.mhpTextBox.Name = "mhpTextBox";
            this.mhpTextBox.Size = new System.Drawing.Size(269, 26);
            this.mhpTextBox.TabIndex = 78;
            this.mhpTextBox.TextChanged += new System.EventHandler(this.mhpTextBox_TextChanged);
            // 
            // thpTextBox
            // 
            this.thpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.thpTextBox.Location = new System.Drawing.Point(652, 150);
            this.thpTextBox.Name = "thpTextBox";
            this.thpTextBox.Size = new System.Drawing.Size(269, 26);
            this.thpTextBox.TabIndex = 77;
            // 
            // hkTextBox
            // 
            this.hkTextBox.Location = new System.Drawing.Point(598, 191);
            this.hkTextBox.Name = "hkTextBox";
            this.hkTextBox.Size = new System.Drawing.Size(100, 24);
            this.hkTextBox.TabIndex = 76;
            // 
            // nhTextBox
            // 
            this.nhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nhTextBox.Location = new System.Drawing.Point(754, 189);
            this.nhTextBox.Name = "nhTextBox";
            this.nhTextBox.Size = new System.Drawing.Size(167, 24);
            this.nhTextBox.TabIndex = 75;
            // 
            // mctTextBox
            // 
            this.mctTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mctTextBox.Location = new System.Drawing.Point(666, 224);
            this.mctTextBox.Name = "mctTextBox";
            this.mctTextBox.Size = new System.Drawing.Size(255, 26);
            this.mctTextBox.TabIndex = 74;
            // 
            // dgkTextBox
            // 
            this.dgkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgkTextBox.Location = new System.Drawing.Point(666, 261);
            this.dgkTextBox.Name = "dgkTextBox";
            this.dgkTextBox.Size = new System.Drawing.Size(100, 26);
            this.dgkTextBox.TabIndex = 73;
            // 
            // dqtTextBox
            // 
            this.dqtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dqtTextBox.Location = new System.Drawing.Point(666, 298);
            this.dqtTextBox.Name = "dqtTextBox";
            this.dqtTextBox.Size = new System.Drawing.Size(100, 26);
            this.dqtTextBox.TabIndex = 72;
            // 
            // dckTextBox
            // 
            this.dckTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dckTextBox.Location = new System.Drawing.Point(666, 331);
            this.dckTextBox.Name = "dckTextBox";
            this.dckTextBox.Size = new System.Drawing.Size(100, 26);
            this.dckTextBox.TabIndex = 71;
            // 
            // dtkTextBox
            // 
            this.dtkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtkTextBox.Location = new System.Drawing.Point(666, 363);
            this.dtkTextBox.Name = "dtkTextBox";
            this.dtkTextBox.Size = new System.Drawing.Size(100, 26);
            this.dtkTextBox.TabIndex = 70;
            // 
            // magvTextBox
            // 
            this.magvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.magvTextBox.Location = new System.Drawing.Point(652, 75);
            this.magvTextBox.Name = "magvTextBox";
            this.magvTextBox.Size = new System.Drawing.Size(268, 26);
            this.magvTextBox.TabIndex = 69;
            // 
            // mctLabel
            // 
            this.mctLabel.AutoSize = true;
            this.mctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mctLabel.Location = new System.Drawing.Point(531, 227);
            this.mctLabel.Name = "mctLabel";
            this.mctLabel.Size = new System.Drawing.Size(129, 20);
            this.mctLabel.TabIndex = 68;
            this.mctLabel.Text = "Mã chương trình";
            // 
            // dgkLabel
            // 
            this.dgkLabel.AutoSize = true;
            this.dgkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgkLabel.Location = new System.Drawing.Point(531, 264);
            this.dgkLabel.Name = "dgkLabel";
            this.dgkLabel.Size = new System.Drawing.Size(105, 20);
            this.dgkLabel.TabIndex = 67;
            this.dgkLabel.Text = "Điểm giữa kỳ";
            // 
            // dqtLabel
            // 
            this.dqtLabel.AutoSize = true;
            this.dqtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dqtLabel.Location = new System.Drawing.Point(531, 301);
            this.dqtLabel.Name = "dqtLabel";
            this.dqtLabel.Size = new System.Drawing.Size(118, 20);
            this.dqtLabel.TabIndex = 66;
            this.dqtLabel.Text = "Điểm quá trình";
            // 
            // dckLabel
            // 
            this.dckLabel.AutoSize = true;
            this.dckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dckLabel.Location = new System.Drawing.Point(531, 336);
            this.dckLabel.Name = "dckLabel";
            this.dckLabel.Size = new System.Drawing.Size(105, 20);
            this.dckLabel.TabIndex = 65;
            this.dckLabel.Text = "Điểm cuối kỳ";
            // 
            // dtkLabel
            // 
            this.dtkLabel.AutoSize = true;
            this.dtkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtkLabel.Location = new System.Drawing.Point(531, 366);
            this.dtkLabel.Name = "dtkLabel";
            this.dtkLabel.Size = new System.Drawing.Size(112, 20);
            this.dtkLabel.TabIndex = 64;
            this.dtkLabel.Text = "Điểm tổng kết";
            // 
            // mhpLabel
            // 
            this.mhpLabel.AutoSize = true;
            this.mhpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mhpLabel.Location = new System.Drawing.Point(531, 119);
            this.mhpLabel.Name = "mhpLabel";
            this.mhpLabel.Size = new System.Drawing.Size(105, 20);
            this.mhpLabel.TabIndex = 63;
            this.mhpLabel.Text = "Mã học phần";
            // 
            // thpLabel
            // 
            this.thpLabel.AutoSize = true;
            this.thpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.thpLabel.Location = new System.Drawing.Point(531, 153);
            this.thpLabel.Name = "thpLabel";
            this.thpLabel.Size = new System.Drawing.Size(110, 20);
            this.thpLabel.TabIndex = 62;
            this.thpLabel.Text = "Tên học phần";
            // 
            // hkLabel
            // 
            this.hkLabel.AutoSize = true;
            this.hkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hkLabel.Location = new System.Drawing.Point(531, 191);
            this.hkLabel.Name = "hkLabel";
            this.hkLabel.Size = new System.Drawing.Size(61, 20);
            this.hkLabel.TabIndex = 61;
            this.hkLabel.Text = "Học kỳ";
            // 
            // nhLabel
            // 
            this.nhLabel.AutoSize = true;
            this.nhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nhLabel.Location = new System.Drawing.Point(704, 193);
            this.nhLabel.Name = "nhLabel";
            this.nhLabel.Size = new System.Drawing.Size(44, 20);
            this.nhLabel.TabIndex = 60;
            this.nhLabel.Text = "Năm";
            // 
            // mgvLabel
            // 
            this.mgvLabel.AutoSize = true;
            this.mgvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mgvLabel.Location = new System.Drawing.Point(530, 79);
            this.mgvLabel.Name = "mgvLabel";
            this.mgvLabel.Size = new System.Drawing.Size(112, 20);
            this.mgvLabel.TabIndex = 58;
            this.mgvLabel.Text = "Mã giảng viên";
            // 
            // dkGridView
            // 
            this.dkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dkGridView.Location = new System.Drawing.Point(17, 20);
            this.dkGridView.Name = "dkGridView";
            this.dkGridView.RowHeadersWidth = 51;
            this.dkGridView.RowTemplate.Height = 24;
            this.dkGridView.Size = new System.Drawing.Size(490, 381);
            this.dkGridView.TabIndex = 57;
            this.dkGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dkGridView_CellClick);
            // 
            // temp6
            // 
            this.temp6.AutoSize = true;
            this.temp6.Location = new System.Drawing.Point(13, 110);
            this.temp6.Name = "temp6";
            this.temp6.Size = new System.Drawing.Size(44, 16);
            this.temp6.TabIndex = 41;
            this.temp6.Text = "label5";
            this.temp6.Visible = false;
            // 
            // temp5
            // 
            this.temp5.AutoSize = true;
            this.temp5.Location = new System.Drawing.Point(20, 110);
            this.temp5.Name = "temp5";
            this.temp5.Size = new System.Drawing.Size(44, 16);
            this.temp5.TabIndex = 39;
            this.temp5.Text = "label3";
            this.temp5.Visible = false;
            // 
            // temp3
            // 
            this.temp3.AutoSize = true;
            this.temp3.Location = new System.Drawing.Point(15, 110);
            this.temp3.Name = "temp3";
            this.temp3.Size = new System.Drawing.Size(44, 16);
            this.temp3.TabIndex = 38;
            this.temp3.Text = "label3";
            this.temp3.Visible = false;
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.Location = new System.Drawing.Point(15, 110);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(44, 16);
            this.temp2.TabIndex = 37;
            this.temp2.Text = "label2";
            this.temp2.Visible = false;
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.Location = new System.Drawing.Point(15, 110);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(44, 16);
            this.temp1.TabIndex = 36;
            this.temp1.Text = "temp1";
            this.temp1.Visible = false;
            // 
            // temp4
            // 
            this.temp4.AutoSize = true;
            this.temp4.Location = new System.Drawing.Point(20, 110);
            this.temp4.Name = "temp4";
            this.temp4.Size = new System.Drawing.Size(44, 16);
            this.temp4.TabIndex = 40;
            this.temp4.Text = "label3";
            this.temp4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-98, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "label5";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-91, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "label3";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-96, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 85;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-96, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 84;
            this.label4.Text = "label2";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-96, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-91, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 87;
            this.label6.Text = "label3";
            this.label6.Visible = false;
            // 
            // deldkDKButton
            // 
            this.deldkDKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deldkDKButton.Location = new System.Drawing.Point(824, 20);
            this.deldkDKButton.Name = "deldkDKButton";
            this.deldkDKButton.Size = new System.Drawing.Size(96, 38);
            this.deldkDKButton.TabIndex = 90;
            this.deldkDKButton.Text = "Xóa";
            this.deldkDKButton.UseVisualStyleBackColor = true;
            // 
            // adddkDKButton
            // 
            this.adddkDKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adddkDKButton.Location = new System.Drawing.Point(708, 20);
            this.adddkDKButton.Name = "adddkDKButton";
            this.adddkDKButton.Size = new System.Drawing.Size(89, 38);
            this.adddkDKButton.TabIndex = 89;
            this.adddkDKButton.Text = "Thêm";
            this.adddkDKButton.UseVisualStyleBackColor = true;
            this.adddkDKButton.Click += new System.EventHandler(this.adddkDKButton_Click);
            // 
            // SVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 596);
            this.Controls.Add(this.temp6);
            this.Controls.Add(this.temp5);
            this.Controls.Add(this.temp3);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.temp4);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.gvTabControl);
            this.Name = "SVienForm";
            this.Text = "SVienForm";
            this.Load += new System.EventHandler(this.SVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khmoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpGridView)).EndInit();
            this.hpTabPage.ResumeLayout(false);
            this.khmoTabPage.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.gvTabControl.ResumeLayout(false);
            this.dkTabPage.ResumeLayout(false);
            this.dkTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dkGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView khmoGridView;
        private System.Windows.Forms.DataGridView hpGridView;
        private System.Windows.Forms.TabPage hpTabPage;
        private System.Windows.Forms.TabPage khmoTabPage;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.ToolStripMenuItem logoutItem;
        private System.Windows.Forms.ToolStripMenuItem noticeItem;
        private System.Windows.Forms.ToolStripMenuItem infoItem;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TabControl gvTabControl;
        private System.Windows.Forms.TabPage dkTabPage;
        private System.Windows.Forms.Button savedkButton;
        private System.Windows.Forms.Button editdkButton;
        private System.Windows.Forms.TextBox mhpTextBox;
        private System.Windows.Forms.TextBox thpTextBox;
        private System.Windows.Forms.TextBox hkTextBox;
        private System.Windows.Forms.TextBox nhTextBox;
        private System.Windows.Forms.TextBox mctTextBox;
        private System.Windows.Forms.TextBox dgkTextBox;
        private System.Windows.Forms.TextBox dqtTextBox;
        private System.Windows.Forms.TextBox dckTextBox;
        private System.Windows.Forms.TextBox dtkTextBox;
        private System.Windows.Forms.TextBox magvTextBox;
        private System.Windows.Forms.Label mctLabel;
        private System.Windows.Forms.Label dgkLabel;
        private System.Windows.Forms.Label dqtLabel;
        private System.Windows.Forms.Label dckLabel;
        private System.Windows.Forms.Label dtkLabel;
        private System.Windows.Forms.Label mhpLabel;
        private System.Windows.Forms.Label thpLabel;
        private System.Windows.Forms.Label hkLabel;
        private System.Windows.Forms.Label nhLabel;
        private System.Windows.Forms.Label mgvLabel;
        private System.Windows.Forms.DataGridView dkGridView;
        private System.Windows.Forms.Label temp6;
        private System.Windows.Forms.Label temp5;
        private System.Windows.Forms.Label temp3;
        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label temp4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deldkDKButton;
        private System.Windows.Forms.Button adddkDKButton;
    }
}