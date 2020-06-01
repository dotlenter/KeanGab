using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class victimEditFrm : Form
    {
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        ConfirmationForms.informationFrm onInformation = new ConfirmationForms.informationFrm();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        public victimEditFrm()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, victimImg.Width - 3, victimImg.Height - 3);
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

        private void victimEditFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen b = new Pen(Brushes.Black, 4);
            e.Graphics.DrawRectangle(b, 0,0, this.Width, this.Height);
        }
        private long victimID;
        public long passvID
        {
            get { return victimID; }
            set { victimID = value; }
        }
        DateTime dateOfBirth = new DateTime(1900, 1, 1);
        string birthPlace = "N/A";
        string curAddress = "N/A";
        string fathName = "N/A";
        string mothName = "N/A";
        string occMoth = "N/A";
        string occFath = "N/A";
        long fathCon = 0;
        long mothCon = 0;
        string hea = "N/A";
        string presentedID = "N/A";
        string schoolAdd = "N/A";
        string remarks = "N/A";

        private void victimEditFrm_Load(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { onInformation.ShowDialog(); garCol.FlushMemory(); }

                using(commnd = new SqlCommand("SELECT * FROM tbVictim WHERE VictimID = @ID", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@ID", victimID);
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
                }

                using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE VictimID = @ID", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@ID", victimID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        victimIDtb.Text = dataReader.GetInt64(0).ToString();
                        victimLNtb.Text = dataReader[1].ToString();
                        victimFNtb.Text = dataReader[2].ToString();
                        victimMNtb.Text = dataReader[3].ToString();
                        victimNNtb.Text = dataReader[6].ToString();
                        victimAgetb.Text = dataReader.GetInt32(4).ToString();
                        if (dataReader[5].ToString().ToLower() == "female")
                        { victimGenderCmb.SelectedIndex = 1; }
                        else { victimGenderCmb.SelectedIndex = 0; }
                        dtpDOB.Value = dataReader.GetDateTime(7);
                        dateOfBirth = dataReader.GetDateTime(7);
                        victimBirthPlacetb.Text = dataReader[8].ToString();
                        birthPlace = dataReader[8].ToString();
                        curAddresstb.Text = dataReader[9].ToString();
                        curAddress = dataReader[9].ToString();
                        addOntb.Text = dataReader[10].ToString();

                    }
                    dataReader.Close();

                }
                using(commnd = new SqlCommand("SELECT * FROM tbVictimDetails WHERE VictimID = @ID", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@ID", victimID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        tbFathVictimDat.Text = dataReader[1].ToString();
                        fathName = dataReader[1].ToString();
                        cmbFathOccupVicDat.Text = dataReader[2].ToString();
                        occFath = dataReader[2].ToString();
                        tbFathNumVicDat.Text = dataReader[3].ToString();
                        fathCon = dataReader.GetInt64(3);
                        tbMother.Text = dataReader[4].ToString();
                        mothName = dataReader[4].ToString();
                        cmbOccupt.Text = dataReader[5].ToString();
                        occMoth = dataReader[5].ToString();
                        tbContact.Text = dataReader[6].ToString();
                        mothCon = dataReader.GetInt64(6);
                        cmbHEA.Text = dataReader[7].ToString();
                        hea = dataReader[7].ToString();
                        rchSchoolAddVicDat.Text = dataReader[8].ToString();
                        schoolAdd = dataReader[8].ToString();
                        cmbIDprVicDat.Text = dataReader[9].ToString();
                        presentedID = dataReader[9].ToString();
                        rchRemarks.Text = dataReader[10].ToString();
                        remarks = dataReader[10].ToString();
                    }
                    dataReader.Close();
                }
            }
        }
         public static Image resizeImage(Image imgToResize, Size size)
         {
            return (Image)(new Bitmap(imgToResize, size));
         }
        private void vicImgSavebt_Click(object sender, EventArgs e)
        {
            Image img = resizeImage(victimImg.Image, new Size(200, 200));
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { onInformation.ShowDialog(); garCol.FlushMemory(); }
                using(commnd = new SqlCommand("UPDATE tbVictim SET vicImg = @image WHERE VictimID = @ID", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@image", arr);
                    commnd.Parameters.AddWithValue("@ID", Convert.ToInt64(victimIDtb.Text));
                    commnd.ExecuteNonQuery();
                }
            }
            uploadbt.Enabled = true;
            vicImgSavebt.Enabled = false;
            MessageBox.Show("Victim's Image was updated successfully!", "[Image Saved]", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void uploadbt_Click(object sender, EventArgs e)
        {
            vicImgSavebt.Enabled = true;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                victimImg.Image = new Bitmap(open.FileName);
            }
            else
            { vicImgSavebt.Enabled = false; }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to discard editing?", "[Confirmation]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                garCol.FlushMemory();
            }
        }

        private void btClose_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btClose.ForeColor = Color.Goldenrod;
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btClose.ForeColor = Color.White;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void victimUpdateInfobt_Click(object sender, EventArgs e)
        {
            int validVicInfo = 0;
            string LastNameVictim = "N/A";
            string FirstNameVictim = "N/A";
            string MiddleNameVictim = "N/A";
            string NickNameVictim = "N/A";

            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { onInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE VictimID = @ID", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@ID", victimID);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        LastNameVictim = dataReader[1].ToString();
                        FirstNameVictim = dataReader[2].ToString();
                        MiddleNameVictim = dataReader[3].ToString();
                        NickNameVictim = dataReader[6].ToString();
                    }
                    dataReader.Close();
                }

                if((!string.IsNullOrWhiteSpace(victimLNtb.Text) && (victimLNtb.Text != "N/A")))
                { LastNameVictim = victimLNtb.Text; }
                if ((!string.IsNullOrWhiteSpace(victimFNtb.Text) && (victimFNtb.Text != "N/A")))
                { FirstNameVictim = victimFNtb.Text; }
                if ((!string.IsNullOrWhiteSpace(victimMNtb.Text) && (victimMNtb.Text != "N/A")))
                { MiddleNameVictim = victimMNtb.Text; }
                if ((!string.IsNullOrWhiteSpace(victimNNtb.Text) && (victimNNtb.Text != "N/A")))
                { NickNameVictim = victimNNtb.Text; }

                int checkExistingName = 0;
                using(commnd = new SqlCommand("SELECT * FROM tbVictim WHERE VictimID != @ID AND LastName = @LNAME AND FirstName = @FNAME AND MidName = @MNAME", dbconn_main))
                {
                    commnd.Parameters.AddWithValue("@ID", victimID);
                    commnd.Parameters.Add("@LNAME", SqlDbType.VarChar).Value = LastNameVictim;
                    commnd.Parameters.Add("@FNAME", SqlDbType.VarChar).Value = FirstNameVictim;
                    commnd.Parameters.Add("@MNAME", SqlDbType.VarChar).Value = MiddleNameVictim;
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { checkExistingName++; }
                    dataReader.Close();
                }
                if (checkExistingName > 0)
                {
                    victimLNtb.BackColor = Color.MistyRose;
                    victimFNtb.BackColor = Color.MistyRose;
                    victimMNtb.BackColor = Color.MistyRose;
                    pbNameExist.Enabled = true;
                    pbNameExist.Visible = true;
                    validVicInfo++;
                }
                else
                {
                    victimLNtb.BackColor = Color.White;
                    victimFNtb.BackColor = Color.White;
                    victimMNtb.BackColor = Color.White;
                    pbNameExist.Enabled = false;
                    pbNameExist.Visible = false;
                }

                int Age = 0, errorAge = 0;
                try { Age = Convert.ToInt32(victimAgetb.Text); }
                catch { errorAge++; }

                if (errorAge > 0)
                {
                    victimAgetb.BackColor = Color.MistyRose;
                    erProv.SetError(victimAgetb, "Invalid Age.");
                    validVicInfo++;
                }
                else if(Age > 110 || Age < 0)
                {
                    victimAgetb.BackColor = Color.MistyRose;
                    erProv.SetError(victimAgetb, "Age should be between 0 and 120.");
                    validVicInfo++;
                }
                else {
                    victimAgetb.BackColor = Color.White;
                    erProv.SetError(victimAgetb, string.Empty);
                }

                if (!string.IsNullOrWhiteSpace(curAddresstb.Text))
                { curAddress = curAddresstb.Text; }
                if (!string.IsNullOrWhiteSpace(victimBirthPlacetb.Text))
                { birthPlace = victimBirthPlacetb.Text; }

                if (validVicInfo == 0)
                {
                    using (commnd = new SqlCommand("UPDATE tbVictim SET LastName = @lname, FirstName = @fname, MidName = @mname, Age = @age, Gender = @gnder, NickName = @nckname, DateOfBirth = @dob, PlaceOfBirth = @pob, CurrentAddress = @curAdd WHERE VictimID = @id", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@id", victimID);
                        commnd.Parameters.AddWithValue("@lname", LastNameVictim);
                        commnd.Parameters.AddWithValue("@fname", FirstNameVictim);
                        commnd.Parameters.AddWithValue("@mname", MiddleNameVictim);
                        commnd.Parameters.AddWithValue("@age", Age);
                        commnd.Parameters.AddWithValue("@gnder", victimGenderCmb.Text);
                        commnd.Parameters.AddWithValue("@nckname", NickNameVictim);
                        commnd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                        commnd.Parameters.AddWithValue("@pob", birthPlace);
                        commnd.Parameters.AddWithValue("@curAdd", curAddress);
                        commnd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Victim Information updated Successfully!", "[INFO]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        int validateInfo = 0;
        private void updatebt_Click(object sender, EventArgs e)
        {
            validateInfo = 0;

            if ((!string.IsNullOrWhiteSpace(tbFathVictimDat.Text)) && (tbFathVictimDat.Text != fathName))
            { fathName = tbFathVictimDat.Text; }
            if ((!string.IsNullOrWhiteSpace(tbMother.Text)) && (tbMother.Text != mothName))
            { mothName = tbMother.Text; }

            int checkValidFNum = 0;
            try { fathCon = Convert.ToInt64(tbFathNumVicDat.Text); }
            catch { checkValidFNum++; }
            if (checkValidFNum > 0)
            { 
                tbFathNumVicDat.BackColor = Color.MistyRose;
                erProv.SetError(tbFathNumVicDat, "Invalid Contact Number.");
                validateInfo++;
            }
            else if (fathCon < 0)
            {
                tbFathNumVicDat.BackColor = Color.MistyRose;
                erProv.SetError(tbFathNumVicDat, "Invalid Contact Number.");
                validateInfo++;
            }
            else{
                tbFathNumVicDat.BackColor = Color.White;
                erProv.SetError(tbFathNumVicDat, string.Empty);
            }

            int checkValidMNum = 0;
            try { mothCon = Convert.ToInt64(tbContact.Text); }
            catch { checkValidMNum++; }
            if (checkValidMNum > 0)
            {
                tbContact.BackColor = Color.MistyRose;
                erProv.SetError(tbContact, "Invalid Contact Number.");
                validateInfo++;
            }
            else if (mothCon < 0)
            {
                tbContact.BackColor = Color.MistyRose;
                erProv.SetError(tbContact, "Invalid Contact Number.");
                validateInfo++;
            }
            else {
                tbContact.BackColor = Color.White;
                erProv.SetError(tbContact, string.Empty);
            }

            if ((!string.IsNullOrWhiteSpace(cmbFathOccupVicDat.Text)) && (cmbFathOccupVicDat.Text != occFath))
            { occFath = cmbFathOccupVicDat.Text; }
            if ((!string.IsNullOrWhiteSpace(cmbOccupt.Text)) && (cmbOccupt.Text != occMoth))
            { occMoth = cmbOccupt.Text; }

            if ((!string.IsNullOrWhiteSpace(cmbHEA.Text)) && (cmbHEA.Text != hea))
            { hea = cmbHEA.Text; }
            if ((!string.IsNullOrWhiteSpace(cmbIDprVicDat.Text)) && (cmbIDprVicDat.Text != presentedID))
            { presentedID = cmbIDprVicDat.Text; }
            if ((!string.IsNullOrWhiteSpace(rchSchoolAddVicDat.Text)) && (rchSchoolAddVicDat.Text != schoolAdd))
            { schoolAdd = rchSchoolAddVicDat.Text; }
            if ((!string.IsNullOrWhiteSpace(rchRemarks.Text)) && (rchRemarks.Text != remarks))
            { remarks = rchRemarks.Text; }


            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { onInformation.ShowDialog(); garCol.FlushMemory(); }

                if (validateInfo == 0)
                {
                    using (commnd = new SqlCommand("UPDATE tbVictimDetails SET FatherName = @fname, FathOccupt = @occFath, FathNum = @fnum, MotherName = @mname, MothOccupt = @occMoth, MothNum = @mnum, HEAttained = @hea, SchoolAdd = @sadd, PresentedID = @id, Remarks = @remarks WHERE VictimID = @vID", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@fname", fathName);
                        commnd.Parameters.AddWithValue("@occFath", occFath);
                        commnd.Parameters.AddWithValue("@fnum", fathCon);
                        commnd.Parameters.AddWithValue("@mname", mothName);
                        commnd.Parameters.AddWithValue("@occMoth", occMoth);
                        commnd.Parameters.AddWithValue("@mnum", mothCon);
                        commnd.Parameters.AddWithValue("@hea", hea);
                        commnd.Parameters.AddWithValue("@sadd", schoolAdd);
                        commnd.Parameters.AddWithValue("@id", presentedID);
                        commnd.Parameters.AddWithValue("@remarks", remarks);
                        commnd.Parameters.AddWithValue("@vID", victimID);
                        commnd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Victim Information updated Successfully!", "[INFO]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

    }
}
