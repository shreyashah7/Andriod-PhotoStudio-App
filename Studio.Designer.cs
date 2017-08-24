namespace photostudio
{
    partial class Studio
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
            this.gbstudioInfo = new System.Windows.Forms.GroupBox();
            this.txtphno = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtstudioAddr = new System.Windows.Forms.TextBox();
            this.lblStudio_Addr = new System.Windows.Forms.Label();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.txtStudio_name = new System.Windows.Forms.TextBox();
            this.lblStudio_name = new System.Windows.Forms.Label();
            this.gvstudio = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtowner2 = new System.Windows.Forms.TextBox();
            this.lblowner2 = new System.Windows.Forms.Label();
            this.txtOwner4 = new System.Windows.Forms.TextBox();
            this.lblOwner4 = new System.Windows.Forms.Label();
            this.txtowner3 = new System.Windows.Forms.TextBox();
            this.txtowner1 = new System.Windows.Forms.TextBox();
            this.lblOwner3 = new System.Windows.Forms.Label();
            this.lblOwner1 = new System.Windows.Forms.Label();
            this.txtSinceDate = new System.Windows.Forms.DateTimePicker();
            this.lblSinceDate = new System.Windows.Forms.Label();
            this.gbstudioInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstudio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbstudioInfo
            // 
            this.gbstudioInfo.Controls.Add(this.txtphno);
            this.gbstudioInfo.Controls.Add(this.lblPhoneNo);
            this.gbstudioInfo.Controls.Add(this.txtstudioAddr);
            this.gbstudioInfo.Controls.Add(this.lblStudio_Addr);
            this.gbstudioInfo.Controls.Add(this.txtbranch);
            this.gbstudioInfo.Controls.Add(this.lblBranch);
            this.gbstudioInfo.Controls.Add(this.txtStudio_name);
            this.gbstudioInfo.Controls.Add(this.lblStudio_name);
            this.gbstudioInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstudioInfo.Location = new System.Drawing.Point(73, 59);
            this.gbstudioInfo.Name = "gbstudioInfo";
            this.gbstudioInfo.Size = new System.Drawing.Size(469, 285);
            this.gbstudioInfo.TabIndex = 0;
            this.gbstudioInfo.TabStop = false;
            this.gbstudioInfo.Text = "Studio Information";
            this.gbstudioInfo.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtphno
            // 
            this.txtphno.Location = new System.Drawing.Point(179, 173);
            this.txtphno.MaxLength = 300;
            this.txtphno.Name = "txtphno";
            this.txtphno.Size = new System.Drawing.Size(202, 23);
            this.txtphno.TabIndex = 3;
            this.txtphno.TextChanged += new System.EventHandler(this.txtBranch_TextChanged);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(21, 175);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(90, 20);
            this.lblPhoneNo.TabIndex = 30;
            this.lblPhoneNo.Text = "Contact-No";
            this.lblPhoneNo.Click += new System.EventHandler(this.lblPhoneNo_Click);
            // 
            // txtstudioAddr
            // 
            this.txtstudioAddr.Location = new System.Drawing.Point(179, 93);
            this.txtstudioAddr.Multiline = true;
            this.txtstudioAddr.Name = "txtstudioAddr";
            this.txtstudioAddr.Size = new System.Drawing.Size(202, 60);
            this.txtstudioAddr.TabIndex = 2;
            this.txtstudioAddr.TextChanged += new System.EventHandler(this.txtstudioAddr_TextChanged);
            // 
            // lblStudio_Addr
            // 
            this.lblStudio_Addr.AutoSize = true;
            this.lblStudio_Addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudio_Addr.Location = new System.Drawing.Point(21, 96);
            this.lblStudio_Addr.Name = "lblStudio_Addr";
            this.lblStudio_Addr.Size = new System.Drawing.Size(68, 20);
            this.lblStudio_Addr.TabIndex = 26;
            this.lblStudio_Addr.Text = "Address";
            this.lblStudio_Addr.Click += new System.EventHandler(this.lblStudio_Addr_Click);
            // 
            // txtbranch
            // 
            this.txtbranch.Location = new System.Drawing.Point(179, 220);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(202, 23);
            this.txtbranch.TabIndex = 4;
            this.txtbranch.TextChanged += new System.EventHandler(this.txtstudioPhno_TextChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(21, 220);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(60, 20);
            this.lblBranch.TabIndex = 24;
            this.lblBranch.Text = "Branch";
            this.lblBranch.Click += new System.EventHandler(this.lblBranch_Click);
            // 
            // txtStudio_name
            // 
            this.txtStudio_name.Location = new System.Drawing.Point(179, 46);
            this.txtStudio_name.Name = "txtStudio_name";
            this.txtStudio_name.Size = new System.Drawing.Size(202, 23);
            this.txtStudio_name.TabIndex = 1;
            this.txtStudio_name.TextChanged += new System.EventHandler(this.txtStudio_name_TextChanged);
            // 
            // lblStudio_name
            // 
            this.lblStudio_name.AutoSize = true;
            this.lblStudio_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudio_name.Location = new System.Drawing.Point(21, 46);
            this.lblStudio_name.Name = "lblStudio_name";
            this.lblStudio_name.Size = new System.Drawing.Size(101, 20);
            this.lblStudio_name.TabIndex = 22;
            this.lblStudio_name.Text = "Studio Name";
            this.lblStudio_name.Click += new System.EventHandler(this.lblStudio_name_Click);
            // 
            // gvstudio
            // 
            this.gvstudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstudio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gvstudio.Location = new System.Drawing.Point(78, 487);
            this.gvstudio.Name = "gvstudio";
            this.gvstudio.Size = new System.Drawing.Size(1027, 140);
            this.gvstudio.TabIndex = 13;
            this.gvstudio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Edit";
            this.Column1.ToolTipText = "Edit";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Delete";
            this.Column2.ToolTipText = "Delete";
            this.Column2.UseColumnTextForLinkValue = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(616, 404);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(82, 31);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(508, 404);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(84, 31);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "SUBMIT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtowner2);
            this.groupBox1.Controls.Add(this.lblowner2);
            this.groupBox1.Controls.Add(this.txtOwner4);
            this.groupBox1.Controls.Add(this.lblOwner4);
            this.groupBox1.Controls.Add(this.txtowner3);
            this.groupBox1.Controls.Add(this.txtowner1);
            this.groupBox1.Controls.Add(this.lblOwner3);
            this.groupBox1.Controls.Add(this.lblOwner1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(587, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 235);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Owner Information";
            // 
            // txtowner2
            // 
            this.txtowner2.Location = new System.Drawing.Point(215, 88);
            this.txtowner2.Name = "txtowner2";
            this.txtowner2.Size = new System.Drawing.Size(179, 23);
            this.txtowner2.TabIndex = 8;
            // 
            // lblowner2
            // 
            this.lblowner2.AutoSize = true;
            this.lblowner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblowner2.Location = new System.Drawing.Point(57, 86);
            this.lblowner2.Name = "lblowner2";
            this.lblowner2.Size = new System.Drawing.Size(116, 20);
            this.lblowner2.TabIndex = 63;
            this.lblowner2.Text = "*Owner Name2";
            // 
            // txtOwner4
            // 
            this.txtOwner4.Location = new System.Drawing.Point(215, 190);
            this.txtOwner4.Name = "txtOwner4";
            this.txtOwner4.Size = new System.Drawing.Size(179, 23);
            this.txtOwner4.TabIndex = 10;
            // 
            // lblOwner4
            // 
            this.lblOwner4.AutoSize = true;
            this.lblOwner4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner4.Location = new System.Drawing.Point(57, 188);
            this.lblOwner4.Name = "lblOwner4";
            this.lblOwner4.Size = new System.Drawing.Size(116, 20);
            this.lblOwner4.TabIndex = 61;
            this.lblOwner4.Text = "*Owner Name4";
            // 
            // txtowner3
            // 
            this.txtowner3.Location = new System.Drawing.Point(217, 139);
            this.txtowner3.Name = "txtowner3";
            this.txtowner3.Size = new System.Drawing.Size(177, 23);
            this.txtowner3.TabIndex = 9;
            // 
            // txtowner1
            // 
            this.txtowner1.Location = new System.Drawing.Point(216, 40);
            this.txtowner1.Name = "txtowner1";
            this.txtowner1.Size = new System.Drawing.Size(178, 23);
            this.txtowner1.TabIndex = 7;
            // 
            // lblOwner3
            // 
            this.lblOwner3.AutoSize = true;
            this.lblOwner3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner3.Location = new System.Drawing.Point(57, 137);
            this.lblOwner3.Name = "lblOwner3";
            this.lblOwner3.Size = new System.Drawing.Size(116, 20);
            this.lblOwner3.TabIndex = 58;
            this.lblOwner3.Text = "*Owner Name3";
            // 
            // lblOwner1
            // 
            this.lblOwner1.AutoSize = true;
            this.lblOwner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner1.Location = new System.Drawing.Point(57, 38);
            this.lblOwner1.Name = "lblOwner1";
            this.lblOwner1.Size = new System.Drawing.Size(110, 20);
            this.lblOwner1.TabIndex = 57;
            this.lblOwner1.Text = "Owner Name1";
            // 
            // txtSinceDate
            // 
            this.txtSinceDate.CustomFormat = "dd-MM-yyyy";
            this.txtSinceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtSinceDate.Location = new System.Drawing.Point(779, 58);
            this.txtSinceDate.Name = "txtSinceDate";
            this.txtSinceDate.Size = new System.Drawing.Size(202, 20);
            this.txtSinceDate.TabIndex = 5;
            // 
            // lblSinceDate
            // 
            this.lblSinceDate.AutoSize = true;
            this.lblSinceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinceDate.Location = new System.Drawing.Point(644, 58);
            this.lblSinceDate.Name = "lblSinceDate";
            this.lblSinceDate.Size = new System.Drawing.Size(88, 20);
            this.lblSinceDate.TabIndex = 57;
            this.lblSinceDate.Text = "Since Date";
            // 
            // Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 628);
            this.Controls.Add(this.txtSinceDate);
            this.Controls.Add(this.lblSinceDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.gvstudio);
            this.Controls.Add(this.gbstudioInfo);
            this.Name = "Studio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Studio_Load);
            this.gbstudioInfo.ResumeLayout(false);
            this.gbstudioInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstudio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbstudioInfo;
        private System.Windows.Forms.TextBox txtphno;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtstudioAddr;
        private System.Windows.Forms.Label lblStudio_Addr;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.TextBox txtStudio_name;
        private System.Windows.Forms.Label lblStudio_name;
        private System.Windows.Forms.DataGridView gvstudio;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtowner2;
        private System.Windows.Forms.Label lblowner2;
        private System.Windows.Forms.TextBox txtOwner4;
        private System.Windows.Forms.Label lblOwner4;
        private System.Windows.Forms.TextBox txtowner3;
        private System.Windows.Forms.TextBox txtowner1;
        private System.Windows.Forms.Label lblOwner3;
        private System.Windows.Forms.Label lblOwner1;
        private System.Windows.Forms.DateTimePicker txtSinceDate;
        private System.Windows.Forms.Label lblSinceDate;




    }
}

