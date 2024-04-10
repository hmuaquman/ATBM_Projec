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
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM dba_users", conn))
                {
                    try
                    {
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

        private void createUsButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

         
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CREATEUSER";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Parameters.Add("n_password", OracleDbType.Varchar2);
            cmd.Parameters["n_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_password"].Value = pwTB.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create User successfully");

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
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drop User successfully");

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
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Parameters.Add("n_password", OracleDbType.Varchar2);
            cmd.Parameters["n_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_password"].Value = pwTB.Text;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM dba_users", conn))
                {
                    try
                    {
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
