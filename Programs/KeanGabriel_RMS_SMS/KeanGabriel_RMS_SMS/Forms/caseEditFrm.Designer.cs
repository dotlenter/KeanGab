namespace KeanGabriel_RMS_SMS.Forms
{
    partial class caseEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caseEditFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.addedOnlbl = new System.Windows.Forms.Label();
            this.updatebt = new System.Windows.Forms.Button();
            this.Cancelbt = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.entryNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDTR = new System.Windows.Forms.DateTimePicker();
            this.caseStatcmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toiRch = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.poiRch = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDTI = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.findRefbt = new System.Windows.Forms.Button();
            this.addRefbt = new System.Windows.Forms.Button();
            this.referrerIDtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.findPerpetbt = new System.Windows.Forms.Button();
            this.addPerpetbt = new System.Windows.Forms.Button();
            this.perpetratorIDtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.victimIDtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.caseNumtb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Case No:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.updatebt);
            this.panel1.Controls.Add(this.Cancelbt);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 560);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(379, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Case Added on";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.addedOnlbl);
            this.panel7.Location = new System.Drawing.Point(335, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(187, 62);
            this.panel7.TabIndex = 15;
            // 
            // addedOnlbl
            // 
            this.addedOnlbl.Location = new System.Drawing.Point(6, 15);
            this.addedOnlbl.Name = "addedOnlbl";
            this.addedOnlbl.Size = new System.Drawing.Size(174, 34);
            this.addedOnlbl.TabIndex = 3;
            this.addedOnlbl.Text = "09/07/17";
            this.addedOnlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatebt
            // 
            this.updatebt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebt.Location = new System.Drawing.Point(340, 513);
            this.updatebt.Name = "updatebt";
            this.updatebt.Size = new System.Drawing.Size(118, 39);
            this.updatebt.TabIndex = 14;
            this.updatebt.Text = "Edit Case";
            this.updatebt.UseVisualStyleBackColor = true;
            this.updatebt.Click += new System.EventHandler(this.updatebt_Click);
            // 
            // Cancelbt
            // 
            this.Cancelbt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbt.Location = new System.Drawing.Point(216, 513);
            this.Cancelbt.Name = "Cancelbt";
            this.Cancelbt.Size = new System.Drawing.Size(118, 39);
            this.Cancelbt.TabIndex = 13;
            this.Cancelbt.Text = "Cancel";
            this.Cancelbt.UseVisualStyleBackColor = true;
            this.Cancelbt.Click += new System.EventHandler(this.Cancelbt_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.entryNum);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.dtpDTR);
            this.panel6.Controls.Add(this.caseStatcmb);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.toiRch);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.poiRch);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.dtpDTI);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(11, 202);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(649, 286);
            this.panel6.TabIndex = 12;
            // 
            // entryNum
            // 
            this.entryNum.BackColor = System.Drawing.Color.White;
            this.entryNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryNum.Location = new System.Drawing.Point(328, 223);
            this.entryNum.Name = "entryNum";
            this.entryNum.ReadOnly = true;
            this.entryNum.Size = new System.Drawing.Size(154, 23);
            this.entryNum.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(325, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Entry Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Date and time Reported:";
            // 
            // dtpDTR
            // 
            this.dtpDTR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDTR.Location = new System.Drawing.Point(26, 223);
            this.dtpDTR.Name = "dtpDTR";
            this.dtpDTR.Size = new System.Drawing.Size(249, 23);
            this.dtpDTR.TabIndex = 18;
            // 
            // caseStatcmb
            // 
            this.caseStatcmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseStatcmb.FormattingEnabled = true;
            this.caseStatcmb.Location = new System.Drawing.Point(330, 51);
            this.caseStatcmb.Name = "caseStatcmb";
            this.caseStatcmb.Size = new System.Drawing.Size(164, 25);
            this.caseStatcmb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Case status:";
            // 
            // toiRch
            // 
            this.toiRch.Location = new System.Drawing.Point(26, 122);
            this.toiRch.Name = "toiRch";
            this.toiRch.Size = new System.Drawing.Size(272, 62);
            this.toiRch.TabIndex = 14;
            this.toiRch.Text = "";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type of Incident:";
            // 
            // poiRch
            // 
            this.poiRch.Location = new System.Drawing.Point(330, 122);
            this.poiRch.Name = "poiRch";
            this.poiRch.Size = new System.Drawing.Size(272, 62);
            this.poiRch.TabIndex = 12;
            this.poiRch.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Place of Incident:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date and time of incident:";
            // 
            // dtpDTI
            // 
            this.dtpDTI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDTI.Location = new System.Drawing.Point(25, 53);
            this.dtpDTI.Name = "dtpDTI";
            this.dtpDTI.Size = new System.Drawing.Size(249, 23);
            this.dtpDTI.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "(Separate by comma.)";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.findRefbt);
            this.panel5.Controls.Add(this.addRefbt);
            this.panel5.Controls.Add(this.referrerIDtb);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(422, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(181, 90);
            this.panel5.TabIndex = 11;
            // 
            // findRefbt
            // 
            this.findRefbt.Location = new System.Drawing.Point(111, 60);
            this.findRefbt.Name = "findRefbt";
            this.findRefbt.Size = new System.Drawing.Size(60, 23);
            this.findRefbt.TabIndex = 9;
            this.findRefbt.Text = "Find";
            this.findRefbt.UseVisualStyleBackColor = true;
            this.findRefbt.Click += new System.EventHandler(this.findRefbt_Click);
            // 
            // addRefbt
            // 
            this.addRefbt.Enabled = false;
            this.addRefbt.Location = new System.Drawing.Point(59, 60);
            this.addRefbt.Name = "addRefbt";
            this.addRefbt.Size = new System.Drawing.Size(48, 23);
            this.addRefbt.TabIndex = 8;
            this.addRefbt.Text = "Add";
            this.addRefbt.UseVisualStyleBackColor = true;
            this.addRefbt.Click += new System.EventHandler(this.addRefbt_Click);
            // 
            // referrerIDtb
            // 
            this.referrerIDtb.BackColor = System.Drawing.Color.White;
            this.referrerIDtb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referrerIDtb.Location = new System.Drawing.Point(17, 32);
            this.referrerIDtb.Name = "referrerIDtb";
            this.referrerIDtb.ReadOnly = true;
            this.referrerIDtb.Size = new System.Drawing.Size(154, 23);
            this.referrerIDtb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Referrer ID:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.findPerpetbt);
            this.panel4.Controls.Add(this.addPerpetbt);
            this.panel4.Controls.Add(this.perpetratorIDtb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(220, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 90);
            this.panel4.TabIndex = 10;
            // 
            // findPerpetbt
            // 
            this.findPerpetbt.Location = new System.Drawing.Point(110, 60);
            this.findPerpetbt.Name = "findPerpetbt";
            this.findPerpetbt.Size = new System.Drawing.Size(60, 23);
            this.findPerpetbt.TabIndex = 7;
            this.findPerpetbt.Text = "Find";
            this.findPerpetbt.UseVisualStyleBackColor = true;
            this.findPerpetbt.Click += new System.EventHandler(this.findPerpetbt_Click);
            // 
            // addPerpetbt
            // 
            this.addPerpetbt.Enabled = false;
            this.addPerpetbt.Location = new System.Drawing.Point(58, 60);
            this.addPerpetbt.Name = "addPerpetbt";
            this.addPerpetbt.Size = new System.Drawing.Size(48, 23);
            this.addPerpetbt.TabIndex = 6;
            this.addPerpetbt.Text = "Add";
            this.addPerpetbt.UseVisualStyleBackColor = true;
            this.addPerpetbt.Click += new System.EventHandler(this.addPerpetbt_Click);
            // 
            // perpetratorIDtb
            // 
            this.perpetratorIDtb.BackColor = System.Drawing.Color.White;
            this.perpetratorIDtb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perpetratorIDtb.Location = new System.Drawing.Point(16, 32);
            this.perpetratorIDtb.Name = "perpetratorIDtb";
            this.perpetratorIDtb.ReadOnly = true;
            this.perpetratorIDtb.Size = new System.Drawing.Size(154, 23);
            this.perpetratorIDtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Perpetrator ID:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.victimIDtb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 70);
            this.panel3.TabIndex = 9;
            // 
            // victimIDtb
            // 
            this.victimIDtb.BackColor = System.Drawing.Color.White;
            this.victimIDtb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victimIDtb.Location = new System.Drawing.Point(15, 33);
            this.victimIDtb.Name = "victimIDtb";
            this.victimIDtb.ReadOnly = true;
            this.victimIDtb.Size = new System.Drawing.Size(154, 23);
            this.victimIDtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Victim ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.caseNumtb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 51);
            this.panel2.TabIndex = 8;
            // 
            // caseNumtb
            // 
            this.caseNumtb.BackColor = System.Drawing.Color.White;
            this.caseNumtb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseNumtb.Location = new System.Drawing.Point(74, 12);
            this.caseNumtb.Name = "caseNumtb";
            this.caseNumtb.ReadOnly = true;
            this.caseNumtb.Size = new System.Drawing.Size(154, 23);
            this.caseNumtb.TabIndex = 1;
            // 
            // caseEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "caseEditFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Case Form";
            this.Load += new System.EventHandler(this.caseEditFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label addedOnlbl;
        private System.Windows.Forms.Button updatebt;
        private System.Windows.Forms.Button Cancelbt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDTR;
        private System.Windows.Forms.ComboBox caseStatcmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox toiRch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox poiRch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDTI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button findRefbt;
        private System.Windows.Forms.Button addRefbt;
        private System.Windows.Forms.TextBox referrerIDtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button findPerpetbt;
        private System.Windows.Forms.Button addPerpetbt;
        private System.Windows.Forms.TextBox perpetratorIDtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox victimIDtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox caseNumtb;
        private System.Windows.Forms.TextBox entryNum;
        private System.Windows.Forms.Label label12;
    }
}