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
    public partial class ThemDVForm : Form
    {
        public ThemDVForm()
        {
            InitializeComponent();
            ttdvDVTextBox.Enabled = false;
        }

        private void cancelDVButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adddvDVButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.DONVI(MADV, TENDV, TRGDV) VALUES (:MADV,:TENDV, :TRGDV) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MADV", mdvDVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("TENDV", OracleDbType.NVarchar2)).Value = tdvDVTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("TRGDV", mtdvDVTextBox.Text));
                    
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới đơn vị thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void mtdvDVTextBox_TextChanged(object sender, EventArgs e)
        {
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
}
