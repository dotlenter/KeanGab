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
using System.IO;
using System.Runtime.InteropServices;

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class casesFrm : Form
    {
        ConfirmationForms.informationFrm OnInformation = new ConfirmationForms.informationFrm();
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();

        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        public casesFrm()
        {
            InitializeComponent();
        }
        private int usrID;

        public int passID
        {
            get { return usrID; }
            set { usrID = value; }
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

        private void casesFrm_Load(object sender, EventArgs e)
        {
            using(dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using(commnd = new SqlCommand("SELECT * FROM tbCases", dbconn_main))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dvCases.DataSource = dt;

                    for (int x = 11; x <= 16; x++)
                    {
                        dvCases.Columns[x].Visible = false;
                    }
                }
            }
            dataFeedtb.Text = "All Cases";
        }

        private void dvCases_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            numRowstb.Text = dvCases.Rows.Count.ToString();
            dataFeedtb.Text = cmbFilterCases.Text;
        }

        private void cmbFilterCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                if (cmbFilterCases.SelectedIndex == 0)
                {
                    //CASES THIS MONTH
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE MONTH(caseAddedOn) = @date", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@date", DateTime.Now.Month);
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 1)
                {
                    //CASES PAST MONTH
                    int pastMonth = Convert.ToInt32(Convert.ToInt32(DateTime.Now.Month) - 1);
                    if (pastMonth < 1)
                    {
                        int pastYearMonth = Convert.ToInt32(Convert.ToInt32(DateTime.Now.Year) - 1);
                        DateTime pastMonth_date = new DateTime(pastYearMonth, 12, DateTime.Now.Day);

                        using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE MONTH(caseAddedOn) = @date", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@date", pastMonth_date);
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            dvCases.DataSource = dt;

                            for (int x = 11; x <= 16; x++)
                            {
                                dvCases.Columns[x].Visible = false;
                            }
                        }
                    }
                    else
                    {
                        using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE MONTH(caseAddedOn) = @date", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@date", (Convert.ToInt32(DateTime.Now.Month) - 1));
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            dvCases.DataSource = dt;

                            for (int x = 11; x <= 16; x++)
                            {
                                dvCases.Columns[x].Visible = false;
                            }
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 2)
                { 
                    using(commnd = new SqlCommand("SELECT * FROM tbCases WHERE typeOfIncident LIKE 'NEGLECTED%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 3)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE typeOfIncident LIKE 'VAWC%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 4)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE typeOfIncident LIKE 'MISSING%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 5)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE typeOfIncident LIKE 'PHYSICAL ABUSE%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 6)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE typeOfIncident LIKE 'SEXUAL ABUSE%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 7)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE typeOfIncident LIKE 'CUSTODY CASE%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 8)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 9)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE VictimID != 0 AND PerpetratorID != 0 AND personRepID != 0", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
                else if (cmbFilterCases.SelectedIndex == 10)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE PerpetratorID = 0 OR personRepID = 0 AND VictimID != 0", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvCases.DataSource = dt;

                        for (int x = 11; x <= 16; x++)
                        {
                            dvCases.Columns[x].Visible = false;
                        }
                    }
                }
            }
        }

        protected long CASE_NUMBER = 0;
        private void dvCases_SelectionChanged(object sender, EventArgs e)
        {
            CASE_NUMBER = 0;

            if (dvCases.SelectedRows.Count > 0)
            {
                using (dbconn_main = dbpath.getdbConnection())
                {
                    try { dbconn_main.Open(); }
                    catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                    try { CASE_NUMBER = Convert.ToInt64(dvCases.SelectedRows[0].Cells[0].Value); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    using (commnd = new SqlCommand("SELECT * FROM tbNarat WHERE caseNo = @CASENUM", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@CASENUM", CASE_NUMBER);
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            caseNumtb.Text = dataReader[0].ToString();
                            tbWhat.Text = dataReader[1].ToString();
                            tbWho.Text = dataReader[2].ToString();
                            tbWhen.Text = dataReader[3].ToString();
                            tbWhere.Text = dataReader[4].ToString();
                            tbWhy.Text = dataReader[5].ToString();
                            tbHow.Text = dataReader[6].ToString();
                            callTakertb.Text = dataReader[7].ToString();
                            tbSWorker.Text = dataReader[8].ToString();
                            PNPtb.Text = dataReader[9].ToString();
                            policeReptb.Text = dataReader[10].ToString();
                            barangayReptb.Text = dataReader[11].ToString();
                            preparedBytb.Text = dataReader[12].ToString();
                            approvedBytb.Text = dataReader[13].ToString();
                        }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE caseNo = @CASENUM", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@CASENUM", CASE_NUMBER);
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            caseNumDetTB.Text = dataReader[0].ToString();
                            victimIDtb.Text = dataReader[1].ToString();
                            perpetratorIDtb.Text = dataReader[2].ToString();
                            referrerIDtb.Text = dataReader[3].ToString();
                            dtIncidentTB.Text = dataReader[4].ToString();
                            placeOfIncidenttb.Text = dataReader[5].ToString();
                            typeOfIncidentTB.Text = dataReader[6].ToString();
                            caseAddedtb.Text = dataReader[10].ToString();
                            dtReportedTB.Text = dataReader[9].ToString();
                            presentProblemtxt.Text = dataReader[11].ToString();
                            caseBackgroundtxt.Text = dataReader[12].ToString();
                            initialAssesmenttxt.Text = dataReader[13].ToString();
                            servicesExtendedtxt.Text = dataReader[14].ToString();
                            procRecordingtxt.Text = dataReader[15].ToString();
                            actionTakentxt.Text = dataReader[16].ToString();
                            
                        }
                        dataReader.Close();
                    }
                }
            }
        }

        private void casesFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 4);
            e.Graphics.DrawRectangle(black, 0,0,this.Width,this.Height);
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

        private void closePb_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void closePb_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void closePb_Click(object sender, EventArgs e)
        {
            selectionFrm newFrm = new selectionFrm();
            newFrm.passID = usrID;
            newFrm.Show();
            this.Dispose(false);
            garCol.FlushMemory();
        }

        private void hidePb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hidePb_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void hidePb_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void viewVictimDetails_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt64(victimIDtb.Text) == 0 || string.IsNullOrWhiteSpace(victimIDtb.Text)))
            { }
            else
            {
                victimDetailsFrm vicEdit = new victimDetailsFrm();
                vicEdit.passvID = Convert.ToInt64(victimIDtb.Text);
                vicEdit.ShowDialog();
                garCol.FlushMemory();
            }
        }

        private void viewVictimDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void viewVictimDetails_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void viewPerpetDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void viewPerpetDetails_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void viewReferrerDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void viewReferrerDetails_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void editCasebt_Click(object sender, EventArgs e)
        {
            Forms.caseEditFrm cEdit = new Forms.caseEditFrm();
            cEdit.passCNum = Convert.ToInt64(dvCases.SelectedRows[0].Cells[0].Value);
            cEdit.ShowDialog();
            garCol.FlushMemory();
        }

        private void printSelectedCasebt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void viewPerpetDetails_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(perpetratorIDtb.Text) == 0 || string.IsNullOrWhiteSpace(perpetratorIDtb.Text))
            { }
            else
            {
                perpetratorDetailsFrm perpetratorDetFrm = new perpetratorDetailsFrm();
                perpetratorDetFrm.passPetratorID = Convert.ToInt64(perpetratorIDtb.Text);
                perpetratorDetFrm.ShowDialog();
                garCol.FlushMemory();
            }
        }

        private void viewReferrerDetails_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(referrerIDtb.Text) == 0 || string.IsNullOrWhiteSpace(perpetratorIDtb.Text))
            { }
            else 
            {
                referrerDetailsFrm referrerDetFrm = new referrerDetailsFrm();
                referrerDetFrm.passRefID = Convert.ToInt64(referrerIDtb.Text);
                referrerDetFrm.ShowDialog();
                garCol.FlushMemory();
            }
        }

        private void addCaseFormbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addCaseExtDatabt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
