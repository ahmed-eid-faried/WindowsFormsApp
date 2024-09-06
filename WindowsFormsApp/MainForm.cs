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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form from1 = new Form1();
            from1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form from2 = new Form2();
            from2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form from1 = new Form1();
            from1.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form from2 = new Form2();
            from2.ShowDialog();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            Form from2 = new MessageBoxForm();
            from2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form from2 = new MessageBoxForm();
            from2.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form from2 = new CheckBoxAndRadioForm();
            from2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form from2 = new CheckBoxAndRadioForm();
            from2.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Form from2 = new PizzaForm();
            from2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form from2 = new PizzaForm();
            from2.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form from2 = new TextBoxForm();
            from2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form from2 = new TextBoxForm();
            from2.ShowDialog();
        }
    }
}
