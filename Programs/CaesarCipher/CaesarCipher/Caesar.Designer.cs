namespace CaesarCipher
{
    partial class Caesar
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
            this.ttle = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.TxtLine1 = new System.Windows.Forms.Label();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.TxtLine2 = new System.Windows.Forms.Label();
            this.TextShift = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.TxtLine3 = new System.Windows.Forms.Label();
            this.TipBro = new System.Windows.Forms.ToolTip(this.components);
            this.btCipher = new System.Windows.Forms.Label();
            this.btDecipher = new System.Windows.Forms.Label();
            this.btCopyP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ttle
            // 
            this.ttle.BackColor = System.Drawing.Color.Black;
            this.ttle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttle.ForeColor = System.Drawing.Color.White;
            this.ttle.Location = new System.Drawing.Point(2, 2);
            this.ttle.Name = "ttle";
            this.ttle.Size = new System.Drawing.Size(337, 31);
            this.ttle.TabIndex = 0;
            this.ttle.Text = "Caesar Cipher";
            this.ttle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Gray;
            this.lbl1.Location = new System.Drawing.Point(31, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Input:";
            // 
            // TextInput
            // 
            this.TextInput.BackColor = System.Drawing.Color.White;
            this.TextInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInput.Location = new System.Drawing.Point(38, 71);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(235, 19);
            this.TextInput.TabIndex = 2;
            this.TextInput.Enter += new System.EventHandler(this.TextInput_Enter);
            this.TextInput.Leave += new System.EventHandler(this.TextInput_Leave);
            // 
            // TxtLine1
            // 
            this.TxtLine1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLine1.ForeColor = System.Drawing.Color.Gray;
            this.TxtLine1.Location = new System.Drawing.Point(31, 81);
            this.TxtLine1.Name = "TxtLine1";
            this.TxtLine1.Size = new System.Drawing.Size(271, 16);
            this.TxtLine1.TabIndex = 3;
            this.TxtLine1.Text = "_________________________________________";
            // 
            // TextOutput
            // 
            this.TextOutput.BackColor = System.Drawing.Color.White;
            this.TextOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextOutput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextOutput.Location = new System.Drawing.Point(38, 132);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.Size = new System.Drawing.Size(235, 19);
            this.TextOutput.TabIndex = 5;
            this.TextOutput.Enter += new System.EventHandler(this.TextOutput_Enter);
            this.TextOutput.Leave += new System.EventHandler(this.TextOutput_Leave);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Gray;
            this.lbl2.Location = new System.Drawing.Point(31, 113);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 16);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Output:";
            // 
            // TxtLine2
            // 
            this.TxtLine2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLine2.ForeColor = System.Drawing.Color.Gray;
            this.TxtLine2.Location = new System.Drawing.Point(31, 142);
            this.TxtLine2.Name = "TxtLine2";
            this.TxtLine2.Size = new System.Drawing.Size(271, 16);
            this.TxtLine2.TabIndex = 6;
            this.TxtLine2.Text = "_________________________________________";
            // 
            // TextShift
            // 
            this.TextShift.BackColor = System.Drawing.Color.White;
            this.TextShift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextShift.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShift.Location = new System.Drawing.Point(150, 198);
            this.TextShift.MaxLength = 2;
            this.TextShift.Name = "TextShift";
            this.TextShift.Size = new System.Drawing.Size(24, 19);
            this.TextShift.TabIndex = 8;
            this.TextShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipBro.SetToolTip(this.TextShift, "Maximum of 25 Shifts.");
            this.TextShift.Enter += new System.EventHandler(this.TextShift_Enter);
            this.TextShift.Leave += new System.EventHandler(this.TextShift_Leave);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Gray;
            this.lbl3.Location = new System.Drawing.Point(145, 179);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(37, 16);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Shifts:";
            // 
            // TxtLine3
            // 
            this.TxtLine3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLine3.ForeColor = System.Drawing.Color.Gray;
            this.TxtLine3.Location = new System.Drawing.Point(144, 207);
            this.TxtLine3.Name = "TxtLine3";
            this.TxtLine3.Size = new System.Drawing.Size(43, 16);
            this.TxtLine3.TabIndex = 9;
            this.TxtLine3.Text = "_________________________________________";
            // 
            // btCipher
            // 
            this.btCipher.BackColor = System.Drawing.Color.DarkGray;
            this.btCipher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btCipher.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCipher.ForeColor = System.Drawing.Color.Black;
            this.btCipher.Location = new System.Drawing.Point(34, 245);
            this.btCipher.Name = "btCipher";
            this.btCipher.Size = new System.Drawing.Size(76, 28);
            this.btCipher.TabIndex = 10;
            this.btCipher.Text = "Encrypt";
            this.btCipher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCipher.Click += new System.EventHandler(this.btCipher_Click);
            this.btCipher.MouseLeave += new System.EventHandler(this.btCipher_MouseLeave);
            this.btCipher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btCipher_MouseMove);
            // 
            // btDecipher
            // 
            this.btDecipher.BackColor = System.Drawing.Color.DarkGray;
            this.btDecipher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btDecipher.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecipher.ForeColor = System.Drawing.Color.Black;
            this.btDecipher.Location = new System.Drawing.Point(116, 245);
            this.btDecipher.Name = "btDecipher";
            this.btDecipher.Size = new System.Drawing.Size(76, 28);
            this.btDecipher.TabIndex = 11;
            this.btDecipher.Text = "Decrypt";
            this.btDecipher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDecipher.Click += new System.EventHandler(this.btDecipher_Click);
            // 
            // btCopyP
            // 
            this.btCopyP.BackColor = System.Drawing.Color.DarkGray;
            this.btCopyP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btCopyP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCopyP.ForeColor = System.Drawing.Color.Black;
            this.btCopyP.Location = new System.Drawing.Point(198, 245);
            this.btCopyP.Name = "btCopyP";
            this.btCopyP.Size = new System.Drawing.Size(104, 28);
            this.btCopyP.TabIndex = 12;
            this.btCopyP.Text = "Source Codes";
            this.btCopyP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 293);
            this.Controls.Add(this.btCopyP);
            this.Controls.Add(this.btDecipher);
            this.Controls.Add(this.btCipher);
            this.Controls.Add(this.TextShift);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.TxtLine3);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.TxtLine2);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.ttle);
            this.Controls.Add(this.TxtLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caesar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cipdec_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cipdec_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ttle;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label TxtLine1;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label TxtLine2;
        private System.Windows.Forms.TextBox TextShift;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label TxtLine3;
        private System.Windows.Forms.ToolTip TipBro;
        private System.Windows.Forms.Label btCipher;
        private System.Windows.Forms.Label btDecipher;
        private System.Windows.Forms.Label btCopyP;
    }
}

