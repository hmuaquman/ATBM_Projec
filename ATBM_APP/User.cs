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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        //Xử lí tham số khi nhấn nút refresh
        private void Refresh_Click(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                //Khai báo câu SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM dba_users", conn))
                {
                    try
                    {  //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            userGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        //Xử lí sự kiện khi nhấp nút Create User
        private void createUsButton_Click(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            //Khai báo procedure sử dụng
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CREATEUSER";
            cmd.CommandType = CommandType.StoredProcedure;

            //Khai báo và truyền tham số nhập từ form
            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Parameters.Add("n_password", OracleDbType.Varchar2);
            cmd.Parameters["n_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_password"].Value = pwTB.Text;
            cmd.Connection = conn;

            try
            {
                //Mở kết nối
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create User successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Xử lí sự kiện khi nhấn nút drop role
        private void dropUsButton_Click(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            //Khai báo procedure sử dụng
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_DROPUSER";
            cmd.CommandType = CommandType.StoredProcedure;

            //Khai báo và truyền thông tin tham số từ form
            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Connection = conn;

            try
            {
                //Mở kết nối
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drop User successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Xử lí sự kiện khi nhấn nút Change Password
        private void changePassButtton_Click(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            //Khai báo procedure sử dụng
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CHANGEUSRPW";
            cmd.CommandType = CommandType.StoredProcedure;

            //Khai báo và truyền thông tin tham số  nhập từ form
            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Parameters.Add("n_password", OracleDbType.Varchar2);
            cmd.Parameters["n_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_password"].Value = pwTB.Text;
            cmd.Connection = conn;

            try
            {
                //Mở kết nối
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Change user password successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Xử lí khi load form user
        private void User_Load(object sender, EventArgs e)
        {
            //Khai báo và truyền thông tin kết nối
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                //Khai báo câu lệnh  SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM dba_users", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            userGridView.DataSource = dt;
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
