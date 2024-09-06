using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class CheckBoxAndRadioForm : Form
    {
        public CheckBoxAndRadioForm()
        {
            InitializeComponent();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
            textBox1.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox2.Checked.ToString());
            textBox2.Enabled = checkBox2.Checked;

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox3.Checked.ToString());
            textBox3.Enabled = checkBox3.Checked;
        }



        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = radioButton7.Checked;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = radioButton8.Checked;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = radioButton9.Checked;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.ForeColor = Color.Red;
            radioButton5.ForeColor = Color.Black;
            radioButton6.ForeColor = Color.Black;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.ForeColor = Color.Black;
            radioButton5.ForeColor = Color.Green;
            radioButton6.ForeColor = Color.Black;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.ForeColor = Color.Black;
            radioButton5.ForeColor = Color.Black;
            radioButton6.ForeColor = Color.Blue;
        }
    }
}
