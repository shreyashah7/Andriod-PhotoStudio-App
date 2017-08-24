using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace photostudio
{
    public partial class Studio : Form
    {

        public string count;
        public bool flag = false;
        public Studio()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Studio_Load(object sender, EventArgs e)
        {

            bind_info();
        }

        private void txtSinceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOwner3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtOwner4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOwner4_Click(object sender, EventArgs e)
        {

        }

       /* private void btncancel_Click(object sender, EventArgs e)
        {
            
        }*/

        /*private void btnadd_Click(object sender, EventArgs e)
        {
            
        }*/
        public void bind_info()
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
                sqlcomm.CommandText = "studio_select";
                SqlDataAdapter dta = new SqlDataAdapter("studio_select", sqlcon);
                // DataTable dtablestudio = new DataTable();
                DataSet ds = new DataSet();
                dta.Fill(ds, "studio_info");
                gvstudio.DataSource = ds.Tables["studio_info"];

                sqlcon.Close();
                sqlcon.Dispose();
            }
            catch (Exception ex)
            {
            }

        }
        public void clear()
        {
            txtStudio_name.Text = "";
            txtstudioAddr.Text = "";
            txtphno.Text = "";
            txtSinceDate.Text = "";
            txtowner1.Text = "";
            txtowner2.Text = "";
            txtowner3.Text = "";
            txtOwner4.Text = "";
            txtbranch.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblOwner3_Click_1(object sender, EventArgs e)
        {

        }

        private void lblowner2_Click(object sender, EventArgs e)
        {

        }

        private void lblOwner1_Click(object sender, EventArgs e)
        {

        }

        private void txtBranch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhoneNo_Click(object sender, EventArgs e)
        {

        }

        private void txtSinceDate_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblSinceDate_Click(object sender, EventArgs e)
        {

        }

        private void txtstudioAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudio_Addr_Click(object sender, EventArgs e)
        {

        }

        private void txtstudioPhno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBranch_Click(object sender, EventArgs e)
        {

        }

        private void txtStudio_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblStudio_name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            Int16 vstudio_id = Convert.ToInt16( gvstudio.SelectedCells[0].RowIndex.ToString());
            count = gvstudio.Rows[vstudio_id].Cells[2].Value.ToString();
            try
            {
                if (e.ColumnIndex == 0)
                {

                    sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                    sqlcon.Open();
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.CommandText = "studio_select";

                    sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 4));
                    sqlcomm.Parameters["@studio_id"].Value = count;
                    
                    SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                    DataTable dtable = new DataTable();
                    dta.Fill(dtable);
                    vstudio_id = Convert.ToInt16( dtable.Rows[0]["Studio_Id"].ToString());
                    txtStudio_name.Text = dtable.Rows[0]["Studio_Name"].ToString();
                    txtstudioAddr.Text = dtable.Rows[0]["Studio_Address"].ToString();
                    txtphno.Text = dtable.Rows[0]["Studio_PhNo"].ToString();
                    txtSinceDate.Text = dtable.Rows[0]["Since_Date"].ToString();
                    txtowner1.Text = dtable.Rows[0]["Owner_Name1"].ToString();
                    txtowner2.Text = dtable.Rows[0]["Owner_Name2"].ToString();
                    txtowner3.Text = dtable.Rows[0]["Owner_Name3"].ToString();
                    txtOwner4.Text = dtable.Rows[0]["Owner_Name4"].ToString();
                    txtbranch.Text = dtable.Rows[0]["Branch"].ToString();
                    sqlcon.Close();
                    sqlcon.Dispose();

                    flag = true;
                }
                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure you want to delete?This will delete all your entries of customer along with your income..", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                        sqlcon.Open();
                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.CommandText = "select Customer_ID from Customer_Info where Studio_Id ='" + count + "' ";
                        DataTable dtSet = new DataTable();
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcomm);
                        sqlDa.Fill(dtSet);
                        for (int i = 0; i < dtSet.Rows.Count; i++)
                        {
                            Int32 cust_ids = Convert.ToInt32(dtSet.Rows[i]["customer_id"].ToString());
                            SqlCommand comm = new SqlCommand();
                            comm = new SqlCommand();
                            comm.Connection = sqlcon;
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.CommandText = "advanced_delete";
                            comm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                            comm.Parameters["@cust_id"].Value = cust_ids;
                            comm.ExecuteNonQuery();

                            SqlCommand sqlcom = new SqlCommand();
                            sqlcom = new SqlCommand();
                            sqlcom.Connection = sqlcon;
                            sqlcom.CommandType = CommandType.StoredProcedure;
                            sqlcom.CommandText = "main_grid_delete_photo";
                            sqlcom.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                            sqlcom.Parameters["@cust_id"].Value = cust_ids;
                            sqlcom.ExecuteNonQuery();

                            SqlCommand sqlcom1 = new SqlCommand();
                            sqlcom1 = new SqlCommand();
                            sqlcom1.Connection = sqlcon;
                            sqlcom1.CommandText = "delete from Income_Info where Studio_Id ='" + count + "' ";
                            sqlcom1.ExecuteNonQuery();

                            SqlCommand com1 = new SqlCommand();
                            com1 = new SqlCommand();
                            com1.Connection = sqlcon;
                            com1.CommandType = CommandType.StoredProcedure;
                            com1.CommandText = "main_grid_delete_cust";
                            com1.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.VarChar, 255));
                            com1.Parameters["@cust_id"].Value = cust_ids;
                            com1.ExecuteNonQuery();

                            SqlCommand comm1 = new SqlCommand();
                            comm1 = new SqlCommand();
                            comm1.Connection = sqlcon;
                            comm1.CommandText = "delete from Expense_Info where Studio_Id ='" + count + "' ";
                            comm1.ExecuteNonQuery();
                        }

                        SqlCommand com = new SqlCommand();
                        com.Connection = sqlcon;
                        com.CommandType = CommandType.StoredProcedure;
                        com.CommandText = "studio_delete";
                        com.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 4));
                        com.Parameters["@studio_id"].Value = count;
                        com.ExecuteNonQuery();
                        MessageBox.Show("records deleted");
                        sqlcon.Close();
                        sqlcon.Dispose();
                        bind_info();
                        count = null;
                    }

                }
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

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (txtStudio_name.Text == "")
            {
                MessageBox.Show("Enter Studio Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudio_name.Focus();
            }
            else if (!Regex.IsMatch(txtStudio_name.Text, @"^[A-Za-z0-9\s]{3,25}$"))
            {
                    MessageBox.Show(txtStudio_name.Text+ " is Invalid Studio Name");
                    txtStudio_name.Focus();
            }
            else if (txtstudioAddr.Text == "")
            {
                MessageBox.Show("Enter Studio Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstudioAddr.Focus();
            }
            else if (txtphno.Text == "")
            {
                MessageBox.Show("Enter Studio Contact No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtphno.Focus();
            }
            else if (!Regex.IsMatch(txtphno.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show(txtphno.Text + " is Invalid Phone Number");
                txtphno.Focus();
            }
            else if (txtbranch.Text == "")
            {
                MessageBox.Show("Enter Studio Branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbranch.Focus();
            }
            else if (!Regex.IsMatch(txtbranch.Text, @"^[A-Za-z\s]{3,25}$"))
            {
                MessageBox.Show(txtbranch.Text + " is Invalid Branch Name");
                txtbranch.Focus();
            }
            else if (txtowner1.Text == "")
            {
                MessageBox.Show("Enter Owner's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtowner1.Focus();
            }
            //else if (!Regex.IsMatch(txtowner1.Text, @"^[A-Za-z\s]$"))
            //{
            //    MessageBox.Show(txtowner1.Text + " is Invalid Owner's Name");
            //    txtowner1.Focus();
            //}

            else
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
                    if (count == null)
                    {

                        sqlcomm.CommandText = "studio_insert";
                        sqlcomm.Parameters.Add(new SqlParameter("@studio_name", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@studio_addr", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@studio_phno", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@since_date", SqlDbType.Date, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner1", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner2", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner3", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner4", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));

                        sqlcomm.Parameters["@studio_name"].Value = txtStudio_name.Text;
                        sqlcomm.Parameters["@studio_addr"].Value = txtstudioAddr.Text;
                        sqlcomm.Parameters["@studio_phno"].Value = txtphno.Text;
                        sqlcomm.Parameters["@since_date"].Value = txtSinceDate.Text;
                        sqlcomm.Parameters["@owner1"].Value = txtowner1.Text;
                        sqlcomm.Parameters["@owner2"].Value = txtowner2.Text;
                        sqlcomm.Parameters["@owner3"].Value = txtowner3.Text;
                        sqlcomm.Parameters["@owner4"].Value = txtOwner4.Text;
                        sqlcomm.Parameters["@branch"].Value = txtbranch.Text;
                    }
                    else
                    {
                        sqlcomm.CommandText = "studio_update";
                        sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 4));
                        sqlcomm.Parameters.Add(new SqlParameter("@studio_name", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@studio_addr", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@studio_phno", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@since_date", SqlDbType.Date, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner1", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner2", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner3", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@owner4", SqlDbType.VarChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));

                        sqlcomm.Parameters["@studio_id"].Value = count;
                        sqlcomm.Parameters["@studio_name"].Value = txtStudio_name.Text;
                        sqlcomm.Parameters["@studio_addr"].Value = txtstudioAddr.Text;
                        sqlcomm.Parameters["@studio_phno"].Value = txtphno.Text;
                        sqlcomm.Parameters["@since_date"].Value = txtSinceDate.Text;
                        sqlcomm.Parameters["@owner1"].Value = txtowner1.Text;
                        sqlcomm.Parameters["@owner2"].Value = txtowner2.Text;
                        sqlcomm.Parameters["@owner3"].Value = txtowner3.Text;
                        sqlcomm.Parameters["@owner4"].Value = txtOwner4.Text;
                        sqlcomm.Parameters["@branch"].Value = txtbranch.Text;
                    }
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Records Successfully Inserted");
                    clear();
                    sqlcon.Close();
                    sqlcon.Dispose();
                    bind_info();
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
        }
        

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
