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
    public partial class Balanced_sheet : Form
    {
        public Balanced_sheet()
        {
            InitializeComponent();
        }

        private void Balanced_sheet_Load(object sender, EventArgs e)
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
                combo_branch_sheet.DataSource = dt;
                combo_branch_sheet.DisplayMember = "branch";
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

        private void btnsubmit_sheet_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                balanced_sheet_report name_report = new balanced_sheet_report();

                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "balanced_sheet ";
                sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50));
                sqlcomm.Parameters.Add(new SqlParameter("@from", SqlDbType.DateTime, 50));
                sqlcomm.Parameters.Add(new SqlParameter("@to", SqlDbType.DateTime, 50));
                sqlcomm.Parameters["@branch"].Value = combo_branch_sheet.Text;
                sqlcomm.Parameters["@from"].Value = dtpickfrom_expense.Text;
                sqlcomm.Parameters["@to"].Value = dtpickto_expense.Text;
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataSet ds1 = new DataSet();
                dta.Fill(ds1, "table");
                int row_count = ds1.Tables[0].Rows.Count;

                if (row_count == 0)
                {
                    balanced_reportviewer.Refresh();
                    MessageBox.Show("No branch of such name!");
                    balanced_reportviewer.ReportSource = null;
                    return;
                }
                name_report.SetDataSource(ds1.Tables[0]);
                balanced_reportviewer.ReportSource = name_report;
                SqlCommand com = new SqlCommand();
                com.Connection = sqlcon;
                com.CommandText = "drop table tbltemp";
                com.ExecuteNonQuery();
                ds1.Clear();
                sqlcon.Close();
                sqlcon.Dispose();
                combo_branch_sheet.Text = "";

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
