﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class TextBoxForm : Form
    {
        public TextBoxForm()
        {
            InitializeComponent();
        }

         private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form=new DockTextBoxForm();
            form.Show();
        }
    }
}
