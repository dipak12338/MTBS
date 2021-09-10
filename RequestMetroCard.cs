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
    public partial class RequestMetroCard : Form
    {
        string gen;
        
 
        public RequestMetroCard()
        {
            InitializeComponent();
        }

        private void RequestMetroCard_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
                  gen=radioButton1.Text;
            else
                gen=radioButton2.Text;

           

            OleDbConnection con = null;
            try
            {

                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DBMetro.accdb");

                con.Open();
                MessageBox.Show("connection Done");
                string q="insert into tblmetrocard (u_name,passw,age,gender,phone_num,email,u_addr) values ('" +txtname.Text + "','"+txtpass.Text +  "'," +txtade.Text +",'"+ gen.ToString() +"','" + txtphone.Text +"','" + txtemail.Text +"','"+txtaddr.Text+"')";
                MessageBox.Show(q);
                OleDbCommand cm = new OleDbCommand(q, con);
               cm.ExecuteNonQuery();

                MessageBox.Show("Record Insertde successfully");

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

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
                e.Handled = true;
        }

        private void txtade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

      


        }
    }
