namespace photostudio
{
    partial class Photo_size
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
            this.grpbphotsizeinfo = new System.Windows.Forms.GroupBox();
            this.lblphoto_sizeinfo = new System.Windows.Forms.Label();
            this.lblPhoto_size = new System.Windows.Forms.Label();
            this.lblphoto_price = new System.Windows.Forms.Label();
            this.txtphoto_size_info = new System.Windows.Forms.TextBox();
            this.txtphoto_prize = new System.Windows.Forms.TextBox();
            this.btnphotosize_submit = new System.Windows.Forms.Button();
            this.btnphotosize_cancel = new System.Windows.Forms.Button();
            this.dgvphoto_sizeinfo = new System.Windows.Forms.DataGridView();
            this.lbl_display = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.grpbphotsizeinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphoto_sizeinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbphotsizeinfo
            // 
            this.grpbphotsizeinfo.Controls.Add(this.txtphoto_prize);
            this.grpbphotsizeinfo.Controls.Add(this.txtphoto_size_info);
            this.grpbphotsizeinfo.Controls.Add(this.lblphoto_price);
            this.grpbphotsizeinfo.Controls.Add(this.lblPhoto_size);
            this.grpbphotsizeinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbphotsizeinfo.Location = new System.Drawing.Point(37, 102);
            this.grpbphotsizeinfo.Name = "grpbphotsizeinfo";
            this.grpbphotsizeinfo.Size = new System.Drawing.Size(360, 178);
            this.grpbphotsizeinfo.TabIndex = 0;
            this.grpbphotsizeinfo.TabStop = false;
            this.grpbphotsizeinfo.Text = "Photo Size Information";
            // 
            // lblphoto_sizeinfo
            // 
            this.lblphoto_sizeinfo.AutoSize = true;
            this.lblphoto_sizeinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoto_sizeinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblphoto_sizeinfo.Location = new System.Drawing.Point(397, 32);
            this.lblphoto_sizeinfo.Name = "lblphoto_sizeinfo";
            this.lblphoto_sizeinfo.Size = new System.Drawing.Size(171, 20);
            this.lblphoto_sizeinfo.TabIndex = 1;
            this.lblphoto_sizeinfo.Text = "Photo Size Information";
            // 
            // lblPhoto_size
            // 
            this.lblPhoto_size.AutoSize = true;
            this.lblPhoto_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto_size.Location = new System.Drawing.Point(23, 52);
            this.lblPhoto_size.Name = "lblPhoto_size";
            this.lblPhoto_size.Size = new System.Drawing.Size(81, 18);
            this.lblPhoto_size.TabIndex = 0;
            this.lblPhoto_size.Text = "Photo Size";
            this.lblPhoto_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblphoto_price
            // 
            this.lblphoto_price.AutoSize = true;
            this.lblphoto_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoto_price.Location = new System.Drawing.Point(23, 118);
            this.lblphoto_price.Name = "lblphoto_price";
            this.lblphoto_price.Size = new System.Drawing.Size(50, 18);
            this.lblphoto_price.TabIndex = 1;
            this.lblphoto_price.Text = "Prices";
            // 
            // txtphoto_size_info
            // 
            this.txtphoto_size_info.Location = new System.Drawing.Point(132, 47);
            this.txtphoto_size_info.Name = "txtphoto_size_info";
            this.txtphoto_size_info.Size = new System.Drawing.Size(157, 23);
            this.txtphoto_size_info.TabIndex = 2;
            // 
            // txtphoto_prize
            // 
            this.txtphoto_prize.Location = new System.Drawing.Point(132, 113);
            this.txtphoto_prize.Name = "txtphoto_prize";
            this.txtphoto_prize.Size = new System.Drawing.Size(157, 23);
            this.txtphoto_prize.TabIndex = 3;
            // 
            // btnphotosize_submit
            // 
            this.btnphotosize_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphotosize_submit.Location = new System.Drawing.Point(123, 335);
            this.btnphotosize_submit.Name = "btnphotosize_submit";
            this.btnphotosize_submit.Size = new System.Drawing.Size(83, 31);
            this.btnphotosize_submit.TabIndex = 2;
            this.btnphotosize_submit.Text = "SUBMIT";
            this.btnphotosize_submit.UseVisualStyleBackColor = true;
            this.btnphotosize_submit.Click += new System.EventHandler(this.btnphotosize_submit_Click);
            // 
            // btnphotosize_cancel
            // 
            this.btnphotosize_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphotosize_cancel.Location = new System.Drawing.Point(244, 335);
            this.btnphotosize_cancel.Name = "btnphotosize_cancel";
            this.btnphotosize_cancel.Size = new System.Drawing.Size(82, 31);
            this.btnphotosize_cancel.TabIndex = 3;
            this.btnphotosize_cancel.Text = "CANCEL";
            this.btnphotosize_cancel.UseVisualStyleBackColor = true;
            this.btnphotosize_cancel.Click += new System.EventHandler(this.btnphotosize_cancel_Click);
            // 
            // dgvphoto_sizeinfo
            // 
            this.dgvphoto_sizeinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphoto_sizeinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvphoto_sizeinfo.Location = new System.Drawing.Point(493, 109);
            this.dgvphoto_sizeinfo.Name = "dgvphoto_sizeinfo";
            this.dgvphoto_sizeinfo.Size = new System.Drawing.Size(443, 171);
            this.dgvphoto_sizeinfo.TabIndex = 4;
            this.dgvphoto_sizeinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphoto_sizeinfo_CellContentClick);
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_display.Location = new System.Drawing.Point(625, 77);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(109, 20);
            this.lbl_display.TabIndex = 5;
            this.lbl_display.Text = "Virtual Display";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.ToolTipText = "Delete";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // Photo_size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 499);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.dgvphoto_sizeinfo);
            this.Controls.Add(this.btnphotosize_cancel);
            this.Controls.Add(this.btnphotosize_submit);
            this.Controls.Add(this.lblphoto_sizeinfo);
            this.Controls.Add(this.grpbphotsizeinfo);
            this.Name = "Photo_size";
            this.Text = "Photo_size";
            this.Load += new System.EventHandler(this.Photo_size_Load);
            this.grpbphotsizeinfo.ResumeLayout(false);
            this.grpbphotsizeinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphoto_sizeinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbphotsizeinfo;
        private System.Windows.Forms.Label lblphoto_price;
        private System.Windows.Forms.Label lblPhoto_size;
        private System.Windows.Forms.Label lblphoto_sizeinfo;
        private System.Windows.Forms.TextBox txtphoto_prize;
        private System.Windows.Forms.TextBox txtphoto_size_info;
        private System.Windows.Forms.Button btnphotosize_submit;
        private System.Windows.Forms.Button btnphotosize_cancel;
        private System.Windows.Forms.DataGridView dgvphoto_sizeinfo;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
    }
}