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
    public partial class informationFrm : Form
    {
        public informationFrm()
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
        private void informationFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 2);
            e.Graphics.DrawRectangle(black, 0,0,this.Width,this.Height);
        }

        private void informationFrm_Load(object sender, EventArgs e)
        {

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
    }
}
