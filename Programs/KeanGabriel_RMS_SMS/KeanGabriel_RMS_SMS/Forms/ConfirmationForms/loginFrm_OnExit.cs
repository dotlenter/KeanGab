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
    public partial class loginFrm_OnExit : Form
    {
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();

        public loginFrm_OnExit()
        {
            InitializeComponent();
            txtOnQuestion.Left = ((this.ClientSize.Width + 40) - txtOnQuestion.Width) / 2;

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
        private void loginFrm_OnExit_Load(object sender, EventArgs e)
        {

        }

        private void loginFrm_OnExit_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 2);
            e.Graphics.DrawRectangle(black, 0, 0, this.Width, this.Height);
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btYes_MouseMove(object sender, MouseEventArgs e)
        {
            btYes.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void btYes_MouseLeave(object sender, EventArgs e)
        {
            btYes.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void btNo_MouseMove(object sender, MouseEventArgs e)
        {
            btNo.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void btNo_MouseLeave(object sender, EventArgs e)
        {
            btNo.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            garCol.FlushMemory();
            this.Close();
        }

        private void loginFrm_OnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btNo_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                btYes_Click(sender, e);
            }
        }
    }
}
