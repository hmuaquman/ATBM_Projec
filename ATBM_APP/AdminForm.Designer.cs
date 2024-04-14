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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.rolePB = new System.Windows.Forms.PictureBox();
            this.privPB = new System.Windows.Forms.PictureBox();
            this.usrLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.privLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.privilegeToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // privilegeToolStripMenuItem
            // 
            this.privilegeToolStripMenuItem.Name = "privilegeToolStripMenuItem";
            this.privilegeToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.privilegeToolStripMenuItem.Text = "Privilege";
            this.privilegeToolStripMenuItem.Click += new System.EventHandler(this.privilegeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userPB
            // 
            this.userPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPB.Location = new System.Drawing.Point(55, 108);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(151, 133);
            this.userPB.TabIndex = 1;
            this.userPB.TabStop = false;
            this.userPB.Click += new System.EventHandler(this.userPB_Click);
            this.userPB.MouseEnter += new System.EventHandler(this.userPB_MouseEnter);
            this.userPB.MouseLeave += new System.EventHandler(this.userPB_MouseLeave);
            // 
            // rolePB
            // 
            this.rolePB.BackColor = System.Drawing.SystemColors.Control;
            this.rolePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rolePB.Location = new System.Drawing.Point(278, 108);
            this.rolePB.Name = "rolePB";
            this.rolePB.Size = new System.Drawing.Size(151, 133);
            this.rolePB.TabIndex = 2;
            this.rolePB.TabStop = false;
            this.rolePB.Click += new System.EventHandler(this.rolePB_Click);
            this.rolePB.MouseEnter += new System.EventHandler(this.rolePB_MouseEnter);
            this.rolePB.MouseLeave += new System.EventHandler(this.rolePB_MouseLeave);
            // 
            // privPB
            // 
            this.privPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.privPB.Location = new System.Drawing.Point(502, 108);
            this.privPB.Name = "privPB";
            this.privPB.Size = new System.Drawing.Size(151, 133);
            this.privPB.TabIndex = 3;
            this.privPB.TabStop = false;
            this.privPB.Click += new System.EventHandler(this.privPB_Click);
            this.privPB.MouseEnter += new System.EventHandler(this.privPB_MouseEnter);
            this.privPB.MouseLeave += new System.EventHandler(this.privPB_MouseLeave);
            // 
            // usrLabel
            // 
            this.usrLabel.AutoSize = true;
            this.usrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usrLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usrLabel.Location = new System.Drawing.Point(88, 264);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(79, 29);
            this.usrLabel.TabIndex = 4;
            this.usrLabel.Text = "USER";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.roleLabel.Location = new System.Drawing.Point(306, 264);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(78, 29);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "ROLE";
            // 
            // privLabel
            // 
            this.privLabel.AutoSize = true;
            this.privLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.privLabel.Location = new System.Drawing.Point(508, 264);
            this.privLabel.Name = "privLabel";
            this.privLabel.Size = new System.Drawing.Size(136, 29);
            this.privLabel.TabIndex = 6;
            this.privLabel.Text = "PRIVILEGE";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 412);
            this.Controls.Add(this.privLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.usrLabel);
            this.Controls.Add(this.privPB);
            this.Controls.Add(this.rolePB);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "AdminForm";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.PictureBox rolePB;
        private System.Windows.Forms.PictureBox privPB;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label privLabel;
    }
}