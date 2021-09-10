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
    public partial class AddNewAmdn : Form
    {
        public AddNewAmdn()
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
                string q = "insert into TblAddAdmin (a_name,a_address,phone_num,email,age,designation,password) values ('" +txtname.Text +"','"+ txtaddr.Text+ "','"+txtphone.Text+
                    "','"+ txtemail.Text + "','" +txtage.Text+ "','" + txtdes.Text +"','" + txtpass.Text +"')";
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
