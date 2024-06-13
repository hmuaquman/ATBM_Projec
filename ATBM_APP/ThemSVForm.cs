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
    public partial class ThemSVForm : Form
    {
        public ThemSVForm()
        {
            InitializeComponent();
        }

        private void cancelSVButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSVButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.SINHVIEN(MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES (:MASV,:HOTEN, :PHAI,TO_DATE(:NGSINH, 'DD-MM-YYYY'),:DCHI, :DT, :MACT, :MANGANH, :SOTCTL, :DTBTL) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MASV", masvSVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("HOTEN", OracleDbType.NVarchar2)).Value = htsvSVTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("PHAI", OracleDbType.NVarchar2)).Value = gtSVTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("NGSINH", nsSVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("DCHI", OracleDbType.NVarchar2)).Value = dcSVTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("DT", sdtSVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", mctSVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MANGANH", mnSVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("SOTCTL", tctlSVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("DTBTL", dtbSVTextBox.Text));
                    MessageBox.Show(cmd.CommandText);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới sinh viên thành công");

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
