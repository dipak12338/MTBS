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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Complaint : Form
    {
        public Complaint()
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
                string q="insert into tblcomplaints (u_name,u_address,phone_num,email,age,c_msg) values ('" +txtname.Text +"','" + txtaddress.Text +"','"+txtphone.Text +"','" + txtemail.Text +"','" +txtage.Text+  "','"+ txtmsg.Text+"')";
                MessageBox.Show(q);
                OleDbCommand cm = new OleDbCommand(q, con);
               cm.ExecuteNonQuery();

                MessageBox.Show("Record Insertde successfully");

                ShowCardData f2 = new ShowCardData(txtname.Text,txtage.Text,txtemail.Text,txtemail.Text,txtaddress.Text,txtphone.Text);
                f2.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show( "OOPs, something went wrong." + ex.ToString());
            }


            finally
            {
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {
           // ShowCardData  f2 = new ShowCardData (txtname.Text);
          //  f2.ShowDialog();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            e.Handled=true;
         }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='+')
                e.Handled = true;

        }
private void txtemail_Leave(object sender, EventArgs e)
        {
            emailvalidate();
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

         void emailvalidate()
        {

            if (txtemail.Text.Length > 0)
            {
                Regex rex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
                if (!rex.IsMatch(txtemail.Text.Trim()))
                {
                    MessageBox.Show("Please enter proper email");
                    txtemail.Focus();
                    return;
                }
            }
        }

        }
    }

