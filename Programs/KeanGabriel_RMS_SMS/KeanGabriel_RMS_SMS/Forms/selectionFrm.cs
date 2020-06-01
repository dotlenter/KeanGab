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

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class selectionFrm : Form
    {
        private bool DragPress;
        private Point WindowsLoc;
        SqlConnection dbconn_main;
        SqlDataReader dataReader;
        SqlCommand commnd;
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
 
        
        public selectionFrm()
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
        private void btClose_MouseMove(object sender, MouseEventArgs e)
        {
            btClose.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }
        private void btHide_MouseMove(object sender, MouseEventArgs e)
        {
            btHide.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void btHide_MouseLeave(object sender, EventArgs e)
        {
            btHide.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "[LOGOUT]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose(false);
                garCol.FlushMemory();
                loginFrm loginFrm = new loginFrm();
                loginFrm.Show();
            }
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void selectionFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Lime, 4);
            e.Graphics.DrawRectangle(black, 0,0,this.Width, this.Height);
        }

        #region Hover_Effcts
        private void caseFormPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _1.Image = Properties.Resources.Hover_CircButton;
        }

        private void caseFormPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _1.Image = Properties.Resources.Unhover_CircButton;
        }

        private void victimPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _2.Image = Properties.Resources.Hover_CircButton;
        }

        private void victimPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _2.Image = Properties.Resources.Unhover_CircButton;
        }

        private void prpetratorsPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _3.Image = Properties.Resources.Hover_CircButton;
        }

        private void prpetratorsPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _3.Image = Properties.Resources.Unhover_CircButton;
        }

        private void referrerPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _4.Image = Properties.Resources.Hover_CircButton;
        }

        private void referrerPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _4.Image = Properties.Resources.Unhover_CircButton;
        }

        private void callLogsPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _5.Image = Properties.Resources.Hover_CircButton;
        }

        private void callLogsPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _5.Image = Properties.Resources.Unhover_CircButton;
        }

        private void casesPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _6.Image = Properties.Resources.Hover_CircButton;
        }

        private void casesPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _6.Image = Properties.Resources.Unhover_CircButton;
        }

        private void statPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _7.Image = Properties.Resources.Hover_CircButton;
        }

        private void statPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _7.Image = Properties.Resources.Unhover_CircButton;
        }

        private void reportPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _8.Image = Properties.Resources.Hover_CircButton;
        }

        private void reportPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _8.Image = Properties.Resources.Unhover_CircButton;
        }

        private void logoutPn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _9.Image = Properties.Resources.Hover_CircButton;
        }

        private void logoutPn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _9.Image = Properties.Resources.Unhover_CircButton;
        }
        #endregion

        private int usrID;

        public int passID
        {
            get { return usrID; }
            set { usrID = value; }
        }
        private void selectionFrm_Load(object sender, EventArgs e)
        {
            int Hour = Convert.ToInt32(DateTime.Now.Hour.ToString());
            if (Hour > 1 && Hour < 12)
            { greetings.Text = "Good Morning!"; }
            else if (Hour > 12 && Hour < 18)
            { greetings.Text = "Good Afternoon!"; }
            else
            { greetings.Text = "Good Evening!"; }
            using(dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { }

                using(commnd = new SqlCommand("Select name from tbUserDetails Where UserID = @id", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@id", usrID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        currentUserLbl.Text = dataReader[0].ToString();
                    }
                    dataReader.Close();
                }
            }
            
        }

        private void curDateTime_Tick(object sender, EventArgs e)
        {
            lblcurDT.Text = DateTime.Now.ToString();
        }

        private void borderPn_MouseUp(object sender, MouseEventArgs e)
        {
            DragPress = false;
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

        private void borderPn_MouseDown(object sender, MouseEventArgs e)
        {
            DragPress = true;
            WindowsLoc = e.Location;
        }

        private void caseFormPn_Click(object sender, EventArgs e)
        {
            Forms.caseFrm case_Frm = new Forms.caseFrm();
            case_Frm.passID = usrID;
            case_Frm.Show();
            this.Hide();
            garCol.FlushMemory();
        }

        private void victimPn_Click(object sender, EventArgs e)
        {
            Forms.victimFrm victim_Frm = new Forms.victimFrm();
            victim_Frm.passID = usrID;
            victim_Frm.Show();
            this.Hide();
            garCol.FlushMemory();

        }

        private void prpetratorsPn_Click(object sender, EventArgs e)
        {
            Forms.perpetratorFrm perpet_Frm = new Forms.perpetratorFrm();
            perpet_Frm.passID = usrID;
            perpet_Frm.Show();
            this.Hide();
            garCol.FlushMemory();
        }

        private void callLogsPn_Click(object sender, EventArgs e)
        {
            Forms.callLogsFrm callLogs_Frm = new Forms.callLogsFrm();
            callLogs_Frm.passID = usrID;
            callLogs_Frm.Show();
            this.Hide();
            garCol.FlushMemory();
        }

        private void casesPn_Click(object sender, EventArgs e)
        {
            Forms.casesFrm cases_Frm = new Forms.casesFrm();
            cases_Frm.passID = usrID;
            cases_Frm.Show();
            this.Hide();
            garCol.FlushMemory();
        }

        private void statPn_Click(object sender, EventArgs e)
        {
            Forms.statisticsFrm statistic_Frm = new Forms.statisticsFrm();
            statistic_Frm.passID = usrID;
            statistic_Frm.Show();
            this.Hide();
            garCol.FlushMemory();
        }

        private void referrerPn_Click(object sender, EventArgs e)
        {
            Forms.referrerFrm referrer_Frm = new Forms.referrerFrm();
            referrer_Frm.passID = usrID;
            referrer_Frm.Show();
            this.Hide();
            garCol.FlushMemory();
        }

        private void logoutPn_Click(object sender, EventArgs e)
        {
            btClose_Click(sender, e);
        }

        private void reportPn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void caseFormPn_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
