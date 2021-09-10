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
    public partial class Balanceenquiry : Form
    {
        public Balanceenquiry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con = null;
            try
            {

                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DBMetro.accdb");

                con.Open();
                MessageBox.Show("connection Done");

                OleDbDataAdapter oleDA = new OleDbDataAdapter("select bal from tblmetrocard where card_no='" + txtcno.Text +"' and passw='" +txtpass.Text+"'", con);

                DataTable dtbl = new DataTable();
                oleDA.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                ///MessageBox.Show(q);


            }
            catch (Exception ex)
            {

                MessageBox.Show("OOPs, something went wrong." + ex.ToString());
            }


            finally
            {
                con.Close();
            }
        

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Balanceenquiry_Load(object sender, EventArgs e)
        {

        }
    }
}
