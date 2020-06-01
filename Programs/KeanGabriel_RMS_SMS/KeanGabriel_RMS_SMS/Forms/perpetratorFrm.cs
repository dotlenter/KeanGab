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
    public partial class perpetratorFrm : Form
    {
        Forms.ConfirmationForms.informationFrm OnInformation = new ConfirmationForms.informationFrm();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        public perpetratorFrm()
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
        private int usrID;

        public int passID
        {
            get { return usrID; }
            set { usrID = value; }
        }
        private bool DragPress;
        private Point WindowsLoc;
        private void border_MouseUp(object sender, MouseEventArgs e)
        {
            DragPress = false;
        }

        private void border_MouseMove(object sender, MouseEventArgs e)
        {
            if (DragPress)
            {
                this.Location = new Point(
                    (this.Location.X - WindowsLoc.X) + e.X, (this.Location.Y - WindowsLoc.Y) + e.Y);

                this.Update();
            }
        }

        private void border_MouseDown(object sender, MouseEventArgs e)
        {
            DragPress = true;
            WindowsLoc = e.Location;
        }
        private void closePb_Click(object sender, EventArgs e)
        {
            selectionFrm newFrm = new selectionFrm();
            newFrm.passID = usrID;
            newFrm.Show();
            this.Dispose(false);
            garCol.FlushMemory();
        }

        private void perpetratorFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 2);
            e.Graphics.DrawRectangle(black, 0, 0, this.Width, this.Height);
        }

        private void perpetratorFrm_Load(object sender, EventArgs e)
        {
            filterBycmb.SelectedIndex = 0;
            sortBycmb.SelectedIndex = 0;
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("SELECT PerpetratorID, LastName, FirstName, MidName, NickName FROM tbPerpetrators WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A'", dbconn_main))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dvPerpetrators.DataSource = dt;
                    dvPerpetrators.Columns[3].HeaderText = "Middle Name";
                    dvPerpetrators.Columns[4].HeaderText = "Nick Name";
                }
            }
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {

        }
        private void closePb_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void closePb_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        protected long perpetID = 0;

        private void dvPerpetrators_SelectionChanged(object sender, EventArgs e)
        {
            perpetID = 0;
            if (dvPerpetrators.SelectedRows.Count > 0)
            {
                using (dbconn_main = dbpath.getdbConnection())
                {
                    try { dbconn_main.Open(); }
                    catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }


                    try { perpetID = Convert.ToInt64(dvPerpetrators.SelectedRows[0].Cells[0].Value); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "[OOPS!]", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                    using (commnd = new SqlCommand("SELECT * FROM tbPerpetrators WHERE PerpetratorID = @id", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@id", perpetID);
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            IDlbl.Text = dataReader[0].ToString();
                            lastNamelbl.Text = dataReader[1].ToString();
                            firstNamelbl.Text = dataReader[2].ToString();
                            midNamelbl.Text = dataReader[3].ToString();
                            ageLbl.Text = dataReader[4].ToString();
                            DateTime dateBirth = dataReader.GetDateTime(5);
                            birthDatelbl.Text = dateBirth.ToString("mm/dd/yyyy");
                            genderLbl.Text = dataReader[6].ToString();
                            nckNamelbl.Text = dataReader[7].ToString();
                            occupLbl.Text = dataReader[8].ToString();
                            contNumlbl.Text = dataReader[9].ToString();
                            presentedIDlbl.Text = dataReader[10].ToString();
                            influenceLbl.Text = dataReader[11].ToString();
                            prevCrimlbl.Text = dataReader[12].ToString();
                            prevCaselbl.Text = dataReader[13].ToString();
                            remarksLbl.Text = dataReader[14].ToString();
                            addedOnlbl.Text = dataReader[15].ToString();
                        }
                        dataReader.Close();
                    }
                }
            }
        }

        private void dvPerpetrators_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            perpetratorDetailsFrm perpetratorDetailsFrm = new perpetratorDetailsFrm();
            perpetratorDetailsFrm.passPetratorID = Convert.ToInt64(dvPerpetrators.SelectedRows[0].Cells[0].Value);
            perpetratorDetailsFrm.ShowDialog();
        }

        private void tbSrchPerpetrator_TextChanged(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                using (commnd = new SqlCommand("SELECT PerpetratorID, LastName, FirstName, MidName, NickName FROM tbPerpetrators WHERE (LastName + ' ' + FirstName + ' ' + MidName) LIKE '" + tbSrchPerpetrator.Text + "%' AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A'", dbconn_main))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dvPerpetrators.DataSource = dt;
                    dvPerpetrators.Columns[3].HeaderText = "Middle Name";
                    dvPerpetrators.Columns[4].HeaderText = "Nick Name";
                }
            }
        }

        private void hidePb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btEdtInf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}