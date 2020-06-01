namespace KeanGabriel_RMS_SMS.Forms.ConfirmationForms
{
    partial class loginFrm_OnExit
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
            this.btYes = new System.Windows.Forms.Label();
            this.btNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOnQuestion
            // 
            this.txtOnQuestion.AutoSize = true;
            this.txtOnQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnQuestion.Location = new System.Drawing.Point(66, 20);
            this.txtOnQuestion.Name = "txtOnQuestion";
            this.txtOnQuestion.Size = new System.Drawing.Size(245, 21);
            this.txtOnQuestion.TabIndex = 0;
            this.txtOnQuestion.Text = "Are you sure you want to exit?";
            this.txtOnQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btYes
            // 
            this.btYes.AutoSize = true;
            this.btYes.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYes.Location = new System.Drawing.Point(94, 66);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(74, 16);
            this.btYes.TabIndex = 1;
            this.btYes.Text = "Yes [Enter]";
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            this.btYes.MouseLeave += new System.EventHandler(this.btYes_MouseLeave);
            this.btYes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btYes_MouseMove);
            // 
            // btNo
            // 
            this.btNo.AutoSize = true;
            this.btNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.Location = new System.Drawing.Point(198, 66);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(59, 16);
            this.btNo.TabIndex = 2;
            this.btNo.Text = "No [Esc]";
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            this.btNo.MouseLeave += new System.EventHandler(this.btNo_MouseLeave);
            this.btNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btNo_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Question_AttentionBtn;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginFrm_OnExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 100);
            this.Controls.Add(this.txtOnQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "loginFrm_OnExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "loginFrm_OnExit";
            this.Load += new System.EventHandler(this.loginFrm_OnExit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.loginFrm_OnExit_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginFrm_OnExit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btYes;
        private System.Windows.Forms.Label btNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label txtOnQuestion;
    }
}