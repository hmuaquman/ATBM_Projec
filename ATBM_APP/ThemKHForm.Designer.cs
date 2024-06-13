namespace ATBM_APP
{
    partial class ThemKHForm
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
            this.hkKHTextBox = new System.Windows.Forms.TextBox();
            this.hkKHLabel = new System.Windows.Forms.Label();
            this.mctKHTextBox = new System.Windows.Forms.TextBox();
            this.mctKHLabel = new System.Windows.Forms.Label();
            this.mhpKHTextBox = new System.Windows.Forms.TextBox();
            this.nhKHTextBox = new System.Windows.Forms.TextBox();
            this.nhKHLabel = new System.Windows.Forms.Label();
            this.thpKHTextBox = new System.Windows.Forms.TextBox();
            this.mhpKHLabel = new System.Windows.Forms.Label();
            this.thpKHLabel = new System.Windows.Forms.Label();
            this.cancelKHButton = new System.Windows.Forms.Button();
            this.addkhKHButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hkKHTextBox
            // 
            this.hkKHTextBox.Location = new System.Drawing.Point(344, 230);
            this.hkKHTextBox.Name = "hkKHTextBox";
            this.hkKHTextBox.Size = new System.Drawing.Size(93, 22);
            this.hkKHTextBox.TabIndex = 121;
            // 
            // hkKHLabel
            // 
            this.hkKHLabel.AutoSize = true;
            this.hkKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hkKHLabel.Location = new System.Drawing.Point(260, 232);
            this.hkKHLabel.Name = "hkKHLabel";
            this.hkKHLabel.Size = new System.Drawing.Size(61, 20);
            this.hkKHLabel.TabIndex = 120;
            this.hkKHLabel.Text = "Học kỳ";
            // 
            // mctKHTextBox
            // 
            this.mctKHTextBox.Location = new System.Drawing.Point(196, 289);
            this.mctKHTextBox.Name = "mctKHTextBox";
            this.mctKHTextBox.Size = new System.Drawing.Size(241, 22);
            this.mctKHTextBox.TabIndex = 119;
            // 
            // mctKHLabel
            // 
            this.mctKHLabel.AutoSize = true;
            this.mctKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mctKHLabel.Location = new System.Drawing.Point(54, 293);
            this.mctKHLabel.Name = "mctKHLabel";
            this.mctKHLabel.Size = new System.Drawing.Size(129, 20);
            this.mctKHLabel.TabIndex = 118;
            this.mctKHLabel.Text = "Mã chương trình";
            // 
            // mhpKHTextBox
            // 
            this.mhpKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mhpKHTextBox.Location = new System.Drawing.Point(168, 101);
            this.mhpKHTextBox.Name = "mhpKHTextBox";
            this.mhpKHTextBox.Size = new System.Drawing.Size(269, 26);
            this.mhpKHTextBox.TabIndex = 117;
            this.mhpKHTextBox.TextChanged += new System.EventHandler(this.mhpKHTextBox_TextChanged);
            // 
            // nhKHTextBox
            // 
            this.nhKHTextBox.Location = new System.Drawing.Point(138, 230);
            this.nhKHTextBox.Name = "nhKHTextBox";
            this.nhKHTextBox.Size = new System.Drawing.Size(93, 22);
            this.nhKHTextBox.TabIndex = 116;
            // 
            // nhKHLabel
            // 
            this.nhKHLabel.AutoSize = true;
            this.nhKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nhKHLabel.Location = new System.Drawing.Point(54, 234);
            this.nhKHLabel.Name = "nhKHLabel";
            this.nhKHLabel.Size = new System.Drawing.Size(76, 20);
            this.nhKHLabel.TabIndex = 115;
            this.nhKHLabel.Text = "Năm học";
            // 
            // thpKHTextBox
            // 
            this.thpKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.thpKHTextBox.Location = new System.Drawing.Point(168, 165);
            this.thpKHTextBox.Name = "thpKHTextBox";
            this.thpKHTextBox.Size = new System.Drawing.Size(269, 26);
            this.thpKHTextBox.TabIndex = 114;
            // 
            // mhpKHLabel
            // 
            this.mhpKHLabel.AutoSize = true;
            this.mhpKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mhpKHLabel.Location = new System.Drawing.Point(52, 104);
            this.mhpKHLabel.Name = "mhpKHLabel";
            this.mhpKHLabel.Size = new System.Drawing.Size(105, 20);
            this.mhpKHLabel.TabIndex = 113;
            this.mhpKHLabel.Text = "Mã học phần";
            // 
            // thpKHLabel
            // 
            this.thpKHLabel.AutoSize = true;
            this.thpKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.thpKHLabel.Location = new System.Drawing.Point(52, 168);
            this.thpKHLabel.Name = "thpKHLabel";
            this.thpKHLabel.Size = new System.Drawing.Size(110, 20);
            this.thpKHLabel.TabIndex = 112;
            this.thpKHLabel.Text = "Tên học phần";
            // 
            // cancelKHButton
            // 
            this.cancelKHButton.Location = new System.Drawing.Point(94, 358);
            this.cancelKHButton.Name = "cancelKHButton";
            this.cancelKHButton.Size = new System.Drawing.Size(104, 42);
            this.cancelKHButton.TabIndex = 111;
            this.cancelKHButton.Text = "Hủy";
            this.cancelKHButton.UseVisualStyleBackColor = true;
            this.cancelKHButton.Click += new System.EventHandler(this.cancelKHButton_Click);
            // 
            // addkhKHButton
            // 
            this.addkhKHButton.Location = new System.Drawing.Point(298, 358);
            this.addkhKHButton.Name = "addkhKHButton";
            this.addkhKHButton.Size = new System.Drawing.Size(110, 42);
            this.addkhKHButton.TabIndex = 110;
            this.addkhKHButton.Text = "Thêm";
            this.addkhKHButton.UseVisualStyleBackColor = true;
            this.addkhKHButton.Click += new System.EventHandler(this.addkhKHButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.title.Location = new System.Drawing.Point(133, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(231, 29);
            this.title.TabIndex = 132;
            this.title.Text = "Thêm kế hoạch mở";
            // 
            // ThemKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.hkKHTextBox);
            this.Controls.Add(this.hkKHLabel);
            this.Controls.Add(this.mctKHTextBox);
            this.Controls.Add(this.mctKHLabel);
            this.Controls.Add(this.mhpKHTextBox);
            this.Controls.Add(this.nhKHTextBox);
            this.Controls.Add(this.nhKHLabel);
            this.Controls.Add(this.thpKHTextBox);
            this.Controls.Add(this.mhpKHLabel);
            this.Controls.Add(this.thpKHLabel);
            this.Controls.Add(this.cancelKHButton);
            this.Controls.Add(this.addkhKHButton);
            this.Name = "ThemKHForm";
            this.Text = "ThemKHForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hkKHTextBox;
        private System.Windows.Forms.Label hkKHLabel;
        private System.Windows.Forms.TextBox mctKHTextBox;
        private System.Windows.Forms.Label mctKHLabel;
        private System.Windows.Forms.TextBox mhpKHTextBox;
        private System.Windows.Forms.TextBox nhKHTextBox;
        private System.Windows.Forms.Label nhKHLabel;
        private System.Windows.Forms.TextBox thpKHTextBox;
        private System.Windows.Forms.Label mhpKHLabel;
        private System.Windows.Forms.Label thpKHLabel;
        private System.Windows.Forms.Button cancelKHButton;
        private System.Windows.Forms.Button addkhKHButton;
        private System.Windows.Forms.Label title;
    }
}