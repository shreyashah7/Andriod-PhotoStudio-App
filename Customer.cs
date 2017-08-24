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
using System.IO;
using System.Drawing.Imaging;

namespace photostudio
{

    public partial class Customer : Form
    {
        DataTable dtb = new DataTable();
        DataTable dtbadvance = new DataTable();
        int sum = 0;
        int item = 0;
        int flag = 0;
        int flag1 = 0;
        public string collect;
        int advanced_no = 0;
        public string count1;
        int ccount = 0;
        int value_cust_id = 0;
        public string image_path;
        public byte[] imageData;
        
        //public string total_amount_value;
        public Customer()
        {
            InitializeComponent();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            branch_load();
            photosize_load();
            cust_combostatus.SelectedIndex = 0;
            combo_photo_size.Text = "";
            DataColumn Item_No = new DataColumn("Item No");
            DataColumn Photo_id = new DataColumn("Photo Id");
            DataColumn photosize = new DataColumn("Photo Size");
            DataColumn Price_per_qty = new DataColumn("Price/Qty");
            DataColumn Qty = new DataColumn("Quantity");
            DataColumn amt = new DataColumn("Amount");
            DataColumn Photo_Size_Id = new DataColumn("Photo Size_Id");
            DataColumn Image_Data = new DataColumn("Image Path");
            dtb.Columns.Add(Item_No);
            dtb.Columns.Add(Photo_id);
            dtb.Columns.Add(photosize);
            dtb.Columns.Add(Price_per_qty);
            dtb.Columns.Add(Qty);
            dtb.Columns.Add(amt);
            dtb.Columns.Add(Photo_Size_Id);
            dtb.Columns.Add(Image_Data);
            DataRow dr1 = dtb.NewRow();
            gvphoto_info.DataSource = dtb;
            item = gvphoto_info.Rows.Count - 1 ;
            cust_maingrid_bind_info();

            DataColumn Advance_No = new DataColumn("Advanced No");
            DataColumn Advanced_id = new DataColumn("Advanced Id");
            DataColumn Advanced_amt = new DataColumn("Advanced Amount");
            DataColumn Remain_amt = new DataColumn("Remain Amount");
            DataColumn Created_date = new DataColumn("Created Date");
            DataColumn Updated_date = new DataColumn("Updated Date");
            dtbadvance.Columns.Add(Advance_No);
            dtbadvance.Columns.Add(Advanced_id);
            dtbadvance.Columns.Add(Advanced_amt);
            dtbadvance.Columns.Add(Remain_amt);
            dtbadvance.Columns.Add(Created_date);
            dtbadvance.Columns.Add(Updated_date);
            DataRow dradvance = dtbadvance.NewRow();
            gdvpayment_info.DataSource = dtbadvance;
            advanced_no = gdvpayment_info.Rows.Count - 1;
            change_color_main_grid();
        }
        public void change_color_main_grid()
        {
            
                foreach (DataGridViewRow row in dgvcust_main.Rows)
                {
                    string remain_value = row.Cells[6].Value.ToString();

                    if (remain_value == "0")
                    {
                        
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    else if (remain_value != "0")
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;
                        
                        
                    }
                }
                
           
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
                cust_branchcombo.DataSource = dt;
                cust_branchcombo.DisplayMember = "branch";
                cust_branchcombo.ValueMember = "Studio_Id";
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
        public void photosize_load()
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
                sqlcomm.CommandText = "photo_photosizeload";
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                combo_photo_size.DataSource = dt;
                combo_photo_size.DisplayMember = "Photo_size";
                combo_photo_size.ValueMember = "Photo_Size_ID";
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

        private void btncust_submit_Click(object sender, EventArgs e)
        {

            if (txtcust_name.Text == "")
            {
                MessageBox.Show("Enter Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcust_name.Focus();
            }
            else if (!Regex.IsMatch(txtcust_name.Text, @"^[A-Za-z0-9\s]{3,25}$"))
            {
                MessageBox.Show(txtcust_name.Text + " is Invalid Studio Name");
                txtcust_name.Focus();
            }
            else if (txtcust_addr.Text == "")
            {
                MessageBox.Show("Enter Customer Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcust_addr.Focus();
            }
            else if (cust_branchcombo.Text == "")
            {
                MessageBox.Show("Enter Studio Branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cust_branchcombo.Focus();
            }
            else if (!Regex.IsMatch(cust_branchcombo.Text, @"^[A-Za-z\s]{3,25}$"))
            {
                MessageBox.Show(cust_branchcombo.Text + " is Invalid Branch Name");
                cust_branchcombo.Focus();
            }
            else if (txtcust_phno.Text == "")
            {
                MessageBox.Show("Enter Customer Contact No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcust_phno.Focus();
            }
            else if (!Regex.IsMatch(txtcust_phno.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show(txtcust_phno.Text + " is Invalid Phone Number");
                txtcust_phno.Focus();
            }
            
            else
            {

                if (count1 == null)
                {
                    insert_cust();
                    grid_photo_dbase_insert();
                    advanced_amount_insert();
                    income_insert();
                    
                }
                else
                {
                    update_cust();
                    update_photo_info();
                    update_advanced();
                    income_insert_custupdate();
                    
                }
                
                item = gvphoto_info.Rows.Count - 1;
                advanced_no = gdvpayment_info.Rows.Count - 1;
                clear_cust();
                clear_advanced();
                gvphoto_info.DataSource = null;
                gdvpayment_info.DataSource = null;
                dtb.Clear();
                dtbadvance.Clear();

                dgvimage_display.Columns.Clear();
                dgvimage_display.DataSource = null;
               
                
            }
        }
        public void insert_cust()
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
                sqlcomm.CommandText = "custinfo_insert";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_name", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@cust_addr", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@cust_phno", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@order_date", SqlDbType.Date, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@due_date", SqlDbType.Date, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@total_amount", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, 255));

                sqlcomm.Parameters["@cust_name"].Value = txtcust_name.Text;
                sqlcomm.Parameters["@cust_addr"].Value = txtcust_addr.Text;
                sqlcomm.Parameters["@cust_phno"].Value = txtcust_phno.Text;
                sqlcomm.Parameters["@studio_id"].Value = cust_branchcombo.SelectedValue;
                sqlcomm.Parameters["@order_date"].Value = orderdate.Text;
                sqlcomm.Parameters["@due_date"].Value = duedate.Text;
                sqlcomm.Parameters["@branch"].Value = cust_branchcombo.Text;
                sqlcomm.Parameters["@total_amount"].Value = txttotal_amount.Text;
                sqlcomm.Parameters["@status"].Value = cust_combostatus.Text;
                sqlcomm.ExecuteNonQuery();
                //total_amount_value = txttotal_amount.Text;
                //clear_cust();
                sqlcon.Close();
                sqlcon.Dispose();
                cust_maingrid_bind_info();

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

        public void update_cust()
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
                sqlcomm.CommandText = "maingrid_edit_cust_update";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                sqlcomm.Parameters.Add(new SqlParameter("@cust_name", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@cust_addr", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@cust_phno", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@due_date", SqlDbType.Date, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@total_amount", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, 255));

                sqlcomm.Parameters["@cust_id"].Value = count1;
                sqlcomm.Parameters["@cust_name"].Value = txtcust_name.Text;
                sqlcomm.Parameters["@cust_addr"].Value = txtcust_addr.Text;
                sqlcomm.Parameters["@cust_phno"].Value = txtcust_phno.Text;
                sqlcomm.Parameters["@studio_id"].Value = cust_branchcombo.SelectedValue;
                sqlcomm.Parameters["@due_date"].Value = duedate.Text;
                sqlcomm.Parameters["@branch"].Value = cust_branchcombo.Text;
                sqlcomm.Parameters["@total_amount"].Value = txttotal_amount.Text;
                sqlcomm.Parameters["@status"].Value = cust_combostatus.Text;
                sqlcomm.ExecuteNonQuery();
                sqlcon.Close();
                sqlcon.Dispose();
                cust_maingrid_bind_info();
                //clear_cust();
                change_color_main_grid();
                
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
        public void update_photo_info()
        {
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                SqlConnection sqlcon = new SqlConnection();
                SqlCommand sqlcomm = new SqlCommand();
                Int32 photo_id_value = Convert.ToInt32(dtb.Rows[i]["Photo Id"].ToString());
                if (photo_id_value == 0)
                {
                    try
                    {
                        sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                        sqlcon.Open();
                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;

                        sqlcomm.CommandType = CommandType.StoredProcedure;
                        sqlcomm.CommandText = "photogrid_insert";
                        sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@item_no", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@photo_size", SqlDbType.NChar, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@price_per_photo", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@toal_amount", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@photo_size_id", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@image_path", SqlDbType.NVarChar, 255));

                        sqlcomm.Parameters["@cust_id"].Value = count1;
                        sqlcomm.Parameters["@item_no"].Value = gvphoto_info.Rows[i].Cells[1].Value;
                        sqlcomm.Parameters["@photo_size"].Value = gvphoto_info.Rows[i].Cells[3].Value;
                        sqlcomm.Parameters["@quantity"].Value = gvphoto_info.Rows[i].Cells[5].Value;
                        sqlcomm.Parameters["@price_per_photo"].Value = gvphoto_info.Rows[i].Cells[4].Value;
                        sqlcomm.Parameters["@toal_amount"].Value = gvphoto_info.Rows[i].Cells[6].Value;
                        sqlcomm.Parameters["@photo_size_id"].Value = gvphoto_info.Rows[i].Cells[7].Value;
                        sqlcomm.Parameters["@image_path"].Value = gvphoto_info.Rows[i].Cells[8].Value;
                        sqlcomm.ExecuteNonQuery();
                       
                        clear_photo();
                        sqlcon.Close();
                        sqlcon.Dispose();
                        clear_photo();
                        
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
        }
        public void grid_photo_dbase_insert()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;

                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.CommandText = @"SELECT TOP 1 Customer_ID FROM dbo.Customer_Info ORDER BY Customer_ID DESC";
                value_cust_id = Convert.ToInt32(sqlcomm.ExecuteScalar());



                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "photogrid_insert";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@item_no", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@photo_size", SqlDbType.NChar, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@price_per_photo", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@toal_amount", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@photo_size_id", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@image_path", SqlDbType.NVarChar, 255));

                for (int i = 0; i < gvphoto_info.Rows.Count - 1; i++)
                {
                    
                    sqlcomm.Parameters["@cust_id"].Value = value_cust_id;
                    sqlcomm.Parameters["@item_no"].Value = gvphoto_info.Rows[i].Cells[1].Value;
                    sqlcomm.Parameters["@photo_size"].Value = gvphoto_info.Rows[i].Cells[3].Value;
                    sqlcomm.Parameters["@quantity"].Value = gvphoto_info.Rows[i].Cells[5].Value;
                    sqlcomm.Parameters["@price_per_photo"].Value = gvphoto_info.Rows[i].Cells[4].Value;
                    sqlcomm.Parameters["@toal_amount"].Value = gvphoto_info.Rows[i].Cells[6].Value;

                     
                    SqlCommand com = new SqlCommand();
                    com.Connection = sqlcon;
                    string value = gvphoto_info.Rows[i].Cells[3].Value.ToString();
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"SELECT Photo_Size_ID from PhotoSize_info where Photo_size= '" + value + "' ";
                    int value_photosize_id = Convert.ToInt16(com.ExecuteScalar());
                    sqlcomm.Parameters["@photo_size_id"].Value = value_photosize_id;
                    sqlcomm.Parameters["@image_path"].Value = gvphoto_info.Rows[i].Cells[8].Value.ToString();
                    sqlcomm.ExecuteNonQuery();
                }

                
                
                clear_photo();
                sqlcon.Close();
                sqlcon.Dispose();
                cust_maingrid_bind_info();
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
        //public byte[] ReadImageFile(string imageLocation)
        //{
        //    byte[] imageData1 = null;
        //    FileInfo fileInfo = new FileInfo(imageLocation);
        //    long imageFileLength = fileInfo.Length;
        //    FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(fs);
        //    imageData1 = br.ReadBytes((int)imageFileLength);
        //    return imageData1;
        //}
        public void advanced_amount_insert()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;

                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.CommandText = @"SELECT TOP 1 Customer_ID FROM dbo.Customer_Info ORDER BY Customer_ID DESC";
                int value_cust_id_advanced = Convert.ToInt32(sqlcomm.ExecuteScalar());

                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.CommandText = "advanced_insert";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                sqlcomm.Parameters.Add(new SqlParameter("@advanced_no", SqlDbType.Int, 4));
                sqlcomm.Parameters.Add(new SqlParameter("@advanced_amount", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@remain_amount", SqlDbType.Int, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@created_date", SqlDbType.Date, 255));
                sqlcomm.Parameters.Add(new SqlParameter("@updated_date", SqlDbType.Date, 255));

                if (gdvpayment_info.Rows.Count - 1 == 0)
                {
                    sqlcomm.Parameters["@cust_id"].Value = value_cust_id_advanced;
                    sqlcomm.Parameters["@advanced_no"].Value = 0;
                    sqlcomm.Parameters["@advanced_amount"].Value = 0;
                    sqlcomm.Parameters["@remain_amount"].Value = txttotal_amount.Text;
                    sqlcomm.Parameters["@created_date"].Value = orderdate.Text;
                    sqlcomm.Parameters["@updated_date"].Value = orderdate.Text;
                    sqlcomm.ExecuteNonQuery();
                }
                else
                {
                    for (int i = 0; i < gdvpayment_info.Rows.Count - 1; i++)
                    {
                        sqlcomm.Parameters["@cust_id"].Value = value_cust_id_advanced;
                        sqlcomm.Parameters["@advanced_no"].Value = gdvpayment_info.Rows[i].Cells[1].Value;
                        sqlcomm.Parameters["@advanced_amount"].Value = gdvpayment_info.Rows[i].Cells[3].Value;
                        sqlcomm.Parameters["@remain_amount"].Value = gdvpayment_info.Rows[i].Cells[4].Value;
                        sqlcomm.Parameters["@created_date"].Value = Convert.ToDateTime(gdvpayment_info.Rows[i].Cells[5].Value);
                        sqlcomm.Parameters["@updated_date"].Value = (gdvpayment_info.Rows[i].Cells[6].Value);
                        sqlcomm.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Records Entered Successfully of Selected Customer with their photo details");
                //clear_advanced();
                sqlcon.Close();
                sqlcon.Dispose();
                cust_maingrid_bind_info();
                change_color_main_grid();

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
        public void income_insert()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                
                for (int i = 0; i < gvphoto_info.Rows.Count - 1; i++)
                {
                    collect = collect + " " + gvphoto_info.Rows[i].Cells[3].Value; 
                }
                string note = "Customer Name:"+ txtcust_name.Text +" "+ "photo-sizes:"+"," + collect;
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;

                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.CommandText = @"SELECT TOP 1 Customer_ID FROM dbo.Customer_Info ORDER BY Customer_ID DESC";
                Int32 value_cust_id = Convert.ToInt32(sqlcomm.ExecuteScalar());

                SqlCommand com =new SqlCommand();
                com.Connection=sqlcon;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "income_manual_insert";
                com.Parameters.Add(new SqlParameter("@Customer_id", SqlDbType.Int, 255));
                com.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));
                com.Parameters.Add(new SqlParameter("@date", SqlDbType.Date, 255));
                com.Parameters.Add(new SqlParameter("@amt", SqlDbType.Int, 255));
                com.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                com.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 255));
             
