namespace KeanGabriel_RMS_SMS.Forms
{
    partial class callLogsFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(callLogsFrm));
            this.border = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hidePb = new System.Windows.Forms.PictureBox();
            this.closePb = new System.Windows.Forms.PictureBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numOfCallsDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfcallsMnth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCalls = new System.Windows.Forms.TextBox();
            this.callLogsdgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.numRowstb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.curDTlbl = new System.Windows.Forms.Label();
            this.curTime = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.grpInsertCall = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCall = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbCont = new System.Windows.Forms.ComboBox();
            this.txtMobNum = new System.Windows.Forms.TextBox();
            this.txtTelNum = new System.Windows.Forms.TextBox();
            this.rbTelNum = new System.Windows.Forms.RadioButton();
            this.rbMobNum = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callLogsdgv)).BeginInit();
            this.grpInsertCall.SuspendLayout();
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
            this.border.Location = new System.Drawing.Point(1, 2);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(864, 38);
            this.border.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "- Call Logs";
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
            this.label4.Text = "C";
            // 
            // hidePb
            // 
            this.hidePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.hideCirc;
            this.hidePb.Location = new System.Drawing.Point(807, 6);
            this.hidePb.Name = "hidePb";
            this.hidePb.Size = new System.Drawing.Size(20, 20);
            this.hidePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePb.TabIndex = 1;
            this.hidePb.TabStop = false;
            this.hidePb.Click += new System.EventHandler(this.hidePb_Click);
            // 
            // closePb
            // 
            this.closePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.closeCirc;
            this.closePb.Location = new System.Drawing.Point(833, 6);
            this.closePb.Name = "closePb";
            this.closePb.Size = new System.Drawing.Size(20, 20);
            this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePb.TabIndex = 0;
            this.closePb.TabStop = false;
            this.closePb.Click += new System.EventHandler(this.closePb_Click);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.BackColor = System.Drawing.Color.White;
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterBy.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "(Filter By)",
            "All",
            "Smart Contact Numbers",
            "Globe Contact Numbers",
            "Sun Contact Numbers",
            "TM Contact Numbers",
            "Prank Calls",
            "Valid Calls"});
            this.cmbFilterBy.Location = new System.Drawing.Point(12, 525);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(234, 24);
            this.cmbFilterBy.TabIndex = 3;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numOfCallsDay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numOfcallsMnth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalCalls);
            this.panel1.Location = new System.Drawing.Point(588, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 475);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(61, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Data feed";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-4, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Number of calls this month:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numOfCallsDay
            // 
            this.numOfCallsDay.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfCallsDay.Location = new System.Drawing.Point(172, 83);
            this.numOfCallsDay.Name = "numOfCallsDay";
            this.numOfCallsDay.ReadOnly = true;
            this.numOfCallsDay.Size = new System.Drawing.Size(56, 21);
            this.numOfCallsDay.TabIndex = 25;
            this.numOfCallsDay.Text = "10";
            this.numOfCallsDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Number of calls this day:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numOfcallsMnth
            // 
            this.numOfcallsMnth.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfcallsMnth.Location = new System.Drawing.Point(183, 115);
            this.numOfcallsMnth.Name = "numOfcallsMnth";
            this.numOfcallsMnth.ReadOnly = true;
            this.numOfcallsMnth.Size = new System.Drawing.Size(56, 21);
            this.numOfcallsMnth.TabIndex = 23;
            this.numOfcallsMnth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Calls:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCalls
            // 
            this.totalCalls.BackColor = System.Drawing.SystemColors.Control;
            this.totalCalls.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCalls.Location = new System.Drawing.Point(92, 53);
            this.totalCalls.Name = "totalCalls";
            this.totalCalls.ReadOnly = true;
            this.totalCalls.Size = new System.Drawing.Size(56, 21);
            this.totalCalls.TabIndex = 21;
            this.totalCalls.Text = "0";
            this.totalCalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // callLogsdgv
            // 
            this.callLogsdgv.AllowUserToAddRows = false;
            this.callLogsdgv.AllowUserToDeleteRows = false;
            this.callLogsdgv.AllowUserToResizeColumns = false;
            this.callLogsdgv.AllowUserToResizeRows = false;
            this.callLogsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.callLogsdgv.BackgroundColor = System.Drawing.Color.Silver;
            this.callLogsdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.callLogsdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.callLogsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.callLogsdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.callLogsdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.callLogsdgv.GridColor = System.Drawing.Color.Blue;
            this.callLogsdgv.Location = new System.Drawing.Point(12, 344);
            this.callLogsdgv.Name = "callLogsdgv";
            this.callLogsdgv.RowHeadersVisible = false;
            this.callLogsdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.callLogsdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.callLogsdgv.Size = new System.Drawing.Size(570, 175);
            this.callLogsdgv.TabIndex = 11;
            this.callLogsdgv.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.callLogsdgv_RowStateChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(266, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchBoxTxt
            // 
            this.searchBoxTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxTxt.Location = new System.Drawing.Point(374, 315);
            this.searchBoxTxt.Name = "searchBoxTxt";
            this.searchBoxTxt.Size = new System.Drawing.Size(172, 21);
            this.searchBoxTxt.TabIndex = 19;
            this.searchBoxTxt.TextChanged += new System.EventHandler(this.searchBoxTxt_TextChanged);
            // 
            // numRowstb
            // 
            this.numRowstb.BackColor = System.Drawing.Color.White;
            this.numRowstb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRowstb.Location = new System.Drawing.Point(374, 527);
            this.numRowstb.Name = "numRowstb";
            this.numRowstb.ReadOnly = true;
            this.numRowstb.Size = new System.Drawing.Size(43, 21);
            this.numRowstb.TabIndex = 27;
            this.numRowstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(273, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Row Count:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add a call";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // curDTlbl
            // 
            this.curDTlbl.BackColor = System.Drawing.Color.Transparent;
            this.curDTlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curDTlbl.ForeColor = System.Drawing.Color.Black;
            this.curDTlbl.Location = new System.Drawing.Point(145, 49);
            this.curDTlbl.Name = "curDTlbl";
            this.curDTlbl.Size = new System.Drawing.Size(135, 25);
            this.curDTlbl.TabIndex = 33;
            this.curDTlbl.Text = "00:00:00";
            this.curDTlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curTime
            // 
            this.curTime.Enabled = true;
            this.curTime.Interval = 1000;
            this.curTime.Tick += new System.EventHandler(this.curTime_Tick);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Current Date && Time: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInsertCall
            // 
            this.grpInsertCall.Controls.Add(this.label12);
            this.grpInsertCall.Controls.Add(this.label11);
            this.grpInsertCall.Controls.Add(this.cmbCall);
            this.grpInsertCall.Controls.Add(this.btnSubmit);
            this.grpInsertCall.Controls.Add(this.cmbCont);
            this.grpInsertCall.Controls.Add(this.txtMobNum);
            this.grpInsertCall.Controls.Add(this.txtTelNum);
            this.grpInsertCall.Controls.Add(this.rbTelNum);
            this.grpInsertCall.Controls.Add(this.rbMobNum);
            this.grpInsertCall.Location = new System.Drawing.Point(13, 117);
            this.grpInsertCall.Name = "grpInsertCall";
            this.grpInsertCall.Size = new System.Drawing.Size(561, 159);
            this.grpInsertCall.TabIndex = 34;
            this.grpInsertCall.TabStop = false;
            this.grpInsertCall.Visible = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(381, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 28);
            this.label12.TabIndex = 37;
            this.label12.Text = "Type of contacts:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 28);
            this.label11.TabIndex = 35;
            this.label11.Text = "Type of calls:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCall
            // 
            this.cmbCall.FormattingEnabled = true;
            this.cmbCall.Items.AddRange(new object[] {
            "VALID",
            "PRANK"});
            this.cmbCall.Location = new System.Drawing.Point(22, 37);
            this.cmbCall.Name = "cmbCall";
            this.cmbCall.Size = new System.Drawing.Size(121, 21);
            this.cmbCall.TabIndex = 36;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(406, 110);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 41);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbCont
            // 
            this.cmbCont.FormattingEnabled = true;
            this.cmbCont.Items.AddRange(new object[] {
            "SMART",
            "SUN",
            "GLOBE",
            "TM"});
            this.cmbCont.Location = new System.Drawing.Point(406, 83);
            this.cmbCont.Name = "cmbCont";
            this.cmbCont.Size = new System.Drawing.Size(121, 21);
            this.cmbCont.TabIndex = 5;
            // 
            // txtMobNum
            // 
            this.txtMobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobNum.Location = new System.Drawing.Point(174, 82);
            this.txtMobNum.Multiline = true;
            this.txtMobNum.Name = "txtMobNum";
            this.txtMobNum.Size = new System.Drawing.Size(195, 29);
            this.txtMobNum.TabIndex = 4;
            this.txtMobNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobNum_KeyPress);
            // 
            // txtTelNum
            // 
            this.txtTelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNum.Location = new System.Drawing.Point(174, 122);
            this.txtTelNum.Multiline = true;
            this.txtTelNum.Name = "txtTelNum";
            this.txtTelNum.Size = new System.Drawing.Size(195, 29);
            this.txtTelNum.TabIndex = 3;
            this.txtTelNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelNum_KeyPress);
            // 
            // rbTelNum
            // 
            this.rbTelNum.AutoSize = true;
            this.rbTelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTelNum.Location = new System.Drawing.Point(29, 131);
            this.rbTelNum.Name = "rbTelNum";
            this.rbTelNum.Size = new System.Drawing.Size(136, 19);
            this.rbTelNum.TabIndex = 1;
            this.rbTelNum.TabStop = true;
            this.rbTelNum.Text = "Tel Number       : ";
            this.rbTelNum.UseVisualStyleBackColor = true;
            this.rbTelNum.CheckedChanged += new System.EventHandler(this.rbTelNum_CheckedChanged);
            // 
            // rbMobNum
            // 
            this.rbMobNum.AutoSize = true;
            this.rbMobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMobNum.Location = new System.Drawing.Point(29, 92);
            this.rbMobNum.Name = "rbMobNum";
            this.rbMobNum.Size = new System.Drawing.Size(132, 19);
            this.rbMobNum.TabIndex = 0;
            this.rbMobNum.TabStop = true;
            this.rbMobNum.Text = "Mobile Number: ";
            this.rbMobNum.UseVisualStyleBackColor = true;
            this.rbMobNum.CheckedChanged += new System.EventHandler(this.rbMobNum_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-3, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 3);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-2, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 3);
            this.panel3.TabIndex = 36;
            // 
            // cmbCat
            // 
            this.cmbCat.BackColor = System.Drawing.Color.White;
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "Mobile Number",
            "Tel Number"});
            this.cmbCat.Location = new System.Drawing.Point(76, 314);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(181, 24);
            this.cmbCat.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(-30, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 38;
            this.label8.Text = "Filter by:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // callLogsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.grpInsertCall);
            this.Controls.Add(this.curDTlbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numRowstb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBoxTxt);
            this.Controls.Add(this.callLogsdgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.border);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "callLogsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "callLogsFrm";
            this.Load += new System.EventHandler(this.callLogsFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.callLogsFrm_Paint);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callLogsdgv)).EndInit();
            this.grpInsertCall.ResumeLayout(false);
            this.grpInsertCall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox hidePb;
        private System.Windows.Forms.PictureBox closePb;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView callLogsdgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numOfCallsDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numOfcallsMnth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalCalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.TextBox numRowstb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label curDTlbl;
        private System.Windows.Forms.Timer curTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpInsertCall;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbCont;
        private System.Windows.Forms.TextBox txtMobNum;
        private System.Windows.Forms.TextBox txtTelNum;
        private System.Windows.Forms.RadioButton rbTelNum;
        private System.Windows.Forms.RadioButton rbMobNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label8;
    }
}