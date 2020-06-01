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

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class caseEditFrm : Form
    {
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        ConfirmationForms.informationFrm OnInformation = new ConfirmationForms.informationFrm();
        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataReader dataReader;

        public caseEditFrm()
        {
            InitializeComponent();
        }
        private long caseNum;
        public long passCNum
        {
            get { return caseNum; }
            set { caseNum = value; }
        }
        DateTime dti = new DateTime(1900, 1, 1);
        DateTime dtr = new DateTime(1900, 1, 1);
        string placeOfIncident = "";
        string typeOfIncident = "";
        string entry_Num = "";
        string caseStat = "";

        private void caseEditFrm_Load(object sender, EventArgs e)
        {
            string defaultCase = "";

            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                using (commnd = new SqlCommand("SELECT * FROM tbCases WHERE caseNo = @CASE_NUM", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@CASE_NUM", caseNum);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        caseNumtb.Text = dataReader[0].ToString();
                        victimIDtb.Text = dataReader[1].ToString();
                        perpetratorIDtb.Text = dataReader[2].ToString();
                        referrerIDtb.Text = dataReader[3].ToString();
                        dtpDTI.Value = dataReader.GetDateTime(4);
                        dti = dataReader.GetDateTime(4);
                        poiRch.Text = dataReader[5].ToString();
                        placeOfIncident = dataReader[5].ToString();
                        toiRch.Text = dataReader[6].ToString();
                        typeOfIncident = dataReader[6].ToString();
                        defaultCase = dataReader[6].ToString();
                        entryNum.Text = dataReader[7].ToString();
                        entry_Num = dataReader[7].ToString();
                        if (dataReader.IsDBNull(8))
                            caseStatcmb.Text = "";
                        else
                        { caseStatcmb.Text = dataReader[8].ToString(); caseStat = dataReader[8].ToString(); }
                        dtpDTR.Value = dataReader.GetDateTime(9);
                        dtr = dataReader.GetDateTime(9);
                        addedOnlbl.Text = dataReader.GetDateTime(10).ToString();
                    }
                    dataReader.Close();
                }
            }
        }

        private void Cancelbt_Click(object sender, EventArgs e)
        {

        }
        private void updatebt_Click(object sender, EventArgs e)
        {
            if (dtpDTI.Value != dti)
            { dti = dtpDTI.Value; }
            if (caseStatcmb.Text != caseStat && !string.IsNullOrWhiteSpace(caseStatcmb.Text))
            { caseStat = caseStatcmb.Text; }
            if (toiRch.Text != typeOfIncident && !string.IsNullOrWhiteSpace(toiRch.Text))
            { typeOfIncident = toiRch.Text; }
            if(poiRch.Text != placeOfIncident && !string.IsNullOrWhiteSpace(poiRch.Text))
            { placeOfIncident = poiRch.Text; }
            if(dtpDTR.Value != dtr)
            { dtr = dtpDTR.Value; }
            if (entryNum.Text != entry_Num && !string.IsNullOrWhiteSpace(entryNum.Text))
            { entry_Num = entryNum.Text; }

            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using(commnd = new SqlCommand("UPDATE tbCases SET PerpetratorID = @pID, personRepID = @prepID, dateTimeIncident = @dti, placeOfIncident = @poi, typeOfIncident = @toi, entryNum = @enum, stat = @st, dateTimeRep = @dtr WHERE caseNo = @CASE_NUM", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@pID", Convert.ToInt64(perpetratorIDtb.Text));
                    commnd.Parameters.AddWithValue("@prepID", Convert.ToInt64(referrerIDtb.Text));
                    commnd.Parameters.AddWithValue("@dti", dti);
                    commnd.Parameters.AddWithValue("@poi",placeOfIncident);
                    commnd.Parameters.AddWithValue("@toi", typeOfIncident);
                    commnd.Parameters.AddWithValue("@enum", entry_Num);
                    commnd.Parameters.AddWithValue("@st", caseStat);
                    commnd.Parameters.AddWithValue("@dtr", dtr);
                    commnd.Parameters.AddWithValue("@CASE_NUM", caseNum);
                    commnd.ExecuteNonQuery();
                }
                MessageBox.Show("Case updated successfully!", "[INFO]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void findPerpetbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addPerpetbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addRefbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void findRefbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
