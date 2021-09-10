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
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            BtnTicket.Visible = false;

        }

        private void Find_Click(object sender, EventArgs e)
        {
            OleDbConnection con = null;
            try
            {
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DBMetro.accdb");
                con.Open();
                MessageBox.Show("connection Done");
                string q = "select * from tbl_trip where src='" + cmbsrc.Text + "' and des='" + cmbdes.Text + "'";
                MessageBox.Show(q);
              
                OleDbCommand cmd = new OleDbCommand(q, con);
                OleDbDataReader dr =cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtcharges.Text = dr.GetValue(6).ToString();       //for balance
                }

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
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = Convert.ToInt32(txtadults.Text);
                b = Convert.ToInt32(txtchilds.Text);
                c = Convert.ToInt32(txtcharges.Text);

                txttotal.Text = ((a * c) + (b * (c / 2))).ToString();
                BtnTicket.Visible = true;

            }
            catch (Exception ex)
            { MessageBox.Show("No results Please select Values.","Warning...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmTickets ct = new ConfirmTickets((txttotal.Text));
            ct.ShowDialog();
           // ShowCardData f2 = new ShowCardData(txtname.Text, txtage.Text, txtemail.Text, txtemail.Text, txtaddress.Text, txtphone.Text);
           // f2.ShowDialog();
        }
    }
}
