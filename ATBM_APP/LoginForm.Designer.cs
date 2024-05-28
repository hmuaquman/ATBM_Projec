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
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loginButton.Location = new System.Drawing.Point(78, 171);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(97, 44);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "OK";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cancelButton.Location = new System.Drawing.Point(224, 171);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 44);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pasLabel
            // 
            this.pasLabel.AutoSize = true;
            this.pasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.pasLabel.Location = new System.Drawing.Point(74, 117);
            this.pasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasLabel.Name = "pasLabel";
            this.pasLabel.Size = new System.Drawing.Size(89, 22);
            this.pasLabel.TabIndex = 9;
            this.pasLabel.Text = "Password";
            // 
            // usnlabel
            // 
            this.usnlabel.AutoSize = true;
            this.usnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usnlabel.Location = new System.Drawing.Point(74, 76);
            this.usnlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usnlabel.Name = "usnlabel";
            this.usnlabel.Size = new System.Drawing.Size(92, 22);
            this.usnlabel.TabIndex = 8;
            this.usnlabel.Text = "Username";
            // 
            // passTextbox
            // 
            this.passTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passTextbox.Location = new System.Drawing.Point(176, 115);
            this.passTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.Size = new System.Drawing.Size(146, 27);
            this.passTextbox.TabIndex = 7;
            this.passTextbox.UseSystemPasswordChar = true;
            this.passTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextbox_KeyPress);
            // 
            // usnTextbox
            // 
            this.usnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usnTextbox.Location = new System.Drawing.Point(176, 76);
            this.usnTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usnTextbox.Name = "usnTextbox";
            this.usnTextbox.Size = new System.Drawing.Size(146, 27);
            this.usnTextbox.TabIndex = 6;
            this.usnTextbox.TextChanged += new System.EventHandler(this.usnTextbox_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 283);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pasLabel);
            this.Controls.Add(this.usnlabel);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.usnTextbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
    }
}