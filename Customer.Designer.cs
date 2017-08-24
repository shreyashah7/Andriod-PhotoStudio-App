namespace photostudio
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbcust = new System.Windows.Forms.GroupBox();
            this.cust_combostatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcust_phno = new System.Windows.Forms.TextBox();
            this.lblcust_phno = new System.Windows.Forms.Label();
            this.duedate = new System.Windows.Forms.DateTimePicker();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.cust_branchcombo = new System.Windows.Forms.ComboBox();
            this.txtcust_addr = new System.Windows.Forms.TextBox();
            this.txtcust_name = new System.Windows.Forms.TextBox();
            this.lblcust_duedate = new System.Windows.Forms.Label();
            this.lblcust_orderdate = new System.Windows.Forms.Label();
            this.lblcust_branch = new System.Windows.Forms.Label();
            this.lblcust_addr = new System.Windows.Forms.Label();
            this.lblcust_name = new System.Windows.Forms.Label();
            this.dgvcust_main = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btncust_submit = new System.Windows.Forms.Button();
            this.btncust_cancel = new System.Windows.Forms.Button();
            this.grpbphoto = new System.Windows.Forms.GroupBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.combo_photo_size = new System.Windows.Forms.ComboBox();
            this.btnphoto_save = new System.Windows.Forms.Button();
            this.txtphoto_amount = new System.Windows.Forms.TextBox();
            this.txtprice_qty = new System.Windows.Forms.TextBox();
            this.lblphotoamount = new System.Windows.Forms.Label();
            this.lblpriceperqty = new System.Windows.Forms.Label();
            this.txtphoto_qty = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblphoto_size = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.txttotal_amount = new System.Windows.Forms.TextBox();
            this.gvphoto_info = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lbladvance = new System.Windows.Forms.Label();
            this.txtAdvanced = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd_advanced = new System.Windows.Forms.Button();
            this.txtremain_amt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvpayment_info = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbill = new System.Windows.Forms.Button();
            this.Image_display = new System.Windows.Forms.GroupBox();
            this.dgvimage_display = new System.Windows.Forms.DataGridView();
            this.grpbcust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust_main)).BeginInit();
            this.grpbphoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvphoto_info)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvpayment_info)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Image_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvimage_display)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbcust
            // 
            this.grpbcust.Controls.Add(this.cust_combostatus);
            this.grpbcust.Controls.Add(this.label2);
            this.grpbcust.Controls.Add(this.txtcust_phno);
            this.grpbcust.Controls.Add(this.lblcust_phno);
            this.grpbcust.Controls.Add(this.duedate);
            this.grpbcust.Controls.Add(this.orderdate);
            this.grpbcust.Controls.Add(this.cust_branchcombo);
            this.grpbcust.Controls.Add(this.txtcust_addr);
            this.grpbcust.Controls.Add(this.txtcust_name);
            this.grpbcust.Controls.Add(this.lblcust_duedate);
            this.grpbcust.Controls.Add(this.lblcust_orderdate);
            this.grpbcust.Controls.Add(this.lblcust_branch);
            this.grpbcust.Controls.Add(this.lblcust_addr);
            this.grpbcust.Controls.Add(this.lblcust_name);
            this.grpbcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbcust.Location = new System.Drawing.Point(5, 12);
            this.grpbcust.Name = "grpbcust";
            this.grpbcust.Size = new System.Drawing.Size(695, 151);
            this.grpbcust.TabIndex = 0;
            this.grpbcust.TabStop = false;
            this.grpbcust.Text = "Customer information";
            // 
            // cust_combostatus
            // 
            this.cust_combostatus.FormattingEnabled = true;
            this.cust_combostatus.Items.AddRange(new object[] {
            "Pending",
            "Completed",
            "Delivered"});
            this.cust_combostatus.Location = new System.Drawing.Point(569, 118);
            this.cust_combostatus.Name = "cust_combostatus";
            this.cust_combostatus.Size = new System.Drawing.Size(121, 24);
            this.cust_combostatus.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Status";
            // 
            // txtcust_phno
            // 
            this.txtcust_phno.Location = new System.Drawing.Point(307, 83);
            this.txtcust_phno.Name = "txtcust_phno";
            this.txtcust_phno.Size = new System.Drawing.Size(124, 23);
            this.txtcust_phno.TabIndex = 4;
            // 
            // lblcust_phno
            // 
            this.lblcust_phno.AutoSize = true;
            this.lblcust_phno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_phno.Location = new System.Drawing.Point(238, 86);
            this.lblcust_phno.Name = "lblcust_phno";
            this.lblcust_phno.Size = new System.Drawing.Size(63, 15);
            this.lblcust_phno.TabIndex = 16;
            this.lblcust_phno.Text = "Phone-No";
            // 
            // duedate
            // 
            this.duedate.CustomFormat = "dd-MM-yyyy";
            this.duedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.duedate.Location = new System.Drawing.Point(569, 70);
            this.duedate.Name = "duedate";
            this.duedate.Size = new System.Drawing.Size(121, 23);
            this.duedate.TabIndex = 6;
            // 
            // orderdate
            // 
            this.orderdate.CustomFormat = "dd-MM-yyyy";
            this.orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderdate.Location = new System.Drawing.Point(569, 31);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(121, 23);
            this.orderdate.TabIndex = 5;
            // 
            // cust_branchcombo
            // 
            this.cust_branchcombo.FormattingEnabled = true;
            this.cust_branchcombo.Location = new System.Drawing.Point(307, 31);
            this.cust_branchcombo.Name = "cust_branchcombo";
            this.cust_branchcombo.Size = new System.Drawing.Size(124, 24);
            this.cust_branchcombo.TabIndex = 3;
            // 
            // txtcust_addr
            // 
            this.txtcust_addr.Location = new System.Drawing.Point(70, 77);
            this.txtcust_addr.Multiline = true;
            this.txtcust_addr.Name = "txtcust_addr";
            this.txtcust_addr.Size = new System.Drawing.Size(125, 57);
            this.txtcust_addr.TabIndex = 2;
            // 
            // txtcust_name
            // 
            this.txtcust_name.Location = new System.Drawing.Point(70, 33);
            this.txtcust_name.Name = "txtcust_name";
            this.txtcust_name.Size = new System.Drawing.Size(125, 23);
            this.txtcust_name.TabIndex = 1;
            this.txtcust_name.TextChanged += new System.EventHandler(this.txtcust_name_TextChanged);
            // 
            // lblcust_duedate
            // 
            this.lblcust_duedate.AutoSize = true;
            this.lblcust_duedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_duedate.Location = new System.Drawing.Point(489, 78);
            this.lblcust_duedate.Name = "lblcust_duedate";
            this.lblcust_duedate.Size = new System.Drawing.Size(59, 15);
            this.lblcust_duedate.TabIndex = 6;
            this.lblcust_duedate.Text = "Due Date";
            // 
            // lblcust_orderdate
            // 
            this.lblcust_orderdate.AutoSize = true;
            this.lblcust_orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_orderdate.Location = new System.Drawing.Point(489, 34);
            this.lblcust_orderdate.Name = "lblcust_orderdate";
            this.lblcust_orderdate.Size = new System.Drawing.Size(67, 15);
            this.lblcust_orderdate.TabIndex = 5;
            this.lblcust_orderdate.Text = "Order Date";
            // 
            // lblcust_branch
            // 
            this.lblcust_branch.AutoSize = true;
            this.lblcust_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_branch.Location = new System.Drawing.Point(238, 36);
            this.lblcust_branch.Name = "lblcust_branch";
            this.lblcust_branch.Size = new System.Drawing.Size(46, 15);
            this.lblcust_branch.TabIndex = 4;
            this.lblcust_branch.Text = "Branch";
            // 
            // lblcust_addr
            // 
            this.lblcust_addr.AutoSize = true;
            this.lblcust_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_addr.Location = new System.Drawing.Point(7, 92);
            this.lblcust_addr.Name = "lblcust_addr";
            this.lblcust_addr.Size = new System.Drawing.Size(51, 15);
            this.lblcust_addr.TabIndex = 3;
            this.lblcust_addr.Text = "Address";
            // 
            // lblcust_name
            // 
            this.lblcust_name.AutoSize = true;
            this.lblcust_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_name.Location = new System.Drawing.Point(8, 33);
            this.lblcust_name.Name = "lblcust_name";
            this.lblcust_name.Size = new System.Drawing.Size(41, 15);
            this.lblcust_name.TabIndex = 0;
            this.lblcust_name.Text = "Name";
            // 
            // dgvcust_main
            // 
            this.dgvcust_main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcust_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcust_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dgvcust_main.Location = new System.Drawing.Point(6, 22);
            this.dgvcust_main.Name = "dgvcust_main";
            this.dgvcust_main.Size = new System.Drawing.Size(626, 307);
            this.dgvcust_main.TabIndex = 14;
            this.dgvcust_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcust_main_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edit";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Edit";
            this.Column2.ToolTipText = "Edit";
            this.Column2.UseColumnTextForLinkValue = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Delete";
            this.Column3.Name = "Column3";
            this.Column3.Text = "Delete";
            this.Column3.ToolTipText = "Delete";
            this.Column3.UseColumnTextForLinkValue = true;
            // 
            // btncust_submit
            // 
            this.btncust_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust_submit.Location = new System.Drawing.Point(574, 620);
            this.btncust_submit.Name = "btncust_submit";
            this.btncust_submit.Size = new System.Drawing.Size(86, 34);
            this.btncust_submit.TabIndex = 11;
            this.btncust_submit.Text = "SUBMIT";
            this.btncust_submit.UseVisualStyleBackColor = true;
            this.btncust_submit.Click += new System.EventHandler(this.btncust_submit_Click);
            // 
            // btncust_cancel
            // 
            this.btncust_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust_cancel.Location = new System.Drawing.Point(692, 620);
            this.btncust_cancel.Name = "btncust_cancel";
            this.btncust_cancel.Size = new System.Drawing.Size(86, 33);
            this.btncust_cancel.TabIndex = 12;
            this.btncust_cancel.Text = "CANCEL";
            this.btncust_cancel.UseVisualStyleBackColor = true;
            this.btncust_cancel.Click += new System.EventHandler(this.btncust_cancel_Click);
            // 
            // grpbphoto
            // 
            this.grpbphoto.Controls.Add(this.btnbrowse);
            this.grpbphoto.Controls.Add(this.combo_photo_size);
            this.grpbphoto.Controls.Add(this.btnphoto_save);
            this.grpbphoto.Controls.Add(this.txtphoto_amount);
            this.grpbphoto.Controls.Add(this.txtprice_qty);
            this.grpbphoto.Controls.Add(this.lblphotoamount);
            this.grpbphoto.Controls.Add(this.lblpriceperqty);
            this.grpbphoto.Controls.Add(this.txtphoto_qty);
            this.grpbphoto.Controls.Add(this.lblquantity);
            this.grpbphoto.Controls.Add(this.lblphoto_size);
            this.grpbphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbphoto.Location = new System.Drawing.Point(5, 169);
            this.grpbphoto.Name = "grpbphoto";
            this.grpbphoto.Size = new System.Drawing.Size(195, 237);
            this.grpbphoto.TabIndex = 7;
            this.grpbphoto.TabStop = false;
            this.grpbphoto.Text = "Photo Information";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(23, 201);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(65, 25);
            this.btnbrowse.TabIndex = 12;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // combo_photo_size
            // 
            this.combo_photo_size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_photo_size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_photo_size.FormattingEnabled = true;
            this.combo_photo_size.Location = new System.Drawing.Point(100, 26);
            this.combo_photo_size.Name = "combo_photo_size";
            this.combo_photo_size.Size = new System.Drawing.Size(59, 24);
            this.combo_photo_size.TabIndex = 8;
            this.combo_photo_size.SelectedIndexChanged += new System.EventHandler(this.combo_photo_size_SelectedIndexChanged);
            // 
            // btnphoto_save
            // 
            this.btnphoto_save.Location = new System.Drawing.Point(100, 201);
            this.btnphoto_save.Name = "btnphoto_save";
            this.btnphoto_save.Size = new System.Drawing.Size(69, 25);
            this.btnphoto_save.TabIndex = 10;
            this.btnphoto_save.Text = "Add";
            this.btnphoto_save.UseVisualStyleBackColor = true;
            this.btnphoto_save.Click += new System.EventHandler(this.btnphoto_save_Click);
            // 
            // txtphoto_amount
            // 
            this.txtphoto_amount.BackColor = System.Drawing.SystemColors.Control;
            this.txtphoto_amount.Location = new System.Drawing.Point(100, 167);
            this.txtphoto_amount.Name = "txtphoto_amount";
            this.txtphoto_amount.ReadOnly = true;
            this.txtphoto_amount.Size = new System.Drawing.Size(59, 23);
            this.txtphoto_amount.TabIndex = 11;
            // 
            // txtprice_qty
            // 
            this.txtprice_qty.BackColor = System.Drawing.SystemColors.Control;
            this.txtprice_qty.Location = new System.Drawing.Point(100, 68);
            this.txtprice_qty.Name = "txtprice_qty";
            this.txtprice_qty.ReadOnly = true;
            this.txtprice_qty.Size = new System.Drawing.Size(59, 23);
            this.txtprice_qty.TabIndex = 10;
            this.txtprice_qty.TextChanged += new System.EventHandler(this.txtprice_qty_TextChanged);
            // 
            // lblphotoamount
            // 
            this.lblphotoamount.AutoSize = true;
            this.lblphotoamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphotoamount.Location = new System.Drawing.Point(20, 164);
            this.lblphotoamount.Name = "lblphotoamount";
            this.lblphotoamount.Size = new System.Drawing.Size(49, 15);
            this.lblphotoamount.TabIndex = 5;
            this.lblphotoamount.Text = "Amount";
            // 
            // lblpriceperqty
            // 
            this.lblpriceperqty.AutoSize = true;
            this.lblpriceperqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpriceperqty.Location = new System.Drawing.Point(20, 75);
            this.lblpriceperqty.Name = "lblpriceperqty";
            this.lblpriceperqty.Size = new System.Drawing.Size(55, 15);
            this.lblpriceperqty.TabIndex = 4;
            this.lblpriceperqty.Text = "Price/Qty";
            // 
            // txtphoto_qty
            // 
            this.txtphoto_qty.Location = new System.Drawing.Point(100, 119);
            this.txtphoto_qty.Name = "txtphoto_qty";
            this.txtphoto_qty.Size = new System.Drawing.Size(59, 23);
            this.txtphoto_qty.TabIndex = 9;
            this.txtphoto_qty.TextChanged += new System.EventHandler(this.txtphoto_qty_TextChanged);
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.Location = new System.Drawing.Point(20, 126);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(56, 16);
            this.lblquantity.TabIndex = 2;
            this.lblquantity.Text = "Quantity";
            // 
            // lblphoto_size
            // 
            this.lblphoto_size.AutoSize = true;
            this.lblphoto_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoto_size.Location = new System.Drawing.Point(20, 29);
            this.lblphoto_size.Name = "lblphoto_size";
            this.lblphoto_size.Size = new System.Drawing.Size(66, 15);
            this.lblphoto_size.TabIndex = 0;
            this.lblphoto_size.Text = "Photo Size";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(93, 237);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(104, 20);
            this.lbltotalamount.TabIndex = 8;
            this.lbltotalamount.Text = "Total Amount";
            // 
            // txttotal_amount
            // 
            this.txttotal_amount.Location = new System.Drawing.Point(208, 236);
            this.txttotal_amount.Name = "txttotal_amount";
            this.txttotal_amount.ReadOnly = true;
            this.txttotal_amount.Size = new System.Drawing.Size(118, 21);
            this.txttotal_amount.TabIndex = 9;
            this.txttotal_amount.TextChanged += new System.EventHandler(this.txttotal_amount_TextChanged);
            // 
            // gvphoto_info
            // 
            this.gvphoto_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvphoto_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvphoto_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gvphoto_info.Location = new System.Drawing.Point(9, 20);
            this.gvphoto_info.Name = "gvphoto_info";
            this.gvphoto_info.Size = new System.Drawing.Size(474, 206);
            this.gvphoto_info.TabIndex = 13;
            this.gvphoto_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvphoto_info_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.ToolTipText = "Delete";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 49;
            // 
            // lbladvance
            // 
            this.lbladvance.AutoSize = true;
            this.lbladvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvance.Location = new System.Drawing.Point(10, 35);
            this.lbladvance.Name = "lbladvance";
            this.lbladvance.Size = new System.Drawing.Size(96, 16);
            this.lbladvance.TabIndex = 15;
            this.lbladvance.Text = "Advanced Amt";
            // 
            // txtAdvanced
            // 
            this.txtAdvanced.Location = new System.Drawing.Point(121, 34);
            this.txtAdvanced.Name = "txtAdvanced";
            this.txtAdvanced.Size = new System.Drawing.Size(44, 23);
            this.txtAdvanced.TabIndex = 10;
            this.txtAdvanced.Text = "0";
            this.txtAdvanced.TextChanged += new System.EventHandler(this.txtAdvanced_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadd_advanced);
            this.groupBox1.Controls.Add(this.txtremain_amt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbladvance);
            this.groupBox1.Controls.Add(this.txtAdvanced);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 168);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information";
            // 
            // btnadd_advanced
            // 
            this.btnadd_advanced.Location = new System.Drawing.Point(49, 121);
            this.btnadd_advanced.Name = "btnadd_advanced";
            this.btnadd_advanced.Size = new System.Drawing.Size(68, 27);
            this.btnadd_advanced.TabIndex = 18;
            this.btnadd_advanced.Text = "ADD";
            this.btnadd_advanced.UseVisualStyleBackColor = true;
            this.btnadd_advanced.Click += new System.EventHandler(this.btnadd_advanced_Click);
            // 
            // txtremain_amt
            // 
            this.txtremain_amt.Location = new System.Drawing.Point(121, 82);
            this.txtremain_amt.Name = "txtremain_amt";
            this.txtremain_amt.ReadOnly = true;
            this.txtremain_amt.Size = new System.Drawing.Size(44, 23);
            this.txtremain_amt.TabIndex = 17;
            this.txtremain_amt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Remain Amount";
            // 
            // gdvpayment_info
            // 
            this.gdvpayment_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvpayment_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvpayment_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.gdvpayment_info.Location = new System.Drawing.Point(6, 20);
            this.gdvpayment_info.Name = "gdvpayment_info";
            this.gdvpayment_info.Size = new System.Drawing.Size(477, 138);
            this.gdvpayment_info.TabIndex = 17;
            this.gdvpayment_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvpayment_info_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Delete";
            this.Column4.Name = "Column4";
            this.Column4.Text = "Delete";
            this.Column4.ToolTipText = "Delete";
            this.Column4.UseColumnTextForLinkValue = true;
            this.Column4.Width = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdvpayment_info);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(212, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 164);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Display";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvphoto_info);
            this.groupBox3.Controls.Add(this.lbltotalamount);
            this.groupBox3.Controls.Add(this.txttotal_amount);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(212, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 267);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo Item Display";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvcust_main);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(720, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(638, 364);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Virtual Display";
            // 
            // btnbill
            // 
            this.btnbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbill.Location = new System.Drawing.Point(800, 620);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(81, 32);
            this.btnbill.TabIndex = 21;
            this.btnbill.Text = "BILL";
            this.btnbill.UseVisualStyleBackColor = true;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // Image_display
            // 
            this.Image_display.Controls.Add(this.dgvimage_display);
            this.Image_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image_display.Location = new System.Drawing.Point(720, 12);
            this.Image_display.Name = "Image_display";
            this.Image_display.Size = new System.Drawing.Size(638, 223);
            this.Image_display.TabIndex = 22;
            this.Image_display.TabStop = false;
            this.Image_display.Text = "Image Display";
            // 
            // dgvimage_display
            // 
            this.dgvimage_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvimage_display.Location = new System.Drawing.Point(6, 22);
            this.dgvimage_display.Name = "dgvimage_display";
            this.dgvimage_display.Size = new System.Drawing.Size(626, 195);
            this.dgvimage_display.TabIndex = 0;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.Image_display);
            this.Controls.Add(this.btnbill);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbphoto);
            this.Controls.Add(this.btncust_cancel);
            this.Controls.Add(this.btncust_submit);
            this.Controls.Add(this.grpbcust);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.grpbcust.ResumeLayout(false);
            this.grpbcust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust_main)).EndInit();
            this.grpbphoto.ResumeLayout(false);
            this.grpbphoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvphoto_info)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvpayment_info)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.Image_display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvimage_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbcust;
        private System.Windows.Forms.TextBox txtcust_addr;
        private System.Windows.Forms.TextBox txtcust_name;
        private System.Windows.Forms.Label lblcust_duedate;
        private System.Windows.Forms.Label lblcust_orderdate;
        private System.Windows.Forms.Label lblcust_branch;
        private System.Windows.Forms.Label lblcust_addr;
        private System.Windows.Forms.Label lblcust_name;
        private System.Windows.Forms.DateTimePicker duedate;
        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.ComboBox cust_branchcombo;
        private System.Windows.Forms.Button btncust_submit;
        private System.Windows.Forms.Button btncust_cancel;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.GroupBox grpbphoto;
        private System.Windows.Forms.Label lblphoto_size;
        private System.Windows.Forms.Button btnphoto_save;
        private System.Windows.Forms.TextBox txttotal_amount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.TextBox txtphoto_amount;
        private System.Windows.Forms.TextBox txtprice_qty;
        private System.Windows.Forms.Label lblphotoamount;
        private System.Windows.Forms.Label lblpriceperqty;
        private System.Windows.Forms.TextBox txtphoto_qty;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.DataGridView gvphoto_info;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.ComboBox combo_photo_size;
        private System.Windows.Forms.TextBox txtcust_phno;
        private System.Windows.Forms.Label lblcust_phno;
        private System.Windows.Forms.Label lbladvance;
        private System.Windows.Forms.TextBox txtAdvanced;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdvpayment_info;
        private System.Windows.Forms.TextBox txtremain_amt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
        private System.Windows.Forms.Button btnadd_advanced;
        private System.Windows.Forms.DataGridView dgvcust_main;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cust_combostatus;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.GroupBox Image_display;
        private System.Windows.Forms.DataGridView dgvimage_display;
    }
}