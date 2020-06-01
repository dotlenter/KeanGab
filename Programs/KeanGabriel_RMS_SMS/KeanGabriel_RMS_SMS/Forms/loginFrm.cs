using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace KeanGabriel_RMS_SMS
{
    public partial class loginFrm : Form
    {
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        Forms.ConfirmationForms.loginFrm_OnExit OnExit = new Forms.ConfirmationForms.loginFrm_OnExit();
        Forms.ConfirmationForms.attentionFrm OnWrngAcct = new Forms.ConfirmationForms.attentionFrm();
        Forms.ConfirmationForms.informationFrm OnInformation = new Forms.ConfirmationForms.informationFrm();
        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataReader dataReader;
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        #region frq
        protected int Shifts = 7;
        protected int Freq2 = 4;
        #endregion
        int db_handShake = 1;
        public loginFrm()
        {
            InitializeComponent();
            KGH_Circ.Left = (this.ClientSize.Width - KGH_Circ.Width) / 2;
            Log_pan.Left = (this.ClientSize.Width - Log_pan.Width) / 2;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void loginFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Red, 4);
            e.Graphics.DrawRectangle(black, 0,0,this.Width,this.Height);
        }

        private void loginFrm_Load(object sender, EventArgs e)
        {
        }

        private void btClose_MouseMove(object sender, MouseEventArgs e)
        {
            btClose.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void btHide_MouseMove(object sender, MouseEventArgs e)
        {
            btHide.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void btHide_MouseLeave(object sender, EventArgs e)
        {
            btHide.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            OnExit.ShowDialog();
            garCol.FlushMemory();
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btLogin_MouseMove(object sender, MouseEventArgs e)
        {
            loginPn.BackgroundImage = Properties.Resources.Hover_Button;
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            loginPn.BackgroundImage = Properties.Resources.unHover_Button;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string EncryptF1 = "";
            string EncryptF2 = "";

            #region $Ciph
            char[] Shift1 = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string PlaintText = passwordTxt.Text.ToUpper();

            for (int c = 0; c < PlaintText.Length; c++)
            {
                char check_Alph = PlaintText[c];

                for (int s = 0; s < Shift1.Length; s++)
                {
                    if (check_Alph == Shift1[s])
                    {
                        int letCount = 0;
                        letCount = s + Shifts;

                        if (letCount > 25)
                        {
                            int letCiph = letCount - Shift1.Length;

                            EncryptF1 += Shift1[letCiph].ToString();
                        }
                        else
                        {
                            EncryptF1 += Shift1[letCount].ToString();
                        }

                    }

                }
            }
            PlaintText = EncryptF1;

            for (int c = 0; c < PlaintText.Length; c++)
            {
                char check_Alph = PlaintText[c];

                for (int s = 0; s < Shift1.Length; s++)
                {
                    if (check_Alph == Shift1[s])
                    {
                        int letCount = 0;
                        letCount = s + Freq2;

                        if (letCount > 25)
                        {
                            int letCiph = letCount - Shift1.Length;

                            EncryptF2 += Shift1[letCiph].ToString();
                        }
                        else
                        {
                            EncryptF2 += Shift1[letCount].ToString();
                        }

                    }

                }
            }

            #endregion

            using(dbconn_main = dbpath.getdbConnection())
            {
                
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); db_handShake = 0; }

                if (db_handShake == 1)
                {
                    using (commnd = new SqlCommand("SELECT usrnme FROM tbUser WHERE usrnme = @username", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@username", usernameTxt.Text);
                        dataReader = commnd.ExecuteReader();
                        int userAlive = 0;
                        while (dataReader.Read())
                        {
                            userAlive++;
                        }
                        dataReader.Close();
                        if (userAlive > 0)
                        {
                            int userAuth = 0;
                            int id = 0;
                            string userType = "";
                            string logStatus = "";
                            using (commnd = new SqlCommand("SELECT * FROM tbUser WHERE usrnme = @username AND paswrd = @password", dbconn_main))
                            {
                                commnd.Parameters.AddWithValue("@username", usernameTxt.Text);
                                commnd.Parameters.AddWithValue("@password", EncryptF2);
                                dataReader = commnd.ExecuteReader();
                                while (dataReader.Read())
                                {
                                    id = dataReader.GetInt32(0);
                                    userType = dataReader[3].ToString();
                                    logStatus = dataReader[4].ToString();
                                    userAuth++;
                                }
                                dataReader.Close();
                                if (userAuth > 0)
                                {
                                    if (logStatus.ToLower() == "off")
                                    {
                                        Forms.selectionFrm menuFrm = new Forms.selectionFrm();
                                        menuFrm.passID = id;
                                        menuFrm.Show();
                                        userAuth = 0;
                                        this.Hide();
                                        garCol.FlushMemory();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Online!");
                                    }

                                }
                                else
                                {
                                    OnWrngAcct.Exlamation_lbl.Text = "Invalid Password!";
                                }
                            }
                        }
                        else
                        {
                            OnWrngAcct.Exlamation_lbl.Text = "Account not found!";
                            OnWrngAcct.ShowDialog();
                            garCol.FlushMemory();
                        }
                    }
                }
                else { MessageBox.Show("Online!"); }
            }

        }

        private void btFrgotPass_MouseMove(object sender, MouseEventArgs e)
        {
            frgotPassPn.BackgroundImage = Properties.Resources.Hover_Button;
        }

        private void btFrgotPass_MouseLeave(object sender, EventArgs e)
        {
            frgotPassPn.BackgroundImage = Properties.Resources.unHover_Button;
        }

        private void btFrgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.","[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void loginFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btClose_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }

        private bool DragPress;
        private Point WindowsLoc;
        private void borderPn_MouseDown(object sender, MouseEventArgs e)
        {
            DragPress = true;
            WindowsLoc = e.Location;
        }

        private void borderPn_MouseMove(object sender, MouseEventArgs e)
        {
            if (DragPress)
            {
                this.Location = new Point(
                    (this.Location.X - WindowsLoc.X) + e.X, (this.Location.Y - WindowsLoc.Y) + e.Y);

                this.Update();
            }
        }

        private void borderPn_MouseUp(object sender, MouseEventArgs e)
        {
            DragPress = false;
        }
    }
}
