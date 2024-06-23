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
using static System.Net.Mime.MediaTypeNames;


namespace ATBM_APP
{
    public partial class TKForm : Form
    {
        
        private LoginForm loginForm;
        
        public TKForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
               + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
               + Account.service + ")));Password=" + Account.password + ";User ID=" + Account.username;
            logo.Image = System.Drawing.Image.FromFile(@"..\\..\\icon\\hcmus.png");
            icon.Image = System.Drawing.Image.FromFile(@"..\\..\\icon\\avatar.png");
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            masvTextBox.Enabled = false;
            htsvTextBox.Enabled = false;
            mhpTextBox.Enabled = false;
            thpTextBox.Enabled = false;
            hkTextBox.Enabled = false;
            nhTextBox.Enabled = false;
            mctTextBox.Enabled = false;
            dgkTextBox.Enabled = false;
            dqtTextBox.Enabled = false;
            dckTextBox.Enabled = false;
            dtkTextBox.Enabled = false;
            dkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dkGridView.ReadOnly = true;
            pcGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pcGridView.ReadOnly = true;
            nsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            khmoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nsGridView.ReadOnly = true;
            mhpPCComboBox.Enabled = false;
            magvPCComboBox.Enabled = false;
            htgvPCTextBox.Enabled = false;
            thpPCTextBox.Enabled = false;
            hkPCTextBox.Enabled = false;
            nhPCTextBox.Enabled = false;
            mctPCTextBox.Enabled = false;
            manvTextBox.Enabled = false;
            hotenTextBox.Enabled = false;
            gtTextBox.Enabled = false;
            nsTextBox.Enabled = false;
            pcTextBox.Enabled = false;
            sdtTextBox.Enabled = false;
            cvTextBox.Enabled = false;
            dvTextBox.Enabled = false;
            csTextBox.Enabled = false;

            bellButton.Image = System.Drawing.Image.FromFile(@"..\\..\\icon\\notice.png");
            bellButton.ImageAlign = ContentAlignment.MiddleCenter;
            InitializeNotificationPanel();
            LoadNotifications();
            
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
                    int totalHeight = 0;
                    OracleDataReader reader = command.ExecuteReader();
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
            //Point menuLocation = new Point(icon.Left - 82, icon.Bottom);
            //menu.Show(this, menuLocation);
            notificationPanel.Location = new Point(bellButton.Left - 192, bellButton.Bottom);
            notificationPanel.Visible = !notificationPanel.Visible;
        }
        private void icon_Click(object sender, EventArgs e)
        {
            Point menuLocation = new Point(icon.Left - 82, icon.Bottom);
            menu.Show(this, menuLocation);
        }

        private void logoutItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void svTabPage_Enter(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.SINHVIEN", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            svGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dvTabPage_Enter(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.DONVI", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dvGridView.DataSource = dt;
                        }
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

