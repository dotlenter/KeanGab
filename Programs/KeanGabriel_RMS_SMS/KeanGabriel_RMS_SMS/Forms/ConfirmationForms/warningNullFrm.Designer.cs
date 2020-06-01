namespace KeanGabriel_RMS_SMS.Forms.ConfirmationForms
{
    partial class warningNullFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(warningNullFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.errorTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorTStxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Error: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorTxt
            // 
            this.errorTxt.BackColor = System.Drawing.Color.Transparent;
            this.errorTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTxt.Location = new System.Drawing.Point(77, 24);
            this.errorTxt.Name = "errorTxt";
            this.errorTxt.Padding = new System.Windows.Forms.Padding(5);
            this.errorTxt.Size = new System.Drawing.Size(249, 79);
            this.errorTxt.TabIndex = 1;
            this.errorTxt.Text = "Victim is Null! You need to enter a victim for a valid case!\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorTStxt
            // 
            this.errorTStxt.BackColor = System.Drawing.Color.White;
            this.errorTStxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorTStxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTStxt.Location = new System.Drawing.Point(77, 103);
            this.errorTStxt.Name = "errorTStxt";
            this.errorTStxt.Padding = new System.Windows.Forms.Padding(10);
            this.errorTStxt.Size = new System.Drawing.Size(234, 89);
            this.errorTStxt.TabIndex = 3;
            this.errorTStxt.Text = "Victim should have at least a Family name, First name, or Middle Name for the sys" +
    "tem to confirm that it is valid.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Exclamation_AttentionBtn;
            this.pictureBox1.Location = new System.Drawing.Point(26, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // warningNullFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorTStxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "warningNullFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[NULL VICTIM]";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.warningNullFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label errorTxt;
        public System.Windows.Forms.Label errorTStxt;
    }
}