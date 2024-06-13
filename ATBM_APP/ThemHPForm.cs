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
    public partial class ThemHPForm : Form
    {
        public ThemHPForm()
        {
            InitializeComponent();
        }

        private void addhpHPButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.HOCPHAN(MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES (:MAHP,:TENHP, :SOTC,:STLT, :STTH, :SOSVTD, :MADV) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MAHP", mhpHPTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("TENHP", OracleDbType.NVarchar2)).Value = thpHPTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("SOTC", tcHPTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("STLT", tltHPTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("STTH", tthHPTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("SOSVTD", svtdHPTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MADV", mdvHPTextBox.Text));
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                       MessageBox.Show("Thêm mới học phần thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void cancelHPButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
