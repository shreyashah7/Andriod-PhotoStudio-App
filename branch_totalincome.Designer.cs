namespace photostudio
{
    partial class branch_totalincome
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
            this.lblbranch_income = new System.Windows.Forms.Label();
            this.combo_branchincome = new System.Windows.Forms.ComboBox();
            this.btnsubmit_income = new System.Windows.Forms.Button();
            this.branch_income_reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lblbranch_income
            // 
            this.lblbranch_income.AutoSize = true;
            this.lblbranch_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch_income.Location = new System.Drawing.Point(177, 40);
            this.lblbranch_income.Name = "lblbranch_income";
            this.lblbranch_income.Size = new System.Drawing.Size(53, 17);
            this.lblbranch_income.TabIndex = 0;
            this.lblbranch_income.Text = "Branch";
            // 
            // combo_branchincome
            // 
            this.combo_branchincome.FormattingEnabled = true;
            this.combo_branchincome.Location = new System.Drawing.Point(264, 40);
            this.combo_branchincome.Name = "combo_branchincome";
            this.combo_branchincome.Size = new System.Drawing.Size(121, 21);
            this.combo_branchincome.TabIndex = 1;
            // 
            // btnsubmit_income
            // 
            this.btnsubmit_income.Location = new System.Drawing.Point(459, 37);
            this.btnsubmit_income.Name = "btnsubmit_income";
            this.btnsubmit_income.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit_income.TabIndex = 2;
            this.btnsubmit_income.Text = "SUBMIT";
            this.btnsubmit_income.UseVisualStyleBackColor = true;
            this.btnsubmit_income.Click += new System.EventHandler(this.btnsubmit_income_Click);
            // 
            // branch_income_reportviewer
            // 
            this.branch_income_reportviewer.ActiveViewIndex = -1;
            this.branch_income_reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.branch_income_reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.branch_income_reportviewer.Location = new System.Drawing.Point(12, 113);
            this.branch_income_reportviewer.Name = "branch_income_reportviewer";
            this.branch_income_reportviewer.Size = new System.Drawing.Size(1346, 625);
            this.branch_income_reportviewer.TabIndex = 3;
            // 
            // branch_totalincome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.branch_income_reportviewer);
            this.Controls.Add(this.btnsubmit_income);
            this.Controls.Add(this.combo_branchincome);
            this.Controls.Add(this.lblbranch_income);
            this.Name = "branch_totalincome";
            this.Text = "branch_totalincome";
            this.Load += new System.EventHandler(this.branch_totalincome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbranch_income;
        private System.Windows.Forms.ComboBox combo_branchincome;
        private System.Windows.Forms.Button btnsubmit_income;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer branch_income_reportviewer;
    }
}