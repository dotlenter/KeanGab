namespace KeanGabriel_RMS_SMS.Forms
{
    partial class victimFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(victimFrm));
            this.border = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.hidePb = new System.Windows.Forms.PictureBox();
            this.closePb = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.victimCountlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewVicbt = new System.Windows.Forms.Label();
            this.curDatelbl = new System.Windows.Forms.Label();
            this.victimDgv = new System.Windows.Forms.DataGridView();
            this.pn1 = new System.Windows.Forms.Panel();
            this.editBt = new System.Windows.Forms.Label();
            this.pn2 = new System.Windows.Forms.Panel();
            this.viewFullDetbt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbSearchVictims = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srchbyCmb = new System.Windows.Forms.ComboBox();
            this.srtbyCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterCmb = new System.Windows.Forms.ComboBox();
            this.rowCounttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvStatlbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.victimDgv)).BeginInit();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.White;
            this.border.Controls.Add(this.label5);
            this.border.Controls.Add(this.panel4);
            this.border.Controls.Add(this.hidePb);
            this.border.Controls.Add(this.closePb);
            this.border.Location = new System.Drawing.Point(1, 1);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(1179, 36);
            this.border.TabIndex = 0;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "- Victims";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 28);
            this.panel4.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "V";
            // 
            // hidePb
            // 
            this.hidePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.hideCirc;
            this.hidePb.Location = new System.Drawing.Point(1125, 7);
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
            this.closePb.Location = new System.Drawing.Point(1151, 7);
            this.closePb.Name = "closePb";
            this.closePb.Size = new System.Drawing.Size(20, 20);
            this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePb.TabIndex = 0;
            this.closePb.TabStop = false;
            this.closePb.Click += new System.EventHandler(this.closePb_Click);
            this.closePb.MouseLeave += new System.EventHandler(this.closePb_MouseLeave);
            this.closePb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closePb_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.victimCountlbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.viewVicbt);
            this.panel2.Controls.Add(this.curDatelbl);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 33);
            this.panel2.TabIndex = 1;
            // 
            // victimCountlbl
            // 
            this.victimCountlbl.BackColor = System.Drawing.Color.Maroon;
            this.victimCountlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victimCountlbl.ForeColor = System.Drawing.Color.White;
            this.victimCountlbl.Location = new System.Drawing.Point(838, 6);
            this.victimCountlbl.Name = "victimCountlbl";
            this.victimCountlbl.Size = new System.Drawing.Size(41, 16);
            this.victimCountlbl.TabIndex = 13;
            this.victimCountlbl.Text = "1";
            this.victimCountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(881, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total recorded Victims as of ";
            // 
            // viewVicbt
            // 
            this.viewVicbt.AutoSize = true;
            this.viewVicbt.BackColor = System.Drawing.Color.Transparent;
            this.viewVicbt.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewVicbt.ForeColor = System.Drawing.Color.White;
            this.viewVicbt.Location = new System.Drawing.Point(14, 7);
            this.viewVicbt.Name = "viewVicbt";
            this.viewVicbt.Size = new System.Drawing.Size(90, 16);
            this.viewVicbt.TabIndex = 10;
            this.viewVicbt.Text = "View Victims";
            this.viewVicbt.Click += new System.EventHandler(this.viewVicbt_Click);
            this.viewVicbt.MouseLeave += new System.EventHandler(this.viewVicbt_MouseLeave);
            this.viewVicbt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewVicbt_MouseMove);
            // 
            // curDatelbl
            // 
            this.curDatelbl.AutoSize = true;
            this.curDatelbl.BackColor = System.Drawing.Color.Transparent;
            this.curDatelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curDatelbl.ForeColor = System.Drawing.Color.White;
            this.curDatelbl.Location = new System.Drawing.Point(1068, 6);
            this.curDatelbl.Name = "curDatelbl";
            this.curDatelbl.Size = new System.Drawing.Size(62, 16);
            this.curDatelbl.TabIndex = 12;
            this.curDatelbl.Text = "1/1/2001";
            // 
            // victimDgv
            // 
            this.victimDgv.AllowUserToAddRows = false;
            this.victimDgv.AllowUserToDeleteRows = false;
            this.victimDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.victimDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.victimDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.victimDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.victimDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.victimDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.victimDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.victimDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.victimDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.victimDgv.GridColor = System.Drawing.Color.Blue;
            this.victimDgv.Location = new System.Drawing.Point(12, 186);
            this.victimDgv.MultiSelect = false;
            this.victimDgv.Name = "victimDgv";
            this.victimDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.victimDgv.RowHeadersVisible = false;
            this.victimDgv.RowTemplate.Height = 44;
            this.victimDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.victimDgv.Size = new System.Drawing.Size(1158, 417);
            this.victimDgv.TabIndex = 2;
            this.victimDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.victimDgv_CellClick);
            this.victimDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.victimDgv_CellDoubleClick);
            this.victimDgv.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.victimDgv_RowStateChanged);
            // 
            // pn1
            // 
            this.pn1.BackgroundImage = global::KeanGabriel_RMS_SMS.Properties.Resources.unHover_Button;
            this.pn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn1.Controls.Add(this.editBt);
            this.pn1.Location = new System.Drawing.Point(12, 135);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(122, 34);
            this.pn1.TabIndex = 3;
            // 
            // editBt
            // 
            this.editBt.BackColor = System.Drawing.Color.Transparent;
            this.editBt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.ForeColor = System.Drawing.Color.White;
            this.editBt.Location = new System.Drawing.Point(3, 3);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(116, 28);
            this.editBt.TabIndex = 6;
            this.editBt.Text = "Edit Data[F1]";
            this.editBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            this.editBt.MouseLeave += new System.EventHandler(this.editBt_MouseLeave);
            this.editBt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editBt_MouseMove);
            // 
            // pn2
            // 
            this.pn2.BackgroundImage = global::KeanGabriel_RMS_SMS.Properties.Resources.unHover_Button;
            this.pn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn2.Controls.Add(this.viewFullDetbt);
            this.pn2.Location = new System.Drawing.Point(140, 135);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(176, 34);
            this.pn2.TabIndex = 4;
            // 
            // viewFullDetbt
            // 
            this.viewFullDetbt.BackColor = System.Drawing.Color.Transparent;
            this.viewFullDetbt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFullDetbt.ForeColor = System.Drawing.Color.White;
            this.viewFullDetbt.Location = new System.Drawing.Point(3, 3);
            this.viewFullDetbt.Name = "viewFullDetbt";
            this.viewFullDetbt.Size = new System.Drawing.Size(170, 28);
            this.viewFullDetbt.TabIndex = 7;
            this.viewFullDetbt.Text = "View Full Details [F2]";
            this.viewFullDetbt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewFullDetbt.Click += new System.EventHandler(this.viewFullDetbt_Click);
            this.viewFullDetbt.MouseLeave += new System.EventHandler(this.viewFullDetbt_MouseLeave);
            this.viewFullDetbt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewFullDetbt_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::KeanGabriel_RMS_SMS.Properties.Resources.Textbox_Rounded;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.tbSearchVictims);
            this.panel5.Location = new System.Drawing.Point(555, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 28);
            this.panel5.TabIndex = 8;
            // 
            // tbSearchVictims
            // 
            this.tbSearchVictims.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchVictims.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchVictims.Location = new System.Drawing.Point(7, 7);
            this.tbSearchVictims.Name = "tbSearchVictims";
            this.tbSearchVictims.Size = new System.Drawing.Size(360, 15);
            this.tbSearchVictims.TabIndex = 0;
            this.tbSearchVictims.TextChanged += new System.EventHandler(this.tbSearchVictims_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(471, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // srchbyCmb
            // 
            this.srchbyCmb.DropDownHeight = 80;
            this.srchbyCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srchbyCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchbyCmb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbyCmb.FormattingEnabled = true;
            this.srchbyCmb.IntegralHeight = false;
            this.srchbyCmb.Items.AddRange(new object[] {
            "(Search by)",
            "Last Name",
            "First Name",
            "Middle Name",
            "Nick Name",
            "Current Address",
            "Default(Last Name, First Name, and Middle Name)"});
            this.srchbyCmb.Location = new System.Drawing.Point(938, 142);
            this.srchbyCmb.Name = "srchbyCmb";
            this.srchbyCmb.Size = new System.Drawing.Size(232, 24);
            this.srchbyCmb.TabIndex = 9;
            // 
            // srtbyCmb
            // 
            this.srtbyCmb.DropDownHeight = 80;
            this.srtbyCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srtbyCmb.DropDownWidth = 200;
            this.srtbyCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srtbyCmb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srtbyCmb.FormattingEnabled = true;
            this.srtbyCmb.IntegralHeight = false;
            this.srtbyCmb.ItemHeight = 16;
            this.srtbyCmb.Items.AddRange(new object[] {
            "(Sort by)",
            "VictimID",
            "Last Name",
            "First Name",
            "Middle Name",
            "Age",
            "Gender",
            "Nick Name",
            "Date Of Birth",
            "Place of Birth",
            "Current Address",
            "addedOn"});
            this.srtbyCmb.Location = new System.Drawing.Point(825, 625);
            this.srtbyCmb.MaxDropDownItems = 4;
            this.srtbyCmb.Name = "srtbyCmb";
            this.srtbyCmb.Size = new System.Drawing.Size(235, 24);
            this.srtbyCmb.TabIndex = 10;
            this.srtbyCmb.SelectedIndexChanged += new System.EventHandler(this.srtbyCmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(694, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sort victims by:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownHeight = 80;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.DropDownWidth = 200;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.IntegralHeight = false;
            this.cmbSort.ItemHeight = 16;
            this.cmbSort.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbSort.Location = new System.Drawing.Point(1068, 625);
            this.cmbSort.MaxDropDownItems = 4;
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(101, 24);
            this.cmbSort.TabIndex = 12;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterCmb
            // 
            this.filterCmb.DropDownHeight = 80;
            this.filterCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCmb.DropDownWidth = 200;
            this.filterCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterCmb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCmb.FormattingEnabled = true;
            this.filterCmb.IntegralHeight = false;
            this.filterCmb.ItemHeight = 15;
            this.filterCmb.Items.AddRange(new object[] {
            "(Filtering)",
            "Victims added this month",
            "Ages 8 below",
            "Ages 9-12",
            "Ages 13-17",
            "Ages 18+",
            "Victims involved in more than one case"});
            this.filterCmb.Location = new System.Drawing.Point(59, 625);
            this.filterCmb.MaxDropDownItems = 4;
            this.filterCmb.Name = "filterCmb";
            this.filterCmb.Size = new System.Drawing.Size(297, 23);
            this.filterCmb.TabIndex = 13;
            this.filterCmb.SelectedIndexChanged += new System.EventHandler(this.filterCmb_SelectedIndexChanged);
            // 
            // rowCounttb
            // 
            this.rowCounttb.Location = new System.Drawing.Point(442, 626);
            this.rowCounttb.Name = "rowCounttb";
            this.rowCounttb.ReadOnly = true;
            this.rowCounttb.Size = new System.Drawing.Size(39, 20);
            this.rowCounttb.TabIndex = 15;
            this.rowCounttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(362, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Row Count:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvStatlbl
            // 
            this.dgvStatlbl.BackColor = System.Drawing.Color.White;
            this.dgvStatlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStatlbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStatlbl.ForeColor = System.Drawing.Color.Black;
            this.dgvStatlbl.Location = new System.Drawing.Point(111, 99);
            this.dgvStatlbl.Name = "dgvStatlbl";
            this.dgvStatlbl.Size = new System.Drawing.Size(278, 24);
            this.dgvStatlbl.TabIndex = 15;
            this.dgvStatlbl.Text = "Data Grid Status";
            this.dgvStatlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data Grid Feed:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // victimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1181, 660);
            this.Controls.Add(this.dgvStatlbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rowCounttb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterCmb);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.srtbyCmb);
            this.Controls.Add(this.srchbyCmb);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.victimDgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.border);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "victimFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "victimFrm";
            this.Load += new System.EventHandler(this.victimFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.victimFrm_Paint);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.victimDgv)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView victimDgv;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Label editBt;
        private System.Windows.Forms.Label viewFullDetbt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbSearchVictims;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox srchbyCmb;
        private System.Windows.Forms.Label victimCountlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label viewVicbt;
        private System.Windows.Forms.Label curDatelbl;
        private System.Windows.Forms.ComboBox srtbyCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox hidePb;
        private System.Windows.Forms.PictureBox closePb;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rowCounttb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dgvStatlbl;
        private System.Windows.Forms.Label label8;
    }
}