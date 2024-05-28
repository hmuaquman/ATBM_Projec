using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_APP
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Account chứa thông tin liên quan đến connection của admin sử dụng ứng dụng
            Account.username = "ADMIN";
            Account.password = "ADMIN";
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + ")));Password=" + Account.password + ";User ID=" + Account.username;

            //Căn chỉnh và gắn nguồn ảnh từ thư mục icon vào các picture box
            privPB.Image = Image.FromFile(@"..\\..\\icon\\privilege2.png");
            rolePB.Image = Image.FromFile(@"..\\..\\icon\\role2.png");
            userPB.Image = Image.FromFile(@"..\\..\\icon\\user2.png");
            userPB.SizeMode = PictureBoxSizeMode.Zoom;
            privPB.SizeMode = PictureBoxSizeMode.Zoom;
            rolePB.SizeMode = PictureBoxSizeMode.Zoom;
        }

        
        //Xử lí sự kiện khi click ảnh user
        private void userPB_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        //Xử lí sự kiện khi click ảnh role
        private void rolePB_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
        }

        //Xử lí sự kiện khi nhấp user trên toolstripmenu
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        //Xử lí sự kiện khi nhấp role trên tool strip menu
        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
        }

        //Xử lí sự kiện khi nhấp privilege trên tool strip menu
        private void privilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privilege priv = new Privilege();
            priv.Show();
        }

        //Xử lí sự kiện nhấp ảnh Privilege
        private void privPB_Click(object sender, EventArgs e)
        {
            Privilege priv = new Privilege();
            priv.Show();
        }

        
        //Xử lí sự kiện khi đưa chuột vào vùng ảnh role
        private void rolePB_MouseEnter(object sender, EventArgs e)
        {
            roleLabel.ForeColor = Color.LightGray;
            rolePB.BackColor = Color.LightGray;
        }
        // Xử lí sự kiện khi đưa chuột ra khỏi ảnh user
        private void userPB_MouseLeave(object sender, EventArgs e)
        {
            usrLabel.ForeColor = Color.Black;
            userPB.BackColor = default(Color);
        }

        //Xử lí sự kiện khi đưa chuột vào vùng ảnh user
        private void userPB_MouseEnter(object sender, EventArgs e)
        {
            usrLabel.ForeColor = Color.LightGray;
            userPB.BackColor = Color.LightGray;
        }

        //Xử lí sự kiện khi đưa chuột ra khỏi ảnh role
        private void rolePB_MouseLeave(object sender, EventArgs e)
        {
            roleLabel.ForeColor= Color.Black;
            rolePB.BackColor = default(Color);
        }

        //Xử lí sự kiện khi đưa chuột vào vùng ảnh privilege
        private void privPB_MouseEnter(object sender, EventArgs e)
        {
            privLabel.ForeColor = Color.LightGray;
            privPB.BackColor = Color.LightGray;
        }

        //Xử lí sự kiện khi đưa chuột ra khỏi vùng ảnh privilege
        private void privPB_MouseLeave(object sender, EventArgs e)
        {
            privPB.BackColor= default(Color);
            privLabel.ForeColor = Color.Black;
        }

        //Xử lí sự kiện đăng xuất khi click logout trên toolstrip menu
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
