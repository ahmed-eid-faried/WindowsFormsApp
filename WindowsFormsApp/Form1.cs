﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ChangeValue()
        {
            textBox2.Text = textBox1.Text;
            if (textBox1.Text != "")
            {
                textBox1.ForeColor = Color.White;
                textBox1.BackColor = Color.GreenYellow;
                textBox2.ForeColor = Color.White;
                textBox2.BackColor = Color.GreenYellow;
            }
            else
            {
                textBox1.ForeColor = Color.White;
                textBox1.BackColor = Color.Red;
                textBox2.ForeColor = Color.White;
                textBox2.BackColor = Color.Red;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ChangeValue();

        }

 
    }
}
