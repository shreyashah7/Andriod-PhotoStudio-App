namespace photostudio
{
    partial class Expense_report
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpickfrom_expense = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpickto_expense = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit_expense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expense_reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // dtpickfrom_expense
            // 
            this.dtpickfrom_expense.CustomFormat = "dd-MM-yyyy";
            this.dtpickfrom_expense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickfrom_expense.Location = new System.Drawing.Point(108, 33);
            this.dtpickfrom_expense.Name = "dtpickfrom_expense";
            this.dtpickfrom_expense.Size = new System.Drawing.Size(138, 20);
            this.dtpickfrom_expense.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dtpickto_expense
            // 
            this.dtpickto_expense.CustomFormat = "dd-MM-yyyy";
            this.dtpickto_expense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickto_expense.Location = new System.Drawing.Point(346, 33);
            this.dtpickto_expense.Name = "dtpickto_expense";
            this.dtpickto_expense.Size = new System.Drawing.Size(133, 20);
            this.dtpickto_expense.TabIndex = 3;
            // 
            // btnsubmit_expense
            // 
            this.btnsubmit_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit_expense.Location = new System.Drawing.Point(265, 70);
            this.btnsubmit_expense.Name = "btnsubmit_expense";
            this.btnsubmit_expense.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit_expense.TabIndex = 4;
            this.btnsubmit_expense.Text = "SUBMIT";
            this.btnsubmit_expense.UseVisualStyleBackColor = true;
            this.btnsubmit_expense.Click += new System.EventHandler(this.btnsubmit_expense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsubmit_expense);
            this.groupBox1.Controls.Add(this.dtpickfrom_expense);
            this.groupBox1.Controls.Add(this.dtpickto_expense);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Report";
            // 
            // expense_reportviewer
            // 
            this.expense_reportviewer.ActiveViewIndex = -1;
            this.expense_reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expense_reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.expense_reportviewer.Location = new System.Drawing.Point(12, 157);
            this.expense_reportviewer.Name = "expense_reportviewer";
            this.expense_reportviewer.Size = new System.Drawing.Size(1346, 581);
            this.expense_reportviewer.TabIndex = 6;
            // 
            // Expense_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.expense_reportviewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Expense_report";
            this.Text = "Expense_report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpickfrom_expense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpickto_expense;
        private System.Windows.Forms.Button btnsubmit_expense;
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer expense_reportviewer;
    }
}