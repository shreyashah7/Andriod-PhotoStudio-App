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
    public partial class cust_bystatus_report : Form
    {
        public cust_bystatus_report()
        {
            InitializeComponent();
        }

        private void cust_bystatus_report_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_status_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                cust_bystatus name_report = new cust_bystatus();
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                if (combo_status.Text == "All")
                {
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.CommandText = "cust_status_all";
                    sqlcomm.Parameters.Add(new SqlParameter("@from", SqlDbType.DateTime, 50));
                    sqlcomm.Parameters.Add(new SqlParameter("@to", SqlDbType.DateTime, 50));
                    sqlcomm.Parameters["@from"].Value = dtpickfrom.Text;
                    sqlcomm.Parameters["@to"].Value = dtpickto.Text;
                    SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                    DataSet ds1 = new DataSet();
                    dta.Fill(ds1, "table");
                    int row_count = ds1.Tables[0].Rows.Count;

                    if (row_count == 0)
                    {
                        cust_status_reportviewer.Refresh();
                        MessageBox.Show("No Customer between this range of any status!");
                        cust_status_reportviewer.ReportSource = null;
                        return;
                    }
                    name_report.SetDataSource(ds1.Tables[0]);
                    cust_status_reportviewer.ReportSource = name_report;
                    sqlcon.Close();
                    sqlcon.Dispose();
                    combo_status.Text = "";
                    return;

                }
                else
                {
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.CommandText = "cust_status_report_select";
                    sqlcomm.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, 50));
                    sqlcomm.Parameters.Add(new SqlParameter("@from", SqlDbType.DateTime, 50));
                    sqlcomm.Parameters.Add(new SqlParameter("@to", SqlDbType.DateTime, 50));
                    sqlcomm.Parameters["@status"].Value = combo_status.Text;
                    sqlcomm.Parameters["@from"].Value = dtpickfrom.Text;
                    sqlcomm.Parameters["@to"].Value = dtpickto.Text;
                    SqlDataAdapter dta1 = new SqlDataAdapter(sqlcomm);
                    DataSet ds2 = new DataSet();
                    dta1.Fill(ds2, "table");
                    int row_counts = ds2.Tables[0].Rows.Count;

                    if (row_counts == 0)
                    {
                        cust_status_reportviewer.Refresh();
                        MessageBox.Show("No Customer of "+combo_status.Text+"Status!");
                        cust_status_reportviewer.ReportSource = null;
                        return;
                    }
                    name_report.SetDataSource(ds2.Tables[0]);
                    cust_status_reportviewer.ReportSource = name_report;
                    sqlcon.Close();
                    sqlcon.Dispose();
                    combo_status.Text = "";

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
