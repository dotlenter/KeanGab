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
using System.Data.Sql;
using System.Data.SqlClient;

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class callLogsFrm : Form
    {
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        ConfirmationForms.informationFrm OnInformation = new ConfirmationForms.informationFrm();
        SqlConnection dbconn_Logs;
        SqlCommand commnd;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        public callLogsFrm()
        {
            InitializeComponent();
        }
        private int usrID;

        public int passID
        {
            get { return usrID; }
            set { usrID = value; }
        }
        private void callLogsFrm_Load(object sender, EventArgs e)
        {
            if (rbMobNum.Checked == true)
            {
                txtMobNum.Visible = true;
            }
            cmbFilterBy.SelectedIndex = 0;
            using (dbconn_Logs = dbpath.getdbConnectionOnLogs())
            {
                try { dbconn_Logs.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                #region DATA FEED
                using (commnd = new SqlCommand("SELECT * FROM callLogs", dbconn_Logs))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    callLogsdgv.DataSource = dt;
                    callLogsdgv.Columns[0].Visible = false;
                }
                using (commnd = new SqlCommand("SELECT COUNT(*) FROM callLogs", dbconn_Logs))
                {
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { totalCalls.Text = dataReader[0].ToString(); }
                    dataReader.Close();
                }
                using (commnd = new SqlCommand("SELECT COUNT(*) FROM callLogs WHERE MONTH(dateTimeOfCall) = @month", dbconn_Logs))
                {
                    commnd.Parameters.AddWithValue("@month", DateTime.Now.Month);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { numOfcallsMnth.Text = dataReader[0].ToString(); }
                    dataReader.Close();
                }
                using (commnd = new SqlCommand("SELECT COUNT(*) FROM callLogs WHERE DAY(dateTimeOfCall) = @day", dbconn_Logs))
                {
                    commnd.Parameters.AddWithValue("@day", DateTime.Now.Day);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { numOfCallsDay.Text = dataReader[0].ToString(); }
                    dataReader.Close();
                }
                #endregion


            }
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

        private void callLogsFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 2);
            e.Graphics.DrawRectangle(black, 0, 0, this.Width, this.Height);

        }

        private void curTime_Tick(object sender, EventArgs e)
        {
            curDTlbl.Text = DateTime.Now.ToString();
        }

        private void callLogsdgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            numRowstb.Text = callLogsdgv.Rows.Count.ToString();
        }

        private void hidePb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Hide")
            {
                grpInsertCall.Visible = false;
                txtMobNum.Clear();
                txtTelNum.Clear();
                button1.Text = "Add a call";
            }
            else if (button1.Text == "Add a call")
            {
                grpInsertCall.Visible = true;
                rbMobNum.Focus();
                cmbCall.Text = "VALID";
                cmbCont.Text = "SMART";
                button1.Text = "Hide";
            }

        }

        private void rbMobNum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMobNum.Checked == true)
            {
                txtTelNum.Enabled = false;
                cmbCont.Enabled = true;
                txtTelNum.Clear();
            }
            else
            {
                txtMobNum.Enabled = false;
                txtTelNum.Enabled = true;
            }
        }

        private void rbTelNum_CheckedChanged(object sender, EventArgs e)
        {

            if (rbTelNum.Checked == true)
            {
                txtMobNum.Enabled = false;
                cmbCont.Enabled = false;
                txtMobNum.Clear();

            }
            else
            {
                txtMobNum.Enabled = true;
                txtTelNum.Enabled = false;
            }
        }
        public void displayAll()
        {
            using (dbconn_Logs = dbpath.getdbConnectionOnLogs())
            {
                try { dbconn_Logs.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                using (commnd = new SqlCommand("SELECT * FROM callLogs", dbconn_Logs))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    callLogsdgv.DataSource = dt;
                    callLogsdgv.Columns[0].Visible = false;
                }
                using (commnd = new SqlCommand("SELECT COUNT(*) FROM callLogs", dbconn_Logs))
                {
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { totalCalls.Text = dataReader[0].ToString(); }
                    dataReader.Close();
                }
                using (commnd = new SqlCommand("SELECT COUNT(*) FROM callLogs WHERE MONTH(dateTimeOfCall) = @month", dbconn_Logs))
                {
                    commnd.Parameters.AddWithValue("@month", DateTime.Now.Month);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { numOfcallsMnth.Text = dataReader[0].ToString(); }
                    dataReader.Close();
                }
                using (commnd = new SqlCommand("SELECT COUNT(*) FROM callLogs WHERE DAY(dateTimeOfCall) = @day", dbconn_Logs))
                {
                    commnd.Parameters.AddWithValue("@day", DateTime.Now.Day);
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { numOfCallsDay.Text = dataReader[0].ToString(); }
                    dataReader.Close();
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbconn_Logs = dbpath.getdbConnectionOnLogs())
                {
                    try { dbconn_Logs.Open(); }
                    catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                    if (txtTelNum.Text == "" && txtMobNum.Text != "")
                    {
                        using (commnd = new SqlCommand("INSERT INTO callLogs(contactNumberUsed, typeOfContactNo, dateTimeOfCall, typeOfCall) Values(@cn,@tcn,@dtoc,@toc)", dbconn_Logs))
                        {
                            commnd.Parameters.AddWithValue("@cn", txtMobNum.Text);
                            commnd.Parameters.AddWithValue("@tcn", cmbCont.Text);
                            commnd.Parameters.Add("@dtoc", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                            commnd.Parameters.AddWithValue("@toc", cmbCall.Text);
                            commnd.ExecuteNonQuery();
                            MessageBox.Show("Added");
                            button1.Enabled = true;
                            button1.Text = "Add a call";
                            grpInsertCall.Visible = false;
                        }

                    }
                    else if (txtMobNum.Text == "" && txtTelNum.Text != "")
                    {
                        using (commnd = new SqlCommand("INSERT INTO callLogs(telephoneNumberUsed, dateTimeOfCall, typeOfCall) Values(@tnu,@dtoc,@toc)", dbconn_Logs))
                        {
                            commnd.Parameters.AddWithValue("@tnu", txtTelNum.Text);
                            commnd.Parameters.AddWithValue("@tn", txtTelNum.Text);
                            commnd.Parameters.Add("@dtoc", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                            commnd.Parameters.AddWithValue("@toc", cmbCall.Text);
                            commnd.ExecuteNonQuery();
                            MessageBox.Show("Added");
                            button1.Enabled = true;
                            button1.Text = "Add a call";
                            grpInsertCall.Visible = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Fill up the following fields");
                    }
                    txtMobNum.Clear();
                    txtTelNum.Clear();

                    displayAll();

                    dbconn_Logs.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbconn_Logs = dbpath.getdbConnectionOnLogs())
            {
                try { dbconn_Logs.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                /*
                 * (Filter By)
                    Smart Contact Numbers
                    Globe Contact Numbers
                    Sun Contact Numbers
                    TM Contact Numbers
                    Prank Calls
                    Valid Calls
                 */
                try
                {
                    if (cmbFilterBy.Text == "All")
                    {
                        using (commnd = new SqlCommand("SELECT * FROM callLogs", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                    if (cmbFilterBy.Text == "Smart Contact Numbers")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE typeOfContactNo = 'SMART'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                    if (cmbFilterBy.Text == "Sun Contact Numbers")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE typeOfContactNo = 'SUN'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                    if (cmbFilterBy.Text == "Globe Contact Numbers")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE typeOfContactNo = 'GLOBE'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                    if (cmbFilterBy.Text == "TM Contact Numbers")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE typeOfContactNo = 'TM'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                    if (cmbFilterBy.Text == "Prank Calls")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE typeOfCall = 'PRANK'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                    if (cmbFilterBy.Text == "Valid Calls")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE typeOfCall = 'VALID'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void searchBoxTxt_TextChanged(object sender, EventArgs e)
        {
            using (dbconn_Logs = dbpath.getdbConnectionOnLogs())
            {
                try { dbconn_Logs.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                try
                {
                    if (cmbCat.Text == "Mobile Number")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE contactNumberUsed LIKE '" + searchBoxTxt.Text + "%'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                    if (cmbCat.Text == "Tel Number")
                    {
                        using (commnd = new SqlCommand("SELECT * From callLogs WHERE telephoneNumberUsed LIKE '" + searchBoxTxt.Text + "%'", dbconn_Logs))
                        {
                            dataAdapter = new SqlDataAdapter(commnd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            callLogsdgv.DataSource = dt;
                            callLogsdgv.Columns[0].Visible = false;
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtMobNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers Only", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers Only", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}