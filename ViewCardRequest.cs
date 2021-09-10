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
    public partial class ViewCardRequest : Form
    {
        public ViewCardRequest()
        {
            InitializeComponent();
        }

        private void ViewCardRequest_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                OleDbDataAdapter oleDA = new OleDbDataAdapter("select * from tblmetrocard where card_no is NULL",con);

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

        private void button2_Click(object sender, EventArgs e)
        {
            IssueCard ic = new IssueCard();
            ic.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }
    }
}
