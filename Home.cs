using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void timingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Timetable tt = new Timetable();

                tt.MdiParent = this;
                tt.Show();
        }

        private void tripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            login l = new login();
            l.MdiParent=this;
            l.Show();
           
        }

        private void rechargeMetrcoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechargemetroCard rmcard = new rechargemetroCard();
            rmcard.MdiParent = this;
            rmcard.Show();

        }

        private void applicationForMetroCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestMetroCard rmc = new RequestMetroCard();
            rmc.MdiParent = this;
            rmc.Dock=DockStyle.Fill;
            rmc.FormBorderStyle = FormBorderStyle.None;
            rmc.Show();
        }

        private void hToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void viewBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanceenquiry be = new Balanceenquiry();
            be.MdiParent = this;
            be.Show();
        }

        private void complaintoolStripMenuItem_Click(object sender, EventArgs e)
        {

            Complaint sc = new Complaint();
            sc.MdiParent = this;
            sc.Dock = DockStyle.Fill;
            sc.FormBorderStyle = FormBorderStyle.None;
        sc.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Timetable tt = new Timetable();
            tt.MdiParent = this;
            tt.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();

        }

        

       
    }
}
