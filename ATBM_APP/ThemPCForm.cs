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
    public partial class ThemPCForm : Form
    {
        public ThemPCForm()
        {
            InitializeComponent();
            htgvPCTextBox.Enabled = false;
            thpPCTextBox.Enabled = false;
            mhpTextBox.Enabled = false;
            hkPCTextBox.Enabled = false;
            nhPCTextBox.Enabled = false;
            mctPCTextBox.Enabled = false;
            magvPCComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            thempcGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadDataTHEMPC()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN.view_add_phancong", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            thempcGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ThemPCForm_Load(object sender, EventArgs e)
        {
            LoadDataTHEMPC();
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                // Khai báo câu lệnh SQL
                string query = "SELECT MANV FROM ADMIN.NHANSU ns JOIN ADMIN.DONVI dv ON ns.MADV = dv.MADV WHERE dv.TRGDV = :TRUONGDV";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("TRGDV", Account.username));
                    try
                    {
                        // Mở kết nối
                        conn.Open();

                        // Thực thi câu lệnh và đọc dữ liệu
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Thêm các mục vào ComboBox
                                magvPCComboBox.Items.Add(reader["MANV"].ToString());
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
        }

      
        private void magvPCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT HOTEN FROM ADMIN.NHANSU WHERE MANV = :MANHANVIEN", conn))
                {

                    cmd.Parameters.Add(new OracleParameter("MANHANVIEN", magvPCComboBox.Text));
                    try
                    {
                        conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra nếu có dòng dữ liệu trả về
                            if (reader.Read())
                            {
                                htgvPCTextBox.Text = reader["HOTEN"].ToString();
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

        private void addPCButton_Click(object sender, EventArgs e)
        {
            if (htgvPCTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giáo viên muốn phân công dạy");
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO ADMIN.PHANCONG(MAGV, MAHP, HK, NAM, MACT) VALUES (:MAGV,:MAHP, :HK,:NAM, :MACT) ", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MAGV", magvPCComboBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MAHP", mhpTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("HK", hkPCTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("NAM", nhPCTextBox.Text));
                        cmd.Parameters.Add(new OracleParameter("MACT", mctPCTextBox.Text));
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm mới phân công thành công");
                            LoadDataTHEMPC();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void exiAddPCButton_Click(object sender, EventArgs e)
        { 
            this.Close();
            
        }

        private void thempcGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = thempcGridView.Rows[e.RowIndex];
                mhpTextBox.Text = row.Cells["MAHP"].Value.ToString();
                thpPCTextBox.Text = row.Cells["TENHP"].Value.ToString();
                hkPCTextBox.Text = row.Cells["HK"].Value.ToString();
                nhPCTextBox.Text = row.Cells["NAM"].Value.ToString();
                mctPCTextBox.Text = row.Cells["MACT"].Value.ToString();
            }
        }
    }
}
