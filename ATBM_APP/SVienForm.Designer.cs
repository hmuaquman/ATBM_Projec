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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dkGridView = new System.Windows.Forms.DataGridView();
            this.dkhptabPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dsdkGridView = new System.Windows.Forms.DataGridView();
            this.dkhpGridView = new System.Windows.Forms.DataGridView();
            this.adddkDKButton = new System.Windows.Forms.Button();
            this.deldkDKButton = new System.Windows.Forms.Button();
            this.temp6 = new System.Windows.Forms.Label();
            this.temp5 = new System.Windows.Forms.Label();
            this.temp3 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.temp4 = new System.Windows.Forms.Label();
            this.notificationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bellButton = new System.Windows.Forms.Button();
            this.oracleCommandBuilder1 = new Oracle.ManagedDataAccess.Client.OracleCommandBuilder();
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
            this.dkhptabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsdkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkhpGridView)).BeginInit();
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
            this.hpTabPage.Size = new System.Drawing.Size(936, 534);
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
            this.khmoTabPage.Size = new System.Drawing.Size(936, 534);
            this.khmoTabPage.TabIndex = 3;
            this.khmoTabPage.Text = "Kế hoạch mở";
            this.khmoTabPage.UseVisualStyleBackColor = true;
            this.khmoTabPage.Enter += new System.EventHandler(this.khmoTabPage_Enter);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.helloLabel.Location = new System.Drawing.Point(514, 31);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(69, 18);
            this.helloLabel.TabIndex = 19;
            this.helloLabel.Text = "Xin Chào";
            // 
            // logoutItem
            // 
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(196, 24);
            this.logoutItem.Text = "Đăng xuất";
            this.logoutItem.Click += new System.EventHandler(this.logoutItem_Click);
            // 
            // noticeItem
            // 
            this.noticeItem.Name = "noticeItem";
            this.noticeItem.Size = new System.Drawing.Size(196, 24);
            this.noticeItem.Text = "Thông báo";
            this.noticeItem.Click += new System.EventHandler(this.noticeItem_Click);
            // 
            // infoItem
            // 
            this.infoItem.Name = "infoItem";
            this.infoItem.Size = new System.Drawing.Size(196, 24);
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
            this.gvTabControl.Controls.Add(this.dkhptabPage);
            this.gvTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gvTabControl.Location = new System.Drawing.Point(16, 129);
            this.gvTabControl.Name = "gvTabControl";
            this.gvTabControl.SelectedIndex = 0;
            this.gvTabControl.Size = new System.Drawing.Size(944, 565);
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
            this.dkTabPage.Controls.Add(this.dkGridView);
            this.dkTabPage.Location = new System.Drawing.Point(4, 27);
            this.dkTabPage.Name = "dkTabPage";
            this.dkTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dkTabPage.Size = new System.Drawing.Size(936, 534);
            this.dkTabPage.TabIndex = 4;
            this.dkTabPage.Text = "Kết quả học tập";
            this.dkTabPage.UseVisualStyleBackColor = true;
            this.dkTabPage.Enter += new System.EventHandler(this.dkTabPage_Enter);
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
            // dkGridView
            // 
            this.dkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dkGridView.Location = new System.Drawing.Point(17, 78);
            this.dkGridView.Name = "dkGridView";
            this.dkGridView.RowHeadersWidth = 51;
            this.dkGridView.RowTemplate.Height = 24;
            this.dkGridView.Size = new System.Drawing.Size(885, 309);
            this.dkGridView.TabIndex = 57;
            this.dkGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dkGridView_CellClick);
            // 
            // dkhptabPage
            // 
            this.dkhptabPage.Controls.Add(this.label9);
            this.dkhptabPage.Controls.Add(this.label8);
            this.dkhptabPage.Controls.Add(this.label7);
            this.dkhptabPage.Controls.Add(this.dsdkGridView);
            this.dkhptabPage.Controls.Add(this.dkhpGridView);
            this.dkhptabPage.Controls.Add(this.adddkDKButton);
            this.dkhptabPage.Controls.Add(this.deldkDKButton);
            this.dkhptabPage.Location = new System.Drawing.Point(4, 27);
            this.dkhptabPage.Name = "dkhptabPage";
            this.dkhptabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dkhptabPage.Size = new System.Drawing.Size(936, 534);
            this.dkhptabPage.TabIndex = 5;
            this.dkhptabPage.Text = "Đăng ký học phần";
            this.dkhptabPage.UseVisualStyleBackColor = true;
            this.dkhptabPage.Enter += new System.EventHandler(this.dkhptabPage_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(494, 36);
            this.label9.TabIndex = 128;
            this.label9.Text = "Đã hết thời hạn điều chỉnh học phần";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(14, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 36);
            this.label8.TabIndex = 127;
            this.label8.Text = "Danh sách lớp mở";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(14, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 36);
            this.label7.TabIndex = 126;
            this.label7.Text = "Danh sách môn học đã đăng ký";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dsdkGridView
            // 
            this.dsdkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsdkGridView.Location = new System.Drawing.Point(20, 72);
            this.dsdkGridView.Name = "dsdkGridView";
            this.dsdkGridView.RowHeadersWidth = 51;
            this.dsdkGridView.RowTemplate.Height = 24;
            this.dsdkGridView.Size = new System.Drawing.Size(888, 179);
            this.dsdkGridView.TabIndex = 125;
            this.dsdkGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsdkGridView_CellClick);
            // 
            // dkhpGridView
            // 
            this.dkhpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dkhpGridView.Location = new System.Drawing.Point(20, 340);
            this.dkhpGridView.Name = "dkhpGridView";
            this.dkhpGridView.RowHeadersWidth = 51;
            this.dkhpGridView.RowTemplate.Height = 24;
            this.dkhpGridView.Size = new System.Drawing.Size(888, 179);
            this.dkhpGridView.TabIndex = 124;
            this.dkhpGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dkhpGridView_CellClick);
            // 
            // adddkDKButton
            // 
            this.adddkDKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adddkDKButton.Location = new System.Drawing.Point(787, 281);
            this.adddkDKButton.Name = "adddkDKButton";
            this.adddkDKButton.Size = new System.Drawing.Size(121, 43);
            this.adddkDKButton.TabIndex = 92;
            this.adddkDKButton.Text = "Đăng ký";
            this.adddkDKButton.UseVisualStyleBackColor = true;
            this.adddkDKButton.Click += new System.EventHandler(this.adddkDKButton_Click);
            // 
            // deldkDKButton
            // 
            this.deldkDKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deldkDKButton.Location = new System.Drawing.Point(767, 23);
            this.deldkDKButton.Name = "deldkDKButton";
            this.deldkDKButton.Size = new System.Drawing.Size(141, 43);
            this.deldkDKButton.TabIndex = 91;
            this.deldkDKButton.Text = "Hủy đăng ký";
            this.deldkDKButton.UseVisualStyleBackColor = true;
            this.deldkDKButton.Click += new System.EventHandler(this.deldkDKButton_Click);
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
            // notificationPanel
            // 
            this.notificationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.notificationPanel.Location = new System.Drawing.Point(636, 60);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(200, 100);
            this.notificationPanel.TabIndex = 43;
            // 
            // bellButton
            // 
            this.bellButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bellButton.Location = new System.Drawing.Point(787, 16);
            this.bellButton.Name = "bellButton";
            this.bellButton.Size = new System.Drawing.Size(50, 50);
            this.bellButton.TabIndex = 42;
            this.bellButton.UseVisualStyleBackColor = true;
            this.bellButton.Click += new System.EventHandler(this.bellButton_Click);
            // 
            // oracleCommandBuilder1
            // 
            this.oracleCommandBuilder1.CatalogLocation = System.Data.Common.CatalogLocation.End;
            this.oracleCommandBuilder1.CatalogSeparator = "@";
            // 
            // SVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 699);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.bellButton);
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
            this.dkhptabPage.ResumeLayout(false);
            this.dkhptabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsdkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkhpGridView)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel notificationPanel;
        private System.Windows.Forms.Button bellButton;
        private System.Windows.Forms.TabPage dkhptabPage;
        private System.Windows.Forms.Button adddkDKButton;
        private System.Windows.Forms.Button deldkDKButton;
        private System.Windows.Forms.DataGridView dkhpGridView;
        private Oracle.ManagedDataAccess.Client.OracleCommandBuilder oracleCommandBuilder1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dsdkGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}