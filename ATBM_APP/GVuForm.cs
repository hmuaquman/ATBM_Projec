using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_APP
{
    public partial class GVuForm : Form
    {
        private LoginForm loginForm;
        public GVuForm(LoginForm loginForm)
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
            this.loginForm = loginForm;
            htsvSVTextBox.Enabled = false;
            masvSVTextBox.Enabled = false;
            gtSVTextBox.Enabled = false;
            nsSVTextBox.Enabled = false;
            dcSVTextBox.Enabled = false;
            sdtSVTextBox.Enabled = false;
            mnSVTextBox.Enabled = false;
            mctSVTextBox.Enabled = false;
            tctlSVTextBox.Enabled = false;
            dtbSVTextBox.Enabled = false;
            csSVTextBox.Enabled = false;

            mhpHPTextBox.Enabled = false;
            thpHPTextBox.Enabled = false;
            tcHPTextBox.Enabled = false;
            tltHPTextBox.Enabled = false;
            tthHPTextBox.Enabled = false;
            svtdHPTextBox.Enabled = false;
            mdvHPTextBox.Enabled = false;

            pcGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            svGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            khmoGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            hpGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            pcGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            khmoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            pcGridView.ReadOnly = true;
            dkGridView.ReadOnly = true;
            svGridView.ReadOnly = true;
            khmoGridView.ReadOnly = true;
            hpGridView.ReadOnly = true;
            dvGridView.ReadOnly = true;

            mdvDVTextBox.Enabled = false;
            tdvDVTextBox.Enabled = false;
            mtdvDVTextBox.Enabled = false;
            ttdvDVTextBox.Enabled = false;

            mhpKHTextBox.Enabled = false;
            thpKHTextBox.Enabled = false;
            nhKHTextBox.Enabled = false;
            hkKHTextBox.Enabled = false;
            mctKHTextBox.Enabled = false;

            mhpPCComboBox.Enabled = false;
            magvPCComboBox.Enabled = false;
            htgvPCTextBox.Enabled = false;
            thpPCTextBox.Enabled = false;
            hkPCTextBox.Enabled = false;
            nhPCTextBox.Enabled = false;
            mctPCTextBox.Enabled = false;

            bellButton.Image = Image.FromFile(@"..\\..\\icon\\notice.png");
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
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gvTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addsvSVButton_Click(object sender, EventArgs e)
        {
            ThemSVForm tsvForm = new ThemSVForm();
            tsvForm.ShowDialog();
            LoadDataSV();
        }

        private void editsvSVButton_Click(object sender, EventArgs e)
        {
            htsvSVTextBox.Enabled = true;
            masvSVTextBox.Enabled = true;
            gtSVTextBox.Enabled = true;
            nsSVTextBox.Enabled = true;
            dcSVTextBox.Enabled = true;
            sdtSVTextBox.Enabled = true;
            mnSVTextBox.Enabled = true;
            mctSVTextBox.Enabled = true;
            tctlSVTextBox.Enabled = true;
            dtbSVTextBox.Enabled = true;
            csSVTextBox.Enabled = true;
            svGridView.Enabled = false;
        }

        private void savesvSVbutton_Click(object sender, EventArgs e)
        {
            if (masvSVTextBox.Enabled == true)
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.SINHVIEN SET " +
                        "MASV = :MASV," +
                        "HOTEN = :HOTEN, " +
                        "PHAI = :PHAI, " +
                        "NGSINH = TO_DATE(:NGSINH,'DD-MM-YYYY'), " +
                        "DCHI = :DCHI, " +
                        "DT = :DT, " +
                        "MACT = :MACT, " +
                        "MANGANH = :MANGANH, " +
                        "COSO = :COSO, " +
                        "SOTCTL = :SOTCTL, " +
                        "DTBTL = :DTBTL " +
                        "WHERE MASV = :MASINHVIEN", conn))
                    {
                        cmd.BindByName = true;
                        
                        
                        double sotctl = double.Parse(tctlSVTextBox.Text);
                        double dtbtl = double.Parse(dtbSVTextBox.Text);
                        cmd.Parameters.Add(new OracleParameter("SOTCTL", sotctl));
                        cmd.Parameters.Add(new OracleParameter("DTBTL", dtbtl));
                        cmd.Parameters.Add(new OracleParameter("MASV", masvSVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("HOTEN", OracleDbType.NVarchar2)).Value = htsvSVTextBox.Text;
                        cmd.Parameters.Add(new OracleParameter("PHAI", OracleDbType.NVarchar2)).Value = gtSVTextBox.Text;
                        cmd.Parameters.Add(new OracleParameter("NGSINH",nsSVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("DCHI", OracleDbType.NVarchar2)).Value = dcSVTextBox.Text;
                        cmd.Parameters.Add(new OracleParameter("DT", sdtSVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MACT", mctSVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MANGANH", mnSVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("COSO", csSVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MASINHVIEN", temp1.Text));
                       


                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataSV();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                // Vô hiệu hóa các TextBox sau khi cập nhật
                htsvSVTextBox.Enabled = false;
                masvSVTextBox.Enabled = false;
                gtSVTextBox.Enabled = false;
                nsSVTextBox.Enabled = false;
                dcSVTextBox.Enabled = false;
                sdtSVTextBox.Enabled = false;
                mnSVTextBox.Enabled = false;
                mctSVTextBox.Enabled = false;
                tctlSVTextBox.Enabled = false;
                dtbSVTextBox.Enabled = false;
                csSVTextBox.Enabled = false;
                svGridView.Enabled = true;
            }
        }

        private void masvSVLabel_Click(object sender, EventArgs e)
        {

        }

        private void masvSVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void htsvSVLabel_Click(object sender, EventArgs e)
        {

        }

        private void htsvSVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dcSVLabel_Click(object sender, EventArgs e)
        {

        }

        private void dcSVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void svGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = svGridView.Rows[e.RowIndex];
                masvSVTextBox.Text = row.Cells["MASV"].Value.ToString();
                temp1.Text = masvSVTextBox.Text;
                htsvSVTextBox.Text = row.Cells["HOTEN"].Value.ToString();
                gtSVTextBox.Text = row.Cells["PHAI"].Value.ToString();
                nsSVTextBox.Text = row.Cells["NGSINH"].Value.ToString();
                nsSVTextBox.Text = nsSVTextBox.Text.Substring(0, 10);
                dcSVTextBox.Text = row.Cells["DCHI"].Value.ToString();
                sdtSVTextBox.Text = row.Cells["DT"].Value.ToString();
                mnSVTextBox.Text = row.Cells["MANGANH"].Value.ToString();
                mctSVTextBox.Text = row.Cells["MACT"].Value.ToString();
                tctlSVTextBox.Text = row.Cells["SOTCTL"].Value.ToString();
                dtbSVTextBox.Text = row.Cells["DTBTL"].Value.ToString();
                csSVTextBox.Text = row.Cells["COSO"].Value.ToString();
            }
        }
        private void LoadDataSV()
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

        private void edithpHPButton_Click(object sender, EventArgs e)
        {
            mhpHPTextBox.Enabled = true;
            thpHPTextBox.Enabled = true;
            tcHPTextBox.Enabled = true;
            tltHPTextBox.Enabled = true;
            tthHPTextBox.Enabled = true;
            svtdHPTextBox.Enabled = true;
            mdvHPTextBox.Enabled = true;
            hpGridView.Enabled = false;
        }

        private void hpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hpGridView.Rows[e.RowIndex];
                mhpHPTextBox.Text = row.Cells["MAHP"].Value.ToString();
                temp2.Text = row.Cells["MAHP"].Value.ToString();
                thpHPTextBox.Text = row.Cells["TENHP"].Value.ToString();
                tcHPTextBox.Text = row.Cells["SOTC"].Value.ToString();
                tltHPTextBox.Text = row.Cells["STLT"].Value.ToString();
                tthHPTextBox.Text = row.Cells["STTH"].Value.ToString();
                svtdHPTextBox.Text = row.Cells["SOSVTD"].Value.ToString();
                mdvHPTextBox.Text = row.Cells["MADV"].Value.ToString();
            }
        }

        private void savehpHPbutton_Click(object sender, EventArgs e)
        {
            if (mhpHPTextBox.Enabled == true)
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.HOCPHAN SET  " +
                        "                                                                   MAHP = :MAHP, " +
                        "                                                                   TENHP = :TENHP, " +
                        "                                                                   SOTC = :SOTC," +
                        "                                                                   STLT = :STLT," +
                        "                                                                   STTH = :STTH," +
                        "                                                                   SOSVTD = :SOSVTD," +
                        "                                                                   MADV = :MADV " +
                        "                                                                      WHERE MAHP = :MAHOCPHAN", conn))
                    {
                        cmd.BindByName = true;
                        double sotc = double.Parse(tcHPTextBox.Text);
                        double tlt = double.Parse(tltHPTextBox.Text);
                        double tth = double.Parse(tthHPTextBox.Text);
                        double svtd = double.Parse(svtdHPTextBox.Text);
                        cmd.Parameters.Add(new OracleParameter("SOTC", sotc));
                        cmd.Parameters.Add(new OracleParameter("STLT", tlt));
                        cmd.Parameters.Add(new OracleParameter("STTH", tth));
                        cmd.Parameters.Add(new OracleParameter("SOSVTD", svtd));
                        cmd.Parameters.Add(new OracleParameter("MAHP", mhpHPTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("TENHP", OracleDbType.NVarchar2)).Value = thpHPTextBox.Text;
                        cmd.Parameters.Add(new OracleParameter("MADV", mdvHPTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", temp2.Text));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataHP();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                mhpHPTextBox.Enabled = false;
                thpHPTextBox.Enabled = false;
                tcHPTextBox.Enabled = false;
                tltHPTextBox.Enabled = false;
                tthHPTextBox.Enabled = false;
                svtdHPTextBox.Enabled = false;
                mdvHPTextBox.Enabled = false;
                hpGridView.Enabled = true;

            }
        }

        private void addhpHPButton_Click(object sender, EventArgs e)
        {
            ThemHPForm themHPForm = new ThemHPForm();
            themHPForm.ShowDialog();
            LoadDataHP();
        }
        private void LoadDataHP()
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

        private void svtdHPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdvHPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdvHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void svtdHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void tthHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void tthHPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tltHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void mhpHPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tltHPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void thpHPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mhpHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void thpHPLabel_Click(object sender, EventArgs e)
        {

        }

        private void tcHPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GVuForm_Load(object sender, EventArgs e)
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
                string query = "SELECT MAHP FROM ADMIN.HOCPHAN hp JOIN ADMIN.DONVI dv ON hp.MADV = dv.MADV WHERE dv.MADV = :MADV";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MADV", "VPK"));
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
                string query = "SELECT MANV FROM ADMIN.view_decrypted_nhansu ns JOIN ADMIN.DONVI dv ON ns.MADV = dv.MADV WHERE dv.MADV = :MADV";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MADV", "VPK"));
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

        private void icon_Click(object sender, EventArgs e)
        {
            Point menuLocation = new Point(icon.Left - 82, icon.Bottom);
            menu.Show(this, menuLocation);
        }

        private void gvTabControl_Enter(object sender, EventArgs e)
        {

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

        private void logoutItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void editdvDVButton_Click(object sender, EventArgs e)
        {
            mdvDVTextBox.Enabled = true;
            tdvDVTextBox.Enabled = true;
            mtdvDVTextBox.Enabled = true;
            ttdvDVTextBox.Enabled = true;
            dvGridView.Enabled = false;
        }

        private void savedvDVButton_Click(object sender, EventArgs e)
        {
            if (mdvDVTextBox.Enabled == true)
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.DONVI SET " +
                        "MADV = :MADV," +
                        "TENDV = :TENDV, " +
                        "TRGDV = :TRGDV " +
                        "WHERE MADV = :MADONVI", conn))
                    {
                        
                        cmd.Parameters.Add(new OracleParameter("MADV", mdvDVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("TENDV", OracleDbType.NVarchar2)).Value = tdvDVTextBox.Text;
                        cmd.Parameters.Add(new OracleParameter("TRGDV", mtdvDVTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MADONVI", temp3.Text));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataDV();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                // Vô hiệu hóa các TextBox sau khi cập nhật
                mdvDVTextBox.Enabled = false;
                tdvDVTextBox.Enabled = false;
                mtdvDVTextBox.Enabled = false;
                ttdvDVTextBox.Enabled = false;
                dvGridView.Enabled = true;
            }
        }

        private void dvGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvGridView.Rows[e.RowIndex];
                mdvDVTextBox.Text = row.Cells["MADV"].Value.ToString();
                temp3.Text = row.Cells["MADV"].Value.ToString();
                tdvDVTextBox.Text = row.Cells["TENDV"].Value.ToString();
                mtdvDVTextBox.Text = row.Cells["TRGDV"].Value.ToString();
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {
                    using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.NHANSU WHERE MANV = :MANHANVIEN", conn))
                    {

                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", mtdvDVTextBox.Text));
                        try
                        {
                            conn.Open();
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    ttdvDVTextBox.Text = reader["HOTEN"].ToString();
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
        }
        private void LoadDataDV()
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

        private void ttdvDVLabel_Click(object sender, EventArgs e)
        {

        }

        private void mdvDVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtdvDVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtdvDVLabel_Click(object sender, EventArgs e)
        {

        }

        private void tdvDVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdvDVLabel_Click(object sender, EventArgs e)
        {

        }

        private void tdvDVLabel_Click(object sender, EventArgs e)
        {

        }

        private void adddvDVButton_Click(object sender, EventArgs e)
        {
            ThemDVForm themDVForm = new ThemDVForm();
            themDVForm.ShowDialog();
            LoadDataDV();
        }

        private void ttdvDVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void khmoGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = khmoGridView.Rows[e.RowIndex];
                mhpKHTextBox.Text = row.Cells["MAHP"].Value.ToString();
                hkKHTextBox.Text = row.Cells["HK"].Value.ToString();
                nhKHTextBox.Text = row.Cells["NAM"].Value.ToString();
                mctKHTextBox.Text = row.Cells["MACT"].Value.ToString();
                temp1.Text = mhpKHTextBox.Text;
                temp2.Text = hkKHTextBox.Text;
                temp3.Text = nhKHTextBox.Text;
                temp4.Text = mctKHTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {
                    using (OracleCommand cmd = new OracleCommand("SELECT TENHP FROM ADMIN.HOCPHAN WHERE MAHP = :MAHP", conn))
                    {

                        cmd.Parameters.Add(new OracleParameter("MAHP", mhpKHTextBox.Text));
                        try
                        {
                            conn.Open();
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    thpKHTextBox.Text = reader["TENHP"].ToString();
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
        }

        private void editkhKHButton_Click(object sender, EventArgs e)
        {
            mhpKHTextBox.Enabled = true;
            nhKHTextBox.Enabled = true;
            hkKHTextBox.Enabled = true;
            mctKHTextBox.Enabled = true;
            khmoGridView.Enabled = false;
        }

        private void savekhKHButton_Click(object sender, EventArgs e)
        {
            if (mhpKHTextBox.Enabled == true)
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.KHMO SET " +
                        "MAHP = :MAHP," +
                        "HK = :HK, " +
                        "NAM = :NAM, " +
                        "MACT = :MACT " +
                        "WHERE MAHP = :MAHOCPHAN AND HK = :HKY AND NAM = :NAMHOC AND MACT = :MACTRINH", conn))
                    {

                        cmd.Parameters.Add(new OracleParameter("MAHP", mhpKHTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("HK", hkKHTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("NAM", nhKHTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MACT", mctKHTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", temp1.Text));
                        cmd.Parameters.Add(new OracleParameter("HKY", temp2.Text));
                        cmd.Parameters.Add(new OracleParameter("NAMHOC", temp3.Text));
                        cmd.Parameters.Add(new OracleParameter("MACTRINH", temp4.Text));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");
                            LoadDataKH();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                // Vô hiệu hóa các TextBox sau khi cập nhật
                mhpKHTextBox.Enabled = false;
                hkKHTextBox.Enabled = false;
                nhKHTextBox.Enabled = false;
                mctKHTextBox.Enabled = false;
                khmoGridView.Enabled = true;
            }
        }
        private void LoadDataKH()
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

        private void addkhKHButton_Click(object sender, EventArgs e)
        {
            ThemKHForm themKHForm = new ThemKHForm();
            themKHForm.ShowDialog();
            LoadDataKH();
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
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.NHANSU WHERE MANV = :MANHANVIEN", conn))
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
                        using (OracleCommand cmd1 = new OracleCommand("SELECT HOTEN FROM ADMIN.NHANSU WHERE MANV = :MANHANVIEN", conn))
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

        private void dkSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dkSearchTextBox.Text == "")
            {
                LoadDataDK();
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.DANGKY WHERE INSTR(MASV,:MASV) > 0", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MASV", dkSearchTextBox.Text));
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
        }

        private void adddkDKButton_Click(object sender, EventArgs e)
        {
            ThemDKForm themDKForm = new ThemDKForm();
            themDKForm.ShowDialog();
            themDKForm.Close();
            LoadDataDK();
            dkSearchTextBox.Text = "";
        }

        private void deldkDKButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("DELETE FROM ADMIN.DANGKY WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MASV",temp1.Text));
                    cmd.Parameters.Add(new OracleParameter("MAGV",temp2.Text));
                    cmd.Parameters.Add(new OracleParameter("MAHP",temp3.Text));
                    cmd.Parameters.Add(new OracleParameter("HK", temp4.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM",temp5.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT",temp6.Text));
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa đăng ký thành công");
                        LoadDataDK();
                        dkSearchTextBox.Text = "";

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
                temp1.Text = row.Cells["MASV"].Value.ToString();
                temp2.Text = row.Cells["MAGV"].Value.ToString();
                temp3.Text = row.Cells["MAHP"].Value.ToString();
                temp4.Text = row.Cells["HK"].Value.ToString();
                temp5.Text = row.Cells["NAM"].Value.ToString();
                temp6.Text = row.Cells["MACT"].Value.ToString();
            }
        }

        private void infoItem_Click(object sender, EventArgs e)
        {
            TTNVForm tTNVForm = new TTNVForm();
            tTNVForm.Show();
        }
    }
}
