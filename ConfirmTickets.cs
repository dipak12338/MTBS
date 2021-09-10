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
    public partial class ConfirmTickets : Form
    {
        public ConfirmTickets(string  c)
        {
            InitializeComponent();
            txttc.Text = c.ToString();              //receiving the values

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmTickets_Load(object sender, EventArgs e)
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
                string q = "select * from tblmetrocard where card_no='" + txtcn.Text + "' and passw='" + txtpass.Text + "'";
                MessageBox.Show(q);
                OleDbCommand cmd = new OleDbCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ok Done");
                q = "Update  tblmetrocard  set bal=(bal-" + txttc.Text + ") where card_no='" + txtcn.Text + "' and passw='" + txtpass.Text + "'";
                MessageBox.Show(q);
                cmd = new OleDbCommand(q, con);
                cmd.ExecuteNonQuery();
                 MessageBox.Show("Your Ticket is succided....");
            }
            catch (Exception ex)
            {

                MessageBox.Show("You dont have money....");
            }


            finally
            {
                con.Close();
            }
        }
    }
}