        private void pcTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataPC();
            if (pcGridView.Rows.Count > 0)
            {
                pcGridView.Rows[0].Selected = true;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                pcGridView_CellClick(pcGridView, args);
            }
        }
        private void dkTabPage_Enter(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.DANGKY", conn))
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
            if (dkGridView.Rows.Count > 0)
            {
                dkGridView.Rows[0].Selected = true;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                dkGridView_CellClick(dkGridView, args);
            }
        }
        private void infoItem_Click(object sender, EventArgs e)
        {
            TTNVForm tTNVForm = new TTNVForm();
            tTNVForm.Show();
        }



        private void dkGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dkGridView.Rows[e.RowIndex];
                masvTextBox.Text = row.Cells["MASV"].Value.ToString();
                mhpTextBox.Text = row.Cells["MAHP"].Value.ToString();
                hkTextBox.Text = row.Cells["HK"].Value.ToString();
                nhTextBox.Text = row.Cells["NAM"].Value.ToString();
                mctTextBox.Text = row.Cells["MACT"].Value.ToString();
                dgkTextBox.Text = row.Cells["DIEMTHI"].Value.ToString();
                dckTextBox.Text = row.Cells["DIEMCK"].Value.ToString();
                dqtTextBox.Text = row.Cells["DIEMQT"].Value.ToString();
                dtkTextBox.Text = row.Cells["DIEMTK"].Value.ToString();
            }
        }

        private void masvTextBox_TextChanged(object sender, EventArgs e)
        {
            string maSV = masvTextBox.Text;
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.SINHVIEN WHERE MASV = :MASINHVIEN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                htsvTextBox.Text = reader["HOTEN"].ToString();
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

        private void mhpTextBox_TextChanged(object sender, EventArgs e)
        {
            string maHP = mhpTextBox.Text;
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT TENHP FROM ADMIN.HOCPHAN WHERE MAHP = :MAHOCPHAN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                thpTextBox.Text = reader["TENHP"].ToString();
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

        private void TKForm_Load(object sender, EventArgs e)
        {
            gvTabControl.SelectedTab = svTabPage;
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.view_decrypted_nhansu WHERE MANV = :MANHANVIEN", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MANHANVIEN", Account.username));
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
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                // Khai báo câu lệnh SQL
                string query = "SELECT MAHP FROM ADMIN.HOCPHAN hp JOIN ADMIN.DONVI dv ON hp.MADV = dv.MADV WHERE dv.TRGDV = :TRUONGDV";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("TRGDV", Account.username));
                    try
                    {
                        // Mở kết nối
                        conn.Open();

                        // Thực thi câu lệnh và đọc dữ liệu
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Thêm các mục vào ComboBox
                                mhpPCComboBox.Items.Add(reader["MAHP"].ToString());
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                // Khai báo câu lệnh SQL
                string query = "SELECT MANV FROM ADMIN.view_decrypted_nhansu ns JOIN ADMIN.DONVI dv ON ns.MADV = dv.MADV WHERE dv.TRGDV = :TRUONGDV";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("TRGDV", Account.username));
                    try
                    {
                        // Mở kết nối
                        conn.Open();

                        // Thực thi câu lệnh và đọc dữ liệu
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Thêm các mục vào ComboBox
                                magvPCComboBox.Items.Add(reader["MANV"].ToString());
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
        }

        private void noticeItem_Click(object sender, EventArgs e)
        {

        }

        private void editgkButton_Click(object sender, EventArgs e)
        {
            temp1.Text = dgkTextBox.Text;
            dgkTextBox.Enabled = true;
            dkGridView.Enabled = false;
            
        }

        private void savegkButton_Click(object sender, EventArgs e)
        {
            if (dgkTextBox.Enabled == true)
            {
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMTHI = :DGK WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.BindByName = true;
                        double dgk = double.Parse(dgkTextBox.Text);
                        cmd.Parameters.Add(new OracleParameter("DGK", dgk));
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thành công");
                            }
                            else
                            {
                                dgkTextBox.Text = temp1.Text;
                                MessageBox.Show("Không thể cập nhật được do không dạy sinh viên này");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dgkTextBox.Enabled = false;
                dkGridView.Enabled = true;
            }
        }

        private void editqtButton_Click(object sender, EventArgs e)
        {
            dqtTextBox.Enabled = true;
            dkGridView.Enabled = false;
            temp1.Text = dqtTextBox.Text;
        }

        private void saveqtButton_Click(object sender, EventArgs e)
        {
            if (dqtTextBox.Enabled == true)
            {
               
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMQT = :DQT WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.BindByName = true;
                        double dqt = double.Parse(dqtTextBox.Text);
                        cmd.Parameters.Add(new OracleParameter("DQT", dqt));
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thành công");
                            }
                            else
                            {
                                dqtTextBox.Text = temp1.Text;
                                MessageBox.Show("Không thể cập nhật được do không dạy sinh viên này");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dqtTextBox.Enabled = false;
                dkGridView.Enabled = true;
            }
        }

        private void editckButton_Click(object sender, EventArgs e)
        {
            dckTextBox.Enabled = true;
            dkGridView.Enabled = false;
            temp1.Text = dckTextBox.Text;
        }

        private void saveckButton_Click(object sender, EventArgs e)
        {
            if (dckTextBox.Enabled == true)
            {
              
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMCK = :DCK WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.BindByName = true;
                        double dck = double.Parse(dckTextBox.Text);
                        cmd.Parameters.Add(new OracleParameter("DCK", dck));
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thành công");
                            }
                            else
                            {
                                dckTextBox.Text = temp1.Text;
                                MessageBox.Show("Không thể cập nhật được do không dạy sinh viên này");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dckTextBox.Enabled = false;
                dkGridView.Enabled = true;
            }
        }

        private void edittkButton_Click(object sender, EventArgs e)
        {
            dtkTextBox.Enabled = true;
            dkGridView.Enabled = false;
            temp1.Text = dtkTextBox.Text;
        }

        private void savetkButton_Click(object sender, EventArgs e)
        {
            if (dtkTextBox.Enabled == true)
            {
                
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMTK = :DTK WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.BindByName = true;
                        double dtk = double.Parse(dtkTextBox.Text);
                        cmd.Parameters.Add(new OracleParameter("DTK", dtk));
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thành công");
                            }
                            else
                            {
                                dtkTextBox.Text = temp1.Text;
                                MessageBox.Show("Không thể cập nhật được do không dạy sinh viên này");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dtkTextBox.Enabled = false;
                dkGridView.Enabled = true;
            }
        }

        private void pcGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = pcGridView.Rows[e.RowIndex];

                temp1.Text = row.Cells["MAGV"].Value.ToString();
                temp2.Text = row.Cells["MAHP"].Value.ToString();
                temp3.Text = row.Cells["HK"].Value.ToString();
                temp4.Text = row.Cells["NAM"].Value.ToString();
                temp5.Text = row.Cells["MACT"].Value.ToString();

                magvPCComboBox.Text = row.Cells["MAGV"].Value.ToString();
                mhpPCComboBox.Text = row.Cells["MAHP"].Value.ToString();
                hkPCTextBox.Text = row.Cells["HK"].Value.ToString();
                nhPCTextBox.Text = row.Cells["NAM"].Value.ToString();
                mctPCTextBox.Text = row.Cells["MACT"].Value.ToString();

                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {
                    try
                    {
                        // Mở kết nối
                        conn.Open();

                        // Truy vấn HOTEN từ ADMIN.NHANSU
                        using (OracleCommand cmd1 = new OracleCommand("SELECT HOTEN FROM ADMIN.view_decrypted_nhansu WHERE MANV = :MANHANVIEN", conn))
                        {
                            cmd1.Parameters.Add(new OracleParameter("MANHANVIEN", magvPCComboBox.Text));
                            using (OracleDataReader reader1 = cmd1.ExecuteReader())
                            {
                                if (reader1.Read())
                                {
                                    htgvPCTextBox.Text = reader1["HOTEN"].ToString();
                                }
                            }
                        }

                        // Truy vấn TENHP từ ADMIN.HOCPHAN
                        using (OracleCommand cmd2 = new OracleCommand("SELECT TENHP FROM ADMIN.HOCPHAN WHERE MAHP = :MAHOCPHAN", conn))
                        {
                            cmd2.Parameters.Add(new OracleParameter("MAHOCPHAN", mhpPCComboBox.Text));
                            using (OracleDataReader reader2 = cmd2.ExecuteReader())
                            {
                                if (reader2.Read())
                                {
                                    thpPCTextBox.Text = reader2["TENHP"].ToString();
                                }
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

        private void savePCButton_Click(object sender, EventArgs e)
        {
            if (mhpPCComboBox.Enabled == true)
            {
                string maGV = magvPCComboBox.Text;
                string maHP = mhpPCComboBox.Text;
                string hk = hkPCTextBox.Text;
                string nh = nhPCTextBox.Text;
                string ct = mctPCTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.PHANCONG SET MAGV = :MAGIANGVIEN, " +
                        "                                                                   MAHP = :MAHOCPHAN, " +
                        "                                                                   HK = :HOCKY," +
                        "                                                                   NAM = :NAMHOC," +
                        "                                                                   MACT = :CT " +
                        "                                                                      WHERE MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MAGIANGVIEN", maGV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));
                        cmd.Parameters.Add(new OracleParameter("HOCKY", hk));
                        cmd.Parameters.Add(new OracleParameter("NAMHOC", nh));
                        cmd.Parameters.Add(new OracleParameter("CT", ct));
                        cmd.Parameters.Add(new OracleParameter("MAGV", temp1.Text));
                        cmd.Parameters.Add(new OracleParameter("MAHP", temp2.Text));
                        cmd.Parameters.Add(new OracleParameter("hk", temp3.Text));
                        cmd.Parameters.Add(new OracleParameter("nam", temp4.Text));
                        cmd.Parameters.Add(new OracleParameter("mact", temp5.Text));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataPC();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                mhpPCComboBox.Enabled = false;
                magvPCComboBox.Enabled = false;
                hkPCTextBox.Enabled = false;
                nhPCTextBox.Enabled = false;
                mctPCTextBox.Enabled = false;
                mhpPCComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                magvPCComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                pcGridView.Enabled = true;
            }
        }

        private void editPCBbutton_Click(object sender, EventArgs e)
        {
            if (isHPVPK(mhpPCComboBox.Text) == true)
            {
                mhpPCComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                magvPCComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                mhpPCComboBox.Enabled = true;
                magvPCComboBox.Enabled = true;
                hkPCTextBox.Enabled = true;
                nhPCTextBox.Enabled = true;
                mctPCTextBox.Enabled = true;
                pcGridView.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chỉ có thể cập nhật các học phần thuộc văn phòng khoa");
            }

        }

        private void mhpPCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT TENHP FROM ADMIN.HOCPHAN WHERE MAHP = :MAHOCPHAN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", mhpPCComboBox.Text));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                thpPCTextBox.Text = reader["TENHP"].ToString();
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

        private void magvPCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.view_decrypted_nhansu WHERE MANV = :MANHANVIEN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MANHANVIEN", magvPCComboBox.Text));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                htgvPCTextBox.Text = reader["HOTEN"].ToString();
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

        private void delPCButton_Click(object sender, EventArgs e)
        {
            if (isHPVPK(mhpPCComboBox.Text) == true)
            {
                string maGV = magvPCComboBox.Text;
                string maHP = mhpPCComboBox.Text;
                string hk = hkPCTextBox.Text;
                string nh = nhPCTextBox.Text;
                string ct = mctPCTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM ADMIN.PHANCONG WHERE MAGV = :MAGIANGVIEN AND MAHP = :MAHOCPHAN AND HK = :HOCKY AND NAM = :NAMHOC AND MACT = :CT", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MAGIANGVIEN", maGV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));
                        cmd.Parameters.Add(new OracleParameter("HOCKY", hk));
                        cmd.Parameters.Add(new OracleParameter("NAMHOC", nh));
                        cmd.Parameters.Add(new OracleParameter("CT", ct));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xóa phân công thành công");
                            LoadDataPC();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉ có thể xóa học phần thuộc văn phòng khoa");
            }

        }

        private void addPCButton_Click(object sender, EventArgs e)
        {
            ThemPCForm Form = new ThemPCForm();
            Form.ShowDialog();
            LoadDataPC();
        }
        private void LoadDataPC()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.PHANCONG", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            pcGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private bool isHPVPK(string mahp)
        {
            string madv = "VPK";
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                try
                {
                    conn.Open();
                    using (OracleCommand cmd1 = new OracleCommand("SELECT * FROM ADMIN.HOCPHAN WHERE MAHP = :MAHP AND MADV = :MADV", conn))
                    {
                        cmd1.Parameters.Add(new OracleParameter("MAHP", mahp));
                        cmd1.Parameters.Add(new OracleParameter("MADV", madv));
                        using (OracleDataReader reader1 = cmd1.ExecuteReader())
                        {
                            if (reader1.Read())
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        private void editNSButton_Click(object sender, EventArgs e)
        {
            if (pcTextBox.Text == "")
            {
                MessageBox.Show("Xem phụ cấp trước khi sửa!!");
            }
            else
            {
                manvTextBox.Enabled = true;
                hotenTextBox.Enabled = true;
                gtTextBox.Enabled = true;
                nsTextBox.Enabled = true;
                pcTextBox.Enabled = true;
                sdtTextBox.Enabled = true;
                cvTextBox.Enabled = true;
                dvTextBox.Enabled = true;
                csTextBox.Enabled = true;
                pcTextBox.Enabled = true;
                nsGridView.Enabled = false;
            }
        }


        private void nsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = nsGridView.Rows[e.RowIndex];

                temp1.Text = row.Cells["MANV"].Value.ToString();

                manvTextBox.Text = row.Cells["MANV"].Value.ToString();
                hotenTextBox.Text = row.Cells["HOTEN"].Value.ToString();
                gtTextBox.Text = row.Cells["PHAI"].Value.ToString();
                nsTextBox.Text = row.Cells["NGSINH"].Value.ToString();
                nsTextBox.Text = nsTextBox.Text.Substring(0, 10);
                sdtTextBox.Text = row.Cells["DT"].Value.ToString();
                cvTextBox.Text = row.Cells["VAITRO"].Value.ToString();
                dvTextBox.Text = row.Cells["MADV"].Value.ToString();
                csTextBox.Text = row.Cells["COSO"].Value.ToString();
                pcTextBox.Text = "";
            }
        }

        private void saveNSButton_Click(object sender, EventArgs e)
        {
            if (manvTextBox.Enabled == true)
            {
                string maNV = manvTextBox.Text;
                string ht = hotenTextBox.Text;
                string phai = gtTextBox.Text;
                string ns = nsTextBox.Text;
                string pc = pcTextBox.Text;
                
                string sdt = sdtTextBox.Text;
                string cv = cvTextBox.Text;
                string dv = dvTextBox.Text;
                string cs = csTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.NHANSU SET MANV = :MANV, " + 
                        "                                                                   HOTEN = :HOTEN, " +
                        "                                                                   PHAI = :PHAI, " +
                        "                                                                   NGSINH = TO_DATE(:NGSINH,'DD-MM-YYYY')," +
                        "                                                                   PHUCAP = :PHUCAP," +
                        "                                                                   DT = :DT, " +
                        "                                                                   VAITRO = :VAITRO," +
                        "                                                                   MADV = :MADV, " +
                        "                                                                   COSO = :COSO " +
                        "                                                                      WHERE MANV = :MANHANVIEN", conn))
                    {
                        //cmd.Parameters.Add(new OracleParameter("NGSINH", OracleDbType.Date)).Value = ns;
                        cmd.Parameters.Add(new OracleParameter("NGSINH", ns));
                        cmd.Parameters.Add(new OracleParameter("MANV", maNV));
                        cmd.Parameters.Add(new OracleParameter("PHUCAP", pc));
                        cmd.Parameters.Add(new OracleParameter("HOTEN", OracleDbType.NVarchar2)).Value = ht;
                        cmd.Parameters.Add(new OracleParameter("PHAI", OracleDbType.NVarchar2)).Value = phai;
                        
                        
                        cmd.Parameters.Add(new OracleParameter("DT", sdt));
                        cmd.Parameters.Add(new OracleParameter("VAITRO", OracleDbType.NVarchar2)).Value = cv;
                        cmd.Parameters.Add(new OracleParameter("MADV", dv));
                        cmd.Parameters.Add(new OracleParameter("COSO", cs));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", temp1.Text));
         
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataNS();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                manvTextBox.Enabled = false;
                gtTextBox.Enabled = false;
                nsTextBox.Enabled = false;
                sdtTextBox.Enabled = false;
                cvTextBox.Enabled = false;
                hotenTextBox.Enabled = false;
                pcTextBox.Enabled = false;
                dvTextBox.Enabled = false;
                csTextBox.Enabled = false;
                nsGridView.Enabled = true;
            }
        }

        private void delNSButton_Click(object sender, EventArgs e)
        {
            string maNV = manvTextBox.Text;

            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("DELETE FROM ADMIN.NHANSU WHERE MANV = :MANV", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MANV", maNV));
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhân sự thành công");
                        LoadDataNS();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void LoadDataNS()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT MANV, HOTEN, PHAI, NGSINH, DT, VAITRO, MADV, COSO FROM ADMIN.view_decrypted_nhansu", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            nsGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void addNSButton_Click(object sender, EventArgs e)
        {
            ThemNSForm Form = new ThemNSForm();
            Form.ShowDialog();
            LoadDataNS();
        }

        private void nsTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataNS();
            if (nsGridView.Rows.Count > 0)
            {
                nsGridView.Rows[0].Selected = true;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                nsGridView_CellClick(nsGridView, args);
            }
        }

        private void viewpcapButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                string manv = manvTextBox.Text;
                string query = $"SELECT PHUCAP FROM ADMIN.view_decrypted_nhansu WHERE MANV = '{manv}'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {

                    //cmd.Parameters.Add(new OracleParameter("MANHANVIEN", manvTextBox.Text));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                pcTextBox.Text = reader["PHUCAP"].ToString();
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

        private void nsGridView_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
