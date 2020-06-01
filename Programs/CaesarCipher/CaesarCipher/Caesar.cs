using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Caesar : Form
    {
        int ReadyPT = 0;

        public Caesar()
        {
            InitializeComponent();
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
        private void cipdec_Load(object sender, EventArgs e)
        {

        }

        private void cipdec_Paint(object sender, PaintEventArgs e)
        {
            Pen bp = new Pen(Brushes.DimGray, 2);
            e.Graphics.DrawRectangle(bp, 0,0, this.Width, this.Height);
        }

        private void TextInput_Enter(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.Black;
            TxtLine1.ForeColor = Color.Black;

        }

        private void TextInput_Leave(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.Gray;
            TxtLine1.ForeColor = Color.Gray;

        }

        private void TextOutput_Enter(object sender, EventArgs e)
        {
            lbl2.ForeColor = Color.Black;
            TxtLine2.ForeColor = Color.Black;
        }

        private void TextOutput_Leave(object sender, EventArgs e)
        {
            lbl2.ForeColor = Color.Gray;
            TxtLine2.ForeColor = Color.Gray;
        }

        private void TextShift_Enter(object sender, EventArgs e)
        {
            lbl3.ForeColor = Color.Black;
            TxtLine3.ForeColor = Color.Black;
        }
        int Shifts = 0;
        private void TextShift_Leave(object sender, EventArgs e)
        {
            ReadyPT = 0;
            int Valid = 0;
            try { Shifts = Convert.ToInt32(TextShift.Text); }
            catch
            { Valid++; }

            if (Valid > 0)
            {
                TxtLine3.ForeColor = Color.Red;
                TipBro.SetToolTip(TextShift, "Please input total shift to cipher!");
                ReadyPT++;
            }
            else if (Shifts > 25) {
                TxtLine3.ForeColor = Color.Red;
                TipBro.SetToolTip(TextShift, "Invalid. Maximum of 25 shifts only!");
                ReadyPT++;
            }
            else
            {

                TxtLine3.ForeColor = Color.Gray;
                lbl3.ForeColor = Color.Gray;
                TipBro.SetToolTip(TextShift, "Total amount of Frequency, maximum of 25.");
            }
        }

        private void btCipher_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btCipher_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btCipher_Click(object sender, EventArgs e)
        {
            

            ReadyPT = 0;
            int Valid = 0;
            try { Shifts = Convert.ToInt32(TextShift.Text); }
            catch
            { Valid++; }

            if (Valid > 0)
            {
                TxtLine3.ForeColor = Color.Red;
                TipBro.SetToolTip(TextShift, "Please input total shift to cipher!");
                ReadyPT++;
            }
            else if (Shifts > 25)
            {
                TxtLine3.ForeColor = Color.Red;
                TipBro.SetToolTip(TextShift, "Invalid. Maximum of 25 shifts only!");
                ReadyPT++;
            }
            else
            {

                TxtLine3.ForeColor = Color.Gray;
                lbl3.ForeColor = Color.Gray;
                TipBro.SetToolTip(TextShift, "Total amount of Frequency, maximum of 25.");
            }

            string EncryptedText = "";

            if (ReadyPT > 0)
            { }
            else
            {
                char[] Shift1 = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                string PlaintText = TextInput.Text.ToUpper();

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

                                EncryptedText += Shift1[letCiph].ToString();
                            }
                            else
                            {
                                EncryptedText += Shift1[letCount].ToString();
                            }

                        }
                        
                    }
                }

                TextOutput.Text = EncryptedText;
            }
        }

        private void btDecipher_Click(object sender, EventArgs e)
        {
            string DecryptedText = "";
            string PlainText = "";

            ReadyPT = 0;
            int Valid = 0;
            try { Shifts = Convert.ToInt32(TextShift.Text); }
            catch
            { Valid++; }

            if (Valid > 0)
            {
                TxtLine3.ForeColor = Color.Red;
                TipBro.SetToolTip(TextShift, "Please input total shift to cipher!");
                ReadyPT++;
            }
            else if (Shifts > 25)
            {
                TxtLine3.ForeColor = Color.Red;
                TipBro.SetToolTip(TextShift, "Invalid. Maximum of 25 shifts only!");
                ReadyPT++;
            }
            else
            {

                TxtLine3.ForeColor = Color.Gray;
                lbl3.ForeColor = Color.Gray;
                TipBro.SetToolTip(TextShift, "Total amount of Frequency, maximum of 25.");
            }

            if (ReadyPT > 0)
            {

            }
            else
            {
                char[] Shift1 = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                PlainText = TextInput.Text.ToUpper();

                for (int c = 0; c < PlainText.Length; c++)
                {
                    char check_Alph = PlainText[c];

                    for (int s = 0; s < Shift1.Length; s++)
                    {
                        if (check_Alph == Shift1[s])
                        {
                            int letCount = 0;
                            letCount = s - Shifts;

                            if (letCount < 0)
                            {
                                int letCiph = letCount + 26;

                                DecryptedText += Shift1[letCiph].ToString();
                            }
                            else
                            {
                                letCount = s - Shifts;

                                DecryptedText += Shift1[letCount].ToString();
                            }

                        }
                        
                    }
                }

                TextOutput.Text = DecryptedText;
            }
        }

     }
        
 }
