namespace ATBM_APP
{
    partial class Privilege
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
            this.privGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.privCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.privcheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colCB = new System.Windows.Forms.ComboBox();
            this.revokeButton = new System.Windows.Forms.Button();
            this.grantUsrButton = new System.Windows.Forms.Button();
            this.checkPrivilegeButton = new System.Windows.Forms.Button();
            this.objCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.privGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // privGridView
            // 
            this.privGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.privGridView.Location = new System.Drawing.Point(263, 24);
            this.privGridView.Name = "privGridView";
            this.privGridView.RowHeadersWidth = 51;
            this.privGridView.RowTemplate.Height = 24;
            this.privGridView.Size = new System.Drawing.Size(985, 469);
            this.privGridView.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refreshButton.Location = new System.Drawing.Point(16, 24);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(203, 39);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "User/Role";
            // 
            // roleTB
            // 
            this.roleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.roleTB.Location = new System.Drawing.Point(97, 87);
            this.roleTB.Name = "roleTB";
            this.roleTB.Size = new System.Drawing.Size(122, 28);
            this.roleTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Privilege";
            // 
            // privCB
            // 
            this.privCB.AllowDrop = true;
            this.privCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.privCB.FormattingEnabled = true;
            this.privCB.Items.AddRange(new object[] {
            "Select",
            "Update",
            "Insert",
            "Delete"});
            this.privCB.Location = new System.Drawing.Point(97, 171);
            this.privCB.Name = "privCB";
            this.privCB.Size = new System.Drawing.Size(122, 28);
            this.privCB.TabIndex = 16;
            this.privCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Object";
            // 
            // privcheckBox
            // 
            this.privcheckBox.AutoSize = true;
            this.privcheckBox.Location = new System.Drawing.Point(97, 215);
            this.privcheckBox.Name = "privcheckBox";
            this.privcheckBox.Size = new System.Drawing.Size(132, 20);
            this.privcheckBox.TabIndex = 17;
            this.privcheckBox.Text = "With Grant Option";
            this.privcheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Column";
            // 
            // colCB
            // 
            this.colCB.AllowDrop = true;
            this.colCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colCB.FormattingEnabled = true;
            this.colCB.Items.AddRange(new object[] {
            "None"});
            this.colCB.Location = new System.Drawing.Point(97, 246);
            this.colCB.Name = "colCB";
            this.colCB.Size = new System.Drawing.Size(122, 28);
            this.colCB.TabIndex = 19;
            this.colCB.SelectedIndexChanged += new System.EventHandler(this.colCB_SelectedIndexChanged);
            // 
            // revokeButton
            // 
            this.revokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.revokeButton.Location = new System.Drawing.Point(16, 377);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(203, 39);
            this.revokeButton.TabIndex = 21;
            this.revokeButton.Text = "Revoke ";
            this.revokeButton.UseVisualStyleBackColor = true;
            this.revokeButton.Click += new System.EventHandler(this.revokeButton_Click);
            // 
            // grantUsrButton
            // 
            this.grantUsrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grantUsrButton.Location = new System.Drawing.Point(16, 304);
            this.grantUsrButton.Name = "grantUsrButton";
            this.grantUsrButton.Size = new System.Drawing.Size(203, 47);
            this.grantUsrButton.TabIndex = 23;
            this.grantUsrButton.Text = "Grant For User/Role";
            this.grantUsrButton.UseVisualStyleBackColor = true;
            this.grantUsrButton.Click += new System.EventHandler(this.grantUsrButton_Click);
            // 
            // checkPrivilegeButton
            // 
            this.checkPrivilegeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkPrivilegeButton.Location = new System.Drawing.Point(16, 439);
            this.checkPrivilegeButton.Name = "checkPrivilegeButton";
            this.checkPrivilegeButton.Size = new System.Drawing.Size(203, 39);
            this.checkPrivilegeButton.TabIndex = 24;
            this.checkPrivilegeButton.Text = "Check Privilege";
            this.checkPrivilegeButton.UseVisualStyleBackColor = true;
            this.checkPrivilegeButton.Click += new System.EventHandler(this.checkPrivilegeButton_Click);
            // 
            // objCB
            // 
            this.objCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.objCB.FormattingEnabled = true;
            this.objCB.Items.AddRange(new object[] {
            "SINHVIEN",
            "NHANSU",
            "HOCPHAN",
            "DONVI",
            "PHANCONG",
            "KHMO",
            "DANGKY"});
            this.objCB.Location = new System.Drawing.Point(97, 128);
            this.objCB.Name = "objCB";
            this.objCB.Size = new System.Drawing.Size(121, 30);
            this.objCB.TabIndex = 25;
            this.objCB.SelectedIndexChanged += new System.EventHandler(this.objCB_SelectedIndexChanged);
            // 
            // Privilege
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1271, 512);
            this.Controls.Add(this.objCB);
            this.Controls.Add(this.checkPrivilegeButton);
            this.Controls.Add(this.grantUsrButton);
            this.Controls.Add(this.revokeButton);
            this.Controls.Add(this.colCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.privcheckBox);
            this.Controls.Add(this.privCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleTB);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.privGridView);
            this.Name = "Privilege";
            this.Text = "Privilege";
            this.Load += new System.EventHandler(this.Privilege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView privGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox privCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox privcheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colCB;
        private System.Windows.Forms.Button revokeButton;
        private System.Windows.Forms.Button grantUsrButton;
        private System.Windows.Forms.Button checkPrivilegeButton;
        private System.Windows.Forms.ComboBox objCB;
    }
}