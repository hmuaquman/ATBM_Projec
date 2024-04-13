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
    public partial class Privilege : Form
    {
        public Privilege()
        {
            InitializeComponent();
            privCB.DropDownStyle = ComboBoxStyle.DropDownList;
            colCB.DropDownStyle = ComboBoxStyle.DropDownList;
            colCB.Enabled = false;
            privcheckBox.Checked = false;
            if(!string.IsNullOrEmpty(colCB.Text))
            {
                privcheckBox.Enabled = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(objTB.Text) && (privCB.SelectedItem.ToString() == "Select" || privCB.SelectedItem.ToString() == "Update"))
            {
                colCB.Enabled = true;
            }
            else
            {
                colCB.Enabled = false;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM USER_TAB_PRIVS", conn))
                {
                    try
                    {
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            privGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void roleTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void usrTB_TextChanged(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(Account.connectString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Lấy tên bảng từ TextBox
                    string tableName = objTB.Text;

                    // Kiểm tra nếu TextBox không rỗng
                    if (!string.IsNullOrEmpty(tableName))
                    {
                        // Truy vấn SQL để lấy tên các cột của bảng
                        string query = $"SELECT column_name FROM user_tab_columns WHERE table_name = '{tableName}'";

                        // Tạo đối tượng Command và thực thi truy vấn
                        OracleCommand command = new OracleCommand(query, connection);
                        OracleDataReader reader = command.ExecuteReader();

                        // Xóa các mục hiện có trong ComboBox (nếu có)
                        colCB.Items.Clear();

                        // Đọc và thêm các tên cột vào ComboBox
                        colCB.Items.Add("");
                        while (reader.Read())
                        {
                            string columnName = reader.GetString(0);
                            colCB.Items.Add(columnName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void Privilege_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM USER_TAB_PRIVS", conn))
                {
                    try
                    {
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            privGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void grantUsrButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            if (string.IsNullOrEmpty(colCB.Text))
            {

                cmd.CommandText = "SP_GRANTPRIVUSER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
                cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_username"].Value = roleTB.Text;

                cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
                cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_privilege"].Value = privCB.Text;

                cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
                cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_object"].Value = objTB.Text;

                cmd.Parameters.Add("n_option", OracleDbType.Int32);
                cmd.Parameters["n_option"].Direction = ParameterDirection.Input;

                if (privcheckBox.Checked == true)
                {
                    cmd.Parameters["n_option"].Value = 1;
                }
                else
                {
                    cmd.Parameters["n_option"].Value = 0;
                }
                cmd.Connection = conn;
            } 
            else
            {
                cmd.CommandText = "SP_GRANTPRIVUSERCOL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
                cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_username"].Value = roleTB.Text;

                cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
                cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_privilege"].Value = privCB.Text;

                cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
                cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_object"].Value = objTB.Text;

                cmd.Parameters.Add("n_column", OracleDbType.Varchar2);
                cmd.Parameters["n_column"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_column"].Value = colCB.Text;

                cmd.Parameters.Add("n_option", OracleDbType.Int32);
                cmd.Parameters["n_option"].Direction = ParameterDirection.Input;

                if (privcheckBox.Checked == true)
                {
                    cmd.Parameters["n_option"].Value = 1;
                }
                else
                {
                    cmd.Parameters["n_option"].Value = 0;
                }
                cmd.Connection = conn;
            }
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grant privilege to user successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void revokeButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_REVOKEPRIVUSER";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = roleTB.Text;

            cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
            cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_privilege"].Value = privCB.Text;

            cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
            cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_object"].Value = objTB.Text;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke privilege to user successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkPrivilegeButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CHECKPRIV";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = roleTB.Text;

            cmd.Parameters.Add("c2", OracleDbType.RefCursor);
            cmd.Parameters["c2"].Direction = ParameterDirection.Output;
            //cmd.Parameters["c2"].Value = textBox2.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                privGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void privcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void colCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
