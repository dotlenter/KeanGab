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
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class victimDetailsFrm : Form
    {
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        Forms.ConfirmationForms.informationFrm OnInformation = new ConfirmationForms.informationFrm();
        SqlCommand commnd;
        SqlConnection dbconn_main;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        public victimDetailsFrm()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, victimImg.Width - 5, victimImg.Height - 5);
            Region rg = new Region(gp);
            victimImg.Region = rg;
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
        private void victimDetailsFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 2);
            e.Graphics.DrawRectangle(black, 0,0,this.Width,this.Height);
        }
        private long victimID;
        public long passvID
        {
            get { return victimID; }
            set { victimID = value; }
        }
        private void victimDetailsFrm_Load(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using(commnd = new SqlCommand("SELECT * FROM tbVictim where VictimID = @id", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@id", victimID);
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])(ds.Tables[0].Rows[0]["vicImg"]);
                        MemoryStream mem = new MemoryStream(data);
                        victimImg.Image = Image.FromStream(mem);
                    }
                    dataReader = commnd.ExecuteReader();
                    while(dataReader.Read())
                    {
                        IDtxt.Text = dataReader.GetInt64(0).ToString();
                        LNlbl.Text = dataReader[1].ToString();
                        FNlbl.Text = dataReader[2].ToString();
                        MNlbl.Text = dataReader[3].ToString();
                        lblAge.Text = dataReader.GetInt32(4).ToString();
                        lblGender.Text = dataReader[5].ToString();
                        nckNamelbl.Text = dataReader[6].ToString();
                        lblDOB.Text = dataReader.GetDateTime(7).ToString();
                        poBlbl.Text = dataReader[8].ToString();
                        curAddlbl.Text = dataReader[9].ToString();
                        addedOnlbl.Text = dataReader.GetDateTime(10).ToString();
                    }
                    dataReader.Close();
                }
                using(commnd = new SqlCommand("SELECT * FROM tbVictimDetails WHERE VictimID = @id", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@id", victimID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        fathNamelbl.Text = dataReader[1].ToString();
                        fathOcclbl.Text = dataReader[2].ToString();
                        fathNumlbl.Text = dataReader[3].ToString();
                        mothNamelbl.Text = dataReader[4].ToString();
                        mothOcclbl.Text = dataReader[5].ToString();
                        mothNumlbl.Text = dataReader[6].ToString();
                        lblHEA.Text = dataReader[7].ToString();
                        schoolAddlbl.Text = dataReader[8].ToString();
                        lblpresID.Text = dataReader[9].ToString();
                        lblRem.Text = dataReader[10].ToString();
                    }
                    dataReader.Close();
                }
                using (commnd = new SqlCommand("SELECT caseNo, VictimID, PerpetratorID, personRepID, dateTimeIncident, typeOfIncident FROM tbCases WHERE VictimID = @id", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@id", victimID);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    victimDgvCases.DataSource = dt;

                }
                using(commnd = new SqlCommand("SELECT count(caseNo) FROM tbCases Where VictimID = @id", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@id",victimID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        casesTotLbl.Text = "Cases(" + dataReader.GetInt32(0).ToString() + "):";
                    }
                    dataReader.Close();
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
