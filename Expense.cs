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
    public partial class Expense : Form
    {
        Int32 count1 = 0;
        Int32 sum_expense = 0;
        public Expense()
        {
            InitializeComponent();
        }

        private void txtexpense_amt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Expense_Load(object sender, EventArgs e)
        {
            branch_expense_load();
            txttotal_expense.Text = "";
            expense_bind_info();
        }
        public void branch_expense_load()
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
                combo_branch_expense.DataSource = dt;
                combo_branch_expense.DisplayMember = "branch";
                combo_branch_expense.ValueMember = "Studio_Id";
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
        private void dgv_expense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            Int16 selected_index = Convert.ToInt16(dgv_expense.SelectedCells[0].RowIndex.ToString());
            count1=Convert.ToInt32(dgv_expense.Rows[selected_index].Cells[2].Value);
            try
            {

                if (e.ColumnIndex == 0)
                {
                    sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                    sqlcon.Open();
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.CommandText = "expense_select_foredit";
                    sqlcomm.Parameters.Add(new SqlParameter("@expense_id", SqlDbType.Int, 4));
                    sqlcomm.Parameters["@expense_id"].Value = count1;
                    SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                    DataTable dtable = new DataTable();
                    dta.Fill(dtable);

                    dateexpense.Text = dtable.Rows[0]["Date"].ToString();
                    txtexpense_amt.Text = dtable.Rows[0]["Amount"].ToString();
                    combo_branch_expense.Text = dtable.Rows[0]["Branch"].ToString();
                    txtexpense_on.Text = dtable.Rows[0]["Note"].ToString();
                    sqlcon.Close();
                    sqlcon.Dispose();
                }
                else
                {
                    sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                    sqlcon.Open();
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.CommandText = "expense_delete";
                    sqlcomm.Parameters.Add(new SqlParameter("@expense_id", SqlDbType.Int, 4));
                    sqlcomm.Parameters["@expense_id"].Value = count1;
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("records deleted");
                    sqlcon.Close();
                    sqlcon.Dispose();
                    txttotal_expense.Text = "";
                    expense_bind_info();
                    count1 = 0;
                }
            }
            catch
            {
            }
        }

        private void btnincome_save_Click(object sender, EventArgs e)
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

                if (count1 == 0)
                {
                    sqlcomm.CommandText = "expense_insert";
                    sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@amt", SqlDbType.Int, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 255));

                    sqlcomm.Parameters["@studio_id"].Value = combo_branch_expense.SelectedValue; ;
                    sqlcomm.Parameters["@date"].Value = dateexpense.Text;
                    sqlcomm.Parameters["@amt"].Value = txtexpense_amt.Text;
                    sqlcomm.Parameters["@branch"].Value = combo_branch_expense.Text;
                    sqlcomm.Parameters["@note"].Value = txtexpense_on.Text;
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Expense Recorded");
                    sqlcon.Close();
                    sqlcon.Dispose();
                    txttotal_expense.Text = "";
                    expense_bind_info();
                }
                else
                {

                    sqlcomm.CommandText = "expense_update";
                    sqlcomm.Parameters.Add(new SqlParameter("@expense_id", SqlDbType.Int, 4));
                    sqlcomm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@amt", SqlDbType.Int, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));

                    sqlcomm.Parameters["@expense_id"].Value = count1;
                    sqlcomm.Parameters["@date"].Value = dateexpense.Text;
                    sqlcomm.Parameters["@amt"].Value = txtexpense_amt.Text;
                    sqlcomm.Parameters["@branch"].Value = combo_branch_expense.Text;
                    sqlcomm.Parameters["@note"].Value = txtexpense_on.Text;
                    sqlcomm.Parameters["@studio_id"].Value = Convert.ToInt32(combo_branch_expense.SelectedValue);
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Expense data and values are updated");
                    sqlcon.Close();
                    sqlcon.Dispose();
                    expense_bind_info();
                    
                }
                expense_clear();

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
        public void expense_bind_info()
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
                sqlcomm.CommandText = "expense_grid_display";
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                dta.Fill(dt);
                dgv_expense.DataSource = dt;
                sqlcon.Close();
                sqlcon.Dispose();
                for (int i = 0; i < dgv_expense.Rows.Count - 1; i++)
                {
                    sum_expense = sum_expense + Convert.ToInt32(dgv_expense.Rows[i].Cells[4].Value);
                }
                txttotal_expense.Text = sum_expense.ToString();
                sum_expense = 0;
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
        private void btnincome_cancel_Click(object sender, EventArgs e)
        {
            expense_clear();
        }
        public void expense_clear()
        {
            dateexpense.Text = "";
            txtexpense_amt.Text = "";
            txtexpense_on.Text = "";
            combo_branch_expense.Text = "";
        }

        private void txttotal_expense_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
