namespace KeanGabriel_RMS_SMS.Forms.ConfirmationForms
{
    partial class confirmLogoutFrm
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
            this.txtOnQuestion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btNo = new System.Windows.Forms.Label();
            this.btYes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOnQuestion
            // 
            this.txtOnQuestion.AutoSize = true;
            this.txtOnQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnQuestion.Location = new System.Drawing.Point(68, 25);
            this.txtOnQuestion.Name = "txtOnQuestion";
            this.txtOnQuestion.Size = new System.Drawing.Size(272, 21);
            this.txtOnQuestion.TabIndex = 5;
            this.txtOnQuestion.Text = "Are you sure you want to Logout?";
            this.txtOnQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Question_AttentionBtn;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btNo
            // 
            this.btNo.AutoSize = true;
            this.btNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.Location = new System.Drawing.Point(200, 71);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(59, 16);
            this.btNo.TabIndex = 7;
            this.btNo.Text = "No [Esc]";
            // 
            // btYes
            // 
            this.btYes.AutoSize = true;
            this.btYes.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYes.Location = new System.Drawing.Point(96, 71);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(74, 16);
            this.btYes.TabIndex = 6;
            this.btYes.Text = "Yes [Enter]";
            // 
            // confirmLogoutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 100);
            this.Controls.Add(this.txtOnQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "confirmLogoutFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "confirmLogoutFrm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.confirmLogoutFrm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtOnQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btNo;
        private System.Windows.Forms.Label btYes;
    }
}