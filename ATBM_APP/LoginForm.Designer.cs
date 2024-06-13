namespace ATBM_APP
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pasLabel = new System.Windows.Forms.Label();
            this.usnlabel = new System.Windows.Forms.Label();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.usnTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loaiTKComboBox = new System.Windows.Forms.ComboBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loginButton.Location = new System.Drawing.Point(99, 312);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(129, 54);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "OK";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cancelButton.Location = new System.Drawing.Point(294, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 54);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pasLabel
            // 
            this.pasLabel.AutoSize = true;
            this.pasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.pasLabel.Location = new System.Drawing.Point(94, 205);
            this.pasLabel.Name = "pasLabel";
            this.pasLabel.Size = new System.Drawing.Size(101, 26);
            this.pasLabel.TabIndex = 9;
            this.pasLabel.Text = "Mật khẩu";
            this.pasLabel.Click += new System.EventHandler(this.pasLabel_Click);
            // 
            // usnlabel
            // 
            this.usnlabel.AutoSize = true;
            this.usnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usnlabel.Location = new System.Drawing.Point(48, 154);
            this.usnlabel.Name = "usnlabel";
            this.usnlabel.Size = new System.Drawing.Size(156, 26);
            this.usnlabel.TabIndex = 8;
            this.usnlabel.Text = "Tên đăng nhập";
            this.usnlabel.Click += new System.EventHandler(this.usnlabel_Click);
            // 
            // passTextbox
            // 
            this.passTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passTextbox.Location = new System.Drawing.Point(230, 202);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.Size = new System.Drawing.Size(193, 32);
            this.passTextbox.TabIndex = 7;
            this.passTextbox.UseSystemPasswordChar = true;
            this.passTextbox.TextChanged += new System.EventHandler(this.passTextbox_TextChanged);
            this.passTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextbox_KeyPress);
            // 
            // usnTextbox
            // 
            this.usnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usnTextbox.Location = new System.Drawing.Point(230, 154);
            this.usnTextbox.Name = "usnTextbox";
            this.usnTextbox.Size = new System.Drawing.Size(193, 32);
            this.usnTextbox.TabIndex = 6;
            this.usnTextbox.TextChanged += new System.EventHandler(this.usnTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(48, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Loại tài khoản";
            // 
            // loaiTKComboBox
            // 
            this.loaiTKComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaiTKComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loaiTKComboBox.FormattingEnabled = true;
            this.loaiTKComboBox.Items.AddRange(new object[] {
            "Sinh viên",
            "Nhân viên",
            "Admin"});
            this.loaiTKComboBox.Location = new System.Drawing.Point(230, 253);
            this.loaiTKComboBox.Name = "loaiTKComboBox";
            this.loaiTKComboBox.Size = new System.Drawing.Size(193, 30);
            this.loaiTKComboBox.TabIndex = 13;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(195, 31);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(97, 91);
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 384);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.loaiTKComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pasLabel);
            this.Controls.Add(this.usnlabel);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.usnTextbox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pasLabel;
        private System.Windows.Forms.Label usnlabel;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.TextBox usnTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox loaiTKComboBox;
        private System.Windows.Forms.PictureBox logo;
    }
}