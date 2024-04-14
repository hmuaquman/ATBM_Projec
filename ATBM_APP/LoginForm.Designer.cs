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
            this.loginButton.Location = new System.Drawing.Point(104, 211);
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
            this.cancelButton.Location = new System.Drawing.Point(299, 211);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 54);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pasLabel
            // 
            this.pasLabel.AutoSize = true;
            this.pasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.pasLabel.Location = new System.Drawing.Point(99, 144);
            this.pasLabel.Name = "pasLabel";
            this.pasLabel.Size = new System.Drawing.Size(108, 26);
            this.pasLabel.TabIndex = 9;
            this.pasLabel.Text = "Password";
            // 
            // usnlabel
            // 
            this.usnlabel.AutoSize = true;
            this.usnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usnlabel.Location = new System.Drawing.Point(99, 93);
            this.usnlabel.Name = "usnlabel";
            this.usnlabel.Size = new System.Drawing.Size(113, 26);
            this.usnlabel.TabIndex = 8;
            this.usnlabel.Text = "Username";
            // 
            // passTextbox
            // 
            this.passTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passTextbox.Location = new System.Drawing.Point(235, 141);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.Size = new System.Drawing.Size(193, 32);
            this.passTextbox.TabIndex = 7;
            this.passTextbox.UseSystemPasswordChar = true;
            this.passTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextbox_KeyPress);
            // 
            // usnTextbox
            // 
            this.usnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usnTextbox.Location = new System.Drawing.Point(235, 93);
            this.usnTextbox.Name = "usnTextbox";
            this.usnTextbox.Size = new System.Drawing.Size(193, 32);
            this.usnTextbox.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 348);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pasLabel);
            this.Controls.Add(this.usnlabel);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.usnTextbox);
            this.Name = "LoginForm";
            this.Text = "Login";
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