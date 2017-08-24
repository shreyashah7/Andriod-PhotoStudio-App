namespace photostudio
{
    partial class Customer_name
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtcust_name_rpt = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cust_name_reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(300, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtcust_name_rpt
            // 
            this.txtcust_name_rpt.Location = new System.Drawing.Point(387, 64);
            this.txtcust_name_rpt.Name = "txtcust_name_rpt";
            this.txtcust_name_rpt.Size = new System.Drawing.Size(121, 20);
            this.txtcust_name_rpt.TabIndex = 1;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(592, 61);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(78, 28);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cust_name_reportviewer
            // 
            this.cust_name_reportviewer.ActiveViewIndex = -1;
            this.cust_name_reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cust_name_reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cust_name_reportviewer.Location = new System.Drawing.Point(12, 167);
            this.cust_name_reportviewer.Name = "cust_name_reportviewer";
            this.cust_name_reportviewer.Size = new System.Drawing.Size(1346, 555);
            this.cust_name_reportviewer.TabIndex = 3;
            this.cust_name_reportviewer.Load += new System.EventHandler(this.cust_name_reportviewer_Load);
            // 
            // Customer_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.cust_name_reportviewer);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtcust_name_rpt);
            this.Controls.Add(this.lblName);
            this.Name = "Customer_name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By Name";
            this.Load += new System.EventHandler(this.Customer_name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtcust_name_rpt;
        private System.Windows.Forms.Button btnsubmit;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cust_name_reportviewer;
    }
}