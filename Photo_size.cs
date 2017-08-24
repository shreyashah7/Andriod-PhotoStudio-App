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
    public partial class Photo_size : Form
    {
        public string count;
        public Photo_size()
        {
            InitializeComponent();
        }

        private void Photo_size_Load(object sender, EventArgs e)
        {
            photosizebind_info();
        }
        public void photosizebind_info()
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
                sqlcomm.CommandText = "photo_size_select";
                SqlDataAdapter dta = new SqlDataAdapter("photo_size_select", sqlcon);

                DataSet ds = new DataSet();
                dta.Fill(ds, "PhotoSize_info");
                dgvphoto_sizeinfo.DataSource = ds.Tables["PhotoSize_info"];

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

        private void btnphotosize_submit_Click(object sender, EventArgs e)
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
                sqlcomm.CommandText = "photo_size_insert";
                sqlcomm.Parameters.Add(new SqlParameter("@photo_size", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@photo_price", SqlDbType.VarChar, 255));

                sqlcomm.Parameters["@photo_size"].Value = txtphoto_size_info.Text;
                sqlcomm.Parameters["@photo_price"].Value = txtphoto_prize.Text;
                
                sqlcomm.ExecuteNonQuery();
                MessageBox.Show("Records Successfully Inserted");
                clear();
                sqlcon.Close();
                sqlcon.Dispose();
                photosizebind_info();
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

        private void dgvphoto_sizeinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            Int16 vphoto_id = Convert.ToInt16( dgvphoto_sizeinfo.SelectedCells[0].RowIndex.ToString());
            count = dgvphoto_sizeinfo.Rows[vphoto_id].Cells[1].Value.ToString();
            
            try
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                    sqlcon.Open();
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.CommandText = "photo_size_delete_tblphotosize";
                    sqlcomm.Parameters.Add(new SqlParameter("@photo_size", SqlDbType.Int, 4));
                    sqlcomm.Parameters["@photo_size"].Value = count;
                    SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                    DataTable db = new DataTable();
                    dta.Fill(db);
                    if (db.Rows.Count != 0)
                    {
                        MessageBox.Show("PhotoSize Cannot be deleted because it is linked with the customer");

                    }
                    else
                    {
                        SqlCommand com = new SqlCommand();
                        com.Connection = sqlcon;
                        com.CommandType = CommandType.StoredProcedure;
                        com.CommandText = "photo_size_delete";
                        com.Parameters.Add(new SqlParameter("@photo_size_id", SqlDbType.Int, 4));
                        com.Parameters["@photo_size_id"].Value = count;
                        com.ExecuteNonQuery();
                        MessageBox.Show("records deleted");
                        sqlcon.Close();
                        sqlcon.Dispose();
                        photosizebind_info();
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

        private void btnphotosize_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtphoto_size_info.Text = "";
            txtphoto_prize.Text = "";
        }
        
    }
}
