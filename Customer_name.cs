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
    public partial class Customer_name : Form
    {
        public Customer_name()
        {
            InitializeComponent();
        }

        private void Customer_name_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                cust_name_report name_report = new cust_name_report();
                
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "cust_name_report_select";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_name", SqlDbType.VarChar, 50));
                sqlcomm.Parameters["@cust_name"].Value = txtcust_name_rpt.Text;
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataSet ds1 = new DataSet();
                dta.Fill(ds1,"table");
                int row_count = ds1.Tables[0].Rows.Count;

                if (row_count == 0)
                {
                    cust_name_reportviewer.Refresh();
                    MessageBox.Show("No Customer of such name!");
                    cust_name_reportviewer.ReportSource = null;
                    return;
                }
                name_report.SetDataSource(ds1.Tables[0]);
                cust_name_reportviewer.ReportSource = name_report;
                sqlcon.Close();
                sqlcon.Dispose();
                txtcust_name_rpt.Text = "";

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

        private void cust_name_reportviewer_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}
