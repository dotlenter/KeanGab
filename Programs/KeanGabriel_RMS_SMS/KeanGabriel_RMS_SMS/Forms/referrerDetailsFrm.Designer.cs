namespace KeanGabriel_RMS_SMS
{
    partial class referrerDetailsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(referrerDetailsFrm));
            this.border = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addedOntb = new System.Windows.Forms.Label();
            this.presentedIDtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contactNumbertb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.occupationtb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nicknameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genderTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOfBirthtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.currentAddresstb = new System.Windows.Forms.RichTextBox();
            this.remarkstb = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.referrerTypetb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.homePhoneNumbertb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mobileNumbertb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.citizenshiptb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.border.Location = new System.Drawing.Point(2, 2);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(760, 52);
            this.border.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Referrer Details";
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(697, 13);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(51, 19);
            this.btClose.TabIndex = 32;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            this.btClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btClose_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(581, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 69;
            this.label12.Text = "Added on";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addedOntb);
            this.panel1.Location = new System.Drawing.Point(522, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 55);
            this.panel1.TabIndex = 67;
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
            // presentedIDtb
            // 
            this.presentedIDtb.BackColor = System.Drawing.Color.White;
            this.presentedIDtb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentedIDtb.Location = new System.Drawing.Point(269, 245);
            this.presentedIDtb.Name = "presentedIDtb";
            this.presentedIDtb.ReadOnly = true;
            this.presentedIDtb.Size = new System.Drawing.Size(207, 26);
            this.presentedIDtb.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(265, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Presented ID:";
            // 
            // contactNumbertb
            // 
            this.contactNumbertb.BackColor = System.Drawing.Color.White;
            this.contactNumbertb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumbertb.Location = new System.Drawing.Point(514, 379);
            this.contactNumbertb.Name = "contactNumbertb";
            this.contactNumbertb.ReadOnly = true;
            this.contactNumbertb.Size = new System.Drawing.Size(207, 26);
            this.contactNumbertb.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Contact Number: ";
            // 
            // occupationtb
            // 
            this.occupationtb.BackColor = System.Drawing.Color.White;
            this.occupationtb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationtb.Location = new System.Drawing.Point(269, 315);
            this.occupationtb.Name = "occupationtb";
            this.occupationtb.ReadOnly = true;
            this.occupationtb.Size = new System.Drawing.Size(207, 26);
            this.occupationtb.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Occupation:";
            // 
            // nicknameTB
            // 
            this.nicknameTB.BackColor = System.Drawing.Color.White;
            this.nicknameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameTB.Location = new System.Drawing.Point(23, 379);
            this.nicknameTB.Name = "nicknameTB";
            this.nicknameTB.ReadOnly = true;
            this.nicknameTB.Size = new System.Drawing.Size(207, 26);
            this.nicknameTB.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nick name:";
            // 
            // genderTb
            // 
            this.genderTb.BackColor = System.Drawing.Color.White;
            this.genderTb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTb.Location = new System.Drawing.Point(133, 245);
            this.genderTb.Name = "genderTb";
            this.genderTb.ReadOnly = true;
            this.genderTb.Size = new System.Drawing.Size(97, 26);
            this.genderTb.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Gender: ";
            // 
            // dateOfBirthtb
            // 
            this.dateOfBirthtb.BackColor = System.Drawing.Color.White;
            this.dateOfBirthtb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthtb.Location = new System.Drawing.Point(23, 315);
            this.dateOfBirthtb.Name = "dateOfBirthtb";
            this.dateOfBirthtb.ReadOnly = true;
            this.dateOfBirthtb.Size = new System.Drawing.Size(207, 26);
            this.dateOfBirthtb.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Date of Birth: ";
            // 
            // agetb
            // 
            this.agetb.BackColor = System.Drawing.Color.White;
            this.agetb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetb.Location = new System.Drawing.Point(23, 245);
            this.agetb.Name = "agetb";
            this.agetb.ReadOnly = true;
            this.agetb.Size = new System.Drawing.Size(76, 26);
            this.agetb.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Age:";
            // 
            // fullNametb
            // 
            this.fullNametb.BackColor = System.Drawing.Color.White;
            this.fullNametb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNametb.Location = new System.Drawing.Point(23, 181);
            this.fullNametb.Name = "fullNametb";
            this.fullNametb.ReadOnly = true;
            this.fullNametb.Size = new System.Drawing.Size(321, 27);
            this.fullNametb.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Full Name(Last name, First name, Middle Name):";
            // 
            // idtb
            // 
            this.idtb.BackColor = System.Drawing.Color.White;
            this.idtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtb.Location = new System.Drawing.Point(23, 91);
            this.idtb.Name = "idtb";
            this.idtb.ReadOnly = true;
            this.idtb.Size = new System.Drawing.Size(207, 27);
            this.idtb.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Person Reporting ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Current Address:";
            // 
            // currentAddresstb
            // 
            this.currentAddresstb.BackColor = System.Drawing.Color.White;
            this.currentAddresstb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAddresstb.Location = new System.Drawing.Point(269, 460);
            this.currentAddresstb.Name = "currentAddresstb";
            this.currentAddresstb.ReadOnly = true;
            this.currentAddresstb.Size = new System.Drawing.Size(207, 56);
            this.currentAddresstb.TabIndex = 68;
            this.currentAddresstb.Text = "";
            // 
            // remarkstb
            // 
            this.remarkstb.BackColor = System.Drawing.Color.White;
            this.remarkstb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarkstb.Location = new System.Drawing.Point(514, 460);
            this.remarkstb.Name = "remarkstb";
            this.remarkstb.ReadOnly = true;
            this.remarkstb.Size = new System.Drawing.Size(207, 56);
            this.remarkstb.TabIndex = 71;
            this.remarkstb.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(511, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "Remarks:";
            // 
            // referrerTypetb
            // 
            this.referrerTypetb.BackColor = System.Drawing.Color.White;
            this.referrerTypetb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referrerTypetb.Location = new System.Drawing.Point(269, 379);
            this.referrerTypetb.Name = "referrerTypetb";
            this.referrerTypetb.ReadOnly = true;
            this.referrerTypetb.Size = new System.Drawing.Size(207, 26);
            this.referrerTypetb.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(266, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 72;
            this.label15.Text = "Referrer Type:";
            // 
            // homePhoneNumbertb
            // 
            this.homePhoneNumbertb.BackColor = System.Drawing.Color.White;
            this.homePhoneNumbertb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePhoneNumbertb.Location = new System.Drawing.Point(514, 315);
            this.homePhoneNumbertb.Name = "homePhoneNumbertb";
            this.homePhoneNumbertb.ReadOnly = true;
            this.homePhoneNumbertb.Size = new System.Drawing.Size(207, 26);
            this.homePhoneNumbertb.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(511, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 16);
            this.label14.TabIndex = 74;
            this.label14.Text = "Home Phone Number:";
            // 
            // mobileNumbertb
            // 
            this.mobileNumbertb.BackColor = System.Drawing.Color.White;
            this.mobileNumbertb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumbertb.Location = new System.Drawing.Point(514, 245);
            this.mobileNumbertb.Name = "mobileNumbertb";
            this.mobileNumbertb.ReadOnly = true;
            this.mobileNumbertb.Size = new System.Drawing.Size(207, 26);
            this.mobileNumbertb.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(511, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 76;
            this.label16.Text = "Mobile Number:";
            // 
            // citizenshiptb
            // 
            this.citizenshiptb.BackColor = System.Drawing.Color.White;
            this.citizenshiptb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenshiptb.Location = new System.Drawing.Point(23, 458);
            this.citizenshiptb.Name = "citizenshiptb";
            this.citizenshiptb.ReadOnly = true;
            this.citizenshiptb.Size = new System.Drawing.Size(207, 26);
            this.citizenshiptb.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 439);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 78;
            this.label17.Text = "Citizenship:";
            // 
            // printbt
            // 
            this.printbt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbt.Location = new System.Drawing.Point(294, 543);
            this.printbt.Name = "printbt";
            this.printbt.Size = new System.Drawing.Size(160, 36);
            this.printbt.TabIndex = 80;
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
            // referrerDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 597);
            this.Controls.Add(this.printbt);
            this.Controls.Add(this.citizenshiptb);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.mobileNumbertb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.homePhoneNumbertb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.referrerTypetb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.remarkstb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.currentAddresstb);
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
            this.Name = "referrerDetailsFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "referrerDetailsFrm";
            this.Load += new System.EventHandler(this.referrerDetailsFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.referrerDetailsFrm_Paint);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addedOntb;
        private System.Windows.Forms.TextBox presentedIDtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox contactNumbertb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox occupationtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nicknameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox genderTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateOfBirthtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox agetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullNametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox currentAddresstb;
        private System.Windows.Forms.RichTextBox remarkstb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox referrerTypetb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox homePhoneNumbertb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox mobileNumbertb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox citizenshiptb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button printbt;
        private System.Windows.Forms.PrintPreviewDialog ppDialog;
        private System.Drawing.Printing.PrintDocument pDoc;
    }
}