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
    public partial class ThemDKForm : Form
    {
        public ThemDKForm()
        {
            InitializeComponent();
            htsvTextBox.Enabled = false;
            thpTextBox.Enabled = false;
            tgvTextBox.Enabled = false;
        }

        private void addDKButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.DANGKY(MASV,MAGV, MAHP, HK, NAM, MACT) VALUES (:MASV,:MAGV,:MAHP, :HK,:NAM, :MACT) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MASV", masvTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAGV", mgvTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAHP", mhpTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("HK", hkTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM", nhTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", mctTextBox.Text));


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

        private void cancelDKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void masvTextBox_TextChanged(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.SINHVIEN WHERE MASV = :MASINHVIEN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MASINHVIEN", masvTextBox.Text));
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
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT TENHP FROM ADMIN.HOCPHAN WHERE MAHP = :MAHOCPHAN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MAHOCPHAN", mhpTextBox.Text));
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

        private void mgvTextBox_TextChanged(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.NHANSU WHERE MANV = :MAGIANGVIEN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MAGIANGVIEN", mgvTextBox.Text));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                tgvTextBox.Text = reader["HOTEN"].ToString();
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
}
