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
    public partial class AdminForm : Form
    {
        private LoginForm loginForm;
        public AdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.service + ")));Password=" + Account.password + ";User ID=" + Account.username;
            logo.Image = Image.FromFile(@"..\\..\\icon\\hcmus.png");
            icon.Image = Image.FromFile(@"..\\..\\icon\\admin_avatar.png");
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            privPLComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colPLComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            objPLComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            colPLComboBox.Enabled = false;
            privPLCheckBox.Checked = false;
            privPLCheckBox.Enabled = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LoadDataUSR()
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
        private void LoadDataRole()
        {
            //Khai báo và truyền thông tin kết nối
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                //Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM dba_roles", conn))
                {
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            roleGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void LoadDataPriv()
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
        private void userTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataUSR();
        }

        private void roleTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataRole();
        }

        private void privTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataPriv();
        }

        private void createUsButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CREATEUSER";
            cmd.CommandType = CommandType.StoredProcedure;

           
            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrUSTextBox.Text;

            cmd.Parameters.Add("n_password", OracleDbType.Varchar2);
            cmd.Parameters["n_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_password"].Value = pwUSTextBox.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create User successfully");
                LoadDataUSR();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dropUsButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_DROPUSER";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrUSTextBox.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drop User successfully");
                LoadDataUSR();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changePassButtton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CHANGEUSRPW";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrUSTextBox.Text;

            cmd.Parameters.Add("n_password", OracleDbType.Varchar2);
            cmd.Parameters["n_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_password"].Value = pwUSTextBox.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Change user password successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            admTabControl.SelectedTab = userTabPage;
        }

        private void logoutItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void icon_Click(object sender, EventArgs e)
        {
            Point menuLocation = new Point(icon.Left - 82, icon.Bottom);
            menu.Show(this, menuLocation);
        }


        private void checkRoleButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CHECKROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = userRLTextBox.Text;

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
                roleGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void revokeRoleButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_REVOKEROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_role", OracleDbType.Varchar2);
            cmd.Parameters["n_role"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_role"].Value = roleRLTextBox.Text;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = userRLTextBox.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke Role successfully");
                LoadDataRole();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grantRoleButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_GRANTROLE";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("n_role", OracleDbType.Varchar2);
            cmd.Parameters["n_role"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_role"].Value = roleRLTextBox.Text;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = userRLTextBox.Text;

            cmd.Connection = conn;

            try
            {//Mở kết nối
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grant Role successfully");
                LoadDataRole();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dropRoleButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_DROPROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_role", OracleDbType.Varchar2);
            cmd.Parameters["n_role"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_role"].Value = roleRLTextBox.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drop Role successfully");
                LoadDataRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createRoleButton_Click(object sender, EventArgs e)
        { 
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CREATEROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_role_name", OracleDbType.Varchar2);
            cmd.Parameters["n_role_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_role_name"].Value = roleRLTextBox.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create Role successfully");
                LoadDataRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grantUsrButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            if (string.IsNullOrEmpty(colPLComboBox.Text))
            {
                cmd.CommandText = "SP_GRANTPRIVUSER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
                cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_username"].Value = userPLTextBox.Text;

                cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
                cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_privilege"].Value = privPLComboBox.Text;

                cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
                cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_object"].Value = objPLComboBox.Text;

                cmd.Parameters.Add("n_option", OracleDbType.Int32);
                cmd.Parameters["n_option"].Direction = ParameterDirection.Input;
                
                if (privPLCheckBox.Checked == true)
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
                cmd.Parameters["n_username"].Value = userPLTextBox.Text;

                cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
                cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_privilege"].Value = privPLComboBox.Text;

                cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
                cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_object"].Value = objPLComboBox.Text;

                cmd.Parameters.Add("n_column", OracleDbType.Varchar2);
                cmd.Parameters["n_column"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_column"].Value = colPLComboBox.Text;

                cmd.Parameters.Add("n_option", OracleDbType.Int32);
                cmd.Parameters["n_option"].Direction = ParameterDirection.Input;

                if (privPLCheckBox.Checked == true)
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
                LoadDataPriv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void revokePrivButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();

            cmd.CommandText = "SP_REVOKEPRIVUSER";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = userPLTextBox.Text;

            cmd.Parameters.Add("n_privilege", OracleDbType.Varchar2);
            cmd.Parameters["n_privilege"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_privilege"].Value = privPLComboBox.Text;

            cmd.Parameters.Add("n_object", OracleDbType.Varchar2);
            cmd.Parameters["n_object"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_object"].Value = objPLComboBox.Text;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke privilege to user successfully");
                LoadDataPriv();

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
            cmd.Parameters["n_username"].Value = userPLTextBox.Text;

            cmd.Parameters.Add("c2", OracleDbType.RefCursor);
            cmd.Parameters["c2"].Direction = ParameterDirection.Output;
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
        

        private void colPLComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colPLComboBox.Text == "")
            {
                privPLCheckBox.Enabled = true;
            }
            else
            {
                privPLCheckBox.Checked = false;
                privPLCheckBox.Enabled = false;
            }
        }

        private void objPLComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(Account.connectString))
            {
                try
                {
                    connection.Open();

                    string tableName = objPLComboBox.Text;

                    if (!string.IsNullOrEmpty(tableName))
                    {
                        string query = $"SELECT column_name FROM user_tab_columns WHERE table_name = '{tableName}'";

                        OracleCommand command = new OracleCommand(query, connection);
                        OracleDataReader reader = command.ExecuteReader();

                        colPLComboBox.Items.Clear();

                        colPLComboBox.Items.Add("");
                        while (reader.Read())
                        {
                            string columnName = reader.GetString(0);
                            colPLComboBox.Items.Add(columnName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void privPLComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(objPLComboBox.Text) && privPLComboBox.SelectedItem.ToString() == "Update")
            {

                colPLComboBox.Enabled = true;
            }
            else
            {
                colPLComboBox.Text = "";
                colPLComboBox.Enabled = false;
            }
        }

        private void saTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataSA();
        }
        private void LoadDataSA()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT DBUSERNAME, ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, EVENT_TIMESTAMP, SQL_TEXT FROM UNIFIED_AUDIT_TRAIL WHERE OBJECT_SCHEMA = :ADMIN", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("ADMIN", "ADMIN"));
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            saGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void onSAButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                // Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("BEGIN USP_ENABLE_TABLE_AUDIT_POLICY; END;", conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery(); // Thực thi câu lệnh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); // Hiển thị thông báo lỗi nếu có
                    }
                }
                
            }
        }

        private void offsaButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("BEGIN USP_DISABLE_TABLE_AUDIT_POLICY; END;", conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void saauditSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (saauditSearchTextBox.Text == "")
            {
                LoadDataSA();
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("SELECT DBUSERNAME, ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, EVENT_TIMESTAMP, SQL_TEXT FROM UNIFIED_AUDIT_TRAIL  WHERE INSTR(DBUSERNAME,:MA) > 0", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MA", saauditSearchTextBox.Text));
                        try
                        {
                            //Mở kết nối
                            conn.Open();
                            using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                saGridView.DataSource = dt;
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
        private void LoadDataFGADK()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM AUDIT_DANGKY", conn))
                {
                    
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            fgadkGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void LoadDataFGANS()
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {//Khai báo câu lệnh SQL sử dụng
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM AUDIT_SELECT_PHUCAP", conn))
                { 
                    try
                    {
                        //Mở kết nối
                        conn.Open();
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            fgapcnsGridView.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void fgaTabPage_Enter(object sender, EventArgs e)
        {
            LoadDataFGADK();
            LoadDataFGANS();
        }

        private void fgaDKSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fgaDKSearchTextBox.Text == "")
            {
                LoadDataFGADK();
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("SELECT * FROM AUDIT_DANGKY  WHERE INSTR(user_current,:MA) > 0", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MA", fgaDKSearchTextBox.Text));
                        try
                        {
                            //Mở kết nối
                            conn.Open();
                            using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                fgadkGridView.DataSource = dt;
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

        private void fgaPCSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fgaPCSearchTextBox.Text == "")
            {
                LoadDataFGANS();
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(Account.connectString))
                {//Khai báo câu lệnh SQL sử dụng
                    using (OracleCommand cmd = new OracleCommand("SELECT * FROM AUDIT_SELECT_PHUCAP WHERE INSTR(user_current,:MA) > 0", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MA", fgaPCSearchTextBox.Text));
                        try
                        {
                            //Mở kết nối
                            conn.Open();
                            using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                fgapcnsGridView.DataSource = dt;
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
}
