using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class callLogAddFrm : Form
    {
        public callLogAddFrm()
        {
            InitializeComponent();
        }

        private void callLogAddFrm_Load(object sender, EventArgs e)
        {
            if (rbMobileNumber.Checked == true)
            {
                txtMobNumber.Visible = true;
            }
            
          
        }

        private void rbMobileNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMobileNumber.Checked == true)
            {
                txtTelNo.Enabled = false;
                cmbSim.Enabled = true;
            }
            else 
            {
                txtMobNumber.Enabled = false;
                txtTelNo.Enabled = true;
            }
        }

        private void rbTelNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTelNumber.Checked == true)
            {
                txtMobNumber.Enabled = false;
                cmbSim.Enabled = false;
            }
            else
            {
                txtMobNumber.Enabled = true;
                txtTelNo.Enabled = false;
            }
        }
    }
}
