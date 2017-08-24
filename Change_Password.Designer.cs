namespace photostudio
{
    partial class Change_Password
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
            this.lbloldpwd = new System.Windows.Forms.Label();
            this.lblnewpwd = new System.Windows.Forms.Label();
            this.lblcfrmnewpwd = new System.Windows.Forms.Label();
            this.txtoldpwd = new System.Windows.Forms.TextBox();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.txtcnfrmnewpwd = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbloldpwd
            // 
            this.lbloldpwd.AutoSize = true;
            this.lbloldpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldpwd.ForeColor = System.Drawing.Color.Navy;
            this.lbloldpwd.Location = new System.Drawing.Point(40, 60);
            this.lbloldpwd.Name = "lbloldpwd";
            this.lbloldpwd.Size = new System.Drawing.Size(92, 16);
            this.lbloldpwd.TabIndex = 0;
            this.lbloldpwd.Text = "Old Password";
            // 
            // lblnewpwd
            // 
            this.lblnewpwd.AutoSize = true;
            this.lblnewpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpwd.ForeColor = System.Drawing.Color.Navy;
            this.lblnewpwd.Location = new System.Drawing.Point(40, 114);
            this.lblnewpwd.Name = "lblnewpwd";
            this.lblnewpwd.Size = new System.Drawing.Size(98, 16);
            this.lblnewpwd.TabIndex = 1;
            this.lblnewpwd.Text = "New Password";
            // 
            // lblcfrmnewpwd
            // 
            this.lblcfrmnewpwd.AutoSize = true;
            this.lblcfrmnewpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfrmnewpwd.ForeColor = System.Drawing.Color.Navy;
            this.lblcfrmnewpwd.Location = new System.Drawing.Point(40, 166);
            this.lblcfrmnewpwd.Name = "lblcfrmnewpwd";
            this.lblcfrmnewpwd.Size = new System.Drawing.Size(146, 16);
            this.lblcfrmnewpwd.TabIndex = 2;
            this.lblcfrmnewpwd.Text = "Confirm New Password";
            // 
            // txtoldpwd
            // 
            this.txtoldpwd.Location = new System.Drawing.Point(203, 56);
            this.txtoldpwd.Name = "txtoldpwd";
            this.txtoldpwd.PasswordChar = '*';
            this.txtoldpwd.Size = new System.Drawing.Size(110, 20);
            this.txtoldpwd.TabIndex = 3;
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.Location = new System.Drawing.Point(203, 114);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.PasswordChar = '*';
            this.txtnewpwd.Size = new System.Drawing.Size(110, 20);
            this.txtnewpwd.TabIndex = 4;
            // 
            // txtcnfrmnewpwd
            // 
            this.txtcnfrmnewpwd.Location = new System.Drawing.Point(203, 162);
            this.txtcnfrmnewpwd.Name = "txtcnfrmnewpwd";
            this.txtcnfrmnewpwd.PasswordChar = '*';
            this.txtcnfrmnewpwd.Size = new System.Drawing.Size(110, 20);
            this.txtcnfrmnewpwd.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(95, 223);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(203, 223);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 322);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtcnfrmnewpwd);
            this.Controls.Add(this.txtnewpwd);
            this.Controls.Add(this.txtoldpwd);
            this.Controls.Add(this.lblcfrmnewpwd);
            this.Controls.Add(this.lblnewpwd);
            this.Controls.Add(this.lbloldpwd);
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloldpwd;
        private System.Windows.Forms.Label lblnewpwd;
        private System.Windows.Forms.Label lblcfrmnewpwd;
        private System.Windows.Forms.TextBox txtoldpwd;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.TextBox txtcnfrmnewpwd;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnreset;
    }
}