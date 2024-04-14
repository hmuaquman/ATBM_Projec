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

            Account.username = "QUAN";
            Account.password = "quan";
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + ")));Password=" + Account.password + ";User ID=" + Account.username;

          
            privPB.Image = Image.FromFile(@"..\\..\\icon\\privilege2.png");
            rolePB.Image = Image.FromFile(@"..\\..\\icon\\role2.png");
            userPB.Image = Image.FromFile(@"..\\..\\icon\\user2.png");
            userPB.SizeMode = PictureBoxSizeMode.Zoom;
            privPB.SizeMode = PictureBoxSizeMode.Zoom;
            rolePB.SizeMode = PictureBoxSizeMode.Zoom;
        }

        

        private void userPB_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        private void rolePB_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
        }

        private void privilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privilege priv = new Privilege();
            priv.Show();
        }

        private void privPB_Click(object sender, EventArgs e)
        {
            Privilege priv = new Privilege();
            priv.Show();
        }

        private void usrLabel_Click(object sender, EventArgs e)
        {

        }

        private void userPB_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void rolePB_MouseEnter(object sender, EventArgs e)
        {
            roleLabel.ForeColor = Color.LightGray;
            rolePB.BackColor = Color.LightGray;
        }

        private void userPB_MouseLeave(object sender, EventArgs e)
        {
            usrLabel.ForeColor = Color.Black;
            userPB.BackColor = default(Color);
        }

        private void userPB_MouseEnter(object sender, EventArgs e)
        {
            usrLabel.ForeColor = Color.LightGray;
            userPB.BackColor = Color.LightGray;
        }

        private void userPB_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void rolePB_MouseLeave(object sender, EventArgs e)
        {
            roleLabel.ForeColor= Color.Black;
            rolePB.BackColor = default(Color);
        }

        private void privPB_MouseEnter(object sender, EventArgs e)
        {
            privLabel.ForeColor = Color.LightGray;
            privPB.BackColor = Color.LightGray;
        }

        private void privPB_MouseLeave(object sender, EventArgs e)
        {
            privPB.BackColor= default(Color);
            privLabel.ForeColor = Color.Black;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
