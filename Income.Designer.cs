namespace photostudio
{
    partial class Income
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
            this.lbldateincome = new System.Windows.Forms.Label();
            this.dateincome = new System.Windows.Forms.DateTimePicker();
            this.lblamountincome = new System.Windows.Forms.Label();
            this.lblincome_on = new System.Windows.Forms.Label();
            this.txtincome_amt = new System.Windows.Forms.TextBox();
            this.txtincome_on = new System.Windows.Forms.TextBox();
            this.dgv_income = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnincome_save = new System.Windows.Forms.Button();
            this.btnincome_cancel = new System.Windows.Forms.Button();
            this.grpincome = new System.Windows.Forms.GroupBox();
            this.combo_branch_income = new System.Windows.Forms.ComboBox();
            this.lblbranchincome = new System.Windows.Forms.Label();
            this.lbltotal_income = new System.Windows.Forms.Label();
            this.txttotal_income = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_income)).BeginInit();
            this.grpincome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldateincome
            // 
            this.lbldateincome.AutoSize = true;
            this.lbldateincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateincome.Location = new System.Drawing.Point(18, 33);
            this.lbldateincome.Name = "lbldateincome";
            this.lbldateincome.Size = new System.Drawing.Size(37, 16);
            this.lbldateincome.TabIndex = 0;
            this.lbldateincome.Text = "Date";
            // 
            // dateincome
            // 
            this.dateincome.CustomFormat = "dd-MM-yyyy";
            this.dateincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateincome.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateincome.Location = new System.Drawing.Point(110, 33);
            this.dateincome.Name = "dateincome";
            this.dateincome.Size = new System.Drawing.Size(128, 21);
            this.dateincome.TabIndex = 1;
            // 
            // lblamountincome
            // 
            this.lblamountincome.AutoSize = true;
            this.lblamountincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamountincome.Location = new System.Drawing.Point(296, 38);
            this.lblamountincome.Name = "lblamountincome";
            this.lblamountincome.Size = new System.Drawing.Size(53, 16);
            this.lblamountincome.TabIndex = 2;
            this.lblamountincome.Text = "Amount";
            // 
            // lblincome_on
            // 
            this.lblincome_on.AutoSize = true;
            this.lblincome_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincome_on.Location = new System.Drawing.Point(18, 105);
            this.lblincome_on.Name = "lblincome_on";
            this.lblincome_on.Size = new System.Drawing.Size(72, 16);
            this.lblincome_on.TabIndex = 3;
            this.lblincome_on.Text = "Income On";
            // 
            // txtincome_amt
            // 
            this.txtincome_amt.Location = new System.Drawing.Point(394, 35);
            this.txtincome_amt.Name = "txtincome_amt";
            this.txtincome_amt.Size = new System.Drawing.Size(128, 22);
            this.txtincome_amt.TabIndex = 4;
            // 
            // txtincome_on
            // 
            this.txtincome_on.Location = new System.Drawing.Point(110, 82);
            this.txtincome_on.Multiline = true;
            this.txtincome_on.Name = "txtincome_on";
            this.txtincome_on.Size = new System.Drawing.Size(128, 62);
            this.txtincome_on.TabIndex = 5;
            // 
            // dgv_income
            // 
            this.dgv_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_income.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_income.Location = new System.Drawing.Point(46, 328);
            this.dgv_income.Name = "dgv_income";
            this.dgv_income.Size = new System.Drawing.Size(654, 118);
            this.dgv_income.TabIndex = 6;
            this.dgv_income.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_income_CellContentClick);
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
            // btnincome_save
            // 
            this.btnincome_save.Location = new System.Drawing.Point(201, 187);
            this.btnincome_save.Name = "btnincome_save";
            this.btnincome_save.Size = new System.Drawing.Size(61, 23);
            this.btnincome_save.TabIndex = 7;
            this.btnincome_save.Text = "SAVE";
            this.btnincome_save.UseVisualStyleBackColor = true;
            this.btnincome_save.Click += new System.EventHandler(this.btnincome_save_Click);
            // 
            // btnincome_cancel
            // 
            this.btnincome_cancel.Location = new System.Drawing.Point(302, 187);
            this.btnincome_cancel.Name = "btnincome_cancel";
            this.btnincome_cancel.Size = new System.Drawing.Size(69, 23);
            this.btnincome_cancel.TabIndex = 8;
            this.btnincome_cancel.Text = "CANCEL";
            this.btnincome_cancel.UseVisualStyleBackColor = true;
            this.btnincome_cancel.Click += new System.EventHandler(this.btnincome_cancel_Click);
            // 
            // grpincome
            // 
            this.grpincome.Controls.Add(this.combo_branch_income);
            this.grpincome.Controls.Add(this.lblbranchincome);
            this.grpincome.Controls.Add(this.lbldateincome);
            this.grpincome.Controls.Add(this.btnincome_save);
            this.grpincome.Controls.Add(this.btnincome_cancel);
            this.grpincome.Controls.Add(this.dateincome);
            this.grpincome.Controls.Add(this.lblamountincome);
            this.grpincome.Controls.Add(this.txtincome_amt);
            this.grpincome.Controls.Add(this.lblincome_on);
            this.grpincome.Controls.Add(this.txtincome_on);
            this.grpincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpincome.Location = new System.Drawing.Point(100, 57);
            this.grpincome.Name = "grpincome";
            this.grpincome.Size = new System.Drawing.Size(547, 245);
            this.grpincome.TabIndex = 9;
            this.grpincome.TabStop = false;
            this.grpincome.Text = "Income Information";
            this.grpincome.Enter += new System.EventHandler(this.grpincome_Enter);
            // 
            // combo_branch_income
            // 
            this.combo_branch_income.FormattingEnabled = true;
            this.combo_branch_income.Location = new System.Drawing.Point(394, 97);
            this.combo_branch_income.Name = "combo_branch_income";
            this.combo_branch_income.Size = new System.Drawing.Size(128, 24);
            this.combo_branch_income.TabIndex = 10;
            // 
            // lblbranchincome
            // 
            this.lblbranchincome.AutoSize = true;
            this.lblbranchincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranchincome.Location = new System.Drawing.Point(299, 107);
            this.lblbranchincome.Name = "lblbranchincome";
            this.lblbranchincome.Size = new System.Drawing.Size(50, 16);
            this.lblbranchincome.TabIndex = 9;
            this.lblbranchincome.Text = "Branch";
            // 
            // lbltotal_income
            // 
            this.lbltotal_income.AutoSize = true;
            this.lbltotal_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_income.Location = new System.Drawing.Point(449, 464);
            this.lbltotal_income.Name = "lbltotal_income";
            this.lbltotal_income.Size = new System.Drawing.Size(86, 16);
            this.lbltotal_income.TabIndex = 10;
            this.lbltotal_income.Text = "Total Income";
            // 
            // txttotal_income
            // 
            this.txttotal_income.Location = new System.Drawing.Point(556, 463);
            this.txttotal_income.Name = "txttotal_income";
            this.txttotal_income.ReadOnly = true;
            this.txttotal_income.Size = new System.Drawing.Size(100, 20);
            this.txttotal_income.TabIndex = 11;
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 498);
            this.Controls.Add(this.txttotal_income);
            this.Controls.Add(this.lbltotal_income);
            this.Controls.Add(this.grpincome);
            this.Controls.Add(this.dgv_income);
            this.Name = "Income";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_income)).EndInit();
            this.grpincome.ResumeLayout(false);
            this.grpincome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldateincome;
        private System.Windows.Forms.DateTimePicker dateincome;
        private System.Windows.Forms.Label lblamountincome;
        private System.Windows.Forms.Label lblincome_on;
        private System.Windows.Forms.TextBox txtincome_amt;
        private System.Windows.Forms.TextBox txtincome_on;
        private System.Windows.Forms.DataGridView dgv_income;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.Button btnincome_save;
        private System.Windows.Forms.Button btnincome_cancel;
        private System.Windows.Forms.GroupBox grpincome;
        private System.Windows.Forms.ComboBox combo_branch_income;
        private System.Windows.Forms.Label lblbranchincome;
        private System.Windows.Forms.Label lbltotal_income;
        private System.Windows.Forms.TextBox txttotal_income;
    }
}