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
    public partial class Expense_report : Form
    {
        public Expense_report()
        {
            InitializeComponent();
        }

        private void btnsubmit_expense_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                expense_range_report name_report = new expense_range_report();

                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;
                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "expense_report";
                sqlcomm.Parameters.Add(new SqlParameter("@from", SqlDbType.DateTime, 50));
                sqlcomm.Parameters.Add(new SqlParameter("@to", SqlDbType.DateTime, 50));
                sqlcomm.Parameters["@from"].Value = dtpickfrom_expense.Text;
                sqlcomm.Parameters["@to"].Value = dtpickto_expense.Text;
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataSet ds1 = new DataSet();
                dta.Fill(ds1, "table");
                int row_count = ds1.Tables[0].Rows.Count;

                if (row_count == 0)
                {
                    expense_reportviewer.Refresh();
                    MessageBox.Show("No expense!");
                    expense_reportviewer.ReportSource = null;
                    return;
                }
                name_report.SetDataSource(ds1.Tables[0]);
                expense_reportviewer.ReportSource = name_report;
                sqlcon.Close();
                sqlcon.Dispose();
                expense_reportviewer.Text = "";

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
