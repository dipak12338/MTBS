using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Findfairandroute : Form
    {
        public Findfairandroute()
        {
            InitializeComponent();
        }

        private void Findfairandroutebetweentwostation_Load(object sender, EventArgs e)
        {
            
            label7.Visible = false;
            label6.Visible = false;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            //label6.Visible = true;
            //label7.Visible = true;
            //if ((comboBox3.Text == "Nagpur-JN") && (comboBox4.Text == "Khapri"))
            //    label7.Text = "20";
            //else if ((comboBox3.Text == "Nagpur-JN") && (comboBox4.Text == "Pardi"))
            //    label7.Text = "30";
            //else if ((comboBox3.Text == "Nagpur-JN") && (comboBox4.Text == "Kalmeshwar"))
            //    label7.Text = "25";
            //else if ((comboBox3.Text == "Nagpur-JN") && (comboBox4.Text == "Hingana"))
            //    label7.Text = "30";
            //else if ((comboBox3.Text == "Nagpur-JN") && (comboBox4.Text == "Wadi"))
            //    label7.Text = "30";
            //else 
            //    label7.Text = "No Charge";
            
 




        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
