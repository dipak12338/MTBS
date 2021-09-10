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
    public partial class IssueCard : Form
    {
        public IssueCard()
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
                string q = "Update tblmetrocard set card_no='" + textBox2.Text + "' where cust_id = " + textBox1.Text + "";
                MessageBox.Show(q);
                OleDbCommand cmd=new OleDbCommand(q,con);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully.");

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
    }
}
