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
    public partial class AddNewTrain : Form
    {
        public AddNewTrain()
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
                string q = "insert into tbl_trip(src,des,src_arr,src_dep,des_arr,des_dep,chrg) values('" + comboBox1.Text + "','" + comboBox2.Text
                    + "','" + comboBox3.Text +"','"+ comboBox4.Text +"','"+ comboBox5.Text+"','"+ comboBox6.Text+ "','" + textBox1.Text  + " ')";
                MessageBox.Show(q);
                OleDbCommand cm = new OleDbCommand(q, con);
                cm.ExecuteNonQuery();

                MessageBox.Show("Record Insertde successfully");

            }
            catch (Exception ex)
            {
            }







        }









        private void AddNewTrip_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
