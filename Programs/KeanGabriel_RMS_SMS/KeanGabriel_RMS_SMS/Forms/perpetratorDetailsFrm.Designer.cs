namespace KeanGabriel_RMS_SMS.Forms
{
    partial class perpetratorDetailsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perpetratorDetailsFrm));
            this.border = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.fullNametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOfBirthtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genderTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nicknameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.occupationtb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contactNumbertb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.presentedIDtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addedOntb = new System.Windows.Forms.Label();
            this.underInfluenceOftb = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.prevCrimRectb = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.prevCaseStattb = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.remarksTb = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.printbt = new System.Windows.Forms.Button();
            this.ppDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pDoc = new System.Drawing.Printing.PrintDocument();
            this.border.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Controls.Add(this.label11);
            this.border.Controls.Add(this.btClose);
            this.border.Location = new System.Drawing.Point(1, 2);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(501, 52);
            this.border.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Perpetrator Details";
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(439, 15);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(51, 19);
            this.btClose.TabIndex = 32;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            this.btClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btClose_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Perpetrator ID:";
            // 
            // idtb
            // 
            this.idtb.BackColor = System.Drawing.Color.White;
            this.idtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtb.Location = new System.Drawing.Point(24, 104);
            this.idtb.Name = "idtb";
            this.idtb.ReadOnly = true;
            this.idtb.Size = new System.Drawing.Size(207, 27);
            this.idtb.TabIndex = 20;
            // 
            // fullNametb
            // 
            this.fullNametb.BackColor = System.Drawing.Color.White;
            this.fullNametb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNametb.Location = new System.Drawing.Point(24, 194);
            this.fullNametb.Name = "fullNametb";
            this.fullNametb.ReadOnly = true;
            this.fullNametb.Size = new System.Drawing.Size(321, 27);
            this.fullNametb.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Full Name(Last name, First name, Middle Name):";
            // 
            // agetb
            // 
            this.agetb.BackColor = System.Drawing.Color.White;
            this.agetb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetb.Location = new System.Drawing.Point(24, 258);
            this.agetb.Name = "agetb";
            this.agetb.ReadOnly = true;
            this.agetb.Size = new System.Drawing.Size(76, 26);
            this.agetb.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Age:";
            // 
            // dateOfBirthtb
            // 
            this.dateOfBirthtb.BackColor = System.Drawing.Color.White;
            this.dateOfBirthtb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthtb.Location = new System.Drawing.Point(24, 328);
            this.dateOfBirthtb.Name = "dateOfBirthtb";
            this.dateOfBirthtb.ReadOnly = true;
            this.dateOfBirthtb.Size = new System.Drawing.Size(207, 26);
            this.dateOfBirthtb.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date of Birth: ";
            // 
            // genderTb
            // 
            this.genderTb.BackColor = System.Drawing.Color.White;
            this.genderTb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTb.Location = new System.Drawing.Point(134, 258);
            this.genderTb.Name = "genderTb";
            this.genderTb.ReadOnly = true;
            this.genderTb.Size = new System.Drawing.Size(97, 26);
            this.genderTb.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Gender: ";
            // 
            // nicknameTB
            // 
            this.nicknameTB.BackColor = System.Drawing.Color.White;
            this.nicknameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameTB.Location = new System.Drawing.Point(24, 392);
            this.nicknameTB.Name = "nicknameTB";
            this.nicknameTB.ReadOnly = true;
            this.nicknameTB.Size = new System.Drawing.Size(207, 26);
            this.nicknameTB.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nick name:";
            // 
            // occupationtb
            // 
            this.occupationtb.BackColor = System.Drawing.Color.White;
            this.occupationtb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationtb.Location = new System.Drawing.Point(273, 392);
            this.occupationtb.Name = "occupationtb";
            this.occupationtb.ReadOnly = true;
            this.occupationtb.Size = new System.Drawing.Size(207, 26);
            this.occupationtb.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Occupation:";
            // 
            // contactNumbertb
            // 
            this.contactNumbertb.BackColor = System.Drawing.Color.White;
            this.contactNumbertb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumbertb.Location = new System.Drawing.Point(273, 258);
            this.contactNumbertb.Name = "contactNumbertb";
            this.contactNumbertb.ReadOnly = true;
            this.contactNumbertb.Size = new System.Drawing.Size(207, 26);
            this.contactNumbertb.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Contact Number: ";
            // 
            // presentedIDtb
            // 
            this.presentedIDtb.BackColor = System.Drawing.Color.White;
            this.presentedIDtb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentedIDtb.Location = new System.Drawing.Point(273, 328);
            this.presentedIDtb.Name = "presentedIDtb";
            this.presentedIDtb.ReadOnly = true;
            this.presentedIDtb.Size = new System.Drawing.Size(207, 26);
            this.presentedIDtb.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Presented ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Under Influence of:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addedOntb);
            this.panel1.Location = new System.Drawing.Point(280, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 55);
            this.panel1.TabIndex = 39;
            // 
            // addedOntb
            // 
            this.addedOntb.AutoSize = true;
            this.addedOntb.Location = new System.Drawing.Point(10, 20);
            this.addedOntb.Name = "addedOntb";
            this.addedOntb.Size = new System.Drawing.Size(41, 13);
            this.addedOntb.TabIndex = 0;
            this.addedOntb.Text = "label11";
            // 
            // underInfluenceOftb
            // 
            this.underInfluenceOftb.BackColor = System.Drawing.Color.White;
            this.underInfluenceOftb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underInfluenceOftb.Location = new System.Drawing.Point(24, 466);
            this.underInfluenceOftb.Name = "underInfluenceOftb";
            this.underInfluenceOftb.ReadOnly = true;
            this.underInfluenceOftb.Size = new System.Drawing.Size(207, 56);
            this.underInfluenceOftb.TabIndex = 40;
            this.underInfluenceOftb.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(339, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Added on";
            // 
            // prevCrimRectb
            // 
            this.prevCrimRectb.BackColor = System.Drawing.Color.White;
            this.prevCrimRectb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevCrimRectb.Location = new System.Drawing.Point(273, 466);
            this.prevCrimRectb.Name = "prevCrimRectb";
            this.prevCrimRectb.ReadOnly = true;
            this.prevCrimRectb.Size = new System.Drawing.Size(207, 56);
            this.prevCrimRectb.TabIndex = 43;
            this.prevCrimRectb.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(270, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Previous Criminal Record:";
            // 
            // prevCaseStattb
            // 
            this.prevCaseStattb.BackColor = System.Drawing.Color.White;
            this.prevCaseStattb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevCaseStattb.Location = new System.Drawing.Point(24, 565);
            this.prevCaseStattb.Name = "prevCaseStattb";
            this.prevCaseStattb.ReadOnly = true;
            this.prevCaseStattb.Size = new System.Drawing.Size(207, 56);
            this.prevCaseStattb.TabIndex = 45;
            this.prevCaseStattb.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 541);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Previous Case Status:";
            // 
            // remarksTb
            // 
            this.remarksTb.BackColor = System.Drawing.Color.White;
            this.remarksTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksTb.Location = new System.Drawing.Point(273, 565);
            this.remarksTb.Name = "remarksTb";
            this.remarksTb.ReadOnly = true;
            this.remarksTb.Size = new System.Drawing.Size(207, 56);
            this.remarksTb.TabIndex = 47;
            this.remarksTb.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(270, 541);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 46;
            this.label15.Text = "Remarks:";
            // 
            // printbt
            // 
            this.printbt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbt.Location = new System.Drawing.Point(172, 653);
            this.printbt.Name = "printbt";
            this.printbt.Size = new System.Drawing.Size(160, 36);
            this.printbt.TabIndex = 48;
            this.printbt.Text = "Print";
            this.printbt.UseVisualStyleBackColor = true;
            this.printbt.Click += new System.EventHandler(this.printbt_Click);
            // 
            // ppDialog
            // 
            this.ppDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDialog.Enabled = true;
            this.ppDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDialog.Icon")));
            this.ppDialog.Name = "ppDialog";
            this.ppDialog.ShowIcon = false;
            this.ppDialog.Visible = false;
            // 
            // pDoc
            // 
            this.pDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDoc_PrintPage);
            // 
            // perpetratorDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 701);
            this.Controls.Add(this.printbt);
            this.Controls.Add(this.remarksTb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.prevCaseStattb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.prevCrimRectb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.underInfluenceOftb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.presentedIDtb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.contactNumbertb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.occupationtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nicknameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genderTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirthtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agetb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullNametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "perpetratorDetailsFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.perpetratorDetailsFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.perpetratorDetailsFrm_Paint);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Label btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.TextBox fullNametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox agetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateOfBirthtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genderTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nicknameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox occupationtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contactNumbertb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox presentedIDtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addedOntb;
        private System.Windows.Forms.RichTextBox underInfluenceOftb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox prevCrimRectb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox prevCaseStattb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox remarksTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button printbt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PrintPreviewDialog ppDialog;
        private System.Drawing.Printing.PrintDocument pDoc;
    }
}