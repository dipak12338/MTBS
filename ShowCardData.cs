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
    public partial class ShowCardData : Form
    {
        public ShowCardData(string n,string a,string e,string g,string addr,string  pn)     //,string pn,string e,string ad,)
        {
            InitializeComponent();
    
            txtname.Text = n;
            txtade.Text = a;
            txtemail.Text = e;
            txtaddr.Text = addr;
            txtphone.Text = pn;
            

        }
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataReader dr;
            OleDbConnection con = null;
            try
            {

                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DBMetro.accdb");

                con.Open();
                MessageBox.Show("connection Done");
                string q = "select * from tblmetrocard where c_id=" + txtid.Text;
                MessageBox.Show(q);
                OleDbCommand cm = new OleDbCommand(q, con);


            }
            catch(Exception ex)
            {

            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowCardData_Load(object sender, EventArgs e)
        {

        }
    }


        }

    
