using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.174.1)(PORT = 1522))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe )));User ID=QUAN ;Password=quan;";
                using (OracleConnection connection = new OracleConnection(connectString))
                {
                    connection.Open();
                    MessageBox.Show("Kết nối đến cơ sở dữ liệu Oracle thành công!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối đến cơ sở dữ liệu Oracle: " + ex.Message);
            }
        }
    }
}
