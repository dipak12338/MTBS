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
    public partial class UpdateFairDetail : Form
    {
        public UpdateFairDetail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateFairDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = null;
            try
            {

                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DBMetro.accdb");

                con.Open();
                MessageBox.Show("connection Done");
                string q = "insert into tbl_fairDetail(f_unit,amt_per_unit,min_charge,min_distance) values(" + txtfu.Text  + "," + txtcpa.Text +"," + txtmc.Text+ "," +txtmu.Text +")";
                MessageBox.Show(q);
                OleDbCommand cm = new OleDbCommand(q, con);
                cm.ExecuteNonQuery();

                MessageBox.Show("Record Insertde successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
