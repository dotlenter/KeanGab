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

namespace KeanGabriel_RMS_SMS
{
    public partial class referrerDetailsFrm : Form
    {
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        Forms.ConfirmationForms.informationFrm OnInformation = new Forms.ConfirmationForms.informationFrm();
        SqlCommand commnd;
        SqlDataReader dataReader;
        SqlConnection dbconn_main;

        public referrerDetailsFrm()
        {
            InitializeComponent();
        }
        private long refID;
        public long passRefID
        {
            get { return refID; }
            set { refID = value; }
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
        private void referrerDetailsFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 4);
            e.Graphics.DrawRectangle(black, 0, 0, this.Width, this.Height);
        }
        string id = "";
        string fullname = "";
        string age = "";
        string dateofbirth = "";
        string nickname = "";
        string curAdd = "";
        string occ = "";
        string remarks = "";
        string addedOn = "";
        string refType = "";
        string gender = "";
        string presID = "";
        string citiShip = "";


        private void referrerDetailsFrm_Load(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE PersonRepID = @id", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@id", refID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        idtb.Text = dataReader[0].ToString();
                        id = dataReader[0].ToString();
                        fullNametb.Text = dataReader[1].ToString() + ", " + dataReader[2].ToString() + " " + dataReader[3].ToString();
                        fullname = dataReader[1].ToString() + ", " + dataReader[2].ToString() + " " + dataReader[3].ToString();
                        agetb.Text = dataReader[4].ToString();
                        age = dataReader[4].ToString();
                        dateOfBirthtb.Text = dataReader.GetDateTime(5).ToString();
                        dateofbirth = dataReader.GetDateTime(5).ToString();
                        nicknameTB.Text = dataReader[6].ToString();
                        nickname = dataReader[6].ToString();
                        currentAddresstb.Text = dataReader[7].ToString();
                        curAdd = dataReader[7].ToString();
                        occupationtb.Text = dataReader[8].ToString();
                        occ = dataReader[8].ToString();
                        remarkstb.Text = dataReader[9].ToString();
                        remarks = dataReader[9].ToString();
                        addedOntb.Text = dataReader[10].ToString();
                        addedOn = dataReader[10].ToString();
                        referrerTypetb.Text = dataReader[11].ToString();
                        refType = dataReader[11].ToString();
                        genderTb.Text = dataReader[12].ToString();
                        gender = dataReader[12].ToString();
                        presentedIDtb.Text = dataReader[13].ToString();
                        presID = dataReader[13].ToString();
                        citizenshiptb.Text = dataReader[14].ToString();
                        citiShip = dataReader[14].ToString();
                    }
                    dataReader.Close();
                }

                using(commnd = new SqlCommand("SELECT * FROM tbPersonRepContact WHERE PersonRepID = @id", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@id", refID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        contactNumbertb.Text = dataReader[1].ToString();
                        mobileNumbertb.Text = dataReader[2].ToString();
                        homePhoneNumbertb.Text = dataReader[3].ToString();
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

        private void printbt_Click(object sender, EventArgs e)
        {
            ppDialog.Document = pDoc;
            ppDialog.ShowDialog();
        }

        private void pDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bmp = Properties.Resources.Circular_KBH_OpenBook;
            //Image imgHeader = bmp;
            //e.Graphics.DrawImage(imgHeader, ((this.Width / 2) - 100), 20, 100, 100);
            e.Graphics.DrawString("KEAN GABRIEL HOTLINE", new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new Point((this.Width / 2) - 85, 20));
            e.Graphics.DrawString("0908-818-4444", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point((this.Width / 2) - 20, 50));
            e.Graphics.DrawString("Keangabriel@gmail.com", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point((this.Width / 2) - 60, 70));
            e.Graphics.DrawString("Referrer Details", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point((this.Width / 2) - 60, 140));
            int initialHeight = 220;
            //ID
            e.Graphics.DrawString("ID: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight));
            e.Graphics.DrawString(id, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(125, initialHeight));
            //Fullname
            e.Graphics.DrawString("Full Name: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 30));
            e.Graphics.DrawString(fullname, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(190, initialHeight + 30));
            //Nick Name
            e.Graphics.DrawString("Nick Name: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 60));
            e.Graphics.DrawString(nickname, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, initialHeight + 60));
            //Age
            e.Graphics.DrawString("Age: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 90));
            e.Graphics.DrawString(age, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(140, initialHeight + 90));
            //Date of Birth
            e.Graphics.DrawString("Date Of Birth: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 120));
            e.Graphics.DrawString(dateofbirth, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(210, initialHeight + 120));
            //Gender
            e.Graphics.DrawString("Gender: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 150));
            e.Graphics.DrawString(gender, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(170, initialHeight + 150));
            //Occupation
            e.Graphics.DrawString("Occupation: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 180));
            e.Graphics.DrawString(occ, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, initialHeight + 180));
            //Current Address
            e.Graphics.DrawString("Current Address: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 210));
            e.Graphics.DrawString(curAdd, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(235, initialHeight + 210));
            //Referrer Type
            e.Graphics.DrawString("Referrer Type: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 240));
            e.Graphics.DrawString(refType, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(215, initialHeight + 240));
            //Citizenship
            e.Graphics.DrawString("Citizenship: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 270));
            e.Graphics.DrawString(citiShip, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(195, initialHeight + 270));
            //Presented ID
            e.Graphics.DrawString("Presented ID: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 300));
            e.Graphics.DrawString(presID, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(205, initialHeight + 300));
            //Referrer Added on
            e.Graphics.DrawString("Added in Database at: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 330));
            e.Graphics.DrawString(addedOn, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(270, initialHeight + 330));
            //Remarks
            e.Graphics.DrawString("Remarks: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, initialHeight + 360));
            e.Graphics.DrawString(remarks, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(180, initialHeight + 360));
        }
    }
}
