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
    public partial class statisticsFrm : Form
    {
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        ConfirmationForms.informationFrm OnInformation = new ConfirmationForms.informationFrm();
        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataReader dataReader;

        public statisticsFrm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
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

       
        private void statisticsFrm_Load(object sender, EventArgs e)
        {
        }

        private void showChartBT_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbFilterCHARTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                if (cmbFilterCHARTS.SelectedIndex == 0)
                {
                    ControlTabChart.SelectTab(graphChartTabMF);
                    #region Most Reported Cases (MALE VS FEMALE)
                    int numOfPhysicalAbuse_OnMale = 0;
                    int numOfPhysicalAbuse_OnFemale = 0;
                    int numOfSexualAbuse_OnMale = 0;
                    int numOfSexualAbuse_OnFemale = 0;
                    int numOfVAWC_OnMale = 0;
                    int numOfVAWC_OnFemale = 0;
                    int numOfNeglected_OnMale = 0;
                    int numOfNeglected_OnFemale = 0;
                    int numOfMissing_OnMale = 0;
                    int numOfMissing_OnFemale = 0;
                    int numOfCCase_OnMale = 0;
                    int numOfCCase_OnFemale = 0;
                    foreach (var series in statisticChart.Series)
                    {
                        series.Points.Clear();
                    }
                    //Physical Abuse
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'M' OR Gender = 'male') AND typeOfIncident LIKE 'PHYSICAL ABUSE%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfPhysicalAbuse_OnMale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'F' OR Gender = 'female') AND typeOfIncident LIKE 'PHYSICAL ABUSE%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfPhysicalAbuse_OnFemale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }

                    this.statisticChart.Series["Male"].Points.AddXY("Physical Abuse", numOfPhysicalAbuse_OnMale);
                    this.statisticChart.Series["Female"].Points.AddXY("Physical Abuse", numOfPhysicalAbuse_OnFemale);

                    //Sexual Abuse
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'M' OR Gender = 'male') AND typeOfIncident LIKE 'SEXUAL ABUSE%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfSexualAbuse_OnMale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'F' OR Gender = 'female') AND typeOfIncident LIKE 'SEXUAL ABUSE%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfSexualAbuse_OnFemale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }

                    this.statisticChart.Series["Male"].Points.AddXY("Sexual Abuse", numOfSexualAbuse_OnMale);
                    this.statisticChart.Series["Female"].Points.AddXY("Sexual Abuse", numOfSexualAbuse_OnFemale);

                    //Missing
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'M' OR Gender = 'male') AND typeOfIncident LIKE 'MISSING%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfMissing_OnMale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'F' OR Gender = 'female') AND typeOfIncident LIKE 'MISSING%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfMissing_OnFemale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }

                    this.statisticChart.Series["Male"].Points.AddXY("Missing", numOfMissing_OnMale);
                    this.statisticChart.Series["Female"].Points.AddXY("Missing", numOfMissing_OnFemale);

                    //VAWC
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'M' OR Gender = 'male') AND typeOfIncident LIKE 'VAWC%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfVAWC_OnMale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'F' OR Gender = 'female') AND typeOfIncident LIKE 'VAWC%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfVAWC_OnFemale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }

                    this.statisticChart.Series["Male"].Points.AddXY("VAWC", numOfVAWC_OnMale);
                    this.statisticChart.Series["Female"].Points.AddXY("VAWC", numOfVAWC_OnFemale);

                    //Custody Case
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'M' OR Gender = 'male') AND typeOfIncident LIKE 'CUSTODY CASE%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfCCase_OnMale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'F' OR Gender = 'female') AND typeOfIncident LIKE 'CUSTODY CASE%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfCCase_OnFemale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }

                    this.statisticChart.Series["Male"].Points.AddXY("Custody Case", numOfCCase_OnMale);
                    this.statisticChart.Series["Female"].Points.AddXY("Custody Case", numOfCCase_OnFemale);

                    //Neglected
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'M' OR Gender = 'male') AND typeOfIncident LIKE 'NEGLECTED%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfNeglected_OnMale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Gender = 'F' OR Gender = 'female') AND typeOfIncident LIKE 'NEGLECTED%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            numOfNeglected_OnFemale = dataReader.GetInt32(0);
                        }
                        dataReader.Close();
                    }

                    this.statisticChart.Series["Male"].Points.AddXY("Neglected", numOfNeglected_OnMale);
                    this.statisticChart.Series["Female"].Points.AddXY("Neglected", numOfNeglected_OnFemale);

                    this.statisticChart.DataManipulator.Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending, "Male");
                    ControlTabChart.SelectTab(graphChartTabMF);
                    #endregion
                }
                else if (cmbFilterCHARTS.SelectedIndex == 1)
                {
                    //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    ControlTabChart.SelectTab(sideGraphChartTab);
                    #region Most Reported Cases (PER AGE)
                    #region Variables
                    int victimsOnVAWC_05 = 0;
                    int victimsOnVAWC_612 = 0;
                    int victimsOnVAWC_1318 = 0;
                    int victimsOnVAWC_19up = 0;
                    int victimsOnMissing_05 = 0;
                    int victimsOnMissing_612 = 0;
                    int victimsOnMissing_1318 = 0;
                    int victimsOnMissing_19up = 0;
                    int victimsOnNeg_05 = 0;
                    int victimsOnNeg_612 = 0;
                    int victimsOnNeg_1318 = 0;
                    int victimsOnNeg_19up = 0;
                    #endregion
                    foreach (var series in sideGraphChartAge.Series)
                    {
                        series.Points.Clear();
                    }

                    #region VAWC
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 0 AND Age <= 5) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'VAWC%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnVAWC_05 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 6 AND Age <= 12) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'VAWC%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnVAWC_612 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 13 AND Age <= 18) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'VAWC%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnVAWC_1318 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE Age >= 19 AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'VAWC%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnVAWC_19up = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    #endregion
                    this.sideGraphChartAge.Series["0-5"].Points.AddXY("VAWC", victimsOnVAWC_05);
                    this.sideGraphChartAge.Series["6-12"].Points.AddXY("VAWC", victimsOnVAWC_612);
                    this.sideGraphChartAge.Series["13-18"].Points.AddXY("VAWC", victimsOnVAWC_1318);
                    this.sideGraphChartAge.Series["19 Above"].Points.AddXY("VAWC", victimsOnVAWC_19up);

                    #region MISSING
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 0 AND Age <= 5) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'MISSING%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnMissing_05 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 6 AND Age <= 12) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'MISSING%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnMissing_612 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 13 AND Age <= 18) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'MISSING%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnMissing_1318 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE Age >= 19 AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'MISSING%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnMissing_19up = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }

                    #endregion
                    this.sideGraphChartAge.Series["0-5"].Points.AddXY("Missing", victimsOnMissing_05);
                    this.sideGraphChartAge.Series["6-12"].Points.AddXY("Missing", victimsOnMissing_612);
                    this.sideGraphChartAge.Series["13-18"].Points.AddXY("Missing", victimsOnMissing_1318);
                    this.sideGraphChartAge.Series["19 Above"].Points.AddXY("Missing", victimsOnMissing_19up);

                    #region NEGLECTED
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 0 AND Age <= 5) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'NEGLECTED%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnNeg_05 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 6 AND Age <= 12) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'NEGLECTED%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnNeg_612 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE (Age >= 13 AND Age <= 18) AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'NEGLECTED%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnNeg_1318 = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbCases WHERE VictimID IN(SELECT VictimID FROM tbVictim WHERE Age >= 19 AND LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A') AND typeOfIncident LIKE 'NEGLECTED%'", dbconn_main))
                    {
                        dataReader = commnd.ExecuteReader();
                        while (dataReader.Read())
                        { victimsOnNeg_19up = dataReader.GetInt32(0); }
                        dataReader.Close();
                    }
                    #endregion
                    this.sideGraphChartAge.Series["0-5"].Points.AddXY("Neglected", victimsOnNeg_05);
                    this.sideGraphChartAge.Series["6-12"].Points.AddXY("Neglected", victimsOnNeg_612);
                    this.sideGraphChartAge.Series["13-18"].Points.AddXY("Neglected", victimsOnNeg_1318);
                    this.sideGraphChartAge.Series["19 Above"].Points.AddXY("Neglected", victimsOnNeg_19up);


                    this.sideGraphChartAge.DataManipulator.Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending, "0-5");
                    this.sideGraphChartAge.DataManipulator.Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending, "6-12");
                    this.sideGraphChartAge.DataManipulator.Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending, "13-18");
                    this.sideGraphChartAge.DataManipulator.Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending, "19 Above");
                    #endregion

                }

            }

        }

        private void statisticsFrm_Paint(object sender, PaintEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
