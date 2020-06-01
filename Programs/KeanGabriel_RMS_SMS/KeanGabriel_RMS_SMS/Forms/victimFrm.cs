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
    public partial class victimFrm : Form
    {
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Forms.victimDetailsFrm vicDat = new victimDetailsFrm();
        Forms.victimEditFrm vicEdit = new victimEditFrm();
        Forms.ConfirmationForms.informationFrm OnInformation = new Forms.ConfirmationForms.informationFrm();
        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        public victimFrm()
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
        private void victimFrm_Load(object sender, EventArgs e)
        {
            curDatelbl.Text = DateTime.Now.ToShortDateString();
            srchbyCmb.SelectedIndex = 0;
            srtbyCmb.SelectedIndex = 0;
            cmbSort.SelectedIndex = 0;
            filterCmb.SelectedIndex = 0;
            dgvStatlbl.Text = "Victims";
            using(dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A'", dbconn_main))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    victimDgv.DataSource = dt;
                    victimDgv.Columns[1].HeaderText = "Last Name";
                    victimDgv.Columns[2].HeaderText = "First Name";
                    victimDgv.Columns[3].HeaderText = "Middle Name";
                    victimDgv.Columns[6].HeaderText = "Nick Name";
                    victimDgv.Columns[7].HeaderText = "Date Of Birth";
                    victimDgv.Columns[8].HeaderText = "Place Of Birth";
                    victimDgv.Columns[9].HeaderText = "Current Address";
                    victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                    victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;

                }
                using (commnd = new SqlCommand("SELECT COUNT(*) FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A'", dbconn_main))
                {
                    dataReader = commnd.ExecuteReader();
                    while (dataReader.Read())
                    { victimCountlbl.Text = dataReader.GetInt32(0).ToString(); }
                    dataReader.Close();
                }
            }
        }

        private void victimFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 2);
            e.Graphics.DrawRectangle(black, 0,0,this.Width,this.Height);
        }

        private void closePb_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void closePb_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void editBt_MouseMove(object sender, MouseEventArgs e)
        {
            pn1.BackgroundImage = Properties.Resources.Hover_Button;
        }

        private void editBt_MouseLeave(object sender, EventArgs e)
        {
            pn1.BackgroundImage = Properties.Resources.unHover_Button;
        }

        private void viewFullDetbt_MouseMove(object sender, MouseEventArgs e)
        {
            pn2.BackgroundImage = Properties.Resources.Hover_Button;
        }

        private void viewFullDetbt_MouseLeave(object sender, EventArgs e)
        {
            pn2.BackgroundImage = Properties.Resources.unHover_Button;
        }

        private void closePb_Click(object sender, EventArgs e)
        {
            selectionFrm newFrm = new selectionFrm();
            newFrm.passID = usrID;
            newFrm.Show();
            this.Dispose(false);
            garCol.FlushMemory();
        }

        private void viewFullDetbt_Click(object sender, EventArgs e)
        {
            try
            {
                vicDat.passvID = Convert.ToInt64(victimDgv.SelectedRows[0].Cells[0].Value);
                vicDat.ShowDialog();
            }
            catch(Exception ex) { MessageBox.Show("No item to view!" + ex.Message.ToString(), "[" + ex.Source +"]",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            vicEdit.passvID = Convert.ToInt64(victimDgv.SelectedRows[0].Cells[0].Value);
            vicEdit.ShowDialog();
            viewVicbt_Click(sender, e);
            garCol.FlushMemory();
        }

        private void viewVicbt_MouseMove(object sender, MouseEventArgs e)
        {
            viewVicbt.ForeColor = Color.Goldenrod;
            Cursor = Cursors.Hand;
        }

        private void viewVicbt_MouseLeave(object sender, EventArgs e)
        {
            viewVicbt.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void viewVicbt_Click(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A'", dbconn_main))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    victimDgv.DataSource = dt;
                    victimDgv.Columns[1].HeaderText = "Last Name";
                    victimDgv.Columns[2].HeaderText = "First Name";
                    victimDgv.Columns[3].HeaderText = "Middle Name";
                    victimDgv.Columns[6].HeaderText = "Nick Name";
                    victimDgv.Columns[7].HeaderText = "Date Of Birth";
                    victimDgv.Columns[8].HeaderText = "Place Of Birth";
                    victimDgv.Columns[9].HeaderText = "Current Address";
                    victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                    victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                }
            }
            dgvStatlbl.Text = "Victims";
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

        private void victimDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void victimDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vicDat.passvID = Convert.ToInt64(victimDgv.SelectedRows[0].Cells[0].Value);
            vicDat.ShowDialog();
        }

        private void srtbyCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(srtbyCmb.SelectedIndex != 0)
                if(cmbSort.SelectedIndex == 0)
                    this.victimDgv.Sort(this.victimDgv.Columns[srtbyCmb.SelectedIndex - 1], ListSortDirection.Ascending);
                else
                    this.victimDgv.Sort(this.victimDgv.Columns[srtbyCmb.SelectedIndex - 1], ListSortDirection.Descending);
        }

        private void tbSearchVictims_TextChanged(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                if (srchbyCmb.SelectedIndex == 1)
                {
                    using(commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName LIKE '" + tbSearchVictims.Text + "%'" , dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 2)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE FirstName LIKE '" + tbSearchVictims.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 3)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE MidName LIKE '" + tbSearchVictims.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 4)
                {

                }
                else if (srchbyCmb.SelectedIndex == 5)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE NickName LIKE '" + tbSearchVictims.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 6)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE CurrentAddress LIKE '" + tbSearchVictims.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 7)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE (LastName + ' ' + FirstName + ' ' + MidName) LIKE '" + tbSearchVictims.Text + "%' OR (LastName + FirstName + MidName) LIKE '" + tbSearchVictims.Text.Replace(" ", "") + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
                else
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE (LastName + ' ' + FirstName + ' ' + MidName) LIKE '" + tbSearchVictims.Text + "%' OR (LastName + FirstName + MidName) LIKE '" + tbSearchVictims.Text.Replace(" ", "") + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            srtbyCmb_SelectedIndexChanged(sender, e);
        }

        private void filterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }

                if (filterCmb.SelectedIndex == 1)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Month(addedOn) = @curMonth", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@curMonth", DateTime.Now.Month);
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;
                    }
                }
                else if(filterCmb.SelectedIndex == 2)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Age <= 8", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;

                    }
                }
                else if (filterCmb.SelectedIndex == 3)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Age >= 9 AND Age <= 12", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;

                    }
                }
                else if (filterCmb.SelectedIndex == 4)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Age >= 13 AND Age <= 17", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;

                    }
                }
                else if (filterCmb.SelectedIndex == 5)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND Age >= 18", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;

                    }
                }
                else if (filterCmb.SelectedIndex == 6)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbVictim WHERE LastName != 'N/A' AND FirstName != 'N/A' AND MidName != 'N/A' AND VictimID IN(Select VictimID FROM tbCases GROUP BY VictimID HAVING Count(*) > 1)", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        victimDgv.DataSource = dt;
                        victimDgv.Columns[1].HeaderText = "Last Name";
                        victimDgv.Columns[2].HeaderText = "First Name";
                        victimDgv.Columns[3].HeaderText = "Middle Name";
                        victimDgv.Columns[6].HeaderText = "Nick Name";
                        victimDgv.Columns[7].HeaderText = "Date Of Birth";
                        victimDgv.Columns[8].HeaderText = "Place Of Birth";
                        victimDgv.Columns[9].HeaderText = "Current Address";
                        victimDgv.Columns[0].DefaultCellStyle.Font = new Font(victimDgv.Font, FontStyle.Bold);
                        victimDgv.Columns[0].DefaultCellStyle.ForeColor = Color.SeaGreen;

                    }
                }
            }
            dgvStatlbl.Text = filterCmb.Text;
        }

        private void victimDgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            rowCounttb.Text = victimDgv.Rows.Count.ToString();
        }

        private void hidePb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
