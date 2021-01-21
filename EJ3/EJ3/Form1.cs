using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selecRadioButt = "";
            string selecCheckBox = "";

            if (radioButton1.Checked)
            {
                selecRadioButt = radioButton1.Text;
            }
              else if (radioButton2.Checked)
            {
                selecRadioButt = radioButton2.Text;
            }
              else if (radioButton3.Checked)
            {
                selecRadioButt = radioButton3.Text;
            }

            if (checkBox1.Checked)
            {
                selecCheckBox += checkBox1.Text + ", ";
            }

            if (checkBox2.Checked)
            {
                selecCheckBox += checkBox2.Text + ", ";
            }

            if (checkBox3.Checked)
            {
                selecCheckBox += checkBox3.Text + ", ";
            }
            

            string track = Convert.ToString(trackBar1.Value);

            MessageBox.Show("Sistema Operativo: "+selecRadioButt+
                "\nEspecialidad: "+selecCheckBox+
                "\nHoras en el ordenador: "+track);


        }
    }
}
