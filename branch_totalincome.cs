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

namespace photostudio
{
    public partial class branch_totalincome : Form
    {
        public branch_totalincome()
        {
            InitializeComponent();
        }

        private void branch_totalincome_Load(object sender, EventArgs e)
        {
            branch_load();
        }
        public void branch_load()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "cust_branchload";
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                combo_branchincome.DataSource = dt;
                combo_branchincome.DisplayMember = "branch";
                sqlcon.Close();
                sqlcon.Dispose();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlcon.Close();
                sqlcon.Dispose();
            }
        }

        private void btnsubmit_income_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                branch_income_report name_report = new branch_income_report();

                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "branch_totalincome_report";
                sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50));
                sqlcomm.Parameters["@branch"].Value = combo_branchincome.Text;
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataSet ds1 = new DataSet();
                dta.Fill(ds1, "table");
                int row_count = ds1.Tables[0].Rows.Count;

                if (row_count == 0)
                {
                    branch_income_reportviewer.Refresh();
                    MessageBox.Show("No branch of such name!");
                    branch_income_reportviewer.ReportSource = null;
                    return;
                }
                name_report.SetDataSource(ds1.Tables[0]);
                branch_income_reportviewer.ReportSource = name_report;
                sqlcon.Close();
                sqlcon.Dispose();
                combo_branchincome.Text = "";

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
