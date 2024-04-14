using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM_APP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //Xử lí sự kiện khi nhấn nút Login
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usnTextbox.Text;
            string password = passTextbox.Text;
            //Kiểm tra thông tin tài khoản, mật khẩu
            if (username == "admin" && password == "admin")
            {
                this.Hide();
                AdminForm admin = new AdminForm();
                admin.Show();
                
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác. Vui lòng thử lại!");
            }
        }
        //Xử lí sự kiện khi nhấn nút Cancel
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //Xử lí sự kiện khi nhấn nút enter lúc con trỏ ở ô đăng nhập -> thực hiện bấm nút login nhanh
        private void passTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
