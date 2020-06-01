namespace KeanGabriel_RMS_SMS.Forms.ConfirmationForms
{
    partial class attentionFrm
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
            this.Exlamation_lbl = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exlamation_lbl
            // 
            this.Exlamation_lbl.AutoSize = true;
            this.Exlamation_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exlamation_lbl.Location = new System.Drawing.Point(84, 36);
            this.Exlamation_lbl.Name = "Exlamation_lbl";
            this.Exlamation_lbl.Size = new System.Drawing.Size(165, 21);
            this.Exlamation_lbl.TabIndex = 1;
            this.Exlamation_lbl.Text = "Account not found!";
            this.Exlamation_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exlamation_lbl.Click += new System.EventHandler(this.Exlamation_lbl_Click);
            // 
            // btOk
            // 
            this.btOk.AutoSize = true;
            this.btOk.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(108, 90);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(71, 16);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Ok [Enter]";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            this.btOk.MouseLeave += new System.EventHandler(this.btOk_MouseLeave);
            this.btOk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btOk_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Exclamation_AttentionBtn;
            this.pictureBox1.Location = new System.Drawing.Point(30, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // attentionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.Exlamation_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "attentionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "attentionFrm";
            this.Load += new System.EventHandler(this.attentionFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.attentionFrm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.attentionFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Exlamation_lbl;

    }
}