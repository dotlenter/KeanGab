namespace KeanGabriel_RMS_SMS
{
    partial class loginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFrm));
            this.borderPn = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btHide = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Label();
            this.Log_pan = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tipbro = new System.Windows.Forms.ToolTip(this.components);
            this.KGH_Circ = new System.Windows.Forms.Panel();
            this.frgotPassPn = new System.Windows.Forms.Panel();
            this.btFrgotPass = new System.Windows.Forms.Label();
            this.loginPn = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.borderPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Log_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.frgotPassPn.SuspendLayout();
            this.loginPn.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPn
            // 
            this.borderPn.BackColor = System.Drawing.Color.White;
            this.borderPn.Controls.Add(this.pictureBox4);
            this.borderPn.Controls.Add(this.pictureBox3);
            this.borderPn.Controls.Add(this.btHide);
            this.borderPn.Controls.Add(this.btClose);
            this.borderPn.Location = new System.Drawing.Point(1, 1);
            this.borderPn.Name = "borderPn";
            this.borderPn.Size = new System.Drawing.Size(390, 42);
            this.borderPn.TabIndex = 1;
            this.borderPn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderPn_MouseDown);
            this.borderPn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderPn_MouseMove);
            this.borderPn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderPn_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Kean_Gabriel;
            this.pictureBox4.Location = new System.Drawing.Point(39, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.tipbro.SetToolTip(this.pictureBox4, "City Information Office");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Davao_City_Ph_official_seal;
            this.pictureBox3.Location = new System.Drawing.Point(8, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.tipbro.SetToolTip(this.pictureBox3, "Lungsod ng Davao (Sagisag)");
            // 
            // btHide
            // 
            this.btHide.AutoSize = true;
            this.btHide.BackColor = System.Drawing.Color.Transparent;
            this.btHide.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHide.Location = new System.Drawing.Point(285, 13);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(38, 16);
            this.btHide.TabIndex = 1;
            this.btHide.Text = "Hide";
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            this.btHide.MouseLeave += new System.EventHandler(this.btHide_MouseLeave);
            this.btHide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btHide_MouseMove);
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(338, 13);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(44, 16);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Close";
            this.tipbro.SetToolTip(this.btClose, "Exit");
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            this.btClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btClose_MouseMove);
            // 
            // Log_pan
            // 
            this.Log_pan.Controls.Add(this.passwordTxt);
            this.Log_pan.Controls.Add(this.usernameTxt);
            this.Log_pan.Controls.Add(this.pictureBox2);
            this.Log_pan.Controls.Add(this.label2);
            this.Log_pan.Controls.Add(this.label1);
            this.Log_pan.Controls.Add(this.pictureBox1);
            this.Log_pan.Location = new System.Drawing.Point(61, 223);
            this.Log_pan.Name = "Log_pan";
            this.Log_pan.Size = new System.Drawing.Size(274, 148);
            this.Log_pan.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(11, 109);
            this.passwordTxt.MaxLength = 50;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(251, 20);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(11, 39);
            this.usernameTxt.MaxLength = 50;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(251, 20);
            this.usernameTxt.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Textbox_Rounded;
            this.pictureBox2.Location = new System.Drawing.Point(3, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.Textbox_Rounded;
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // KGH_Circ
            // 
            this.KGH_Circ.BackgroundImage = global::KeanGabriel_RMS_SMS.Properties.Resources.Circular_KBH_OpenBook;
            this.KGH_Circ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KGH_Circ.Location = new System.Drawing.Point(110, 53);
            this.KGH_Circ.Name = "KGH_Circ";
            this.KGH_Circ.Size = new System.Drawing.Size(175, 166);
            this.KGH_Circ.TabIndex = 0;
            this.tipbro.SetToolTip(this.KGH_Circ, "0908-818-4444");
            // 
            // frgotPassPn
            // 
            this.frgotPassPn.BackColor = System.Drawing.Color.Transparent;
            this.frgotPassPn.BackgroundImage = global::KeanGabriel_RMS_SMS.Properties.Resources.unHover_Button;
            this.frgotPassPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frgotPassPn.Controls.Add(this.btFrgotPass);
            this.frgotPassPn.Location = new System.Drawing.Point(205, 377);
            this.frgotPassPn.Name = "frgotPassPn";
            this.frgotPassPn.Size = new System.Drawing.Size(130, 42);
            this.frgotPassPn.TabIndex = 8;
            // 
            // btFrgotPass
            // 
            this.btFrgotPass.BackColor = System.Drawing.Color.Transparent;
            this.btFrgotPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFrgotPass.ForeColor = System.Drawing.Color.White;
            this.btFrgotPass.Location = new System.Drawing.Point(3, 1);
            this.btFrgotPass.Name = "btFrgotPass";
            this.btFrgotPass.Size = new System.Drawing.Size(124, 38);
            this.btFrgotPass.TabIndex = 6;
            this.btFrgotPass.Text = "Forgot Password";
            this.btFrgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btFrgotPass.Click += new System.EventHandler(this.btFrgotPass_Click);
            this.btFrgotPass.MouseLeave += new System.EventHandler(this.btFrgotPass_MouseLeave);
            this.btFrgotPass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btFrgotPass_MouseMove);
            // 
            // loginPn
            // 
            this.loginPn.BackColor = System.Drawing.Color.Transparent;
            this.loginPn.BackgroundImage = global::KeanGabriel_RMS_SMS.Properties.Resources.unHover_Button;
            this.loginPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPn.Controls.Add(this.btLogin);
            this.loginPn.Location = new System.Drawing.Point(58, 377);
            this.loginPn.Name = "loginPn";
            this.loginPn.Size = new System.Drawing.Size(130, 42);
            this.loginPn.TabIndex = 7;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(3, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(124, 38);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login [Enter]";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.MouseLeave += new System.EventHandler(this.btLogin_MouseLeave);
            this.btLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btLogin_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(25, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "This system was made by HCDC BSIT Students (2017-2018) for Kean Gabriel LGU";
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(392, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frgotPassPn);
            this.Controls.Add(this.loginPn);
            this.Controls.Add(this.borderPn);
            this.Controls.Add(this.KGH_Circ);
            this.Controls.Add(this.Log_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "loginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeanGabriel Portal";
            this.Load += new System.EventHandler(this.loginFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.loginFrm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginFrm_KeyDown);
            this.borderPn.ResumeLayout(false);
            this.borderPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Log_pan.ResumeLayout(false);
            this.Log_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.frgotPassPn.ResumeLayout(false);
            this.loginPn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel KGH_Circ;
        private System.Windows.Forms.Panel borderPn;
        private System.Windows.Forms.Panel Log_pan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btHide;
        private System.Windows.Forms.Label btClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label btLogin;
        private System.Windows.Forms.Label btFrgotPass;
        private System.Windows.Forms.Panel loginPn;
        private System.Windows.Forms.Panel frgotPassPn;
        private System.Windows.Forms.ToolTip tipbro;
        private System.Windows.Forms.Label label3;
    }
}

