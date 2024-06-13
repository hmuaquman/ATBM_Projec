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
    public partial class GVienForm : Form
    {
        private LoginForm loginForm;
        public GVienForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.service + ")));Password=" + Account.password + ";User ID=" + Account.username;
            logo.Image = Image.FromFile(@"..\\..\\icon\\hcmus.png");
            icon.Image = Image.FromFile(@"..\\..\\icon\\avatar.png");
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
            pcGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            khmoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pcGridView.ReadOnly = true;
            svGridView.ReadOnly = true;
            khmoGridView.ReadOnly = true;
            hpGridView.ReadOnly = true;
            dvGridView.ReadOnly = true;
            dkGridView.ReadOnly = true;
            this.loginForm = loginForm;
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
        private void dkTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataDK();
        }
        private void infoItem_Click(object sender, EventArgs e)
        {
            TTNVForm tTNVForm = new TTNVForm();
            tTNVForm.Show();
        }

        private void LoadDataDK()
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

        private void GVienForm_Load(object sender, EventArgs e)
        {
            gvTabControl.SelectedTab = svTabPage;
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.NHANSU WHERE MANV = :MANHANVIEN", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MANHANVIEN", Account.username ));
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

        private void noticeItem_Click(object sender, EventArgs e)
        {

        }

        private void editgkButton_Click(object sender, EventArgs e)
        {
            dgkTextBox.Enabled = true;
        }

        private void savegkButton_Click(object sender, EventArgs e)
        {
            if (dgkTextBox.Enabled == true)
            {
                string dgk = dgkTextBox.Text;
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMTHI = :DGK WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));
                        cmd.Parameters.Add(new OracleParameter("DGK", dgk));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataDK();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dgkTextBox.Enabled = false;
            }
        }

        private void editqtButton_Click(object sender, EventArgs e)
        {
            dqtTextBox.Enabled = true;
        }

        private void saveqtButton_Click(object sender, EventArgs e)
        {
            if (dqtTextBox.Enabled == true)
            {
                string dqt = dqtTextBox.Text;
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMQT = :DQT WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));
                        cmd.Parameters.Add(new OracleParameter("DQT", dqt));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataDK();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dqtTextBox.Enabled = false;
            }
        }

        private void editckButton_Click(object sender, EventArgs e)
        {
            dckTextBox.Enabled = true;
        }

        private void saveckButton_Click(object sender, EventArgs e)
        {
            if (dckTextBox.Enabled == true)
            {
                string dck = dckTextBox.Text;
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMCK = :DCK WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));
                        cmd.Parameters.Add(new OracleParameter("DCK", dck));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataDK();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dckTextBox.Enabled = false;
            }
        }

        private void edittkButton_Click(object sender, EventArgs e)
        {
            dtkTextBox.Enabled = true;
        }

        private void savetkButton_Click(object sender, EventArgs e)
        {
            if (dtkTextBox.Enabled == true)
            {
                string dtk = dtkTextBox.Text;
                string maNV = Account.username;
                string maSV = masvTextBox.Text;
                string maHP = mhpTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DANGKY SET DIEMTK = :DTK WHERE MAGV = :MANHANVIEN AND MASV = :MASINHVIEN AND MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", maSV));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", maHP));
                        cmd.Parameters.Add(new OracleParameter("DTK", dtk));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataDK();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                dtkTextBox.Enabled = false;
            }
        }
    }
}
