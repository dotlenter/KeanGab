using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeanGabriel_RMS_SMS.Forms.ConfirmationForms
{
    public partial class attentionFrm : Form
    {
        public attentionFrm()
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
        private void attentionFrm_Load(object sender, EventArgs e)
        {

        }

        private void attentionFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Red, 2);
            e.Graphics.DrawRectangle(black, 0,0,this.Width,this.Height);
        }

        private void btOk_MouseMove(object sender, MouseEventArgs e)
        {
            btOk.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void btOk_MouseLeave(object sender, EventArgs e)
        {
            btOk.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void attentionFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exlamation_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
