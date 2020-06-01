namespace KeanGabriel_RMS_SMS.Forms
{
    partial class referrerFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.border = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hidePb = new System.Windows.Forms.PictureBox();
            this.closePb = new System.Windows.Forms.PictureBox();
            this.dvReferrer = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbSrchPerpetrator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srchbyCmb = new System.Windows.Forms.ComboBox();
            this.viewDetailsbt = new System.Windows.Forms.Button();
            this.editbt = new System.Windows.Forms.Button();
            this.viewAllbt = new System.Windows.Forms.Button();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rowCountb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFeedlbl = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvReferrer)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.border.Size = new System.Drawing.Size(973, 38);
            this.border.TabIndex = 2;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "- Referrers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
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
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "R";
            // 
            // hidePb
            // 
            this.hidePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.hideCirc;
            this.hidePb.Location = new System.Drawing.Point(919, 7);
            this.hidePb.Name = "hidePb";
            this.hidePb.Size = new System.Drawing.Size(20, 20);
            this.hidePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePb.TabIndex = 1;
            this.hidePb.TabStop = false;
            this.toolTip1.SetToolTip(this.hidePb, "Hide");
            this.hidePb.Click += new System.EventHandler(this.hidePb_Click);
            this.hidePb.MouseLeave += new System.EventHandler(this.hidePb_MouseLeave);
            this.hidePb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hidePb_MouseMove);
            // 
            // closePb
            // 
            this.closePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.closeCirc;
            this.closePb.Location = new System.Drawing.Point(945, 7);
            this.closePb.Name = "closePb";
            this.closePb.Size = new System.Drawing.Size(20, 20);
            this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePb.TabIndex = 0;
            this.closePb.TabStop = false;
            this.toolTip1.SetToolTip(this.closePb, "Close");
            this.closePb.Click += new System.EventHandler(this.closePb_Click);
            this.closePb.MouseLeave += new System.EventHandler(this.closePb_MouseLeave);
            this.closePb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closePb_MouseMove);
            // 
            // dvReferrer
            // 
            this.dvReferrer.AllowUserToAddRows = false;
            this.dvReferrer.AllowUserToDeleteRows = false;
            this.dvReferrer.AllowUserToResizeColumns = false;
            this.dvReferrer.AllowUserToResizeRows = false;
            this.dvReferrer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvReferrer.BackgroundColor = System.Drawing.Color.Silver;
            this.dvReferrer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvReferrer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvReferrer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvReferrer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvReferrer.GridColor = System.Drawing.Color.Blue;
            this.dvReferrer.Location = new System.Drawing.Point(13, 93);
            this.dvReferrer.Name = "dvReferrer";
            this.dvReferrer.RowHeadersVisible = false;
            this.dvReferrer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvReferrer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvReferrer.Size = new System.Drawing.Size(950, 353);
            this.dvReferrer.TabIndex = 11;
            this.dvReferrer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvReferrer_CellDoubleClick);
            this.dvReferrer.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dvReferrer_RowStateChanged);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::KeanGabriel_RMS_SMS.Properties.Resources.Textbox_Rounded;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.tbSrchPerpetrator);
            this.panel5.Location = new System.Drawing.Point(457, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 23);
            this.panel5.TabIndex = 14;
            // 
            // tbSrchPerpetrator
            // 
            this.tbSrchPerpetrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSrchPerpetrator.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSrchPerpetrator.Location = new System.Drawing.Point(5, 4);
            this.tbSrchPerpetrator.Name = "tbSrchPerpetrator";
            this.tbSrchPerpetrator.Size = new System.Drawing.Size(250, 14);
            this.tbSrchPerpetrator.TabIndex = 0;
            this.tbSrchPerpetrator.TextChanged += new System.EventHandler(this.tbSrchPerpetrator_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(390, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // srchbyCmb
            // 
            this.srchbyCmb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.srchbyCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srchbyCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchbyCmb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbyCmb.FormattingEnabled = true;
            this.srchbyCmb.Items.AddRange(new object[] {
            "(Search by)",
            "Last Name",
            "First Name",
            "Middle Name",
            "Nick Name",
            "Occupation",
            "Presented ID",
            "Referrer Type",
            "Default(Last Name, First Name, and Middle Name)"});
            this.srchbyCmb.Location = new System.Drawing.Point(723, 61);
            this.srchbyCmb.Name = "srchbyCmb";
            this.srchbyCmb.Size = new System.Drawing.Size(240, 24);
            this.srchbyCmb.TabIndex = 16;
            // 
            // viewDetailsbt
            // 
            this.viewDetailsbt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDetailsbt.Location = new System.Drawing.Point(125, 58);
            this.viewDetailsbt.Name = "viewDetailsbt";
            this.viewDetailsbt.Size = new System.Drawing.Size(106, 30);
            this.viewDetailsbt.TabIndex = 17;
            this.viewDetailsbt.Text = "View details [F2]";
            this.viewDetailsbt.UseVisualStyleBackColor = true;
            this.viewDetailsbt.Click += new System.EventHandler(this.viewDetailsbt_Click);
            // 
            // editbt
            // 
            this.editbt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbt.Location = new System.Drawing.Point(13, 58);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(106, 30);
            this.editbt.TabIndex = 18;
            this.editbt.Text = "Edit Info [F1]";
            this.editbt.UseVisualStyleBackColor = true;
            this.editbt.Click += new System.EventHandler(this.editbt_Click);
            // 
            // viewAllbt
            // 
            this.viewAllbt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllbt.Location = new System.Drawing.Point(237, 58);
            this.viewAllbt.Name = "viewAllbt";
            this.viewAllbt.Size = new System.Drawing.Size(106, 30);
            this.viewAllbt.TabIndex = 19;
            this.viewAllbt.Text = "View All [V]";
            this.viewAllbt.UseVisualStyleBackColor = true;
            this.viewAllbt.Click += new System.EventHandler(this.viewAllbt_Click);
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
            "Added this month",
            "Referrers with complete name"});
            this.cmbFilterBy.Location = new System.Drawing.Point(13, 456);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(287, 24);
            this.cmbFilterBy.TabIndex = 20;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // rowCountb
            // 
            this.rowCountb.BackColor = System.Drawing.Color.White;
            this.rowCountb.Location = new System.Drawing.Point(386, 457);
            this.rowCountb.Name = "rowCountb";
            this.rowCountb.ReadOnly = true;
            this.rowCountb.Size = new System.Drawing.Size(49, 20);
            this.rowCountb.TabIndex = 21;
            this.rowCountb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(304, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Row Count: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataFeedlbl
            // 
            this.dataFeedlbl.BackColor = System.Drawing.Color.Transparent;
            this.dataFeedlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFeedlbl.ForeColor = System.Drawing.Color.Black;
            this.dataFeedlbl.Location = new System.Drawing.Point(441, 457);
            this.dataFeedlbl.Name = "dataFeedlbl";
            this.dataFeedlbl.Size = new System.Drawing.Size(271, 21);
            this.dataFeedlbl.TabIndex = 23;
            this.dataFeedlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // referrerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 492);
            this.Controls.Add(this.dataFeedlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowCountb);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.viewAllbt);
            this.Controls.Add(this.editbt);
            this.Controls.Add(this.viewDetailsbt);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.srchbyCmb);
            this.Controls.Add(this.dvReferrer);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "referrerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "referrerFrm";
            this.Load += new System.EventHandler(this.referrerFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.referrerFrm_Paint);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvReferrer)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.DataGridView dvReferrer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbSrchPerpetrator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox srchbyCmb;
        private System.Windows.Forms.Button viewDetailsbt;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Button viewAllbt;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox rowCountb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dataFeedlbl;
    }
}