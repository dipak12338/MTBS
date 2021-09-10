using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void addStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStation ans = new AddNewStation();
            ans.MdiParent = this;
            ans.Dock = DockStyle.Fill;
            ans.FormBorderStyle = FormBorderStyle.None;
            ans.Show();
        }

        private void addTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTrain ant = new AddNewTrain();
            ant.MdiParent = this;
            ant.Dock = DockStyle.Fill;
            ant.FormBorderStyle = FormBorderStyle.None;
            ant.Show();
        }

        private void addTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTrain antrip = new AddNewTrain();
            antrip.MdiParent = this;
            antrip.Dock = DockStyle.Fill;
            antrip.FormBorderStyle = FormBorderStyle.None;
            antrip.Show();
        }

        private void fairDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFairDetail ufd = new UpdateFairDetail();
            ufd.MdiParent = this;
            ufd.Dock = DockStyle.Fill;
            ufd.FormBorderStyle = FormBorderStyle.None;
            ufd.Show();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAmdn ana = new AddNewAmdn();
            ana.MdiParent = this;
            ana.Dock = DockStyle.Fill;
            ana.FormBorderStyle = FormBorderStyle.None;
            ana.Show();
        }

        
      /*  private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewComplaint vc = new ViewComplaint();
            vc.MdiParent = this;
            vc.Dock = DockStyle.Fill;
            vc.FormBorderStyle = FormBorderStyle.None;
            vc.Show();

        }*/

       

        private void metroCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCardRequest vcr = new ViewCardRequest();
            vcr.MdiParent = this;
            vcr.Dock = DockStyle.Fill;
            vcr.FormBorderStyle = FormBorderStyle.None;
            vcr.Show();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewComplaints vc = new ViewComplaints();
            vc.Show();
        }

        private void issueMetroCardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void showApliedUserForCardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replyComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
