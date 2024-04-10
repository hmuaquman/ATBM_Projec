using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            

            Account.username = "QUAN";
            Account.password = "quan";
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + ")));Password=" + Account.password + ";User ID=" + Account.username;


            privPB.Image = Image.FromFile("J:\\wf\\ATBM_APP\\ATBM_APP\\icon\\privilege2.png");
            rolePB.Image = Image.FromFile("J:\\wf\\ATBM_APP\\ATBM_APP\\icon\\role2.png");
            userPB.Image = Image.FromFile("J:\\wf\\ATBM_APP\\ATBM_APP\\icon\\user2.png");
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
    }
}
