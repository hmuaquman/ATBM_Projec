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
    public partial class ThemKHForm : Form
    {
        public ThemKHForm()
        {
            InitializeComponent();
            thpKHTextBox.Enabled = false;
        }

        private void cancelKHButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addkhKHButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.KHMO(MAHP, HK, NAM, MACT) VALUES (:MAHP,:HK, :NAM, :MACT) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MAHP", mhpKHTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("HK", hkKHTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM", nhKHTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", mctKHTextBox.Text));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới kế hoạch mở thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void mhpKHTextBox_TextChanged(object sender, EventArgs e)
        {
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
}
