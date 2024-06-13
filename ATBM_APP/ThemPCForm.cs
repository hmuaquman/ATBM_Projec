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

namespace ATBM_APP
{
    public partial class ThemPCForm : Form
    {
        public ThemPCForm()
        {
            InitializeComponent();
            htgvPCTextBox.Enabled = false;
            thpPCTextBox.Enabled = false;
            mhpPCComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            magvPCComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ThemPCForm_Load(object sender, EventArgs e)
        {
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
                string query = "SELECT MANV FROM ADMIN.NHANSU ns JOIN ADMIN.DONVI dv ON ns.MADV = dv.MADV WHERE dv.TRGDV = :TRUONGDV";

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

        private void addPCButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.PHANCONG(MAGV, MAHP, HK, NAM, MACT) VALUES (:MAGV,:MAHP, :HK,:NAM, :MACT) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MAGV", magvPCComboBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAHP", mhpPCComboBox.Text));
                    cmd.Parameters.Add(new OracleParameter("HK", hkPCTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM", nhPCTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", mctPCTextBox.Text));
                    
                    
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới phân công thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void exiAddPCButton_Click(object sender, EventArgs e)
        { 
            this.Close();
            
        }
    }
}
