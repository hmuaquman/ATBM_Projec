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
                using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES (:MANV,:HOTEN, :PHAI,:NGSINH, :PHUCAP, :DT, :VAITRO, :MADV) ", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MANV", manvTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("HOTEN", hotenTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("PHAI", gtTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("NGSINH", nsTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("PHUCAP", pcTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("DT", sdtTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("VAITRO", cvTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MADV", dvTextBox.Text));

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
    }
}
