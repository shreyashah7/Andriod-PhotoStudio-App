namespace photostudio
{
    partial class Balanced_sheet
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
            this.dtpickto_expense = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_branch_sheet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsubmit_sheet = new System.Windows.Forms.Button();
            this.balanced_reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // dtpickfrom_expense
            // 
            this.dtpickfrom_expense.CustomFormat = "dd-MM-yyyy";
            this.dtpickfrom_expense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickfrom_expense.Location = new System.Drawing.Point(358, 27);
            this.dtpickfrom_expense.Name = "dtpickfrom_expense";
            this.dtpickfrom_expense.Size = new System.Drawing.Size(138, 22);
            this.dtpickfrom_expense.TabIndex = 5;
            // 
            // dtpickto_expense
            // 
            this.dtpickto_expense.CustomFormat = "dd-MM-yyyy";
            this.dtpickto_expense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickto_expense.Location = new System.Drawing.Point(627, 25);
            this.dtpickto_expense.Name = "dtpickto_expense";
            this.dtpickto_expense.Size = new System.Drawing.Size(133, 22);
            this.dtpickto_expense.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_branch_sheet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnsubmit_sheet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpickto_expense);
            this.groupBox1.Controls.Add(this.dtpickfrom_expense);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(155, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balanced Sheet";
            // 
            // combo_branch_sheet
            // 
            this.combo_branch_sheet.FormattingEnabled = true;
            this.combo_branch_sheet.Location = new System.Drawing.Point(89, 24);
            this.combo_branch_sheet.Name = "combo_branch_sheet";
            this.combo_branch_sheet.Size = new System.Drawing.Size(121, 24);
            this.combo_branch_sheet.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Branch";
            // 
            // btnsubmit_sheet
            // 
            this.btnsubmit_sheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit_sheet.Location = new System.Drawing.Point(380, 81);
            this.btnsubmit_sheet.Name = "btnsubmit_sheet";
            this.btnsubmit_sheet.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit_sheet.TabIndex = 8;
            this.btnsubmit_sheet.Text = "SUBMIT";
            this.btnsubmit_sheet.UseVisualStyleBackColor = true;
            this.btnsubmit_sheet.Click += new System.EventHandler(this.btnsubmit_sheet_Click);
            // 
            // balanced_reportviewer
            // 
            this.balanced_reportviewer.ActiveViewIndex = -1;
            this.balanced_reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanced_reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.balanced_reportviewer.Location = new System.Drawing.Point(12, 205);
            this.balanced_reportviewer.Name = "balanced_reportviewer";
            this.balanced_reportviewer.Size = new System.Drawing.Size(1346, 533);
            this.balanced_reportviewer.TabIndex = 9;
            // 
            // Balanced_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.balanced_reportviewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Balanced_sheet";
            this.Text = "Balanced_sheet";
            this.Load += new System.EventHandler(this.Balanced_sheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpickfrom_expense;
        private System.Windows.Forms.DateTimePicker dtpickto_expense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsubmit_sheet;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer balanced_reportviewer;
        private System.Windows.Forms.ComboBox combo_branch_sheet;
        private System.Windows.Forms.Label label3;
    }
}