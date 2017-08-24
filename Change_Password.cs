using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace photostudio
{
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            change_pwd_clear();
        }
        public void change_pwd_clear()
        {
            txtoldpwd.Text = "";
            txtnewpwd.Text = "";
            txtcnfrmnewpwd.Text = "";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.CommandText = "select Password from Login_studio";
                string old_password = sqlcomm.ExecuteScalar().ToString();
                if (txtoldpwd.Text.Trim() == old_password.Trim() && txtnewpwd.Text.Trim() == txtcnfrmnewpwd.Text.Trim())
                {
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    //sqlcomm.CommandType = CommandType.StoredProcedure;
                    //sqlcomm.CommandText = "pwd_change";
                    //sqlcomm.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 4));
                    //sqlcomm.Parameters.Add(new SqlParameter("@pwd", SqlDbType.VarChar, 255));
                    //sqlcomm.Parameters["@username"].Value = "admin";
                    //sqlcomm.Parameters["@pwd"].Value = txtnewpwd.Text.Trim();
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.CommandText = "update Login_studio set Password='" + txtnewpwd.Text + "' where UserName='admin'";
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Password Updated");
                    sqlcon.Close();
                    sqlcon.Dispose();
                    change_pwd_clear();
                    
                }
                else if (txtoldpwd.Text.Trim() != old_password.Trim())
                {
                    MessageBox.Show("Old Password is Incorrect");
                    txtoldpwd.Focus();
                    change_pwd_clear();
                }
                else if(txtnewpwd.Text.Trim() != txtcnfrmnewpwd.Text.Trim())              
                {
                    MessageBox.Show("New Password And Confirm Password is Not Matching");
                    txtnewpwd.Focus();
                    change_pwd_clear();
                }
            }
            catch
            {
            }
            finally
            {
                sqlcon.Close();
                sqlcon.Dispose();
            }
        }
    }
}
