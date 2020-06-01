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

namespace KeanGabriel_RMS_SMS.Forms
{
    public partial class referrerFrm : Form
    {
        Classes.dbconnClass dbpath = new Classes.dbconnClass();
        Classes.GarbageCollector garCol = new Classes.GarbageCollector();
        ConfirmationForms.informationFrm OnInformation = new ConfirmationForms.informationFrm();
        SqlConnection dbconn_main;
        SqlCommand commnd;
        SqlDataAdapter dataAdapter;

        public referrerFrm()
        {
            InitializeComponent();
        }

        private void referrerFrm_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Brushes.Black, 2);
            e.Graphics.DrawRectangle(black, 0, 0, this.Width, this.Height);
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


        private void referrerFrm_Load(object sender, EventArgs e)
        {
            cmbFilterBy.SelectedIndex = 0;
            srchbyCmb.SelectedIndex = 0;
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting", dbconn_main))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dvReferrer.DataSource = dt;

                    dataFeedlbl.Text = "All Referrers";
                }
            }
        }

        private void viewAllbt_Click(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting", dbconn_main))
                {
                    dataAdapter = new SqlDataAdapter(commnd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dvReferrer.DataSource = dt;

                    dataFeedlbl.Text = "All Referrers";
                }
            }
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

        private bool DragPress;
        private Point WindowsLoc;

        private void border_MouseMove(object sender, MouseEventArgs e)
        {
            if (DragPress)
            {
                this.Location = new Point(
                    (this.Location.X - WindowsLoc.X) + e.X, (this.Location.Y - WindowsLoc.Y) + e.Y);

                this.Update();
            }
        }
        private void border_MouseUp(object sender, MouseEventArgs e)
        {
            DragPress = false;
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

        private void hidePb_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void hidePb_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void viewDetailsbt_Click(object sender, EventArgs e)
        {
            referrerDetailsFrm referrerDetailsFrm = new referrerDetailsFrm();
            referrerDetailsFrm.passRefID = Convert.ToInt64(dvReferrer.SelectedRows[0].Cells[0].Value);
            referrerDetailsFrm.ShowDialog();
            garCol.FlushMemory();
        }
        private void dvReferrer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewDetailsbt.PerformClick();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                if (cmbFilterBy.SelectedIndex == 1)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE month(addedOn) = @mnth", dbconn_main))
                    {
                        commnd.Parameters.AddWithValue("@mnth", DateTime.Now.Month);
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;

                        dataFeedlbl.Text = "Referrers added this month";
                    }
                }
                else if (cmbFilterBy.SelectedIndex == 2)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE LastName <> 'N/A' AND FirstName <> 'N/A' AND MidName <> 'N/A'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;

                        dataFeedlbl.Text = "Referrers with complete name";
                    }
                }
            }
        }

        private void tbSrchPerpetrator_TextChanged(object sender, EventArgs e)
        {
            using (dbconn_main = dbpath.getdbConnection())
            {
                try { dbconn_main.Open(); }
                catch { OnInformation.ShowDialog(); garCol.FlushMemory(); }
                if (srchbyCmb.SelectedIndex == 1)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE LastName LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else if(srchbyCmb.SelectedIndex == 2)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE FirstName LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 3)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE MidName LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 4)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE NickName LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 5)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE Occupation LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 6)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE PresentedID LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 7)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE refType LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else if (srchbyCmb.SelectedIndex == 8)
                {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE (LastName + ' ' + FirstName + ' ' + MidName) LIKE '" + tbSrchPerpetrator.Text + "%' OR (LastName + FirstName + MidName) LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
                else {
                    using (commnd = new SqlCommand("SELECT * FROM tbPersonReporting WHERE (LastName + ' ' + FirstName + ' ' + MidName) LIKE '" + tbSrchPerpetrator.Text + "%' OR (LastName + FirstName + MidName) LIKE '" + tbSrchPerpetrator.Text + "%'", dbconn_main))
                    {
                        dataAdapter = new SqlDataAdapter(commnd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dvReferrer.DataSource = dt;
                    }
                }
            }
        }

        private void editbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're sorry, but this feature is not yet available.", "[NOT AVAILABLE]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dvReferrer_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            rowCountb.Text = dvReferrer.Rows.Count.ToString();
        }
    }
}
