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

namespace ATBM_APP
{
    public partial class SVienForm : Form
    {
        private LoginForm loginForm;
        public SVienForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.service + ")));Password=" + Account.password + ";User ID=" + Account.username;

            logo.Image = Image.FromFile(@"..\\..\\icon\\hcmus.png");
            icon.Image = Image.FromFile(@"..\\..\\icon\\stu_avatar.png");
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            khmoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            khmoGridView.ReadOnly = true;
            hpGridView.ReadOnly = true;
            dkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dkGridView.ReadOnly = true;
            bellButton.Image = Image.FromFile(@"..\\..\\icon\\notice.png");
            bellButton.ImageAlign = ContentAlignment.MiddleCenter;
            InitializeNotificationPanel();
            LoadNotifications();
            dkhpGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsdkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void InitializeNotificationPanel()
        {
            notificationPanel = new FlowLayoutPanel();
            notificationPanel.WrapContents = false;
            notificationPanel.FlowDirection = FlowDirection.TopDown;
            notificationPanel.BorderStyle = BorderStyle.FixedSingle;
            notificationPanel.Visible = false;
            notificationPanel.Size = new Size(230, 300);
            this.Controls.Add(notificationPanel);
            notificationPanel.BringToFront();

            notificationPanel.HorizontalScroll.Enabled = false;
            notificationPanel.HorizontalScroll.Visible = false;
            notificationPanel.AutoScroll = true;
        }
        private void LoadNotifications()
        {
            notificationPanel.Controls.Clear();

            string query = "SELECT NOIDUNG FROM ADMIN_OLS.OLS_THONGBAO"; // Thay đổi tên bảng và cột theo cơ sở dữ liệu của bạn

            try
            {
                using (OracleConnection connection = new OracleConnection(Account.connectString))
                {
                    OracleCommand command = new OracleCommand(query, connection);
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();
                    int totalHeight = 0;
                    Font font = new Font("Microsoft Sans Serif", 8);
                    while (reader.Read())
                    {
                        string notificationText = reader["NOIDUNG"].ToString();
                        Label label = new Label();
                        label.Text = notificationText;
                        label.Width = 200;

                        using (Graphics g = notificationPanel.CreateGraphics())
                        {
                            SizeF size = g.MeasureString(notificationText, font);
                            float textWidth = size.Width;
                            label.Height = (((int)textWidth / label.Width) + 1) * 20;
                        }

                        label.AutoSize = false;

                        label.BorderStyle = BorderStyle.FixedSingle;
                        label.Padding = new Padding(5);
                        label.Margin = new Padding(4);
                        label.BackColor = Color.White;
                        notificationPanel.Controls.Add(label);
                        totalHeight += label.Height + label.Margin.Vertical;
                    }

                    reader.Close();
                    totalHeight += notificationPanel.Padding.Vertical;
                    int panelHeight = Math.Min(totalHeight, 292);
                    notificationPanel.Size = new Size(notificationPanel.Width, panelHeight + 8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bellButton_Click(object sender, EventArgs e)
        {
            notificationPanel.Location = new Point(bellButton.Left - 192, bellButton.Bottom);
            notificationPanel.Visible = !notificationPanel.Visible;
        }
        private void icon_Click(object sender, EventArgs e)
        {
            Point menuLocation = new Point(icon.Left - 82, icon.Bottom);
            menu.Show(this, menuLocation);
        }

        private void SVienForm_Load(object sender, EventArgs e)
        {
            gvTabControl.SelectedTab = hpTabPage;
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.SINHVIEN WHERE MASV = :MASV", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MASV", Account.username));
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                helloLabel.Text = "Xin chào " + reader["HOTEN"].ToString() + " !";
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void hpTabPage_Enter(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.HOCPHAN", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            hpGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void khmoTabPage_Enter(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.KHMO", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            khmoGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dkGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dkGridView.Rows[e.RowIndex];
            //    magvTextBox.Text = row.Cells["MASV"].Value.ToString();
            //    mhpTextBox.Text = row.Cells["MAHP"].Value.ToString();
            //    hkTextBox.Text = row.Cells["HK"].Value.ToString();
            //    nhTextBox.Text = row.Cells["NAM"].Value.ToString();
            //    mctTextBox.Text = row.Cells["MACT"].Value.ToString();
            //    temp1.Text = magvTextBox.Text;
            //    temp2.Text = mhpTextBox.Text;
            //    temp3.Text = hkTextBox.Text;
            //    temp4.Text = nhTextBox.Text;
            //    temp5.Text = mctTextBox.Text;
            //    dgkTextBox.Text = row.Cells["DIEMTHI"].Value.ToString();
            //    dckTextBox.Text = row.Cells["DIEMCK"].Value.ToString();
            //    dqtTextBox.Text = row.Cells["DIEMQT"].Value.ToString();
            //    dtkTextBox.Text = row.Cells["DIEMTK"].Value.ToString();
            //}
        }
        private void LoadDataDK()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT dk.HK, dk.NAM, dk.MAHP, hp.TENHP, hp.SOTC, dk.DIEMQT, dk.DIEMTHI, dk.DIEMCK, dk.DIEMTK  FROM ADMIN.DANGKY dk JOIN ADMIN.HOCPHAN hp ON hp.MAHP = dk.MAHP WHERE dk.DIEMTHI IS NOT NULL ", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dkGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dkTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataDK();
        }

        private void logoutItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void infoItem_Click(object sender, EventArgs e)
        {
            TTSVForm tTSVForm = new TTSVForm();
            tTSVForm.Show();
        }

        private void noticeItem_Click(object sender, EventArgs e)
        {

        }

       

       

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataLMO()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                string query = "SELECT kh.HK, kh.NAM, kh.MACT,hp.* FROM ADMIN.HOCPHAN hp JOIN ADMIN.KHMO kh ON hp.MAHP = kh.MAHP WHERE kh.HK = ( CASE WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 9 AND 12 THEN '1' WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 1 AND 4 THEN '2' ELSE '3' END) AND kh.NAM = TO_CHAR(SYSDATE, 'YYYY')";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dkhpGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void LoadDataDADK()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                string query = "SELECT dk.HK,dk.NAM,dk.MACT, hp.*, dk.MAGV  FROM ADMIN.DANGKY dk JOIN ADMIN.HOCPHAN hp ON dk.MAHP = hp.MAHP WHERE dk.HK = ( CASE WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 9 AND 12 THEN '1' WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 1 AND 4 THEN '2' ELSE '3' END) AND dk.NAM = TO_CHAR(SYSDATE, 'YYYY')";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dsdkGridView.DataSource = dt;
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dkhptabPage_Enter(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            int currentDay = currentDate.Day;
            int currentMonth = currentDate.Month;

            if ((currentDay >= 1 && currentDay <= 14) && (currentMonth == 1 || currentMonth == 5 || currentMonth == 9))
            {
                dsdkGridView.Visible = true;
                dkhpGridView.Visible = true;
                deldkDKButton.Visible = true;
                adddkDKButton.Visible = true;
                label7.Visible= true;
                label8.Visible= true;
                label9.Visible = false;
                LoadDataLMO();
                LoadDataDADK();
            }
            else
            {
                dsdkGridView.Visible = false;
                dkhpGridView.Visible = false;
                deldkDKButton.Visible = false;
                adddkDKButton.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = true;
                
            }
        }

        private void deldkDKButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("DELETE FROM ADMIN.DANGKY WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MASV", Account.username));
                    cmd.Parameters.Add(new OracleParameter("MAGV", temp1.Text));
                    cmd.Parameters.Add(new OracleParameter("MAHP", temp2.Text));
                    cmd.Parameters.Add(new OracleParameter("HK", temp4.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM", temp3.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", temp5.Text));
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Hủy đăng ký thành công");
                        LoadDataDADK();
                        LoadDataLMO();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void adddkDKButton_Click(object sender, EventArgs e)
        {
            label10.Text = Account.username;
            label11.Text = Account.password;
            
            Account.username = "NV008";
            Account.password = "NV008";
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
              + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
              + Account.service + ")));Password=" + Account.password + ";User ID=" + Account.username;
         
            
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                string query = "SELECT MAGV  FROM ADMIN.PHANCONG  WHERE MAHP = :MAHP AND NAM = :NAM AND HK = :HK AND MACT = :MACT";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MAHP", temp2.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM", temp3.Text));
                    cmd.Parameters.Add(new OracleParameter("HK", temp4.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", temp5.Text));
                    
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        temp1.Text = "";
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                temp1.Text = reader["MAGV"].ToString();  
                            } else
                            {
                                MessageBox.Show("Môn học chưa được phân công dạy.");
                                temp1.Text = "";
                            }
                            
                            
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                

            }

