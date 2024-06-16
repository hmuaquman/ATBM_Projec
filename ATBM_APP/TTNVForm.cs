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
    public partial class TTNVForm : Form
    {
        public TTNVForm()
        {
            InitializeComponent();
            hotenTextBox.Enabled = false;
            manvTextBox.Enabled = false;
            cvTextBox.Enabled = false;  
            sdtTextBox.Enabled = false; 
            pcTextBox.Enabled = false;    
            gtTextBox.Enabled = false;
            dvTextBox.Enabled = false;
            nsTextBox.Enabled = false;
            csTextBox.Enabled = false;
        }

        private void TTNVForm_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.NHANSU ns JOIN ADMIN.DONVI dv ON ns.MADV = dv.MADV AND MANV = :MANHANVIEN", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MANHANVIEN", Account.username));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                manvTextBox.Text = reader["MANV"].ToString();
                                cvTextBox.Text = reader["VAITRO"].ToString();
                                hotenTextBox.Text = reader["HOTEN"].ToString();
                                gtTextBox.Text = reader["PHAI"].ToString();
                                nsTextBox.Text = reader["NGSINH"].ToString();
                                nsTextBox.Text = nsTextBox.Text.Substring(0, 10);
                                sdtTextBox.Text = reader["DT"].ToString();
                                pcTextBox.Text = reader["PHUCAP"].ToString();
                                dvTextBox.Text = reader["TENDV"].ToString();
                                csTextBox.Text = reader["COSO"].ToString();
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

        private void editButton_Click(object sender, EventArgs e)
        {
            sdtTextBox.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sdtTextBox.Enabled == true)
            {
                string maNV = manvTextBox.Text;
                string sdt = sdtTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.NHANSU SET DT = :SDT WHERE MANV = :MANHANVIEN ", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("DT", sdt));
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maNV));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                sdtTextBox.Enabled = false;
            }
        }
    }
}
