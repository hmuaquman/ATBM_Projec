namespace ATBM_APP
{
    partial class User
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
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.usrTB = new System.Windows.Forms.TextBox();
            this.pwTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changePassButtton = new System.Windows.Forms.Button();
            this.dropUsButton = new System.Windows.Forms.Button();
            this.createUsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(220, 23);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowHeadersWidth = 51;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(1142, 395);
            this.userGridView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refreshButton.Location = new System.Drawing.Point(25, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(159, 39);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // usrTB
            // 
            this.usrTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usrTB.Location = new System.Drawing.Point(26, 105);
            this.usrTB.Name = "usrTB";
            this.usrTB.Size = new System.Drawing.Size(158, 28);
            this.usrTB.TabIndex = 2;
            // 
            // pwTB
            // 
            this.pwTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pwTB.Location = new System.Drawing.Point(25, 172);
            this.pwTB.Name = "pwTB";
            this.pwTB.Size = new System.Drawing.Size(158, 28);
            this.pwTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // changePassButtton
            // 
            this.changePassButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changePassButtton.Location = new System.Drawing.Point(24, 379);
            this.changePassButtton.Name = "changePassButtton";
            this.changePassButtton.Size = new System.Drawing.Size(159, 39);
            this.changePassButtton.TabIndex = 7;
            this.changePassButtton.Text = "Change Password";
            this.changePassButtton.UseVisualStyleBackColor = true;
            this.changePassButtton.Click += new System.EventHandler(this.changePassButtton_Click);
            // 
            // dropUsButton
            // 
            this.dropUsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dropUsButton.Location = new System.Drawing.Point(24, 308);
            this.dropUsButton.Name = "dropUsButton";
            this.dropUsButton.Size = new System.Drawing.Size(159, 39);
            this.dropUsButton.TabIndex = 8;
            this.dropUsButton.Text = "Drop User";
            this.dropUsButton.UseVisualStyleBackColor = true;
            this.dropUsButton.Click += new System.EventHandler(this.dropUsButton_Click);
            // 
            // createUsButton
            // 
            this.createUsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createUsButton.Location = new System.Drawing.Point(24, 235);
            this.createUsButton.Name = "createUsButton";
            this.createUsButton.Size = new System.Drawing.Size(159, 39);
            this.createUsButton.TabIndex = 9;
            this.createUsButton.Text = "Create User";
            this.createUsButton.UseVisualStyleBackColor = true;
            this.createUsButton.Click += new System.EventHandler(this.createUsButton_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 450);
            this.Controls.Add(this.createUsButton);
            this.Controls.Add(this.dropUsButton);
            this.Controls.Add(this.changePassButtton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwTB);
            this.Controls.Add(this.usrTB);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.userGridView);
            this.Name = "User";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox usrTB;
        private System.Windows.Forms.TextBox pwTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changePassButtton;
        private System.Windows.Forms.Button dropUsButton;
        private System.Windows.Forms.Button createUsButton;
    }
}