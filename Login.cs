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
    public partial class Login : Form
    {
        int flag = 0;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void login_entry_dbase()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandText = "select * from Login_studio";
                DataTable dtab = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlcomm);
                da.Fill(dtab);
                for (int i = 0; i < dtab.Rows.Count; i++)
                {
                    //if (txtusername.Text.Trim() == dtab.Rows[i][0].ToString().Trim() && txtpassword.Text.Trim() == dtab.Rows[i][1].ToString().Trim())
                    if (txtusername.Text.Trim() == dtab.Rows[i][0].ToString().Trim() && txtpassword.Text.Trim() == dtab.Rows[i][1].ToString().Trim())
                    {
                            flag = 1;
                            break;
                    }
                }
                    if(flag == 1)
                    {
                        if (txtusername.Text.Trim() == "employee")
                        {
                            flag = 1;
                            Employee ms = new Employee();
                            ms.Show();
                            clear_login();
                            this.Hide();
                        }
                        else if (txtusername.Text.Trim() == "admin")
                        {
                            master ms = new master();
                            ms.Show();
                            clear_login();
                            this.Hide();
                        }

                    }
                    

                
                if (flag == 0)
                {
                    MessageBox.Show("Enter Valid Username and password");
                    clear_login();
                    txtusername.Focus();
                }
                sqlcon.Close();
                sqlcon.Dispose();  
            }
            catch
            {
            }
        }
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            login_entry_dbase();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            clear_login();
        }
        public void clear_login()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
