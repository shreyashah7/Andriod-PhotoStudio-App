namespace photostudio
{
    partial class cust_bystatus_report
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
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.btnsubmit_status = new System.Windows.Forms.Button();
            this.cust_status_reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpickfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpickto = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // combo_status
            // 
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Completed",
            "Delivered"});
            this.combo_status.Location = new System.Drawing.Point(143, 38);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(121, 21);
            this.combo_status.TabIndex = 1;
            // 
            // btnsubmit_status
            // 
            this.btnsubmit_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit_status.Location = new System.Drawing.Point(358, 92);
            this.btnsubmit_status.Name = "btnsubmit_status";
            this.btnsubmit_status.Size = new System.Drawing.Size(75, 27);
            this.btnsubmit_status.TabIndex = 2;
            this.btnsubmit_status.Text = "SUBMIT";
            this.btnsubmit_status.UseVisualStyleBackColor = true;
            this.btnsubmit_status.Click += new System.EventHandler(this.btnsubmit_status_Click);
            // 
            // cust_status_reportviewer
            // 
            this.cust_status_reportviewer.ActiveViewIndex = -1;
            this.cust_status_reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cust_status_reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cust_status_reportviewer.Location = new System.Drawing.Point(12, 176);
            this.cust_status_reportviewer.Name = "cust_status_reportviewer";
            this.cust_status_reportviewer.Size = new System.Drawing.Size(1346, 562);
            this.cust_status_reportviewer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // dtpickfrom
            // 
            this.dtpickfrom.CustomFormat = "dd-MM-yyyy";
            this.dtpickfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickfrom.Location = new System.Drawing.Point(391, 35);
            this.dtpickfrom.Name = "dtpickfrom";
            this.dtpickfrom.Size = new System.Drawing.Size(130, 20);
            this.dtpickfrom.TabIndex = 6;
            // 
            // dtpickto
            // 
            this.dtpickto.CustomFormat = "dd-MM-yyyy";
            this.dtpickto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickto.Location = new System.Drawing.Point(660, 35);
            this.dtpickto.Name = "dtpickto";
            this.dtpickto.Size = new System.Drawing.Size(136, 20);
            this.dtpickto.TabIndex = 7;
            // 
            // cust_bystatus_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.dtpickto);
            this.Controls.Add(this.dtpickfrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cust_status_reportviewer);
            this.Controls.Add(this.btnsubmit_status);
            this.Controls.Add(this.combo_status);
            this.Controls.Add(this.label1);
            this.Name = "cust_bystatus_report";
            this.Text = "cust_bystatus_report";
            this.Load += new System.EventHandler(this.cust_bystatus_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.Button btnsubmit_status;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cust_status_reportviewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpickfrom;
        private System.Windows.Forms.DateTimePicker dtpickto;
    }
}