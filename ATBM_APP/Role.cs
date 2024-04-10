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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM dba_roles", conn))
                {
                    try
                    {
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

        private void createRoleButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;


            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CREATEROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_role_name", OracleDbType.Varchar2);
            cmd.Parameters["n_role_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_role_name"].Value = roleTB.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create Role successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Role_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Account.connectString))
            {
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM dba_roles", conn))
                {
                    try
                    {
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

        private void checkPrivButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_CHECKROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrTB.Text;

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

        private void dropRoleButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;


            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SP_DROPROLE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_role", OracleDbType.Varchar2);
            cmd.Parameters["n_role"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_role"].Value = roleTB.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drop Role successfully");

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
            cmd.Parameters["n_role"].Value = roleTB.Text;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grant Role successfully");

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
            cmd.Parameters["n_role"].Value = roleTB.Text;

            cmd.Parameters.Add("n_username", OracleDbType.Varchar2);
            cmd.Parameters["n_username"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_username"].Value = usrTB.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke Role successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
