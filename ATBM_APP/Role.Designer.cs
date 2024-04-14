namespace ATBM_APP
{
    partial class Role
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
            this.roleGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usrTB = new System.Windows.Forms.TextBox();
            this.roleTB = new System.Windows.Forms.TextBox();
            this.createRoleButton = new System.Windows.Forms.Button();
            this.dropRoleButton = new System.Windows.Forms.Button();
            this.grantRoleButton = new System.Windows.Forms.Button();
            this.revokeRoleButton = new System.Windows.Forms.Button();
            this.checkRoleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roleGridView
            // 
            this.roleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleGridView.Location = new System.Drawing.Point(248, 26);
            this.roleGridView.Name = "roleGridView";
            this.roleGridView.RowHeadersWidth = 51;
            this.roleGridView.RowTemplate.Height = 24;
            this.roleGridView.Size = new System.Drawing.Size(823, 451);
            this.roleGridView.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refreshButton.Location = new System.Drawing.Point(31, 26);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(159, 39);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Role";
            // 
            // usrTB
            // 
            this.usrTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usrTB.Location = new System.Drawing.Point(71, 129);
            this.usrTB.Name = "usrTB";
            this.usrTB.Size = new System.Drawing.Size(122, 28);
            this.usrTB.TabIndex = 7;
            // 
            // roleTB
            // 
            this.roleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.roleTB.Location = new System.Drawing.Point(71, 88);
            this.roleTB.Name = "roleTB";
            this.roleTB.Size = new System.Drawing.Size(122, 28);
            this.roleTB.TabIndex = 6;
            // 
            // createRoleButton
            // 
            this.createRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createRoleButton.Location = new System.Drawing.Point(34, 188);
            this.createRoleButton.Name = "createRoleButton";
            this.createRoleButton.Size = new System.Drawing.Size(159, 39);
            this.createRoleButton.TabIndex = 11;
            this.createRoleButton.Text = "Create Role";
            this.createRoleButton.UseVisualStyleBackColor = true;
            this.createRoleButton.Click += new System.EventHandler(this.createRoleButton_Click);
            // 
            // dropRoleButton
            // 
            this.dropRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dropRoleButton.Location = new System.Drawing.Point(34, 251);
            this.dropRoleButton.Name = "dropRoleButton";
            this.dropRoleButton.Size = new System.Drawing.Size(159, 39);
            this.dropRoleButton.TabIndex = 12;
            this.dropRoleButton.Text = "Drop Role";
            this.dropRoleButton.UseVisualStyleBackColor = true;
            this.dropRoleButton.Click += new System.EventHandler(this.dropRoleButton_Click);
            // 
            // grantRoleButton
            // 
            this.grantRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grantRoleButton.Location = new System.Drawing.Point(34, 312);
            this.grantRoleButton.Name = "grantRoleButton";
            this.grantRoleButton.Size = new System.Drawing.Size(159, 39);
            this.grantRoleButton.TabIndex = 13;
            this.grantRoleButton.Text = "Grant Role";
            this.grantRoleButton.UseVisualStyleBackColor = true;
            this.grantRoleButton.Click += new System.EventHandler(this.grantRoleButton_Click);
            // 
            // revokeRoleButton
            // 
            this.revokeRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.revokeRoleButton.Location = new System.Drawing.Point(34, 376);
            this.revokeRoleButton.Name = "revokeRoleButton";
            this.revokeRoleButton.Size = new System.Drawing.Size(159, 39);
            this.revokeRoleButton.TabIndex = 14;
            this.revokeRoleButton.Text = "Revoke Role";
            this.revokeRoleButton.UseVisualStyleBackColor = true;
            this.revokeRoleButton.Click += new System.EventHandler(this.revokeRoleButton_Click);
            // 
            // checkRoleButton
            // 
            this.checkRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkRoleButton.Location = new System.Drawing.Point(34, 438);
            this.checkRoleButton.Name = "checkRoleButton";
            this.checkRoleButton.Size = new System.Drawing.Size(159, 39);
            this.checkRoleButton.TabIndex = 15;
            this.checkRoleButton.Text = "Check Role";
            this.checkRoleButton.UseVisualStyleBackColor = true;
            this.checkRoleButton.Click += new System.EventHandler(this.checkRoleButton_Click);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 498);
            this.Controls.Add(this.checkRoleButton);
            this.Controls.Add(this.revokeRoleButton);
            this.Controls.Add(this.grantRoleButton);
            this.Controls.Add(this.dropRoleButton);
            this.Controls.Add(this.createRoleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrTB);
            this.Controls.Add(this.roleTB);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.roleGridView);
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roleGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrTB;
        private System.Windows.Forms.TextBox roleTB;
        private System.Windows.Forms.Button createRoleButton;
        private System.Windows.Forms.Button dropRoleButton;
        private System.Windows.Forms.Button grantRoleButton;
        private System.Windows.Forms.Button revokeRoleButton;
        private System.Windows.Forms.Button checkRoleButton;
    }
}