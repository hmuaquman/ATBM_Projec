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
            mgvTextBox.Enabled = false;
            mctTextBox.Enabled = false;
            hkTextBox.Enabled = false;
            nhTextBox.Enabled = false;
            mhpTextBox.Enabled = false;
            dkhpGridView.Enabled = false;
            dkhpGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN, MACT FROM ADMIN.SINHVIEN WHERE MASV = :MASINHVIEN", conn))
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
                                dkhpGridView.Enabled = true;
                                htsvTextBox.Text = reader["HOTEN"].ToString();
                                mctTextBox.Text = reader["MACT"].ToString();
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
            //using (OracleConnection conn = new OracleConnection(Account.connectString))
            //{
            //    using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.NHANSU WHERE MANV = :MAGIANGVIEN", conn))
            //    {

            //        cmd.Parameters.Add(new OracleParameter("MAGIANGVIEN", mgvTextBox.Text));
            //        try
            //        {
            //            conn.Open();
            //            using (OracleDataReader reader = cmd.ExecuteReader())
            //            {
            //                // Kiểm tra nếu có dòng dữ liệu trả về
            //                if (reader.Read())
            //                {
            //                    tgvTextBox.Text = reader["HOTEN"].ToString();
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //}
        }

        private void ThemDKForm_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                string query = "SELECT kh.HK, kh.NAM, kh.MAHP, hp.TENHP, hp.SOTC, hp.STLT, hp.STTH, hp.SOSVTD, kh.MACT  FROM ADMIN.HOCPHAN hp JOIN ADMIN.KHMO kh ON hp.MAHP = kh.MAHP WHERE kh.HK = ( CASE WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 9 AND 12 THEN '1' WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 1 AND 4 THEN '2' ELSE '3' END) AND kh.NAM = TO_CHAR(SYSDATE, 'YYYY')";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dkhpGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dkhpGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (OracleConnection conn = new OracleConnection(Account.connectString))
            //{//Khai báo câu lệnh SQL sử dụng
            //    using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.HOCPHAN hp JOIN ADMIN.KHMO kh ON hp.MAHP = kh.MAHP", conn))
            //    {
            //        try
            //        {
            //            //Mở kết nối
            //            conn.Open();
            //            using (OracleDataAdapter da = new OracleDataAdapter(cmd))
            //            {
            //                DataTable dt = new DataTable();
            //                da.Fill(dt);
            //                dkhpGridView.DataSource = dt;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //}
        }

        private void mctTextBox_TextChanged(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                string query = "SELECT kh.HK, kh.NAM, kh.MAHP, hp.TENHP, hp.SOTC, hp.STLT, hp.STTH, hp.SOSVTD, kh.MACT  FROM ADMIN.HOCPHAN hp JOIN ADMIN.KHMO kh ON hp.MAHP = kh.MAHP WHERE kh.HK = ( CASE WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 9 AND 12 THEN '1' WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 1 AND 4 THEN '2' ELSE '3' END) AND kh.NAM = TO_CHAR(SYSDATE, 'YYYY') AND kh.MACT = :MACT";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("MACT", mctTextBox.Text));
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dkhpGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if(mhpTextBox.Text != "")
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    string query = "SELECT MAGV  FROM ADMIN.PHANCONG  WHERE MAHP = :MAHP AND NAM = :NAM AND HK = :HK AND MACT = :MACT";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {

                        cmd.Parameters.Add(new OracleParameter("MAHP", mhpTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("NAM", nhTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("HK", hkTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MACT", mctTextBox.Text));

                        try
                        {
                            //Mở kết nối
                            conn.Open();

                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                // Kiểm tra nếu có dòng dữ liệu trả về
                                if (reader.Read())
                                {
                                    mgvTextBox.Text = reader["MAGV"].ToString();

                                }
                            }
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void dkhpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dkhpGridView.Rows[e.RowIndex];
                mhpTextBox.Text = row.Cells["MAHP"].Value.ToString();
                thpTextBox.Text = row.Cells["TENHP"].Value.ToString();
                nhTextBox.Text = row.Cells["NAM"].Value.ToString();
                hkTextBox.Text = row.Cells["HK"].Value.ToString();

            }
            if(mctTextBox.Text != "")
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    string query = "SELECT MAGV  FROM ADMIN.PHANCONG  WHERE MAHP = :MAHP AND NAM = :NAM AND HK = :HK AND MACT = :MACT";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {

                        cmd.Parameters.Add(new OracleParameter("MAHP", mhpTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("NAM", nhTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("HK", hkTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MACT", mctTextBox.Text));

                        try
                        {
                            //Mở kết nối
                            conn.Open();

                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                // Kiểm tra nếu có dòng dữ liệu trả về
                                if (reader.Read())
                                {
                                    mgvTextBox.Text = reader["MAGV"].ToString();

                                }
                            }
                            conn.Close();
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
}
