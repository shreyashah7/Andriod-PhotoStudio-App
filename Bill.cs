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
    public partial class Bill : Form
    {
        int c_id;
        public Bill(int cust_id)
        {
            c_id = cust_id;
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                cust_bill bill_report = new cust_bill();
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "bill_cust_select";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                sqlcomm.Parameters["@cust_id"].Value = c_id;
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataSet ds = new DataSet();
                dta.Fill(ds, "table");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No data Found", "CrystalReportWithOracle");
                    return;
                }
                bill_report.SetDataSource(ds.Tables[0]);
                cust_bill_crystalreportviewer.ReportSource = bill_report;
                sqlcon.Close();
                sqlcon.Dispose();
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

        private void cust_bill_crystalreportviewer_Load(object sender, EventArgs e)
        {
            
        }

    }
}
