namespace ATBM_APP
{
    partial class NVCBForm
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.gvTabControl = new System.Windows.Forms.TabControl();
            this.svTabPage = new System.Windows.Forms.TabPage();
            this.svGridView = new System.Windows.Forms.DataGridView();
            this.dvTabPage = new System.Windows.Forms.TabPage();
            this.dvGridView = new System.Windows.Forms.DataGridView();
            this.hpTabPage = new System.Windows.Forms.TabPage();
            this.hpGridView = new System.Windows.Forms.DataGridView();
            this.khmoTabPage = new System.Windows.Forms.TabPage();
            this.khmoGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.gvTabControl.SuspendLayout();
            this.svTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svGridView)).BeginInit();
            this.dvTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGridView)).BeginInit();
            this.hpTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hpGridView)).BeginInit();
            this.khmoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khmoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.helloLabel.Location = new System.Drawing.Point(630, 28);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(69, 18);
            this.helloLabel.TabIndex = 14;
            this.helloLabel.Text = "Xin Chào";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(125, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(368, 39);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Quản lý dữ liệu nội bộ";
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.menu;
            this.icon.Location = new System.Drawing.Point(864, 16);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(92, 86);
            this.icon.TabIndex = 11;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.icon_Click);
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
            // infoItem
            // 
            this.infoItem.Name = "infoItem";
            this.infoItem.Size = new System.Drawing.Size(196, 24);
            this.infoItem.Text = "Thông tin cá nhân";
            this.infoItem.Click += new System.EventHandler(this.infoItem_Click);
            // 
            // noticeItem
            // 
            this.noticeItem.Name = "noticeItem";
            this.noticeItem.Size = new System.Drawing.Size(196, 24);
            this.noticeItem.Text = "Thông báo";
            this.noticeItem.Click += new System.EventHandler(this.noticeItem_Click);
            // 
            // logoutItem
            // 
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(196, 24);
            this.logoutItem.Text = "Đăng xuất";
            this.logoutItem.Click += new System.EventHandler(this.logoutItem_Click);
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(16, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(92, 86);
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // gvTabControl
            // 
            this.gvTabControl.Controls.Add(this.svTabPage);
            this.gvTabControl.Controls.Add(this.dvTabPage);
            this.gvTabControl.Controls.Add(this.hpTabPage);
            this.gvTabControl.Controls.Add(this.khmoTabPage);
            this.gvTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gvTabControl.Location = new System.Drawing.Point(16, 129);
            this.gvTabControl.Name = "gvTabControl";
            this.gvTabControl.SelectedIndex = 0;
            this.gvTabControl.Size = new System.Drawing.Size(944, 451);
            this.gvTabControl.TabIndex = 13;
            // 
            // svTabPage
            // 
            this.svTabPage.Controls.Add(this.svGridView);
            this.svTabPage.Location = new System.Drawing.Point(4, 27);
            this.svTabPage.Name = "svTabPage";
            this.svTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.svTabPage.Size = new System.Drawing.Size(936, 420);
            this.svTabPage.TabIndex = 0;
            this.svTabPage.Text = "Sinh viên";
            this.svTabPage.UseVisualStyleBackColor = true;
            this.svTabPage.Enter += new System.EventHandler(this.svTabPage_Enter);
            // 
            // svGridView
            // 
            this.svGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.svGridView.Location = new System.Drawing.Point(24, 19);
            this.svGridView.Name = "svGridView";
            this.svGridView.RowHeadersWidth = 51;
            this.svGridView.RowTemplate.Height = 24;
            this.svGridView.Size = new System.Drawing.Size(887, 384);
            this.svGridView.TabIndex = 2;
            // 
            // dvTabPage
            // 
            this.dvTabPage.Controls.Add(this.dvGridView);
            this.dvTabPage.Location = new System.Drawing.Point(4, 27);
            this.dvTabPage.Name = "dvTabPage";
            this.dvTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dvTabPage.Size = new System.Drawing.Size(936, 420);
            this.dvTabPage.TabIndex = 1;
            this.dvTabPage.Text = "Đơn vị";
            this.dvTabPage.UseVisualStyleBackColor = true;
            this.dvTabPage.Enter += new System.EventHandler(this.dvTabPage_Enter);
            // 
            // dvGridView
            // 
            this.dvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvGridView.Location = new System.Drawing.Point(23, 21);
            this.dvGridView.Name = "dvGridView";
            this.dvGridView.RowHeadersWidth = 51;
            this.dvGridView.RowTemplate.Height = 24;
            this.dvGridView.Size = new System.Drawing.Size(887, 384);
            this.dvGridView.TabIndex = 2;
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
            // NVCBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 596);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.gvTabControl);
            this.Name = "NVCBForm";
            this.Text = "NVCBForm";
            this.Load += new System.EventHandler(this.NVCBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.gvTabControl.ResumeLayout(false);
            this.svTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svGridView)).EndInit();
            this.dvTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGridView)).EndInit();
            this.hpTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hpGridView)).EndInit();
            this.khmoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khmoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TabControl gvTabControl;
        private System.Windows.Forms.TabPage svTabPage;
        private System.Windows.Forms.DataGridView svGridView;
        private System.Windows.Forms.TabPage dvTabPage;
        private System.Windows.Forms.DataGridView dvGridView;
        private System.Windows.Forms.TabPage hpTabPage;
        private System.Windows.Forms.DataGridView hpGridView;
        private System.Windows.Forms.TabPage khmoTabPage;
        private System.Windows.Forms.DataGridView khmoGridView;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem infoItem;
        private System.Windows.Forms.ToolStripMenuItem noticeItem;
        private System.Windows.Forms.ToolStripMenuItem logoutItem;
    }
}