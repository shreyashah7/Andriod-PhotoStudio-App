namespace photostudio
{
    partial class Expense
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
            this.lbldateexpense = new System.Windows.Forms.Label();
            this.dateexpense = new System.Windows.Forms.DateTimePicker();
            this.lblamountexpense = new System.Windows.Forms.Label();
            this.txtexpense_amt = new System.Windows.Forms.TextBox();
            this.lblexpense_on = new System.Windows.Forms.Label();
            this.txtexpense_on = new System.Windows.Forms.TextBox();
            this.btnincome_save = new System.Windows.Forms.Button();
            this.btnincome_cancel = new System.Windows.Forms.Button();
            this.grpexpense = new System.Windows.Forms.GroupBox();
            this.combo_branch_expense = new System.Windows.Forms.ComboBox();
            this.lblbranchexpense = new System.Windows.Forms.Label();
            this.dgv_expense = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lbltotalexpense = new System.Windows.Forms.Label();
            this.txttotal_expense = new System.Windows.Forms.TextBox();
            this.grpexpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expense)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldateexpense
            // 
            this.lbldateexpense.AutoSize = true;
            this.lbldateexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateexpense.Location = new System.Drawing.Point(34, 38);
            this.lbldateexpense.Name = "lbldateexpense";
            this.lbldateexpense.Size = new System.Drawing.Size(37, 16);
            this.lbldateexpense.TabIndex = 1;
            this.lbldateexpense.Text = "Date";
            // 
            // dateexpense
            // 
            this.dateexpense.CustomFormat = "dd-MM-yyyy";
            this.dateexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateexpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateexpense.Location = new System.Drawing.Point(130, 33);
            this.dateexpense.Name = "dateexpense";
            this.dateexpense.Size = new System.Drawing.Size(128, 21);
            this.dateexpense.TabIndex = 2;
            // 
            // lblamountexpense
            // 
            this.lblamountexpense.AutoSize = true;
            this.lblamountexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamountexpense.Location = new System.Drawing.Point(319, 41);
            this.lblamountexpense.Name = "lblamountexpense";
            this.lblamountexpense.Size = new System.Drawing.Size(53, 16);
            this.lblamountexpense.TabIndex = 3;
            this.lblamountexpense.Text = "Amount";
            // 
            // txtexpense_amt
            // 
            this.txtexpense_amt.Location = new System.Drawing.Point(407, 38);
            this.txtexpense_amt.Name = "txtexpense_amt";
            this.txtexpense_amt.Size = new System.Drawing.Size(128, 22);
            this.txtexpense_amt.TabIndex = 5;
            this.txtexpense_amt.TextChanged += new System.EventHandler(this.txtexpense_amt_TextChanged);
            // 
            // lblexpense_on
            // 
            this.lblexpense_on.AutoSize = true;
            this.lblexpense_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpense_on.Location = new System.Drawing.Point(34, 115);
            this.lblexpense_on.Name = "lblexpense_on";
            this.lblexpense_on.Size = new System.Drawing.Size(81, 16);
            this.lblexpense_on.TabIndex = 6;
            this.lblexpense_on.Text = "Expense On";
            // 
            // txtexpense_on
            // 
            this.txtexpense_on.Location = new System.Drawing.Point(130, 92);
            this.txtexpense_on.Multiline = true;
            this.txtexpense_on.Name = "txtexpense_on";
            this.txtexpense_on.Size = new System.Drawing.Size(128, 62);
            this.txtexpense_on.TabIndex = 7;
            // 
            // btnincome_save
            // 
            this.btnincome_save.Location = new System.Drawing.Point(197, 212);
            this.btnincome_save.Name = "btnincome_save";
            this.btnincome_save.Size = new System.Drawing.Size(71, 23);
            this.btnincome_save.TabIndex = 8;
            this.btnincome_save.Text = "SAVE";
            this.btnincome_save.UseVisualStyleBackColor = true;
            this.btnincome_save.Click += new System.EventHandler(this.btnincome_save_Click);
            // 
            // btnincome_cancel
            // 
            this.btnincome_cancel.Location = new System.Drawing.Point(308, 212);
            this.btnincome_cancel.Name = "btnincome_cancel";
            this.btnincome_cancel.Size = new System.Drawing.Size(73, 23);
            this.btnincome_cancel.TabIndex = 9;
            this.btnincome_cancel.Text = "CANCEL";
            this.btnincome_cancel.UseVisualStyleBackColor = true;
            this.btnincome_cancel.Click += new System.EventHandler(this.btnincome_cancel_Click);
            // 
            // grpexpense
            // 
            this.grpexpense.Controls.Add(this.combo_branch_expense);
            this.grpexpense.Controls.Add(this.lblbranchexpense);
            this.grpexpense.Controls.Add(this.lbldateexpense);
            this.grpexpense.Controls.Add(this.btnincome_cancel);
            this.grpexpense.Controls.Add(this.dateexpense);
            this.grpexpense.Controls.Add(this.btnincome_save);
            this.grpexpense.Controls.Add(this.lblamountexpense);
            this.grpexpense.Controls.Add(this.txtexpense_on);
            this.grpexpense.Controls.Add(this.txtexpense_amt);
            this.grpexpense.Controls.Add(this.lblexpense_on);
            this.grpexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpexpense.Location = new System.Drawing.Point(108, 55);
            this.grpexpense.Name = "grpexpense";
            this.grpexpense.Size = new System.Drawing.Size(559, 262);
            this.grpexpense.TabIndex = 10;
            this.grpexpense.TabStop = false;
            this.grpexpense.Text = "Expense Information";
            // 
            // combo_branch_expense
            // 
            this.combo_branch_expense.FormattingEnabled = true;
            this.combo_branch_expense.Location = new System.Drawing.Point(407, 107);
            this.combo_branch_expense.Name = "combo_branch_expense";
            this.combo_branch_expense.Size = new System.Drawing.Size(128, 24);
            this.combo_branch_expense.TabIndex = 11;
            // 
            // lblbranchexpense
            // 
            this.lblbranchexpense.AutoSize = true;
            this.lblbranchexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranchexpense.Location = new System.Drawing.Point(319, 115);
            this.lblbranchexpense.Name = "lblbranchexpense";
            this.lblbranchexpense.Size = new System.Drawing.Size(50, 16);
            this.lblbranchexpense.TabIndex = 10;
            this.lblbranchexpense.Text = "Branch";
            // 
            // dgv_expense
            // 
            this.dgv_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_expense.Location = new System.Drawing.Point(59, 355);
            this.dgv_expense.Name = "dgv_expense";
            this.dgv_expense.Size = new System.Drawing.Size(657, 115);
            this.dgv_expense.TabIndex = 11;
            this.dgv_expense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_expense_CellContentClick);
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
            // lbltotalexpense
            // 
            this.lbltotalexpense.AutoSize = true;
            this.lbltotalexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalexpense.Location = new System.Drawing.Point(501, 491);
            this.lbltotalexpense.Name = "lbltotalexpense";
            this.lbltotalexpense.Size = new System.Drawing.Size(95, 16);
            this.lbltotalexpense.TabIndex = 12;
            this.lbltotalexpense.Text = "Total Expense";
            // 
            // txttotal_expense
            // 
            this.txttotal_expense.Location = new System.Drawing.Point(610, 489);
            this.txttotal_expense.Name = "txttotal_expense";
            this.txttotal_expense.Size = new System.Drawing.Size(100, 20);
            this.txttotal_expense.TabIndex = 13;
            this.txttotal_expense.TextChanged += new System.EventHandler(this.txttotal_expense_TextChanged);
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.Controls.Add(this.txttotal_expense);
            this.Controls.Add(this.lbltotalexpense);
            this.Controls.Add(this.dgv_expense);
            this.Controls.Add(this.grpexpense);
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            this.grpexpense.ResumeLayout(false);
            this.grpexpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldateexpense;
        private System.Windows.Forms.DateTimePicker dateexpense;
        private System.Windows.Forms.Label lblamountexpense;
        private System.Windows.Forms.TextBox txtexpense_amt;
        private System.Windows.Forms.Label lblexpense_on;
        private System.Windows.Forms.TextBox txtexpense_on;
        private System.Windows.Forms.Button btnincome_save;
        private System.Windows.Forms.Button btnincome_cancel;
        private System.Windows.Forms.GroupBox grpexpense;
        private System.Windows.Forms.DataGridView dgv_expense;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.Label lblbranchexpense;
        private System.Windows.Forms.ComboBox combo_branch_expense;
        private System.Windows.Forms.Label lbltotalexpense;
        private System.Windows.Forms.TextBox txttotal_expense;
    }
}