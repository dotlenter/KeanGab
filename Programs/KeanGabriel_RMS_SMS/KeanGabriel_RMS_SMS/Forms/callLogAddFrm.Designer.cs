namespace KeanGabriel_RMS_SMS.Forms
{
    partial class callLogAddFrm
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
            this.border = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hidePb = new System.Windows.Forms.PictureBox();
            this.closePb = new System.Windows.Forms.PictureBox();
            this.rbMobileNumber = new System.Windows.Forms.RadioButton();
            this.rbTelNumber = new System.Windows.Forms.RadioButton();
            this.txtMobNumber = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.cmbSim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.border.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.White;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Controls.Add(this.label5);
            this.border.Controls.Add(this.panel4);
            this.border.Controls.Add(this.hidePb);
            this.border.Controls.Add(this.closePb);
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(717, 38);
            this.border.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "- Add Calls";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 28);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "A";
            // 
            // hidePb
            // 
            this.hidePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.hideCirc;
            this.hidePb.Location = new System.Drawing.Point(666, 7);
            this.hidePb.Name = "hidePb";
            this.hidePb.Size = new System.Drawing.Size(20, 20);
            this.hidePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePb.TabIndex = 1;
            this.hidePb.TabStop = false;
            // 
            // closePb
            // 
            this.closePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.closeCirc;
            this.closePb.Location = new System.Drawing.Point(692, 7);
            this.closePb.Name = "closePb";
            this.closePb.Size = new System.Drawing.Size(20, 20);
            this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePb.TabIndex = 0;
            this.closePb.TabStop = false;
            // 
            // rbMobileNumber
            // 
            this.rbMobileNumber.AutoSize = true;
            this.rbMobileNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMobileNumber.Location = new System.Drawing.Point(11, 118);
            this.rbMobileNumber.Name = "rbMobileNumber";
            this.rbMobileNumber.Size = new System.Drawing.Size(172, 26);
            this.rbMobileNumber.TabIndex = 26;
            this.rbMobileNumber.TabStop = true;
            this.rbMobileNumber.Text = "Mobile Number:";
            this.rbMobileNumber.UseVisualStyleBackColor = true;
            this.rbMobileNumber.CheckedChanged += new System.EventHandler(this.rbMobileNumber_CheckedChanged);
            // 
            // rbTelNumber
            // 
            this.rbTelNumber.AutoSize = true;
            this.rbTelNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTelNumber.Location = new System.Drawing.Point(11, 180);
            this.rbTelNumber.Name = "rbTelNumber";
            this.rbTelNumber.Size = new System.Drawing.Size(175, 26);
            this.rbTelNumber.TabIndex = 27;
            this.rbTelNumber.TabStop = true;
            this.rbTelNumber.Text = "Tel Number        :";
            this.rbTelNumber.UseVisualStyleBackColor = true;
            this.rbTelNumber.CheckedChanged += new System.EventHandler(this.rbTelNumber_CheckedChanged);
            // 
            // txtMobNumber
            // 
            this.txtMobNumber.Location = new System.Drawing.Point(192, 113);
            this.txtMobNumber.Name = "txtMobNumber";
            this.txtMobNumber.Size = new System.Drawing.Size(250, 31);
            this.txtMobNumber.TabIndex = 28;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(192, 172);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(250, 31);
            this.txtTelNo.TabIndex = 29;
            // 
            // cmbSim
            // 
            this.cmbSim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSim.FormattingEnabled = true;
            this.cmbSim.Items.AddRange(new object[] {
            "Smart",
            "Sun",
            "Globe",
            "Tm"});
            this.cmbSim.Location = new System.Drawing.Point(483, 113);
            this.cmbSim.Name = "cmbSim";
            this.cmbSim.Size = new System.Drawing.Size(121, 25);
            this.cmbSim.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(413, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "Type of contact:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type of call:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Smart",
            "Sun",
            "Globe",
            "Tm"});
            this.comboBox1.Location = new System.Drawing.Point(150, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSim);
            this.groupBox1.Controls.Add(this.txtTelNo);
            this.groupBox1.Controls.Add(this.txtMobNumber);
            this.groupBox1.Controls.Add(this.rbTelNumber);
            this.groupBox1.Controls.Add(this.rbMobileNumber);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 297);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Call";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // callLogAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "callLogAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "callLogAddFrm";
            this.Load += new System.EventHandler(this.callLogAddFrm_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox hidePb;
        private System.Windows.Forms.PictureBox closePb;
        private System.Windows.Forms.RadioButton rbMobileNumber;
        private System.Windows.Forms.TextBox txtMobNumber;
        private System.Windows.Forms.RadioButton rbTelNumber;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.ComboBox cmbSim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}