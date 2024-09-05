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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static bool IsDark = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox3.Text += textBox1.Text + " - ";
                textBox1.Text = "";
            }
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text;
                textBox3.Text += textBox1.Text + " - ";
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            textBox1.ForeColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (IsDark) button11_Click(sender, e);
            if (this.BackColor == Color.SkyBlue)
            {
                this.BackColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.SkyBlue;
            }

        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                this.Text = textBox1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label3.Text = "Practice Project";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == SystemColors.ButtonFace)
            {
                button5.BackColor = Color.Blue;
                button5.ForeColor = Color.White;
            }
            else
            {
                button5.BackColor = SystemColors.ButtonFace;
                button5.ForeColor = Color.Black;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsDark) button11_Click(sender, e);
            if (button6.ForeColor == Color.Black)
            {
                button6.ForeColor = Color.Blue;
            }
            else
            {
                button6.ForeColor = Color.Black;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IsDark = false;
            this.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            /////////////////////////////////
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Blue;
            /////////////////////////////////
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Blue;
            /////////////////////////////////
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Blue;
            /////////////////////////////////
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Blue;
            /////////////////////////////////
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Blue;
            /////////////////////////////////
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Blue;
            /////////////////////////////////
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Blue;
            /////////////////////////////////
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Blue;
            /////////////////////////////////
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Blue;
            /////////////////////////////////
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Blue;
            /////////////////////////////////
            button11.BackColor = Color.White;
            button11.ForeColor = Color.Blue;
            /////////////////////////////////
            button12.BackColor = Color.White;
            button12.ForeColor = Color.Blue;
            /////////////////////////////////
            button13.BackColor = Color.White;
            button13.ForeColor = Color.Blue;
            /////////////////////////////////
            button14.BackColor = Color.White;
            button14.ForeColor = Color.Blue;
            /////////////////////////////////
            button15.BackColor = Color.White;
            button15.ForeColor = Color.Blue;
            /////////////////////////////////

        }
        private void button12_Click(object sender, EventArgs e)
        {
            IsDark = true;
            this.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            /////////////////////////////////
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            /////////////////////////////////
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            /////////////////////////////////
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            /////////////////////////////////
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            /////////////////////////////////
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
            /////////////////////////////////
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            /////////////////////////////////
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
            /////////////////////////////////
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            /////////////////////////////////
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;
            /////////////////////////////////
            button10.BackColor = Color.Black;
            button10.ForeColor = Color.White;
            /////////////////////////////////
            button11.BackColor = Color.Black;
            button11.ForeColor = Color.White;
            /////////////////////////////////
            button12.BackColor = Color.Black;
            button12.ForeColor = Color.White;
            /////////////////////////////////
            button13.BackColor = Color.Black;
            button13.ForeColor = Color.White;
            /////////////////////////////////
            button14.BackColor = Color.Black;
            button14.ForeColor = Color.White;
            /////////////////////////////////
            button15.BackColor = Color.Black;
            button15.ForeColor = Color.White;
            /////////////////////////////////

        }
    }
}
