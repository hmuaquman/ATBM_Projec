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
    public partial class ThemNSForm : Form
    {
        public ThemNSForm()
        {
            InitializeComponent();
            manvTextBox.Enabled = true;
            gtTextBox.Enabled = true;
            nsTextBox.Enabled = true;
            pcTextBox.Enabled = true;
            sdtTextBox.Enabled = true;
            cvTextBox.Enabled = true;
            dvTextBox.Enabled = true;
            hotenTextBox.Enabled = true;
        }

      

        private void exitADDNSButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNSButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, COSO) VALUES (:MANV,:HOTEN, :PHAI,TO_DATE(:NGSINH,'DD-MM-YYYY'), :PHUCAP, :DT, :VAITRO, :MADV, :COSO) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("PHUCAP", pcTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MANV", manvTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("HOTEN",OracleDbType.NVarchar2)).Value =  hotenTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("PHAI", OracleDbType.NVarchar2)).Value = gtTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("NGSINH",nsTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("DT", sdtTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("VAITRO", OracleDbType.NVarchar2)).Value = cvTextBox.Text;
                    cmd.Parameters.Add(new OracleParameter("MADV", dvTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("COSO", csTextBox.Text));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới nhân viên thành công");

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
