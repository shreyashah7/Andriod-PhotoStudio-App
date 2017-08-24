namespace photostudio
{
    partial class Bill
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
            this.cust_bill_crystalreportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cust_bill_crystalreportviewer
            // 
            this.cust_bill_crystalreportviewer.ActiveViewIndex = -1;
            this.cust_bill_crystalreportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cust_bill_crystalreportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cust_bill_crystalreportviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cust_bill_crystalreportviewer.Location = new System.Drawing.Point(0, 0);
            this.cust_bill_crystalreportviewer.Name = "cust_bill_crystalreportviewer";
            this.cust_bill_crystalreportviewer.Size = new System.Drawing.Size(530, 364);
            this.cust_bill_crystalreportviewer.TabIndex = 0;
            this.cust_bill_crystalreportviewer.Load += new System.EventHandler(this.cust_bill_crystalreportviewer_Load);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 364);
            this.Controls.Add(this.cust_bill_crystalreportviewer);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cust_bill_crystalreportviewer;
    }
}