namespace KeanGabriel_RMS_SMS.Forms.ConfirmationForms
{
    partial class informationFrm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btOk = new System.Windows.Forms.Label();
            this.Exlamation_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Exclamation_AttentionBtn;
            this.pictureBox1.Location = new System.Drawing.Point(47, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btOk
            // 
            this.btOk.AutoSize = true;
            this.btOk.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(125, 102);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(71, 16);
            this.btOk.TabIndex = 5;
            this.btOk.Text = "Ok [Enter]";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            this.btOk.MouseLeave += new System.EventHandler(this.btOk_MouseLeave);
            this.btOk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btOk_MouseMove);
            // 
            // Exlamation_lbl
            // 
            this.Exlamation_lbl.AutoSize = true;
            this.Exlamation_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exlamation_lbl.Location = new System.Drawing.Point(101, 48);
            this.Exlamation_lbl.Name = "Exlamation_lbl";
            this.Exlamation_lbl.Size = new System.Drawing.Size(168, 21);
            this.Exlamation_lbl.TabIndex = 4;
            this.Exlamation_lbl.Text = "No database found!";
            this.Exlamation_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // informationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 141);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.Exlamation_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "informationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informationFrm";
            this.Load += new System.EventHandler(this.informationFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.informationFrm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btOk;
        public System.Windows.Forms.Label Exlamation_lbl;
    }
}