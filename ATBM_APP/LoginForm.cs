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
        }

        private void usnTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usnTextbox.Text;
            string password = passTextbox.Text;

            // Kiểm tra thông tin đăng nhập
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
