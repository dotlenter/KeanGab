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
using System.IO;

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class caseFrm : Form
    {
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Forms.ConfirmationForms.informationFrm OnInformation = new Forms.ConfirmationForms.informationFrm();
        SqlConnection dbconn_main;
        SqlConnection dbconn_Logs;
        SqlCommand commnd;
        SqlDataReader dataReader;
        private int validateRepDat = 0;
        public caseFrm()
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

        private void btClose_Click(object sender, EventArgs e)
        {
            selectionFrm newFrm = new selectionFrm();
            newFrm.passID = usrID;
            newFrm.Show();
            this.Dispose(false);
            garCol.FlushMemory();
        }

        private void curDateTime_Tick(object sender, EventArgs e)
        {

        }

        private void caseFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Lime, 4);
            e.Graphics.DrawRectangle(black, 0, 0, this.Width, this.Height);
        }
        private int usrID;

        public int passID
        {
            get { return usrID; }
            set { usrID = value; }
        }
        private void caseFrm_Load(object sender, EventArgs e)
        {
            using (dbconn_Logs = dbpath.getdbConnectionOnLogs())
            {
                try { dbconn_Logs.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("select Occupations FROM autoCorrects GROUP BY Occupations", dbconn_Logs))
                {
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cmbOccupPerpetDat.Items.Add(dataReader[0].ToString());
                        cmbFathOccupVicDat.Items.Add(dataReader[0].ToString());
                        cmbMothOccupVicDat.Items.Add(dataReader[0].ToString());
                        tbOccupPersonrep.Items.Add(dataReader[0].ToString());
                    }
                    dataReader.Close();
                }
            }
        }

        int OtherSpec = 0;
        private void AddIncbt_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(cmbTOI.Text) && OtherSpec == 0)
            {

                if (typeOfIncLBox.Items.Contains(cmbTOI.Text))
                { MessageBox.Show("Incident already added!", "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    typeOfIncLBox.Items.Add(cmbTOI.Text);
                    cmbTOI.SelectedIndex = -1;
                }
            }
            else if (!string.IsNullOrWhiteSpace(otherTypeofInctb.Text) && OtherSpec == 1)
            {
                if (typeOfIncLBox.Items.Contains(otherTypeofInctb.Text.ToUpper()))
                { MessageBox.Show("Incident already added!", "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    typeOfIncLBox.Items.Add(otherTypeofInctb.Text);
                    otherTypeofInctb.Clear();
                    cmbTOI.SelectedIndex = -1;
                }
            }
        }

        private void cmbTOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTOI.SelectedIndex == 6)
            {
                OtherSpec = 1;
                otherTypeofInctb.Visible = true;
                lblSpec.Visible = true;
            }
            else
            {
                OtherSpec = 0;
                otherTypeofInctb.Visible = false;
                lblSpec.Visible = false;
                otherTypeofInctb.Clear();
            }
        }

        private void newCasebt_Click(object sender, EventArgs e)
        {

            cancelCasebt.Enabled = true;
            saveCasebt.Enabled = true;
            newCasebt.Enabled = false;
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                if (caseFrmPn.Enabled == false)
                {
                    if (MessageBox.Show("Are you sure you want to add a new case?", "[NEW CASE]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (commnd = new SqlCommand("currentIDincrement", dbconn_main))
                        {
                            commnd.Parameters.Add("@id", SqlDbType.BigInt).Value = 0;
                            commnd.CommandType = CommandType.StoredProcedure;
                            dataReader = commnd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                if (dataReader.IsDBNull(0))
                                {
                                    caseNolbl.Text = "10000000";
                                    caseFrmPn.Enabled = true;
                                }
                                else
                                {
                                    caseNolbl.Text = (Convert.ToInt64(dataReader[0]) + 1).ToString();
                                    caseFrmPn.Enabled = true;
                                }
                            }
                            dataReader.Close();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("You're currently editing a case, do you want to discard this?", "[Warning]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        selectionFrm newFrm = new selectionFrm();
                        newFrm.passID = usrID;
                        newFrm.Show();
                        this.Dispose(false);
                        garCol.FlushMemory();
                    }
                }
            }
        }

        private void RemoveIncbt_Click(object sender, EventArgs e)
        {
            if (typeOfIncLBox.SelectedIndex > -1)
            {
                string incident = typeOfIncLBox.SelectedItem.ToString();
                if (typeOfIncLBox.Items.Contains(incident))
                {
                    typeOfIncLBox.Items.Remove(incident);
                }
            }
            else { MessageBox.Show("No item selected.", "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void cancelCasebt_Click(object sender, EventArgs e)
        {
            if (caseFrmPn.Enabled == true)
            {
                if (MessageBox.Show("Are you sure you want to discard this?", "[Warning]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    selectionFrm newFrm = new selectionFrm();
                    newFrm.passID = usrID;
                    newFrm.Show();
                    this.Dispose(false);
                    garCol.FlushMemory();
                }
            }
        }

        protected long conNumPrep = 0;
        protected long mobNumPrep = 0;
        protected long homNumPrep = 0;
        protected int agePrep = 0;
        protected long vicMothNum = 0;
        protected long vicFathNum = 0;
        protected int victimAge = 0;
        protected int agePerpet = 0;
        protected long personReportingID = 0;
        protected long victimID = 0;
        protected long perpetratorID = 0;
        protected long perpetContNum = 0;
        string nullWhiteSp = string.Empty;
        private void saveCasebt_Click(object sender, EventArgs e)
        {
            bool saveNarrative = false;
            if ((tbLNvictimDat.Text == "N/A" || string.IsNullOrWhiteSpace(tbLNvictimDat.Text)) && (tbFNvictimDat.Text == "N/A" || string.IsNullOrWhiteSpace(tbFNvictimDat.Text)) && (tbMNvictimDat.Text == "N/A" || string.IsNullOrWhiteSpace(tbMNvictimDat.Text)))
                {
                    ConfirmationForms.warningNullFrm OnNullVictim = new ConfirmationForms.warningNullFrm();
                    OnNullVictim.errorTxt.Text = "Victim is Null! You need to enter a victim for a valid case!";
                    OnNullVictim.errorTStxt.Text = "Victim should have at least a Family name, First name, or Middle Name for the system to confirm that it is valid.";
                    OnNullVictim.ShowDialog();
                    garCol.FlushMemory();
                }
            else if (typeOfIncLBox.Items.Count <= 0)
            {
                ConfirmationForms.warningNullFrm OnNullVictim = new ConfirmationForms.warningNullFrm();
                OnNullVictim.Text = "[NO INCIDENT]";
                OnNullVictim.errorTxt.Text = "No incident specified!";
                OnNullVictim.errorTStxt.Text = "You need to enter what type of incident this case is!";
                OnNullVictim.ShowDialog();
                garCol.FlushMemory();
            }
            else
            {

                if (MessageBox.Show("ARE YOU SURE YOU WANT TO SAVE THIS CASE?", "[CONFIRMATION]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    personReportingID = 0;
                    victimID = 0;
                    perpetratorID = 0;

                    DateTime dtCaseReported = dtpReportedDT.Value;
                    DateTime dtIncident = dtpIncidentDT.Value;
                    string placeIncident = "N/A";
                    string entryNo = "0";
                    string typeOfincident = "N/A";

                    if (!string.IsNullOrWhiteSpace(rchTxtPlaceOfInc.Text))
                    { placeIncident = rchTxtPlaceOfInc.Text; }
                    if (!string.IsNullOrWhiteSpace(entryNotb.Text))
                    { entryNo =  entryNotb.Text;}
                    if (typeOfIncLBox.Items.Count > 0)
                    {
                        typeOfincident = string.Empty;
                        for (int n = 0; n < typeOfIncLBox.Items.Count; n++)
                        {
                            typeOfincident += typeOfIncLBox.Items[n].ToString() + ", ";
                        }
                    }


                    using (dbconn_main = dbpath.getdbConnection())
                    {
                        try { dbconn_main.Open(); }
                        catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                        long CASE_NUMBER = 0;
                        using (commnd = new SqlCommand("INSERT INTO tbCases(VictimID, PerpetratorID, personRepID, dateTimeIncident, placeOfIncident, typeOfIncident, entryNum, dateTimeRep, caseAddedOn)VALUES(@vicID, @perpetID, @prepID, @dtInc, @placeInc, @typeInc, @eNum, @dtRepo, @addedOn)", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@vicID", 0);
                            commnd.Parameters.AddWithValue("@perpetID", 0);
                            commnd.Parameters.AddWithValue("@prepID", 0);
                            commnd.Parameters.AddWithValue("@dtInc", dtIncident);
                            commnd.Parameters.AddWithValue("@placeInc", placeIncident);
                            commnd.Parameters.AddWithValue("@typeInc", typeOfincident);
                            commnd.Parameters.AddWithValue("@eNum", entryNo);
                            commnd.Parameters.AddWithValue("@dtRepo", dtCaseReported);
                            commnd.Parameters.AddWithValue("@addedOn", DateTime.Now);
                            commnd.ExecuteNonQuery();
                        }
                        using (commnd = new SqlCommand("SELECT IDENT_CURRENT('tbCases')", dbconn_main))
                        {
                            dataReader = commnd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                CASE_NUMBER = Convert.ToInt64(dataReader[0]);
                            }
                            dataReader.Close();
                        }

                        int countRef = 0;
                        #region Referrer Saving

                        string LastNamePersonRep = "N/A";
                        string FirstNamePersonRep = "N/A";
                        string MiddleNamePersonRep = "N/A";
                        string NickNamePersonRep = "N/A";
                        if (!string.IsNullOrWhiteSpace(tbLNpersonrep.Text))
                        { LastNamePersonRep = tbLNpersonrep.Text; }
                        if (!string.IsNullOrWhiteSpace(tbFNpersonrep.Text))
                        { FirstNamePersonRep = tbFNpersonrep.Text; }
                        if (!string.IsNullOrWhiteSpace(tbMNpersonrep.Text))
                        { MiddleNamePersonRep = tbMNpersonrep.Text; }
                        if (!string.IsNullOrWhiteSpace(tbNNpersonrep.Text))
                        { NickNamePersonRep = tbNNpersonrep.Text; }

                        using (commnd = new SqlCommand("SELECT personRepID FROM tbPersonReporting WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@LNAME", LastNamePersonRep);
                            commnd.Parameters.AddWithValue("@FNAME", FirstNamePersonRep);
                            commnd.Parameters.AddWithValue("@MNAME", MiddleNamePersonRep);
                            dataReader = commnd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                personReportingID = dataReader.GetInt64(0);
                                countRef++;
                            }
                            dataReader.Close();
                        }
                        if (personReportingID > 0)
                        {
                            long prepID = 0;
                            if (MessageBox.Show("There are already (" + countRef.ToString() + ") referrer(s) with the details:\n\n Last Name: " + tbLNpersonrep.Text + "\nFirst Name: " + tbFNpersonrep.Text + "\nMiddle Name: " + tbMNpersonrep.Text + " \n\nThe info from the database will be inserted.\n\n[*]NOTE:You can edit the case in the Case panel on the Selection Menu.", "[INFO]", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                using (commnd = new SqlCommand("SELECT MAX(personRepID) FROM tbPersonReporting WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                                {
                                    commnd.Parameters.Add("@LNAME", SqlDbType.VarChar).Value = LastNamePersonRep;
                                    commnd.Parameters.Add("@FNAME", SqlDbType.VarChar).Value = FirstNamePersonRep;
                                    commnd.Parameters.Add("@MNAME", SqlDbType.VarChar).Value = MiddleNamePersonRep;
                                    dataReader = commnd.ExecuteReader();
                                    while (dataReader.Read())
                                    { prepID = dataReader.GetInt64(0); }
                                    dataReader.Close();
                                }
                                if (LastNamePersonRep == "N/A" && FirstNamePersonRep == "N/A" && MiddleNamePersonRep == "N/A")
                                {
                                    using (commnd = new SqlCommand("UPDATE tbCases SET personRepID = @ID WHERE caseNo = @caseNum", dbconn_main))
                                    {
                                        commnd.Parameters.AddWithValue("@ID", 0);
                                        commnd.Parameters.AddWithValue("@caseNum", CASE_NUMBER);
                                        commnd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    using (commnd = new SqlCommand("UPDATE tbCases SET personRepID = @ID WHERE caseNo = @caseNum", dbconn_main))
                                    {
                                        commnd.Parameters.AddWithValue("@ID", prepID);
                                        commnd.Parameters.AddWithValue("@caseNum", CASE_NUMBER);
                                        commnd.ExecuteNonQuery();
                                    }

                                }
                                MessageBox.Show("Database updated!\n\n\nPerson Reporting Information was saved successfully into the database.", "[*] INFORMATION DIALOG [*]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            #region Reporting Person Data


                            DateTime personRepDOB = new DateTime(1900, 1, 1);
                            string genderPersonRep = "N/A";
                            string curAddPersonRep = "N/A";
                            agePrep = 0;

                            if (!string.IsNullOrWhiteSpace(tbAgePersonrep.Text))
                            { personRepDOB = dtpBirthPersonrep.Value; try { agePrep = Convert.ToInt32(tbAgePersonrep.Text); } catch (Exception ex) { MessageBox.Show(ex.ToString(), "[OOps!]", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
                            if (!string.IsNullOrWhiteSpace(cmbGnderPersonrep.Text))
                            { genderPersonRep = cmbGnderPersonrep.Text; }
                            if (!string.IsNullOrWhiteSpace(rchTxtCurAddPersonrep.Text))
                            { curAddPersonRep = rchTxtCurAddPersonrep.Text; }


                            string cmbCitPrep = "N/A";
                            conNumPrep = 0;
                            mobNumPrep = 0;
                            homNumPrep = 0;
                            if (!string.IsNullOrWhiteSpace(tbContNumPersonrep.Text))
                            {
                                try { conNumPrep = Convert.ToInt64(tbContNumPersonrep.Text); }
                                catch { tbContNumPersonrep.BackColor = Color.MistyRose; }
                            }
                            if (!string.IsNullOrWhiteSpace(tbMobNumPersonrep.Text))
                            {
                                try { mobNumPrep = Convert.ToInt64(tbMobNumPersonrep.Text); }
                                catch { tbMobNumPersonrep.BackColor = Color.MistyRose; }
                            }
                            if (!string.IsNullOrWhiteSpace(tbHmePnumPersonrep.Text))
                            {
                                try { homNumPrep = Convert.ToInt64(tbHmePnumPersonrep.Text); }
                                catch { tbHmePnumPersonrep.BackColor = Color.MistyRose; }
                            }
                            if (!string.IsNullOrWhiteSpace(cmbCitizenPersonrep.Text))
                            { cmbCitPrep = cmbCitizenPersonrep.Text; }

                            string occuPersonRep = "N/A";
                            string idPrePRep = "N/A";
                            string remPersonRep = "N/A";
                            string refType = "Concerned Citizen";

                            if (!string.IsNullOrWhiteSpace(tbOccupPersonrep.Text))
                            { occuPersonRep = tbOccupPersonrep.Text; }
                            if (!string.IsNullOrWhiteSpace(cmbIDprsntedPersonrep.Text))
                            { idPrePRep = cmbIDprsntedPersonrep.Text; }
                            if (!string.IsNullOrWhiteSpace(rchTxtRemPersonrep.Text))
                            { remPersonRep = rchTxtRemPersonrep.Text; }
                            if (!string.IsNullOrWhiteSpace(cmbRefType.Text))
                            { refType = cmbRefType.Text; }

                            using (commnd = new SqlCommand("INSERT INTO tbPersonReporting VALUES(@LNAME, @FNAME, @MNAME, @AGE, @dateOfBirth, @nickName, @curAddress, @Occupation, @remarks, @addOn, @refType, @gender, @prID, @ctizen)", dbconn_main))
                            {
                                commnd.Parameters.AddWithValue("@LNAME", LastNamePersonRep);
                                commnd.Parameters.AddWithValue("@FNAME", FirstNamePersonRep);
                                commnd.Parameters.AddWithValue("@MNAME", MiddleNamePersonRep);
                                commnd.Parameters.AddWithValue("@AGE", agePrep);
                                commnd.Parameters.AddWithValue("@gender", genderPersonRep);
                                commnd.Parameters.AddWithValue("@dateOfBirth", personRepDOB);
                                commnd.Parameters.AddWithValue("@nickName", NickNamePersonRep);
                                commnd.Parameters.AddWithValue("@curAddress", curAddPersonRep);
                                commnd.Parameters.AddWithValue("@Occupation", occuPersonRep);
                                commnd.Parameters.AddWithValue("@remarks", remPersonRep);
                                commnd.Parameters.AddWithValue("@addOn", DateTime.Now);
                                commnd.Parameters.AddWithValue("@refType", refType);
                                commnd.Parameters.AddWithValue("@prID", idPrePRep);
                                commnd.Parameters.AddWithValue("@ctizen", cmbCitPrep);
                                commnd.ExecuteNonQuery();
                            }
                            long personRepIDContact = 0;
                            using (commnd = new SqlCommand("SELECT MAX(personRepID) FROM tbPersonReporting WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                            {
                                commnd.Parameters.AddWithValue("@LNAME", LastNamePersonRep);
                                commnd.Parameters.AddWithValue("@FNAME", FirstNamePersonRep);
                                commnd.Parameters.AddWithValue("@MNAME", MiddleNamePersonRep);
                                dataReader = commnd.ExecuteReader();
                                while (dataReader.Read())
                                { personRepIDContact = dataReader.GetInt64(0); }
                                dataReader.Close();
                            }
                            using (commnd = new SqlCommand("INSERT INTO tbPersonRepContact VALUES(@refID, @ConNum, @mobNum, @homeNum)", dbconn_main))
                            {
                                commnd.Parameters.Add("@refID", SqlDbType.BigInt).Value = personRepIDContact;
                                commnd.Parameters.AddWithValue("@ConNum", conNumPrep);
                                commnd.Parameters.AddWithValue("@mobNum", mobNumPrep);
                                commnd.Parameters.AddWithValue("@homeNum", homNumPrep);
                                commnd.ExecuteNonQuery();
                            }
                            long personRepIDCases = personRepIDContact;
                            if (LastNamePersonRep == "N/A" && FirstNamePersonRep == "N/A" && MiddleNamePersonRep == "N/A")
                            {
                                using (commnd = new SqlCommand("UPDATE tbCases SET personRepID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                {
                                    commnd.Parameters.AddWithValue("@ID", 0);
                                    commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                    commnd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                using (commnd = new SqlCommand("UPDATE tbCases SET personRepID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                {
                                    commnd.Parameters.AddWithValue("@ID", personRepIDCases);
                                    commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                    commnd.ExecuteNonQuery();
                                }
                            }
                            #endregion

                            MessageBox.Show("Database updated!\n\n\nPerson Reporting Information was saved successfully into the database.", "[*] INFORMATION DIALOG [*]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        #endregion

                        int countVictim = 0;
                        #region Victim Saving

                        string LastNameVic = "N/A";
                        string FirstNameVic = "N/A";
                        string MiddleNameVic = "N/A";
                        string NickNameVic = "N/A";
                        if (!string.IsNullOrWhiteSpace(tbLNvictimDat.Text))
                        { LastNameVic = tbLNvictimDat.Text; }
                        if (!string.IsNullOrWhiteSpace(tbFNvictimDat.Text))
                        { FirstNameVic = tbFNvictimDat.Text; }
                        if (!string.IsNullOrWhiteSpace(tbMNvictimDat.Text))
                        { MiddleNameVic = tbMNvictimDat.Text; }
                        if (!string.IsNullOrWhiteSpace(tbNNvictimDat.Text))
                        { NickNameVic = tbNNvictimDat.Text; }


                        using (commnd = new SqlCommand("SELECT VictimID FROM tbVictim WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@LNAME", tbLNvictimDat.Text);
                            commnd.Parameters.AddWithValue("@FNAME", tbFNvictimDat.Text);
                            commnd.Parameters.AddWithValue("@MNAME", tbMNvictimDat.Text);
                            dataReader = commnd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                victimID = dataReader.GetInt64(0);
                                countVictim++;
                            }
                            dataReader.Close();
                        }

                        if (victimID > 0)
                        {
                            long vID = 0;
                            if (MessageBox.Show("There are already (" + countVictim.ToString() + ") Victim(s) with the details:\n\n Last Name: " + tbLNvictimDat.Text + "\nFirst Name: " + tbFNvictimDat.Text + "\nMiddle Name: " + tbMNvictimDat.Text + " \n\nThe info from the database will be inserted.\n\n[*]NOTE:You can edit the case in the Case panel on the Selection Menu.", "[INFO]", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                using (commnd = new SqlCommand("SELECT MAX(VictimID) FROM tbVictim WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                                {
                                    commnd.Parameters.Add("@LNAME", SqlDbType.VarChar).Value = tbLNvictimDat.Text;
                                    commnd.Parameters.Add("@FNAME", SqlDbType.VarChar).Value = tbFNvictimDat.Text;
                                    commnd.Parameters.Add("@MNAME", SqlDbType.VarChar).Value = tbMNvictimDat.Text;
                                    dataReader = commnd.ExecuteReader();
                                    while (dataReader.Read())
                                    { vID = dataReader.GetInt64(0); }
                                    dataReader.Close();
                                }
                                if (LastNameVic == "N/A" && FirstNameVic == "N/A" && MiddleNameVic == "N/A")
                                {
                                    using (commnd = new SqlCommand("UPDATE tbCases SET VictimID = @ID WHERE caseNo = @caseNum", dbconn_main))
                                    {
                                        commnd.Parameters.AddWithValue("@ID", 0);
                                        commnd.Parameters.AddWithValue("@caseNum", CASE_NUMBER);
                                        commnd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    using (commnd = new SqlCommand("UPDATE tbCases SET VictimID = @ID WHERE caseNo = @caseNum", dbconn_main))
                                    {
                                        commnd.Parameters.AddWithValue("@ID", vID);
                                        commnd.Parameters.AddWithValue("@caseNum", CASE_NUMBER);
                                        commnd.ExecuteNonQuery();
                                    }
                                }
                                MessageBox.Show("Database updated!\n\n\nVictim Information was successfully saved into the database.", "[*] INFORMATION DIALOG [*]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            #region Victim Data



                            DateTime victimDOB = new DateTime(1950, 1, 1);
                            victimAge = 0;
                            string genderVictim = "N/A";
                            string curAddVictim = "N/A";

                            if (!string.IsNullOrWhiteSpace(tbAgeVictimDat.Text))
                            { victimDOB = dtpBirthVictimDat.Value; try { victimAge = Convert.ToInt32(tbAgeVictimDat.Text); } catch (Exception ex) { MessageBox.Show(ex.ToString(), "[OOps!]", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
                            if (!string.IsNullOrWhiteSpace(cmbGnderVictimDat.Text))
                            { genderVictim = cmbGnderVictimDat.Text; }
                            if (!string.IsNullOrWhiteSpace(rchCurAddressVictimDat.Text))
                            { curAddVictim = rchCurAddressVictimDat.Text; }

                            #region Victim's Father Info

                            string vicFatherName = "N/A";
                            string vicFathOccup = "N/A";
                            vicFathNum = 0;

                            if (!string.IsNullOrWhiteSpace(tbFathVictimDat.Text))
                            { vicFatherName = tbFathVictimDat.Text; }
                            if (!string.IsNullOrWhiteSpace(cmbFathOccupVicDat.Text))
                            { vicFathOccup = cmbFathOccupVicDat.Text; }
                            if (!string.IsNullOrWhiteSpace(tbFathNumVicDat.Text))
                            { try { vicFathNum = Convert.ToInt64(tbFathNumVicDat.Text); } catch (Exception ex) { MessageBox.Show(ex.ToString(), "[OOPS!]", MessageBoxButtons.OK, MessageBoxIcon.Error); } }


                            #endregion

                            #region Victim's Mother Info

                            string vicMotherName = "N/A";
                            string vicMothOccup = "N/A";
                            vicMothNum = 0;

                            if (!string.IsNullOrWhiteSpace(tbMothVicDat.Text))
                            { vicMotherName = tbMothVicDat.Text; }
                            if (!string.IsNullOrWhiteSpace(cmbMothOccupVicDat.Text))
                            { vicMothOccup = cmbMothOccupVicDat.Text; }
                            if (!string.IsNullOrWhiteSpace(tbMothNumVicDat.Text))
                            { try { vicMothNum = Convert.ToInt64(tbMothNumVicDat.Text); } catch (Exception ex) { MessageBox.Show(ex.ToString(), "[OOps!]", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

                            string vicHEA = "N/A";
                            string vicSchoolAdd = "N/A";
                            string vicPresentedID = "N/A";
                            string vicRemarks = "N/A";
                            string vicPlaceBirth = "N/A";
                            if (!string.IsNullOrWhiteSpace(cmbHEAvicDat.Text))
                            { vicHEA = cmbHEAvicDat.Text; }
                            if (!string.IsNullOrWhiteSpace(rchSchoolAddVicDat.Text))
                            { vicSchoolAdd = rchSchoolAddVicDat.Text; }
                            if (!string.IsNullOrWhiteSpace(cmbIDprVicDat.Text))
                            { vicPresentedID = cmbIDprVicDat.Text; }
                            if (!string.IsNullOrWhiteSpace(birthPlaceVicrch.Text))
                            { vicPlaceBirth = birthPlaceVicrch.Text; }
                            #endregion

                            Image img = Properties.Resources.unkown;
                            byte[] arr;
                            ImageConverter converter = new ImageConverter();
                            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                            using (commnd = new SqlCommand("INSERT INTO tbVictim VALUES(@LNAME, @FNAME, @MNAME, @age, @gender, @nickName, @dtbirth, @birthPlace, @curAdd, @addOn, @img)", dbconn_main))
                            {
                                commnd.Parameters.AddWithValue("@LNAME", LastNameVic);
                                commnd.Parameters.AddWithValue("@FNAME", FirstNameVic);
                                commnd.Parameters.AddWithValue("@MNAME", MiddleNameVic);
                                commnd.Parameters.AddWithValue("@age", victimAge);
                                commnd.Parameters.AddWithValue("@gender", genderVictim);
                                commnd.Parameters.AddWithValue("@nickName", NickNameVic);
                                commnd.Parameters.AddWithValue("@dtbirth", victimDOB);
                                commnd.Parameters.AddWithValue("@birthPlace", vicPlaceBirth);
                                commnd.Parameters.AddWithValue("@curAdd", curAddVictim);
                                commnd.Parameters.AddWithValue("@addOn", DateTime.Now);
                                commnd.Parameters.Add("@img", SqlDbType.Image).Value = arr;
                                commnd.ExecuteNonQuery();
                            }

                            long vicFKID = 0;
                            using (commnd = new SqlCommand("SELECT MAX(VictimID) FROM tbVictim WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                            {
                                commnd.Parameters.AddWithValue("@LNAME", LastNameVic);
                                commnd.Parameters.AddWithValue("@FNAME", FirstNameVic);
                                commnd.Parameters.AddWithValue("@MNAME", MiddleNameVic);
                                dataReader = commnd.ExecuteReader();
                                while (dataReader.Read())
                                { vicFKID = dataReader.GetInt64(0); }
                                dataReader.Close();
                            }

                            using (commnd = new SqlCommand("INSERT INTO tbVictimDetails VALUES(@vID, @fathName, @fathOcc, @fathNum, @mothName, @mothOcc, @mothNum, @hea, @schoolAdd, @prsentedID, @remarks)", dbconn_main))
                            {
                                commnd.Parameters.AddWithValue("@vID", vicFKID);
                                commnd.Parameters.AddWithValue("@fathName", vicFatherName);
                                commnd.Parameters.AddWithValue("@fathOcc", vicFathOccup);
                                commnd.Parameters.AddWithValue("@fathNum", vicFathNum);
                                commnd.Parameters.AddWithValue("@mothName", vicMotherName);
                                commnd.Parameters.AddWithValue("@mothOcc", vicMothOccup);
                                commnd.Parameters.AddWithValue("@mothNum", vicMothNum);
                                commnd.Parameters.AddWithValue("@hea", vicHEA);
                                commnd.Parameters.AddWithValue("@schoolAdd", vicSchoolAdd);
                                commnd.Parameters.AddWithValue("@prsentedID", vicPresentedID);
                                commnd.Parameters.AddWithValue("@remarks", vicRemarks);
                                commnd.ExecuteNonQuery();
                            }
                            #endregion

                            if (LastNameVic == "N/A" && FirstNameVic == "N/A" && MiddleNameVic == "N/A")
                            {
                                using (commnd = new SqlCommand("UPDATE tbCases SET VictimID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                {
                                    commnd.Parameters.AddWithValue("@ID", 0);
                                    commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                    commnd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                using (commnd = new SqlCommand("UPDATE tbCases SET VictimID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                {
                                    commnd.Parameters.AddWithValue("@ID", vicFKID);
                                    commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                    commnd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Database updated!\n\n\nVictim Information was successfully saved into the database.", "[*] INFORMATION DIALOG [*]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        #endregion

                        int countPerpetrator = 0;
                        #region Perpetrator Saving

                        string LastNamePerpetrator = "N/A";
                        string FirstNamePerpetrator = "N/A";
                        string MiddleNamePerpetrator = "N/A";
                        string NickNamePerpetrator = "N/A";

                        if (!string.IsNullOrWhiteSpace(tbLNPerpetDat.Text))
                        { LastNamePerpetrator = tbLNPerpetDat.Text; }
                        if (!string.IsNullOrWhiteSpace(tbFNPerpetDat.Text))
                        { FirstNamePerpetrator = tbFNPerpetDat.Text; }
                        if (!string.IsNullOrWhiteSpace(tbMNPerpetDat.Text))
                        { MiddleNamePerpetrator = tbMNPerpetDat.Text; }
                        if (!string.IsNullOrWhiteSpace(tbNNPerpetDat.Text))
                        { NickNamePerpetrator = tbNNPerpetDat.Text; }

                        using (commnd = new SqlCommand("SELECT PerpetratorID FROM tbPerpetrators WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@LNAME", tbLNPerpetDat.Text);
                            commnd.Parameters.AddWithValue("@FNAME", tbFNPerpetDat.Text);
                            commnd.Parameters.AddWithValue("@MNAME", tbMNPerpetDat.Text);
                            dataReader = commnd.ExecuteReader();
                            while (dataReader.Read())
                            { perpetratorID = dataReader.GetInt64(0); countPerpetrator++; }
                            dataReader.Close();
                        }
                        if (perpetratorID > 0)
                        {
                            long perpetID = 0;
                            if (MessageBox.Show("There are already (" + countPerpetrator.ToString() + ") Perpetrator(s) with the details:\n\n LAST NAME: " + tbLNPerpetDat.Text + "\nFIRST NAME: " + tbFNPerpetDat.Text + "\nMIDDLE NAME: " + tbMNPerpetDat.Text + " \n\nThe info from the database will be inserted.\n\n[*]NOTE:You can edit the case in the Case panel on the Selection Menu.", "[INFO]", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                using (commnd = new SqlCommand("SELECT PerpetratorID FROM tbPerpetrators WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                                {
                                    commnd.Parameters.Add("@LNAME", SqlDbType.VarChar).Value = tbLNPerpetDat.Text;
                                    commnd.Parameters.Add("@FNAME", SqlDbType.VarChar).Value = tbFNPerpetDat.Text;
                                    commnd.Parameters.Add("@MNAME", SqlDbType.VarChar).Value = tbMNPerpetDat.Text;
                                    dataReader = commnd.ExecuteReader();
                                    while (dataReader.Read())
                                    { perpetID = dataReader.GetInt64(0); }
                                    dataReader.Close();
                                }
                                if (LastNamePerpetrator == "N/A" && FirstNamePerpetrator == "N/A" && MiddleNamePerpetrator == "N/A")
                                {
                                    using (commnd = new SqlCommand("UPDATE tbCases SET PerpetratorID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                    {
                                        commnd.Parameters.AddWithValue("@ID", 0);
                                        commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                        commnd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    using (commnd = new SqlCommand("UPDATE tbCases SET PerpetratorID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                    {
                                        commnd.Parameters.AddWithValue("@ID", perpetID);
                                        commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                        commnd.ExecuteNonQuery();
                                    }
                                }
                                MessageBox.Show("DATABASE UPDATED!\n\n\nPerpetrator Information was saved successfully into the database.", "[*] INFORMATION DIALOG [*]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {

                            #region Perpetrator's Data


                            DateTime perpetDOB = new DateTime(1900, 1, 1);
                            string perpetOccup = "N/A";
                            string genderPerpet = "N/A";
                            string idPrePerpet = "N/A";
                            agePerpet = 0;
                            perpetContNum = 0;

                            if (!string.IsNullOrWhiteSpace(tbAgePerpetDat.Text))
                            { perpetDOB = dtpBirthPerpetDat.Value; try { agePerpet = Convert.ToInt32(tbAgePerpetDat.Text); } catch (Exception ex) { MessageBox.Show(ex.ToString(), "[OOPS!]", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
                            if (!string.IsNullOrWhiteSpace(cmbOccupPerpetDat.Text))
                            { perpetOccup = cmbOccupPerpetDat.Text; }
                            if (!string.IsNullOrWhiteSpace(cmbGenderPerpetDat.Text))
                            { genderPerpet = cmbGenderPerpetDat.Text; }
                            if (!string.IsNullOrWhiteSpace(cmbIDprPerpetDat.Text))
                            { idPrePerpet = cmbIDprPerpetDat.Text; }
                            if (!string.IsNullOrWhiteSpace(tbContNumPerpet.Text))
                            { try { perpetContNum = Convert.ToInt64(tbContNumPerpet.Text); } catch (Exception ex) { MessageBox.Show(ex.ToString(), "[OOPS!]", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

                            string underInfluence = "N/A";
                            string bothDefInf = "";
                            string prevCrimRec = "None";
                            string perpetRemarks = "N/A";
                            if (chkAlchol.Checked == true)
                            {
                                bothDefInf = chkAlchol.Text + ", ";
                            }
                            else if (chkDrugs.Checked == true)
                            {
                                bothDefInf = chkDrugs.Text + ", ";
                            }
                            else if (chkDrugs.Checked == true && chkAlchol.Checked == true)
                            {
                                bothDefInf = chkAlchol.Text + ", " + chkDrugs.Text + ", ";
                            }

                            if (!string.IsNullOrWhiteSpace(rchOtherInfluence.Text))
                            { underInfluence = bothDefInf + rchOtherInfluence.Text; }

                            if (rdbYesCrim.Checked == true)
                            { if (!string.IsNullOrWhiteSpace(rchPrevCrim.Text)) { prevCrimRec = rchPrevCrim.Text; } }
                            else if (rdbNoCrim.Checked == true)
                            { prevCrimRec = "None"; }

                            if (!string.IsNullOrWhiteSpace(rchRemPerpetDat.Text))
                            { perpetRemarks = rchRemPerpetDat.Text; }

                            using (commnd = new SqlCommand("INSERT INTO tbPerpetrators VALUES(@LNAME, @FNAME, @MNAME, @age, @dob, @gender, @nckName, @occup, @contactNum, @presID, @UIO, @prevCrim, @prevCase, @rem, @addedOn)", dbconn_main))
                            {
                                commnd.Parameters.AddWithValue("@LNAME", LastNamePerpetrator);
                                commnd.Parameters.AddWithValue("@FNAME", FirstNamePerpetrator);
                                commnd.Parameters.AddWithValue("@MNAME", MiddleNamePerpetrator);
                                commnd.Parameters.AddWithValue("@age", agePerpet);
                                commnd.Parameters.AddWithValue("@dob", perpetDOB);
                                commnd.Parameters.AddWithValue("@gender", genderPerpet);
                                commnd.Parameters.AddWithValue("@nckName", NickNamePerpetrator);
                                commnd.Parameters.AddWithValue("@occup", perpetOccup);
                                commnd.Parameters.AddWithValue("@contactNum", perpetContNum);
                                commnd.Parameters.AddWithValue("@presID", idPrePerpet);
                                commnd.Parameters.AddWithValue("@UIO", underInfluence);
                                commnd.Parameters.AddWithValue("@prevCrim", prevCrimRec);
                                commnd.Parameters.AddWithValue("@prevCase", "NONE");
                                commnd.Parameters.AddWithValue("@rem", perpetRemarks);
                                commnd.Parameters.AddWithValue("@addedOn", DateTime.Now);
                                commnd.ExecuteNonQuery();
                            }
                            long perpetID = 0;
                            using (commnd = new SqlCommand("SELECT IDENT_CURRENT('tbPerpetrators')", dbconn_main))
                            {
                                dataReader = commnd.ExecuteReader();
                                while (dataReader.Read())
                                { perpetID = Convert.ToInt64(dataReader[0]); }
                                dataReader.Close();
                            }
                            #endregion

                            if (LastNamePerpetrator == "N/A" && FirstNamePerpetrator == "N/A" && MiddleNamePerpetrator == "N/A")
                            {

                                using (commnd = new SqlCommand("UPDATE tbCases SET PerpetratorID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                {
                                    commnd.Parameters.AddWithValue("@ID", 0);
                                    commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                    commnd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                using (commnd = new SqlCommand("UPDATE tbCases SET PerpetratorID = @ID WHERE caseNo = @CASE_NUM", dbconn_main))
                                {
                                    commnd.Parameters.AddWithValue("@ID", perpetID);
                                    commnd.Parameters.AddWithValue("@CASE_NUM", CASE_NUMBER);
                                    commnd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("DATABASE UPDATED!\n\n\nPerpetrator Information was saved successfully into the database.", "[*] INFORMATION DIALOG [*]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        #endregion

                        #region Case Narrative Saving
                        string what = "N/A";
                        string who = "N/A";
                        string when = "N/A";
                        string where = "N/A";
                        string why = "N/A";
                        string how = "N/A";
                        string callTaker = "N/A";
                        string PNP = "N/A";
                        string socialWork = "N/A";
                        string barangayRep = "N/A";
                        string policeRep = "N/A";
                        string reportingPerson = "N/A";
                        string centHead = "N/A";
                        string prepBy = "N/A";

                        if (!string.IsNullOrWhiteSpace(cmbWhat.Text))
                        { what = cmbWhat.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbWho.Text))
                        { who = cmbWho.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbWhen.Text))
                        { when = cmbWhen.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbWhere.Text))
                        { where = cmbWhere.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbWhy.Text))
                        { why = cmbWhy.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbHow.Text))
                        { how = cmbHow.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbCT.Text))
                        { callTaker = cmbCT.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbPNP.Text))
                        { PNP = cmbPNP.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbSW.Text))
                        { socialWork = cmbSW.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbBarRep.Text))
                        { barangayRep = cmbBarRep.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbPolRep.Text))
                        { policeRep = cmbPolRep.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbperRep.Text))
                        {
                            if ((!string.IsNullOrWhiteSpace(tbLNpersonrep.Text) || tbLNpersonrep.Text == "N/A") && (!string.IsNullOrWhiteSpace(tbFNpersonrep.Text) || tbFNpersonrep.Text == "N/A") && (!string.IsNullOrWhiteSpace(tbMNpersonrep.Text) || tbMNpersonrep.Text == "N/A"))
                            { reportingPerson = tbLNpersonrep.Text + ", " + tbFNpersonrep.Text + " " + tbMNpersonrep.Text; }
                            else { reportingPerson = cmbperRep.Text; }
                        }
                        else
                        {
                            if ((!string.IsNullOrWhiteSpace(tbLNpersonrep.Text) || tbLNpersonrep.Text == "N/A") && (!string.IsNullOrWhiteSpace(tbFNpersonrep.Text) || tbFNpersonrep.Text == "N/A") && (!string.IsNullOrWhiteSpace(tbMNpersonrep.Text) || tbMNpersonrep.Text == "N/A"))
                            { reportingPerson = tbLNpersonrep.Text + ", " + tbFNpersonrep.Text + " " + tbMNpersonrep.Text; }
                        }
                        if (!string.IsNullOrWhiteSpace(cmbCentHead.Text))
                        { centHead = cmbCentHead.Text; }
                        if (!string.IsNullOrWhiteSpace(cmbPrepBy.Text))
                        { prepBy = cmbPrepBy.Text; }
                        try
                        {
                            using (commnd = new SqlCommand("insertNarrative", dbconn_main))
                            {
                                commnd.CommandType = CommandType.StoredProcedure;
                                commnd.Parameters.AddWithValue("@caseNum", CASE_NUMBER);
                                commnd.Parameters.AddWithValue("@what", what);
                                commnd.Parameters.AddWithValue("@who", who);
                                commnd.Parameters.AddWithValue("@when", when);
                                commnd.Parameters.AddWithValue("@where", where);
                                commnd.Parameters.AddWithValue("@why", why);
                                commnd.Parameters.AddWithValue("@how", how);
                                commnd.Parameters.AddWithValue("@callTaker", callTaker);
                                commnd.Parameters.AddWithValue("@socialWorker", socialWork);
                                commnd.Parameters.AddWithValue("@pnp", PNP);
                                commnd.Parameters.AddWithValue("@policeRep", policeRep);
                                commnd.Parameters.AddWithValue("@barangayRep", barangayRep);
                                commnd.Parameters.AddWithValue("@preparedBy", prepBy);
                                commnd.Parameters.AddWithValue("@apprveBy", "Ate JEAN");
                                commnd.Parameters.AddWithValue("@apprveStat", "APPROVED");
                                commnd.ExecuteNonQuery();
                                saveNarrative = true;
                            }
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString(), "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        #endregion


                        #region Other Added
                        string presentProblem = "N/A";
                        string caseBackground = "N/A";
                        string initialAssesment = "N/A";
                        string actionTaken = "N/A";
                        string servicesExtended = "N/A";
                        string processRecording = "N/A";

                        if(!string.IsNullOrWhiteSpace(presentProblemrchtxt.Text))
                        { presentProblem = presentProblemrchtxt.Text; }
                        if (!string.IsNullOrWhiteSpace(caseBackgroundrchtxt.Text))
                        { caseBackground = caseBackgroundrchtxt.Text; }
                        if (!string.IsNullOrWhiteSpace(initialAssesmentrchtxt.Text))
                        { initialAssesment = initialAssesmentrchtxt.Text; }
                        if (!string.IsNullOrWhiteSpace(actionsTakenrchtxt.Text))
                        { actionTaken = actionsTakenrchtxt.Text; }
                        if (!string.IsNullOrWhiteSpace(servicesExtendedrchtxt.Text))
                        { servicesExtended = servicesExtendedrchtxt.Text; }
                        if (!string.IsNullOrWhiteSpace(processRecordingrchtxt.Text))
                        { processRecording = processRecordingrchtxt.Text; }


                        using(commnd = new SqlCommand("UPDATE tbCases SET presentProblem = @problem, caseBackground = @caseBack, initialAssesment = @intAsses, actionTaken = @actTook, servicesExtended = @servExt, procRecording = @prcRec WHERE caseNo = @CASE_NUMBER", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@CASE_NUMBER", CASE_NUMBER);
                            commnd.Parameters.AddWithValue("@problem", presentProblem);
                            commnd.Parameters.AddWithValue("@caseBack", caseBackground);
                            commnd.Parameters.AddWithValue("@intAsses", initialAssesment);
                            commnd.Parameters.AddWithValue("@actTook", actionTaken);
                            commnd.Parameters.AddWithValue("@servExt", servicesExtended);
                            commnd.Parameters.AddWithValue("@prcRec", processRecording);
                            commnd.ExecuteNonQuery();
                        }


                        #endregion
                        MessageBox.Show("Case was added successfully!\n\nCase form will be dispose.", "[*] CASE SAVED [*]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        selectionFrm newFrm = new selectionFrm();
                        newFrm.passID = usrID;
                        newFrm.Show();
                        this.Dispose(false);
                        garCol.FlushMemory();

                    }
                }
                else
                {

                }

                if (saveNarrative)
                {

                }
            }

           }
        int personRepAge = 0;
        bool isValidAge = false;
        string oldTextAgepr = string.Empty;
        private void tbAgePersonrep_Leave(object sender, EventArgs e)
        {
            personRepAge = 0;
            isValidAge = false;
            isValidAge = Int32.TryParse(tbAgePersonrep.Text, out personRepAge);
            if (!string.IsNullOrWhiteSpace(tbAgePersonrep.Text))
            {
                if (isValidAge)
                {
                    oldTextAgepr = tbAgePersonrep.Text;
                    tbAgePersonrep.Text = oldTextAgepr;

                    tbAgePersonrep.BackColor = System.Drawing.Color.White;
                    tbAgePersonrep.ForeColor = System.Drawing.Color.Black;

                    int age = 0;
                    try { age = Convert.ToInt32(tbAgePersonrep.Text); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(),"[Oops!]",MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    DateTime year = new DateTime(2001, 1, 1);
                    try
                    {
                        if (age > 0)
                        {
                            age = (Convert.ToInt32(DateTime.Now.Year) - age);
                            year = new DateTime(age, 1, 1);
                            dtpBirthPersonrep.Value = year;
                        }
                        else
                        {
                            MessageBox.Show("Invalid age value. Input should be greater than 0.", "[OOPS!]", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    catch (Exception ex) { dtpBirthPerpetDat.ResetText(); MessageBox.Show("[VALUE EXCEEDED]" + ex.ToString(), "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    tbAgePersonrep.Text = oldTextAgepr;
                    tbAgePersonrep.BackColor = System.Drawing.Color.Red;
                    tbAgePersonrep.ForeColor = System.Drawing.Color.White;
                }
                tbAgePersonrep.SelectionStart = tbAgePersonrep.Text.Length;
            }
            else
            {

                isValidAge = false;
                oldTextAgepr = tbAgePersonrep.Text;
                tbAgePersonrep.Text = oldTextAgepr;

                tbAgePersonrep.BackColor = System.Drawing.Color.White;
                tbAgePersonrep.ForeColor = System.Drawing.Color.Black;

            }
        }

        private void tbAgePersonrep_TextChanged(object sender, EventArgs e)
        {
            if (tbAgePersonrep.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextAgepr = tbAgePersonrep.Text;
                tbAgePersonrep.Text = oldTextAgepr;

                tbAgePersonrep.BackColor = System.Drawing.Color.White;
                tbAgePersonrep.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbAgePersonrep.Text = oldTextAgepr;
                tbAgePersonrep.BackColor = System.Drawing.Color.Red;
                tbAgePersonrep.ForeColor = System.Drawing.Color.White;
            }
            tbAgePersonrep.SelectionStart = tbAgePersonrep.Text.Length;
        }


        private void dtpBirthPersonrep_ValueChanged(object sender, EventArgs e)
        {
            int Age = (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dtpBirthPersonrep.Value.Year));

            if (Age < 0)
            { tbAgePersonrep.Text = (0).ToString(); }
            else
            { tbAgePersonrep.Text = Age.ToString(); }
        }

        #region Border Drag
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
        #endregion
        #region Person Reporting Contacts TxtChange&Leave
        string oldTextcnp = string.Empty;
        private void tbContNumPersonrep_TextChanged(object sender, EventArgs e)
        {
            
            if (tbContNumPersonrep.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextcnp = tbContNumPersonrep.Text;
                tbContNumPersonrep.Text = oldTextcnp;

                tbContNumPersonrep.BackColor = System.Drawing.Color.White;
                tbContNumPersonrep.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbContNumPersonrep.Text = oldTextcnp;
                tbContNumPersonrep.BackColor = System.Drawing.Color.Red;
                tbContNumPersonrep.ForeColor = System.Drawing.Color.White;
            }
            tbContNumPersonrep.SelectionStart = tbContNumPersonrep.Text.Length;
        }

        private void tbContNumPersonrep_Leave(object sender, EventArgs e)
        {
            bool isValidContNum = Int64.TryParse(tbContNumPersonrep.Text, out conNumPrep);
            if (!string.IsNullOrWhiteSpace(tbContNumPersonrep.Text))
            {
                if (isValidContNum)
                {
                    oldTextcnp = tbContNumPersonrep.Text;
                    tbContNumPersonrep.Text = oldTextcnp;

                    tbContNumPersonrep.BackColor = System.Drawing.Color.White;
                    tbContNumPersonrep.ForeColor = System.Drawing.Color.Black;
                  
                }
                else
                {
                    tbContNumPersonrep.Text = oldTextcnp;
                    tbContNumPersonrep.BackColor = System.Drawing.Color.Red;
                    tbContNumPersonrep.ForeColor = System.Drawing.Color.White;
                }
                tbContNumPersonrep.SelectionStart = tbContNumPersonrep.Text.Length;
            }
            else
            {
                tbContNumPersonrep_TextChanged(sender, e);
                validateRepDat++;
            }
        }
        string oldTextmnp = string.Empty;

        private void tbMobNumPersonrep_TextChanged(object sender, EventArgs e)
        {
            if (tbMobNumPersonrep.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextmnp = tbMobNumPersonrep.Text;
                tbMobNumPersonrep.Text = oldTextmnp;

                tbMobNumPersonrep.BackColor = System.Drawing.Color.White;
                tbMobNumPersonrep.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbMobNumPersonrep.Text = oldTextmnp;
                tbMobNumPersonrep.BackColor = System.Drawing.Color.Red;
                tbMobNumPersonrep.ForeColor = System.Drawing.Color.White;
            }
            tbMobNumPersonrep.SelectionStart = tbMobNumPersonrep.Text.Length;
        }

        private void tbMobNumPersonrep_Leave(object sender, EventArgs e)
        {
             bool isValidMobNum = Int64.TryParse(tbMobNumPersonrep.Text, out mobNumPrep);
            if (!string.IsNullOrWhiteSpace(tbMobNumPersonrep.Text))
            {
                if (isValidMobNum)
                {
                    oldTextmnp = tbMobNumPersonrep.Text;
                    tbMobNumPersonrep.Text = oldTextmnp;

                    tbMobNumPersonrep.BackColor = System.Drawing.Color.White;
                    tbMobNumPersonrep.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    tbMobNumPersonrep.Text = oldTextmnp;
                    tbMobNumPersonrep.BackColor = System.Drawing.Color.Red;
                    tbMobNumPersonrep.ForeColor = System.Drawing.Color.White;
                }
                tbMobNumPersonrep.SelectionStart = tbMobNumPersonrep.Text.Length;
            }
            else
            {
                tbMobNumPersonrep_TextChanged(sender, e);
                validateRepDat++;
            }
        }
        string oldTexthnp = string.Empty;

        private void tbHmePnumPersonrep_TextChanged(object sender, EventArgs e)
        {
            if (tbHmePnumPersonrep.Text.All(chr => char.IsDigit(chr)))
            {
                oldTexthnp = tbHmePnumPersonrep.Text;
                tbHmePnumPersonrep.Text = oldTexthnp;

                tbHmePnumPersonrep.BackColor = System.Drawing.Color.White;
                tbHmePnumPersonrep.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbHmePnumPersonrep.Text = oldTexthnp;
                tbHmePnumPersonrep.BackColor = System.Drawing.Color.Red;
                tbHmePnumPersonrep.ForeColor = System.Drawing.Color.White;
            }
            tbHmePnumPersonrep.SelectionStart = tbHmePnumPersonrep.Text.Length;
        }

        private void tbHmePnumPersonrep_Leave(object sender, EventArgs e)
        {
            bool isValidPnumNum = Int64.TryParse(tbHmePnumPersonrep.Text, out homNumPrep);
            if (!string.IsNullOrWhiteSpace(tbHmePnumPersonrep.Text))
            {
                if (isValidPnumNum)
                {
                    oldTexthnp = tbHmePnumPersonrep.Text;
                    tbHmePnumPersonrep.Text = oldTexthnp;

                    tbHmePnumPersonrep.BackColor = System.Drawing.Color.White;
                    tbHmePnumPersonrep.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    tbHmePnumPersonrep.Text = oldTexthnp;
                    tbHmePnumPersonrep.BackColor = System.Drawing.Color.Red;
                    tbHmePnumPersonrep.ForeColor = System.Drawing.Color.White;
                }
                tbHmePnumPersonrep.SelectionStart = tbHmePnumPersonrep.Text.Length;
            }
            else
            {
                tbHmePnumPersonrep_TextChanged(sender, e);
                validateRepDat++;
            }
        }
        #endregion


        private void dtpBirthVictimDat_ValueChanged(object sender, EventArgs e)
        {
            int Age = (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dtpBirthVictimDat.Value.Year));
            if (Age < 0)
            { tbAgeVictimDat.Text = (0).ToString(); }
            else
            { tbAgeVictimDat.Text = Age.ToString(); }
        }
        
        private void tbAgeVictimDat_TextChanged(object sender, EventArgs e)
        {
            if (tbAgeVictimDat.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextvicAge = tbAgeVictimDat.Text;
                tbAgeVictimDat.Text = oldTextvicAge;

                tbAgeVictimDat.BackColor = System.Drawing.Color.White;
                tbAgeVictimDat.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbAgeVictimDat.Text = oldTextvicAge;
                tbAgeVictimDat.BackColor = System.Drawing.Color.Red;
                tbAgeVictimDat.ForeColor = System.Drawing.Color.White;
            }
            tbAgeVictimDat.SelectionStart = tbAgeVictimDat.Text.Length;
        }
        string oldTextvicAge = string.Empty;
        private void tbAgeVictimDat_Leave(object sender, EventArgs e)
        {
            bool isValidVictimAge = Int32.TryParse(tbAgeVictimDat.Text, out victimAge);
            if (!string.IsNullOrWhiteSpace(tbAgeVictimDat.Text))
            {
                if (isValidVictimAge)
                {
                    oldTextvicAge = tbAgeVictimDat.Text;
                    tbAgeVictimDat.Text = oldTextvicAge;

                    tbAgeVictimDat.BackColor = System.Drawing.Color.White;
                    tbAgeVictimDat.ForeColor = System.Drawing.Color.Black;

                    int age = 0;
                    try { age = Convert.ToInt32(tbAgeVictimDat.Text); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    DateTime year = new DateTime(2001, 1, 1);
                    try
                    {
                        if(age > 0)
                        {
                            age = (Convert.ToInt32(DateTime.Now.Year) - age);
                            year = new DateTime(age, 1, 1);
                            dtpBirthVictimDat.Value = year; 
                        }
                        else
                        {
                            MessageBox.Show("Invalid age value. Input should be greater than 0.", "[OOPS!]", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    catch (Exception ex) { dtpBirthPerpetDat.ResetText(); MessageBox.Show("[VALUE EXCEEDED]\nValid value is between Max: (264) And Min: (1)\n\n[Error Details]\n" + ex.ToString(), "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Error); tbAgeVictimDat.Text = string.Empty; }
                }
                else
                {
                    tbAgeVictimDat.Text = oldTextvicAge;
                    tbAgeVictimDat.BackColor = System.Drawing.Color.Red;
                    tbAgeVictimDat.ForeColor = System.Drawing.Color.White;
                }
                tbAgeVictimDat.SelectionStart = tbAgeVictimDat.Text.Length;
            }
            else
            {
                tbAgeVictimDat_TextChanged(sender, e);
            }
        }
        string oldTextfnum = string.Empty;
        private void tbFathNumVicDat_TextChanged(object sender, EventArgs e)
        {
            if (tbFathNumVicDat.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextfnum = tbFathNumVicDat.Text;
                tbFathNumVicDat.Text = oldTextfnum;

                tbFathNumVicDat.BackColor = System.Drawing.Color.White;
                tbFathNumVicDat.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbFathNumVicDat.Text = oldTextfnum;
                tbFathNumVicDat.BackColor = System.Drawing.Color.Red;
                tbFathNumVicDat.ForeColor = System.Drawing.Color.White;
            }
            tbFathNumVicDat.SelectionStart = tbFathNumVicDat.Text.Length;
        }
        string oldTextmnum = string.Empty;
        private void tbMothNumVicDat_TextChanged(object sender, EventArgs e)
        {
            if (tbMothNumVicDat.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextmnum = tbMothNumVicDat.Text;
                tbMothNumVicDat.Text = oldTextmnum;

                tbMothNumVicDat.BackColor = System.Drawing.Color.White;
                tbMothNumVicDat.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbMothNumVicDat.Text = oldTextmnum;
                tbMothNumVicDat.BackColor = System.Drawing.Color.Red;
                tbMothNumVicDat.ForeColor = System.Drawing.Color.White;
            }
            tbMothNumVicDat.SelectionStart = tbMothNumVicDat.Text.Length;
        }

        private void tbFathNumVicDat_Leave(object sender, EventArgs e)
        {
            bool isValidFathNum = Int64.TryParse(tbFathNumVicDat.Text, out vicFathNum);
            if (!string.IsNullOrWhiteSpace(tbFathNumVicDat.Text))
            {
                if (isValidFathNum)
                {
                    oldTextfnum = tbFathNumVicDat.Text;
                    tbFathNumVicDat.Text = oldTextfnum;

                    tbFathNumVicDat.BackColor = System.Drawing.Color.White;
                    tbFathNumVicDat.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    tbFathNumVicDat.Text = oldTextfnum;
                    tbFathNumVicDat.BackColor = System.Drawing.Color.Red;
                    tbFathNumVicDat.ForeColor = System.Drawing.Color.White;
                }
                tbFathNumVicDat.SelectionStart = tbFathNumVicDat.Text.Length;
            }
            else
            {
                tbFathNumVicDat_TextChanged(sender, e);
            }
        }

        private void tbMothNumVicDat_Leave(object sender, EventArgs e)
        {
            bool isValidMothNum = Int64.TryParse(tbMothNumVicDat.Text, out vicMothNum);
            if (!string.IsNullOrWhiteSpace(tbMothNumVicDat.Text))
            {
                if (isValidMothNum)
                {
                    oldTextmnum = tbMothNumVicDat.Text;
                    tbMothNumVicDat.Text = oldTextmnum;

                    tbMothNumVicDat.BackColor = System.Drawing.Color.White;
                    tbMothNumVicDat.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    tbMothNumVicDat.Text = oldTextmnum;
                    tbMothNumVicDat.BackColor = System.Drawing.Color.Red;
                    tbMothNumVicDat.ForeColor = System.Drawing.Color.White;
                }
                tbMothNumVicDat.SelectionStart = tbMothNumVicDat.Text.Length;
            }
            else
            {
                tbMothNumVicDat_TextChanged(sender, e);
            }
        }
        string oldTextperpetAge = string.Empty;
        private void tbAgePerpetDat_TextChanged(object sender, EventArgs e)
        {
            if (tbAgePerpetDat.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextperpetAge = tbAgePerpetDat.Text;
                tbAgePerpetDat.Text = oldTextperpetAge;

                tbAgePerpetDat.BackColor = System.Drawing.Color.White;
                tbAgePerpetDat.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbAgePerpetDat.Text = oldTextperpetAge;
                tbAgePerpetDat.BackColor = System.Drawing.Color.Red;
                tbAgePerpetDat.ForeColor = System.Drawing.Color.White;
            }
            tbAgePerpetDat.SelectionStart = tbAgePerpetDat.Text.Length;
        }

        private void tbAgePerpetDat_Leave(object sender, EventArgs e)
        {
            bool isValidPerpetAge = Int32.TryParse(tbAgePerpetDat.Text, out victimAge);
            if (!string.IsNullOrWhiteSpace(tbAgePerpetDat.Text))
            {
                if (isValidPerpetAge)
                {
                    oldTextperpetAge = tbAgePerpetDat.Text;
                    tbAgePerpetDat.Text = oldTextperpetAge;

                    tbAgePerpetDat.BackColor = System.Drawing.Color.White;
                    tbAgePerpetDat.ForeColor = System.Drawing.Color.Black;

                    int age = 0;
                    try { age = Convert.ToInt32(tbAgePerpetDat.Text); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    DateTime year = new DateTime(2001, 1, 1);
                    age = (Convert.ToInt32(DateTime.Now.Year) - age);
                    try
                    {
                        year = new DateTime(age, 1, 1);
                        dtpBirthPerpetDat.Value = year;
                    }
                    catch (Exception ex) { dtpBirthPerpetDat.ResetText(); MessageBox.Show(ex.ToString(), "[Oops!]", MessageBoxButtons.OK, MessageBoxIcon.Error); tbAgePerpetDat.Text = string.Empty; }
                }
                else
                {
                    tbAgePerpetDat.Text = oldTextperpetAge;
                    tbAgePerpetDat.BackColor = System.Drawing.Color.Red;
                    tbAgePerpetDat.ForeColor = System.Drawing.Color.White;
                }
                tbAgePerpetDat.SelectionStart = tbAgePerpetDat.Text.Length;
            }
            else
            {
                tbAgePerpetDat_TextChanged(sender, e);
            }
        }

        private void chkOtherInfluence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtherInfluence.Checked == true)
            { rchOtherInfluence.Enabled = true; }
            else
            { rchOtherInfluence.Enabled = false; }
        }

        private void findPrevCasebt_Click(object sender, EventArgs e)
        {
            long perpetratorID = 0;
            int availableToSearch = 0;
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                using(commnd = new SqlCommand("SELECT PerpetratorID FROM tbPerpetrators WHERE LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@LNAME", tbLNPerpetDat.Text);
                    commnd.Parameters.AddWithValue("@FNAME", tbFNPerpetDat.Text);
                    commnd.Parameters.AddWithValue("@MNAME", tbMNPerpetDat.Text);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        perpetratorID = dataReader.GetInt64(0);
                        availableToSearch++;
                    }
                    dataReader.Close();
                }
                int chkWithCase = 0;
                if (availableToSearch > 0)
                {
                    string prevCrimst = "None";
                    int chkPrevCrim = 0;
                    using (commnd = new SqlCommand("SELECT PrevCrimRec FROM tbPerpetrators WHERE PerpetratorID = @ID AND PrevCrimRec != 'None'", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@ID", perpetratorID);
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            chkPrevCrim++;
                            prevCrimst = dataReader[0].ToString();
                        }
                        dataReader.Close();
                    }
                    if (chkPrevCrim > 0)
                    {
                        rdbYesCrim.Checked = true;
                        rdbNoCrim.Checked = false;
                        rchPrevCrim.Text = prevCrimst;
                    }
                    else
                    {
                        rdbNoCrim.Checked = true;
                        rdbYesCrim.Checked = false;
                        rchPrevCrim.Text = string.Empty;
                    }

                    long caseNo = 0;
                    DateTime dtIncident = new DateTime(2001, 1, 1);
                    string placeIncident = "";
                    string typeIncident = "";
                    string caseStat = "";
                    using(commnd = new SqlCommand("SELECT MAX(caseNo) FROM tbCases WHERE PerpetratorID = @ID", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@ID", perpetratorID);
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            chkWithCase++;
                            caseNo = dataReader.GetInt64(0);
                        }
                        dataReader.Close();
                    }
                    if (chkWithCase > 0)
                    {
                        using (commnd = new SqlCommand("SELECT  dateTimeIncident, placeOfIncident, typeOfIncident, stat  FROM tbCases WHERE caseNo = @caseNum", dbconn_main))
                        {
                            commnd.Parameters.AddWithValue("@caseNum", caseNo);
                            dataReader = commnd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                dtIncident = dataReader.GetDateTime(0);
                                placeIncident = dataReader[1].ToString();
                                typeIncident = dataReader[2].ToString();
                                caseStat = dataReader[3].ToString();
                            }
                            dataReader.Close();
                        }

                        rchStatPrevCase.Text = "Case #: " + caseNo.ToString()
                                               + "\nDate of Incident: " + dtIncident.ToShortDateString()
                                               + "\nPlace of Incident: " + placeIncident
                                               + "\nType of Incident: " + typeIncident
                                               + "\nCase status: " + caseStat;

                    }
                    else
                    {
                        rchStatPrevCase.Text = "None";
                    }
                }
                else
                {
                    rchPrevCrim.ResetText();
                    rchStatPrevCase.ResetText();
                    rdbNoCrim.Checked = false;
                    rdbYesCrim.Checked = false;
                    MessageBox.Show("[PERSON NOT FOUND!]", "[Person Not Found!]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void rdbYesCrim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYesCrim.Checked == true)
            { rchPrevCrim.Enabled = true; }
            else
            { rchPrevCrim.Enabled = false; }
        }

        private void rdbNoCrim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNoCrim.Checked == true)
            {
                rchPrevCrim.Enabled = false;
            }
        }
        string oldTextentryNum = string.Empty;
        private void entryNotb_TextChanged(object sender, EventArgs e)
        {
            if (entryNotb.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextentryNum = entryNotb.Text;
                entryNotb.Text = oldTextentryNum;

                entryNotb.BackColor = System.Drawing.Color.White;
                entryNotb.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                entryNotb.Text = oldTextentryNum;
                entryNotb.BackColor = System.Drawing.Color.Red;
                entryNotb.ForeColor = System.Drawing.Color.White;
            }
            entryNotb.SelectionStart = entryNotb.Text.Length;
        }

        private void entryNotb_Leave(object sender, EventArgs e)
        {
            entryNotb_TextChanged(sender, e);
        }
        string oldTextPerpetContNum = string.Empty;
        private void tbContNumPerpet_TextChanged(object sender, EventArgs e)
        {
            if (tbContNumPerpet.Text.All(chr => char.IsDigit(chr)))
            {
                oldTextPerpetContNum = tbContNumPerpet.Text;
                tbContNumPerpet.Text = oldTextPerpetContNum;

                tbContNumPerpet.BackColor = System.Drawing.Color.White;
                tbContNumPerpet.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbContNumPerpet.Text = oldTextPerpetContNum;
                tbContNumPerpet.BackColor = System.Drawing.Color.Red;
                tbContNumPerpet.ForeColor = System.Drawing.Color.White;
            }
            tbContNumPerpet.SelectionStart = tbContNumPerpet.Text.Length;
        }

        private void tbContNumPerpet_Leave(object sender, EventArgs e)
        {
            bool isValidPerpetContNum = Int64.TryParse(tbContNumPerpet.Text, out perpetContNum);
            if (!string.IsNullOrWhiteSpace(tbContNumPerpet.Text))
            {
                if (isValidPerpetContNum)
                {
                    oldTextmnum = tbContNumPerpet.Text;
                    tbContNumPerpet.Text = oldTextPerpetContNum;

                    tbContNumPerpet.BackColor = System.Drawing.Color.White;
                    tbContNumPerpet.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    tbContNumPerpet.Text = oldTextPerpetContNum;
                    tbContNumPerpet.BackColor = System.Drawing.Color.Red;
                    tbContNumPerpet.ForeColor = System.Drawing.Color.White;
                }
                tbContNumPerpet.SelectionStart = tbContNumPerpet.Text.Length;
            }
            else
            {
                tbContNumPerpet_TextChanged(sender, e);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirthPerpetDat_ValueChanged(object sender, EventArgs e)
        {
            int Age = (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dtpBirthPerpetDat.Value.Year));
            if (Age < 0)
            { tbAgePerpetDat.Text = (0).ToString(); }
            else
            { tbAgePerpetDat.Text = Age.ToString(); }
        }

        private void caseFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            { newCasebt.PerformClick(); }
        }
        }
}
