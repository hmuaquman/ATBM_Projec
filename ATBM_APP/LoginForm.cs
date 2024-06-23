using Microsoft.SqlServer.Server;
using Oracle.ManagedDataAccess.Client;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM_APP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Activated += new EventHandler(loginForm_Activated);
            logo.Image = Image.FromFile(@"..\\..\\icon\\hcmus.png");
            logo.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void loginForm_Activated(object sender, EventArgs e)
        {
            // Xử lý khi form được show lại sau khi hide
            Account.username = "ADMIN";
            Account.password = "ADMIN";
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
               + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
               + Account.service + ")));Password=" + Account.password + ";User ID=" + Account.username;
        }

        //Xử lí sự kiện khi nhấn nút Login
        private void loginButton_Click(object sender, EventArgs e)
        { 
            string username = usnTextbox.Text;
            string password = passTextbox.Text;
            if(loaiTKComboBox.Text == "Nhân viên") {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("SELECT VAITRO FROM NHANSU WHERE MANV = :username AND MANV = :password", conn))
                    {
                        try
                        {
                            //Mở kết nối
                            conn.Open();
                            cmd.Parameters.Add(new OracleParameter("username", username));
                            cmd.Parameters.Add(new OracleParameter("password", password));
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string role = reader["VAITRO"].ToString();
                                    Account.username = username;
                                    Account.password = password;

                                    if (role == "Giảng viên")
                                    {
                                        this.Hide();
                                        GVienForm Form = new GVienForm(this);
                                        Form.Show();
                                    }
                                    else if (role == "Nhân viên cơ bản")
                                    {
                                        this.Hide();
                                        NVCBForm Form = new NVCBForm(this);
                                        Form.Show();
                                    }
                                    else if (role == "Trưởng khoa")
                                    {
                                        this.Hide();
                                        TKForm Form = new TKForm(this);
                                        Form.Show();
                                    }
                                    else if (role == "Trưởng đơn vị")
                                    {
                                        this.Hide();
                                        TDVForm Form = new TDVForm(this);
                                        Form.Show();
                                    }
                                    else if (role == "Giáo vụ")
                                    {
                                        this.Hide();
                                        GVuForm Form = new GVuForm(this);
                                        Form.Show();
                                    }

                                    conn.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai, vui lòng thử lại");
                                    conn.Close();
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if(loaiTKComboBox.Text == "Sinh viên")
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("SELECT * FROM SINHVIEN WHERE MASV = :username AND MASV = :password", conn))
                    {
                        try
                        {
                            //Mở kết nối
                            conn.Open();
                            cmd.Parameters.Add(new OracleParameter("username", username));
                            cmd.Parameters.Add(new OracleParameter("password", password));
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Account.username = username;
                                    Account.password = password;
                                    this.Hide();
                                    SVienForm Form = new SVienForm(this);
                                    Form.Show();
                                    conn.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai, vui lòng thử lại");
                                    conn.Close();
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if (loaiTKComboBox.Text == "Admin")
            {
                if(usnTextbox.Text == Account.username && passTextbox.Text == Account.password)
                {
                    this.Hide();
                    AdminForm Form = new AdminForm(this);
                    Form.Show();
                } else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai, vui lòng thử lại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản!!");
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void usnTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usnlabel_Click(object sender, EventArgs e)
        {

        }

        private void pasLabel_Click(object sender, EventArgs e)
        {

        }

        private void passTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