                com.Parameters["@Customer_id"].Value = value_cust_id;
                com.Parameters["@studio_id"].Value = cust_branchcombo.SelectedValue;
                com.Parameters["@date"].Value = orderdate.Text;
                com.Parameters["@amt"].Value = txtAdvanced.Text;
                com.Parameters["@branch"].Value = cust_branchcombo.Text;
                com.Parameters["@note"].Value = note;                
                com.ExecuteNonQuery();
                MessageBox.Show("Income Recorded");
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
        public void income_insert_custupdate()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {

                for (int i = 0; i < gvphoto_info.Rows.Count - 1; i++)
                {
                    collect = collect + " " + gvphoto_info.Rows[i].Cells[3].Value;
                }
                string note = txtcust_name.Text + " " + "photo-sizes: " + " " + collect;
                sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                sqlcon.Open();
                sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlcon;

                //sqlcomm.CommandType = CommandType.Text;
                //sqlcomm.CommandText = @"SELECT TOP 1 Customer_ID FROM dbo.Customer_Info ORDER BY Customer_ID DESC";
                //Int32 value_cust_id = Convert.ToInt32(sqlcomm.ExecuteScalar());

                SqlCommand com = new SqlCommand();
                com.Connection = sqlcon;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "income_manual_insert";
                com.Parameters.Add(new SqlParameter("@Customer_id", SqlDbType.Int, 255));
                com.Parameters.Add(new SqlParameter("@studio_id", SqlDbType.Int, 255));
                com.Parameters.Add(new SqlParameter("@date", SqlDbType.Date, 255));
                com.Parameters.Add(new SqlParameter("@amt", SqlDbType.Int, 255));
                com.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 255));
                com.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 255));

                com.Parameters["@Customer_id"].Value = count1;
                com.Parameters["@studio_id"].Value = cust_branchcombo.SelectedValue;
                com.Parameters["@date"].Value = orderdate.Text;
                com.Parameters["@amt"].Value = txtAdvanced.Text;
                com.Parameters["@branch"].Value = cust_branchcombo.Text;
                com.Parameters["@note"].Value = note;
                com.ExecuteNonQuery();
                MessageBox.Show("Income Recorded");
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
        public void update_advanced()
        {

            for (int i = 0; i < dtbadvance.Rows.Count; i++)
            {
                SqlConnection sqlcon = new SqlConnection();
                SqlCommand sqlcomm = new SqlCommand();
                Int32 advance_id_value = Convert.ToInt32(dtbadvance.Rows[i]["Advanced Id"].ToString());
                if (advance_id_value == 0)
                {
                    try
                    {
                        sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                        sqlcon.Open();
                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;

                        sqlcomm.CommandType = CommandType.StoredProcedure;
                        sqlcomm.CommandText = "advanced_insert";
                        sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                        sqlcomm.Parameters.Add(new SqlParameter("@advanced_no", SqlDbType.Int, 4));
                        sqlcomm.Parameters.Add(new SqlParameter("@advanced_amount", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@remain_amount", SqlDbType.Int, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@created_date", SqlDbType.Date, 255));
                        sqlcomm.Parameters.Add(new SqlParameter("@updated_date", SqlDbType.Date, 255));

                        sqlcomm.Parameters["@cust_id"].Value = count1;
                        sqlcomm.Parameters["@advanced_no"].Value = gdvpayment_info.Rows[i].Cells[1].Value;
                        sqlcomm.Parameters["@advanced_amount"].Value = gdvpayment_info.Rows[i].Cells[3].Value;
                        sqlcomm.Parameters["@remain_amount"].Value = gdvpayment_info.Rows[i].Cells[4].Value;
                        sqlcomm.Parameters["@created_date"].Value = Convert.ToDateTime(gdvpayment_info.Rows[i].Cells[5].Value);
                        sqlcomm.Parameters["@updated_date"].Value = Convert.ToDateTime(gdvpayment_info.Rows[i].Cells[6].Value);
                        sqlcomm.ExecuteNonQuery();
                        MessageBox.Show("Records Updated of Selected Customer");
                        //clear_advanced();
                        sqlcon.Close();
                        sqlcon.Dispose();
                        //clear_advanced();
                        cust_maingrid_bind_info();
                        change_color_main_grid();
                        
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
            
        }
        public void clear_cust()
        {
            txtcust_name.Text = "";
            txtcust_addr.Text = "";
            txtcust_phno.Text = "";
            cust_branchcombo.Text = "";
            txttotal_amount.Text = "";
            cust_combostatus.Text = "";
        }
        public void clear_advanced()
        {
            txtAdvanced.Text = "";
            txtremain_amt.Text = "";
        }



        private void txtcust_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_photo_size_SelectedIndexChanged(object sender, EventArgs e)
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
                sqlcomm.CommandText = "photo_price_insert";
                sqlcomm.Parameters.Add(new SqlParameter("@photo_size_id", SqlDbType.Int, 255));
                sqlcomm.Parameters["@photo_size_id"].Value = combo_photo_size.SelectedValue;
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                txtprice_qty.Text = dt.Rows[0]["Price"].ToString();
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

        private void txtphoto_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int value1 = Convert.ToInt16(txtprice_qty.Text) * Convert.ToInt16(txtphoto_qty.Text);
                txtphoto_amount.Text = value1.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnphoto_save_Click(object sender, EventArgs e)
        {
             if (combo_photo_size.Text == "")
            {
                MessageBox.Show("Enter Photo Size");
                combo_photo_size.Focus();
            }
            else if (txtphoto_qty.Text == "")
            {
                MessageBox.Show("Enter the Quantity");
                txtphoto_qty.Focus();
            }
             else if (image_path == null)
             {
                 MessageBox.Show("select photo");
             }

             else
             {
                 item = gvphoto_info.Rows.Count - 1;
                 DataRow dr1 = dtb.NewRow();
                 dr1[0] = item + 1;
                 item++;
                 dr1[1] = 0;
                 dr1[2] = combo_photo_size.Text;
                 dr1[3] = txtprice_qty.Text;
                 dr1[4] = txtphoto_qty.Text;
                 dr1[5] = txtphoto_amount.Text;
                 dr1[6] = combo_photo_size.SelectedValue;
                 dr1[7] = image_path;
                 dtb.Rows.Add(dr1);
                 gvphoto_info.DataSource = dtb;
                 int rowcount = gvphoto_info.Rows.Count - 2;
                 Bitmap img;

                 img = new Bitmap(@image_path);

                 DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                 imageCol.Width = 160;

                 dgvimage_display.Columns.Add(imageCol);

                 if (gvphoto_info.Rows.Count == 0 || gvphoto_info.Rows.Count == 1)
                 {
                     dgvimage_display.Rows[0].Cells[0].Value = img;
                 }
                 else
                 {
                     dgvimage_display.Rows[0].Cells[rowcount].Value = img;
                 }

                 for (int i = 0; i < dgvimage_display.Columns.Count; i++)
                 {
                     if (dgvimage_display.Columns[i] is DataGridViewImageColumn)
                     {
                         ((DataGridViewImageColumn)dgvimage_display.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                     }
                 }

                 foreach (DataGridViewRow row in dgvimage_display.Rows)
                 {

                     row.Height = 170;

                 }




                 clear_photo();
                 total_amount_count();
             }
        }
        public void total_amount_count()
        {
            try
            {
                for (int i = 0; i < gvphoto_info.RowCount - 1; i++)
                {

                    sum = sum + Convert.ToInt32(gvphoto_info.Rows[i].Cells[6].Value);
                    txttotal_amount.Text = sum.ToString();

                }
                sum = 0;
            }
            catch (Exception ex)
            {
            }
        }
        public void clear_photo()
        {
            combo_photo_size.Text = "";
            txtprice_qty.Text = "";
            txtphoto_qty.Text = "";
            txtphoto_amount.Text = "";
            image_path = null;
        }

        private void btncust_cancel_Click(object sender, EventArgs e)
        {
            count1 = null;
            dtb.Clear();
            dtbadvance.Clear();
            txtcust_name.Text = "";
            txtcust_addr.Text = "";
            txtcust_phno.Text = "";
            cust_branchcombo.Text = "";
            combo_photo_size.Text = "";
            txtprice_qty.Text = "";
            txtphoto_qty.Text = "";
            txtphoto_amount.Text = "";
            txttotal_amount.Text = "";
            txtAdvanced.Text = "";
            txtremain_amt.Text = "";
            cust_combostatus.Text = "";
            item = 0;
            image_path = null;
            gvphoto_info.DataSource = null;
            gdvpayment_info.DataSource = null;
            dgvimage_display.Columns.Clear();
            dgvimage_display.DataSource = null;
            dtb.Clear();
        }

        private void gvphoto_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            Int16 delete = Convert.ToInt16(gvphoto_info.SelectedCells[0].RowIndex.ToString());
            flag = Convert.ToInt32(gvphoto_info.Rows[delete].Cells[1].Value);
            int photo_id_values=Convert.ToInt32(gvphoto_info.Rows[delete].Cells[2].Value);
            if (MessageBox.Show("Are you sure you want to delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataTable dtab = new DataTable();

                        dtab.Columns.Add(new DataColumn("Item No"));
                        dtab.Columns.Add(new DataColumn("Photo Id"));
                        dtab.Columns.Add(new DataColumn("Photo Size"));
                        dtab.Columns.Add(new DataColumn("Price/Qty"));
                        dtab.Columns.Add(new DataColumn("Quantity"));
                        dtab.Columns.Add(new DataColumn("Amount"));
                        dtab.Columns.Add(new DataColumn("Photo Size_Id"));
                        dtab.Columns.Add(new DataColumn("Image Path"));

                        for (int loop = 0; loop <= gvphoto_info.RowCount - 2; loop++)
                        {

                            DataRow dr = dtab.NewRow();

                            dr["Item No"] = gvphoto_info.Rows[loop].Cells[1].Value;
                            dr["Photo Id"] = gvphoto_info.Rows[loop].Cells[2].Value;
                            dr["Photo Size"] = gvphoto_info.Rows[loop].Cells[3].Value;
                            dr["Price/Qty"] = gvphoto_info.Rows[loop].Cells[4].Value;
                            dr["Quantity"] = gvphoto_info.Rows[loop].Cells[5].Value;
                            dr["Amount"] = gvphoto_info.Rows[loop].Cells[6].Value;
                            dr["Photo Size_Id"] = gvphoto_info.Rows[loop].Cells[7].Value;
                            dr["Image Path"] = gvphoto_info.Rows[loop].Cells[8].Value;
                            dtab.Rows.Add(dr);


                        }
                    if (e.ColumnIndex == 0 && photo_id_values == 0)
                    {

                        for (int loop = dtab.Rows.Count - 1; loop >= 0; loop--)
                        {
                            DataRow dr2 = dtab.Rows[loop];
                            if (dr2["Item No"].ToString() == flag.ToString())
                            {
                                dr2.Delete();

                                gvphoto_info.DataSource = dtab;
                                dgvimage_display.Columns.RemoveAt(flag - 1);
                                dtb = dtab;
                                total_amount_count();
                            }
                        }
                        for (int loop1 = flag - 1; loop1 <= dtab.Rows.Count - 1; loop1++)
                        {
                            DataRow dr3 = dtab.Rows[loop1];
                            dr3["Item No"] = flag.ToString();
                            flag++;
                            gvphoto_info.DataSource = dtab;
                            
                            dtb = dtab;
                        }
                        item = flag - 1;



                        dtb = dtab;


                    }

                    else if (e.ColumnIndex == 0 && photo_id_values != 0)
                    {

                        dgvimage_display.Columns.RemoveAt(delete);
                        for (int i = dtab.Rows.Count - 1; i >= 0; i--)
                        {
                            if (dtab.Rows[i]["Photo Id"].ToString() == photo_id_values.ToString())
                            {
                                dtab.Rows.RemoveAt(i);
                                Int32 count2 = Convert.ToInt32(dtab.Rows.Count);
                            }
                            dtb = dtab;
                            gvphoto_info.DataSource = dtab;
                        }

                        sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                        sqlcon.Open();
                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.CommandText = "delete from Photo_Info where Photo_ID=" + photo_id_values;
                        sqlcomm.ExecuteNonQuery();
                        MessageBox.Show("Selected Item is Deleted of Selected customer");
                        sqlcon.Close();
                        sqlcon.Dispose();
                        //gvphoto_info.DataSource = null;
                        total_amount_count();
                        cust_maingrid_bind_info();


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

        private void txtprice_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtprice_qty.Text != null)
                {
                    int value1 = Convert.ToInt16(txtprice_qty.Text) * Convert.ToInt16(txtphoto_qty.Text);
                    txtphoto_amount.Text = value1.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }


        private void cust_maingrid_bind_info()
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
                sqlcomm.CommandText = "cust_select_maingrid";
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                dta.Fill(dt);
                dgvcust_main.DataSource = dt;

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
        private void photo_grid_bind_info()
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
                sqlcomm.CommandText = "photo_select_maingrid";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                sqlcomm.Parameters["@cust_id"].Value = count1;
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                dta.Fill(dt);
                gvphoto_info.DataSource = dt;

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

        private void dgvcust_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            Int16 vcust_id = Convert.ToInt16(dgvcust_main.SelectedCells[0].RowIndex.ToString());
            count1 = dgvcust_main.Rows[vcust_id].Cells[2].Value.ToString();
            try
            {
                
                
                if (e.ColumnIndex == 0)
                {
                    sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                    sqlcon.Open();
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.CommandText = "maingrid_edit_cust";

                    sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                    sqlcomm.Parameters["@cust_id"].Value = count1;
                    SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                    DataTable dtable = new DataTable();
                    dta.Fill(dtable);
                    //vcust_id = Convert.ToInt16(dtable.Rows[0]["Customer_ID"].ToString());
                    txtcust_name.Text = dtable.Rows[0]["Customer_Name"].ToString();
                    txtcust_addr.Text = dtable.Rows[0]["Customer_Address"].ToString();
                    txtcust_phno.Text = dtable.Rows[0]["Customer_PhNo"].ToString();
                    cust_branchcombo.Text = dtable.Rows[0]["branch"].ToString();
                    duedate.Text = dtable.Rows[0]["OrderDue_Date"].ToString();
                    txttotal_amount.Text = dtable.Rows[0]["Total_Amount"].ToString();
                    cust_branchcombo.SelectedValue = dtable.Rows[0]["Studio_Id"].ToString();
                    cust_combostatus.Text = dtable.Rows[0]["Status"].ToString();

                    SqlCommand com = new SqlCommand();
                    com.Connection = sqlcon;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "maingrid_edit_photo";
                    com.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                    com.Parameters["@cust_id"].Value = count1;
                    SqlDataAdapter dtadap = new SqlDataAdapter(com);
                    DataTable dtable1 = new DataTable();
                    dtadap.Fill(dtable1);
                    dtb = dtable1;
                    gvphoto_info.DataSource = null;
                    gvphoto_info.DataSource = dtb;
                    
                    total_amount_count();

                    SqlCommand com1 = new SqlCommand();
                    com1.Connection = sqlcon;
                    com1.CommandType = CommandType.StoredProcedure;
                    com1.CommandText = "advanced_select";
                    com1.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                    com1.Parameters["@cust_id"].Value = count1;
                    SqlDataAdapter dtaadv = new SqlDataAdapter(com1);
                    DataTable dtbadv = new DataTable();
                    dtaadv.Fill(dtbadv);
                    dtbadvance = dtbadv;
                    gdvpayment_info.DataSource = null;
                    gdvpayment_info.DataSource = dtbadvance;
                    sqlcon.Close();
                    sqlcon.Dispose();
                    

                    for (int j = 0; j < gvphoto_info.Rows.Count - 1; j++)
                    {
                        Bitmap img;

                        img = new Bitmap(@gvphoto_info.Rows[j].Cells[8].Value.ToString());

                        DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                        imageCol.Width = 160;

                        dgvimage_display.Columns.Add(imageCol);

                        dgvimage_display.Rows[0].Cells[j].Value = img;

                        for (int i = 0; i < dgvimage_display.Columns.Count; i++)
                        {
                            if (dgvimage_display.Columns[i] is DataGridViewImageColumn)
                            {
                                ((DataGridViewImageColumn)dgvimage_display.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                            }
                        }

                        foreach (DataGridViewRow row in dgvimage_display.Rows)
                        {

                            row.Height = 170;

                        }


                    }
                    change_color_main_grid();

                }
                else if(e.ColumnIndex ==1)
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                        sqlcon.Open();
                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;
                        sqlcomm.CommandType = CommandType.StoredProcedure;
                        sqlcomm.CommandText = "main_grid_delete_photo";
                        sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                        sqlcomm.Parameters["@cust_id"].Value = count1;
                        sqlcomm.ExecuteNonQuery();

                        SqlCommand com = new SqlCommand();
                        com.Connection = sqlcon;
                        com.CommandType = CommandType.StoredProcedure;
                        com.CommandText = "advanced_delete";
                        com.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                        com.Parameters["@cust_id"].Value = count1;
                        com.ExecuteNonQuery();

                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;
                        sqlcomm.CommandType = CommandType.StoredProcedure;
                        sqlcomm.CommandText = "main_grid_delete_cust";
                        sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                        sqlcomm.Parameters["@cust_id"].Value = count1;
                        sqlcomm.ExecuteNonQuery();
                        
                        MessageBox.Show("Records deleted of Selected customer with all photo details ");
                        sqlcon.Close();
                        sqlcon.Dispose();
                        cust_maingrid_bind_info();
                        gvphoto_info.DataSource = null;
                        dtb.Clear();
                        dtbadvance.Clear();
                        clear_cust();
                        clear_photo();
                        gdvpayment_info.DataSource = null;

                        count1 = null;
                        change_color_main_grid();
                       
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

        private void txttotal_amount_TextChanged(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                if (count1 == null)
                {
                    Int32 remain1 = Convert.ToInt32(txttotal_amount.Text) - Convert.ToInt32(txtAdvanced.Text);
                    txtremain_amt.Text = remain1.ToString();
                }
                else
                {
                    sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                    sqlcon.Open();
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandText = "select sum(Advanced_amount) from Advanced_info where Customer_ID='" + count1 + "'";
                    Int32 added_value = Convert.ToInt32(sqlcomm.ExecuteScalar());
                    Int32 remain1 = Convert.ToInt32(txttotal_amount.Text) - (Convert.ToInt32(txtAdvanced.Text) + added_value);
                    txtremain_amt.Text = remain1.ToString();
                    sqlcon.Close();
                    sqlcon.Dispose();
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
            //try
            //{
            //    Int32 remain = Convert.ToInt32(txttotal_amount.Text) - Convert.ToInt32(txtAdvanced.Text);
            //    txtremain_amt.Text = remain.ToString();
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtAdvanced_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            try
            {
                if (count1 == null)
                {
                    Int32 remain = Convert.ToInt32(txttotal_amount.Text) - Convert.ToInt32(txtAdvanced.Text);
                    txtremain_amt.Text = remain.ToString();
                }
                else
                {
                    sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                    sqlcon.Open();
                    sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlcon;
                    sqlcomm.CommandText = "select sum(Advanced_amount) from Advanced_info where Customer_ID='" + count1 + "'";
                    Int32 added_value = Convert.ToInt32(sqlcomm.ExecuteScalar());
                    Int32 remain = Convert.ToInt32(txttotal_amount.Text) - (Convert.ToInt32(txtAdvanced.Text) + added_value);
                    txtremain_amt.Text = remain.ToString();
                    sqlcon.Close();
                    sqlcon.Dispose();
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

        private void btnadd_advanced_Click(object sender, EventArgs e)
        {
            if (count1 == null)
            {
                advanced_no = gdvpayment_info.Rows.Count - 1;
                DataRow dradvance = dtbadvance.NewRow();
                dradvance[0] = advanced_no + 1;
                advanced_no++;
                dradvance[1] = 0;
                dradvance[2] = txtAdvanced.Text;
                dradvance[3] = txtremain_amt.Text;
                dradvance[4] = orderdate.Value;
                dradvance[5] = orderdate.Value;

                dtbadvance.Rows.Add(dradvance);
                gdvpayment_info.DataSource = dtbadvance;
               // clear_advanced();
            }
            if (count1 != null)
            {
                DataRow dradvance = dtbadvance.NewRow();
                dradvance[0] = advanced_no + 1;
                advanced_no++;
                dradvance[1] = 0;
                dradvance[2] = txtAdvanced.Text;
                dradvance[3] = txtremain_amt.Text;
                dradvance[4] = gdvpayment_info.Rows[0].Cells[5].Value;
                dradvance[5] = orderdate.Value;

                dtbadvance.Rows.Add(dradvance);
                gdvpayment_info.DataSource = dtbadvance;
                //clear_advanced(); 
            }
        }

        private void gdvpayment_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            Int16 delete1 = Convert.ToInt16(gdvpayment_info.SelectedCells[0].RowIndex.ToString());
            flag1 = Convert.ToInt32(gdvpayment_info.Rows[delete1].Cells[1].Value);
            int advance_id_values=Convert.ToInt32(gdvpayment_info.Rows[delete1].Cells[2].Value);
            if (MessageBox.Show("Are you sure you want to delete?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (e.ColumnIndex == 0 && advance_id_values == 0)
                    {

                        DataTable dtabadvance = new DataTable();

                        dtabadvance.Columns.Add(new DataColumn("Advanced No"));
                        dtabadvance.Columns.Add(new DataColumn("Advanced Id"));
                        dtabadvance.Columns.Add(new DataColumn("Advanced Amount"));
                        dtabadvance.Columns.Add(new DataColumn("Remain Amount"));
                        dtabadvance.Columns.Add(new DataColumn("Created Date"));
                        dtabadvance.Columns.Add(new DataColumn("Updated Date"));



                        for (int loop = 0; loop <= gdvpayment_info.RowCount - 2; loop++)
                        {

                            DataRow drtabadvance = dtabadvance.NewRow();

                            drtabadvance["Advanced No"] = gdvpayment_info.Rows[loop].Cells[1].Value;
                            drtabadvance["Advanced Id"] = gdvpayment_info.Rows[loop].Cells[2].Value;
                            drtabadvance["Advanced Amount"] = gdvpayment_info.Rows[loop].Cells[3].Value;
                            drtabadvance["Remain Amount"] = gdvpayment_info.Rows[loop].Cells[4].Value;
                            drtabadvance["Created Date"] = gdvpayment_info.Rows[loop].Cells[5].Value;
                            drtabadvance["Updated Date"] = gdvpayment_info.Rows[loop].Cells[6].Value;

                            dtabadvance.Rows.Add(drtabadvance);


                        }

                        for (int loop = dtabadvance.Rows.Count - 1; loop >= 0; loop--)
                        {
                            DataRow dr2advance = dtabadvance.Rows[loop];
                            if (dr2advance["Advanced No"].ToString() == flag1.ToString())
                            {
                                dr2advance.Delete();

                                gdvpayment_info.DataSource = dtabadvance;
                                dtbadvance = dtabadvance;

                            }
                        }
                        for (int loop1 = flag1 - 1; loop1 <= dtabadvance.Rows.Count - 1; loop1++)
                        {
                            DataRow dr3advance = dtabadvance.Rows[loop1];
                            dr3advance["Advanced No"] = flag1.ToString();
                            flag1++;
                            gdvpayment_info.DataSource = dtabadvance;
                            dtbadvance = dtabadvance;
                        }
                        advanced_no = flag1 - 1;



                        dtbadvance = dtabadvance;


                    }

                    else if (e.ColumnIndex == 0 && advance_id_values != 0)
                    {

                        sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["photostudioConnectionString"].ToString());
                        sqlcon.Open();
                        sqlcomm = new SqlCommand();
                        sqlcomm.Connection = sqlcon;
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.CommandText = "delete from Advanced_info where Advanced_id=" + advance_id_values;
                        sqlcomm.ExecuteNonQuery();
                        MessageBox.Show("Item is Deleted of Selected customer");
                        sqlcon.Close();
                        sqlcon.Dispose();
                        advance_grid_bind_info();



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
        private void advance_grid_bind_info()
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
                sqlcomm.CommandText = "advanced_select";
                sqlcomm.Parameters.Add(new SqlParameter("@cust_id", SqlDbType.Int, 4));
                sqlcomm.Parameters["@cust_id"].Value = count1;
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(sqlcomm);
                dta.Fill(dt);
                gdvpayment_info.DataSource = dt;

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

        

        private void btnbill_Click(object sender, EventArgs e)
        {
            if (count1 == null)
            {
                Bill bill = new Bill(Convert.ToInt32(value_cust_id));
                bill.Show();
            }
            if (count1 != null)
            {
                Bill bill = new Bill(Convert.ToInt32(count1));
                bill.Show();
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                image_path = ofd.FileName;
            }
            
        }

        

       

       
    }
}
