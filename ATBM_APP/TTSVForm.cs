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
    public partial class TTSVForm : Form
    {
        public TTSVForm()
        {
            InitializeComponent();
            masvSVTextBox.Enabled = false;
            htsvSVTextBox.Enabled = false;
            gtSVTextBox.Enabled = false;
            nsSVTextBox.Enabled = false;
            dcSVTextBox.Enabled = false;
            sdtSVTextBox.Enabled = false;
            mnSVTextBox.Enabled = false;
            mctSVTextBox.Enabled = false;
            tctlSVTextBox.Enabled = false;
            dtbSVTextBox.Enabled = false;
            csTextBox.Enabled = false;
        }

        

        private void editButton_Click(object sender, EventArgs e)
        {
            dcSVTextBox.Enabled = true;
            sdtSVTextBox.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sdtSVTextBox.Enabled == true)
            {
                string maSV = masvSVTextBox.Text;
                string dc = dcSVTextBox.Text;
                string sdt = sdtSVTextBox.Text;
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("UPDATE ADMIN.SINHVIEN SET DT = :SDT, DCHI = :DCHI WHERE MANV = :MANHANVIEN ", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("DT", sdt));
                        cmd.Parameters.Add(new OracleParameter("DCHI", OracleDbType.NVarchar2)).Value = dc;
                        cmd.Parameters.Add(new OracleParameter("MANHANVIEN", maSV));
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
                dcSVTextBox.Enabled = false;
                sdtSVTextBox.Enabled = false;
            }
        }

        private void TTSVForm_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.SINHVIEN", conn))
                {
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                masvSVTextBox.Text = reader["MASV"].ToString();
                                htsvSVTextBox.Text = reader["HOTEN"].ToString();
                                gtSVTextBox.Text = reader["PHAI"].ToString();
                                nsSVTextBox.Text = reader["NGSINH"].ToString();
                                nsSVTextBox.Text = nsSVTextBox.Text.Substring(0, 10);
                                sdtSVTextBox.Text = reader["DT"].ToString();
                                dcSVTextBox.Text = reader["DCHI"].ToString();
                                mnSVTextBox.Text = reader["MANGANH"].ToString();
                                mctSVTextBox.Text = reader["MACT"].ToString();
                                tctlSVTextBox.Text = reader["STCTL"].ToString();
                                dtbSVTextBox.Text = reader["DTBTL"].ToString();
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
    }
}