            if (temp1.Text != "")
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.DANGKY(MASV,MAGV, MAHP, HK, NAM, MACT) VALUES (:MASV,:MAGV,:MAHP, :HK,:NAM, :MACT) ", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MASV", label10.Text));

                        cmd.Parameters.Add(new OracleParameter("MAGV", temp1.Text));
                        cmd.Parameters.Add(new OracleParameter("MAHP", temp2.Text));
                        cmd.Parameters.Add(new OracleParameter("HK", temp4.Text));
                        cmd.Parameters.Add(new OracleParameter("NAM", temp3.Text));
                        cmd.Parameters.Add(new OracleParameter("MACT", temp5.Text));
                        try
                        {
                            conn.Open();


                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Thêm mới đăng ký thành công");


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            Account.username = label10.Text;
            Account.password = label11.Text;
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.service + ")));Password=" + Account.password + ";User ID=" + Account.username;
            LoadDataDADK();
            
        }

        private void dkhpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dkhpGridView.Rows[e.RowIndex];
                temp2.Text = row.Cells["MAHP"].Value.ToString();
                temp3.Text = row.Cells["NAM"].Value.ToString();
                temp4.Text = row.Cells["HK"].Value.ToString();
                temp5.Text = row.Cells["MACT"].Value.ToString();
                
            }
        }

        private void dsdkGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dsdkGridView.Rows[e.RowIndex];
                temp1.Text = row.Cells["MAGV"].Value.ToString();
                temp2.Text = row.Cells["MAHP"].Value.ToString();
                temp3.Text = row.Cells["NAM"].Value.ToString();
                temp4.Text = row.Cells["HK"].Value.ToString();
                temp5.Text = row.Cells["MACT"].Value.ToString();

            }
        }
    }
}
