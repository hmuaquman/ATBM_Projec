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
            //Khởi tạo không cho nhập vào các combo Box
            privCB.DropDownStyle = ComboBoxStyle.DropDownList;
            colCB.DropDownStyle = ComboBoxStyle.DropDownList;
            objCB.DropDownStyle = ComboBoxStyle.DropDownList;

            colCB.Enabled = false;
            privcheckBox.Checked = false;
            privcheckBox.Enabled = true;
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
   

        }
        //Xử lí sự kiện khi chọn các giá trị từ combobox Object
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(objCB.Text) && privCB.SelectedItem.ToString() == "Update")
            {
                
                colCB.Enabled = true;
            }
            else
            {
                colCB.Text = "";
                colCB.Enabled = false;
            }
        }

        //Xử lí sự kiện khi nhấp nút refresh
        private void refreshButton_Click(object sender, EventArgs e)
        {//Khai báo kết nối và truyền thông tin kết nối
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM USER_TAB_PRIVS", conn))
                {
                    try
                    {
                        //Mở kết nối
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

        //Xử lí sự kiện khi load form Privilege
        private void Privilege_Load(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                //Khai báo câu SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM USER_TAB_PRIVS", conn))
                {
                    try
                    {//Mở kết nối
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
        //Xử lí sự kiện khi nhấn nút grant quyền cho user
        private void grantUsrButton_Click(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            //Kiểm tra sử dụng procedure grant thường hoặc grant with admin option
            if (string.IsNullOrEmpty(colCB.Text))
            {
                //Khai báo procedure sử dụng
                cmd.CommandText = "SP_GRANTPRIVUSER";
                cmd.CommandType = CommandType.StoredProcedure;

                //Khai báo và truyền các tham số nhập từ form
                cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
                cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_username"].Value = roleTB.Text;

                cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
                cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_privilege"].Value = privCB.Text;

                cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
                cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_object"].Value = objCB.Text;

                cmd.Parameters.Add("n_option", OracleDbType.Int32);
                cmd.Parameters["n_option"].Direction = ParameterDirection.Input;
                //Kiểm tra và set tham số WITH GRANT OPTION
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
                //Khai báo procedure sử dụng
                cmd.CommandText = "SP_GRANTPRIVUSERCOL";
                cmd.CommandType = CommandType.StoredProcedure;

                //Khai báo tham số và truyền dữ liệu nhập từ form
                cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
                cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_username"].Value = roleTB.Text;

                cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
                cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_privilege"].Value = privCB.Text;

                cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
                cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_object"].Value = objCB.Text;

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
            {//Mở kết nối
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grant privilege to user successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Xử lí sự kiện khi nhấn nút Revoke quyền của user
        private void revokeButton_Click(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();

            //Khai báo procedure sử dụng
            cmd.CommandText = "SP_REVOKEPRIVUSER";
            cmd.CommandType = CommandType.StoredProcedure;

            //Khai báo các tham số và truyền dữ liệu từ form vào
            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = roleTB.Text;

            cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
            cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_privilege"].Value = privCB.Text;

            cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
            cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_object"].Value = objCB.Text;
            cmd.Connection = conn;
            try
            {
                //Mở kết nối
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke privilege to user successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Xử lí sự kiện khi nhấn nút Check Privilege
        private void checkPrivilegeButton_Click(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            //Khai báo procedure sử dụng
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CHECKPRIV";
            cmd.CommandType = CommandType.StoredProcedure;

            //Khai báo và truyền thông tin tham số nhập từ form
            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = roleTB.Text;

            cmd.Parameters.Add("c2", OracleDbType.RefCursor);
            cmd.Parameters["c2"].Direction = ParameterDirection.Output;
            cmd.Connection = conn;

            try
            {
                //Mở kết nối
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
        //Xử lí sự kiện khi Combobox của Column được chọn giá trị
        private void colCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colCB.Text == "")
            {
                privcheckBox.Enabled = true;
            } else
            {
                privcheckBox.Checked = false;
                privcheckBox.Enabled = false;
            }
        }
        //Xử lí sự kiện khi Combobox của Object được chọn giá trị    
        private void objCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(Account.connectString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Lấy tên bảng từ TextBox
                    string tableName = objCB.Text;

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
    }
}
