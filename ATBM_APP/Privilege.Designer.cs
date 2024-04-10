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
            this.usrTB = new System.Windows.Forms.TextBox();
            this.roleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.privCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.privcheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colCB = new System.Windows.Forms.ComboBox();
            this.revokeButton = new System.Windows.Forms.Button();
            this.grantRlButton = new System.Windows.Forms.Button();
            this.grantUsrButton = new System.Windows.Forms.Button();
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
            this.privGridView.Size = new System.Drawing.Size(573, 451);
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
            // usrTB
            // 
            this.usrTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usrTB.Location = new System.Drawing.Point(97, 128);
            this.usrTB.Name = "usrTB";
            this.usrTB.Size = new System.Drawing.Size(122, 28);
            this.usrTB.TabIndex = 11;
            this.usrTB.TextChanged += new System.EventHandler(this.usrTB_TextChanged);
            // 
            // roleTB
            // 
            this.roleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.roleTB.Location = new System.Drawing.Point(97, 87);
            this.roleTB.Name = "roleTB";
            this.roleTB.Size = new System.Drawing.Size(122, 28);
            this.roleTB.TabIndex = 10;
            this.roleTB.TextChanged += new System.EventHandler(this.roleTB_TextChanged);
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
            "1",
            "2",
            "3",
            "4"});
            this.colCB.Location = new System.Drawing.Point(97, 246);
            this.colCB.Name = "colCB";
            this.colCB.Size = new System.Drawing.Size(122, 28);
            this.colCB.TabIndex = 19;
            // 
            // revokeButton
            // 
            this.revokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.revokeButton.Location = new System.Drawing.Point(16, 411);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(203, 39);
            this.revokeButton.TabIndex = 21;
            this.revokeButton.Text = "Revoke ";
            this.revokeButton.UseVisualStyleBackColor = true;
            // 
            // grantRlButton
            // 
            this.grantRlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grantRlButton.Location = new System.Drawing.Point(16, 357);
            this.grantRlButton.Name = "grantRlButton";
            this.grantRlButton.Size = new System.Drawing.Size(203, 39);
            this.grantRlButton.TabIndex = 22;
            this.grantRlButton.Text = "Grant For Role";
            this.grantRlButton.UseVisualStyleBackColor = true;
            // 
            // grantUsrButton
            // 
            this.grantUsrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grantUsrButton.Location = new System.Drawing.Point(16, 303);
            this.grantUsrButton.Name = "grantUsrButton";
            this.grantUsrButton.Size = new System.Drawing.Size(203, 39);
            this.grantUsrButton.TabIndex = 23;
            this.grantUsrButton.Text = "Grant For User";
            this.grantUsrButton.UseVisualStyleBackColor = true;
            // 
            // Privilege
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 501);
            this.Controls.Add(this.grantUsrButton);
            this.Controls.Add(this.grantRlButton);
            this.Controls.Add(this.revokeButton);
            this.Controls.Add(this.colCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.privcheckBox);
            this.Controls.Add(this.privCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrTB);
            this.Controls.Add(this.roleTB);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.privGridView);
            this.Name = "Privilege";
            this.Text = "Privilege";
            ((System.ComponentModel.ISupportInitialize)(this.privGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView privGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrTB;
        private System.Windows.Forms.TextBox roleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox privCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox privcheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colCB;
        private System.Windows.Forms.Button revokeButton;
        private System.Windows.Forms.Button grantRlButton;
        private System.Windows.Forms.Button grantUsrButton;
    }
}