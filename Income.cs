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
    public partial class Income : Form
    {
        Int32 cust_id_income = 0;
        int count1 = 0;
        Int32 sum_income = 0;
        public Income()
        {
            InitializeComponent();
        }
        private void Income_Load(object sender, EventArgs e)
        {
            branch_income_load();
            txttotal_income.Text = "";
            income_bind_info();
            
        }
        
        public void branch_income_load()
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
                combo_branch_income.DataSource = dt;
                combo_branch_income.DisplayMember = "branch";
                combo_branch_income.ValueMember = "Studio_Id";
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
                    sqlcomm.CommandText = "income_manual_insert";
                    sqlcomm.Parameters.Add(new SqlParameter("@Customer_id", SqlDbType.Int, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@amt", SqlDbType.Int, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 255));
                    

                    sqlcomm.Parameters["@Customer_id"].Value = 0;
                    sqlcomm.Parameters["@studio_id"].Value = combo_branch_income.SelectedValue; ;
                    sqlcomm.Parameters["@date"].Value = dateincome.Text;
                    sqlcomm.Parameters["@amt"].Value = txtincome_amt.Text;
                    sqlcomm.Parameters["@branch"].Value = combo_branch_income.Text;
                    sqlcomm.Parameters["@note"].Value = txtincome_on.Text;
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Income Recorded");
                    sqlcon.Close();
                    sqlcon.Dispose();
                    txttotal_income.Text = "";
                    income_bind_info();
                }
                else
                {

                    sqlcomm.CommandText = "income_update";
                    sqlcomm.Parameters.Add(new SqlParameter("@income_id", SqlDbType.Int, 4));
                    sqlcomm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@amt", SqlDbType.Int, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 255));
                    sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));

                    sqlcomm.Parameters["@income_id"].Value = count1;
                    sqlcomm.Parameters["@date"].Value = dateincome.Text;
                    sqlcomm.Parameters["@amt"].Value = txtincome_amt.Text;
                    sqlcomm.Parameters["@branch"].Value = combo_branch_income.Text;
                    sqlcomm.Parameters["@note"].Value = txtincome_on.Text;
                    sqlcomm.Parameters["@studio_id"].Value = Convert.ToInt32(combo_branch_income.SelectedValue);
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Income data and values are updated");
                    sqlcon.Close();
                    sqlcon.Dispose();
                    income_bind_info();
                    
                }
                income_clear();

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
        public void income_bind_info()
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
                sqlcomm.CommandText = "income_grid_display";
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                dta.Fill(dt);
                dgv_income.DataSource = dt;
                sqlcon.Close();
                sqlcon.Dispose();
                for (int i = 0; i < dgv_income.Rows.Count - 1; i++)
                {
                    sum_income = sum_income + Convert.ToInt32(dgv_income.Rows[i].Cells[5].Value);
                }
                txttotal_income.Text = sum_income.ToString();
                sum_income = 0;
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
        private void grpincome_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_income_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            Int16 selected_index = Convert.ToInt16(dgv_income.SelectedCells[0].RowIndex.ToString());
            cust_id_income = Convert.ToInt32(dgv_income.Rows[selected_index].Cells[3].Value);
            count1=Convert.ToInt32(dgv_income.Rows[selected_index].Cells[2].Value);
            if (cust_id_income == 0)
            {
                try
                {

                    if (e.ColumnIndex == 0)
                    {
                        sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                        sqlcon.Open();
                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;
                        sqlcomm.CommandType = CommandType.StoredProcedure;
                        sqlcomm.CommandText = "income_select_foredit";
                        sqlcomm.Parameters.Add(new SqlParameter("@income_id", SqlDbType.Int, 4));
                        sqlcomm.Parameters["@income_id"].Value = count1;
                        SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                        DataTable dtable = new DataTable();
                        dta.Fill(dtable);

                        dateincome.Text = dtable.Rows[0]["Date"].ToString();
                        txtincome_amt.Text = dtable.Rows[0]["Amount"].ToString();
                        combo_branch_income.Text = dtable.Rows[0]["Branch"].ToString();
                        txtincome_on.Text = dtable.Rows[0]["Note"].ToString();
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
                        sqlcomm.CommandText = "income_delete";
                        sqlcomm.Parameters.Add(new SqlParameter("@income_id", SqlDbType.Int, 4));
                        sqlcomm.Parameters["@income_id"].Value = count1;
                        sqlcomm.ExecuteNonQuery();
                        MessageBox.Show("records deleted");
                        sqlcon.Close();
                        sqlcon.Dispose();
                        txttotal_income.Text = "";
                        income_bind_info(); 
                        count1 = 0;
                    }
                }
                catch
                {
                }

            }
            else
            {
                MessageBox.Show("Records cannot be updated");
                return;
            }
        }

        private void btnincome_cancel_Click(object sender, EventArgs e)
        {
            income_clear();
        }
        public void income_clear()
        {
            dateincome.Text = "";
            txtincome_amt.Text = "";
            txtincome_on.Text = "";
            combo_branch_income.Text = "";
        }

        
    }
}
