using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Properties;

namespace WindowsFormsApp
{
    public partial class PictureForm2 : Form
    {
        public PictureForm2()
        {
            InitializeComponent();
        }
 
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            label1.Text = "Boy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            label1.Text = "Girl";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Pen;
            label1.Text = "Pen";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            label1.Text = "Book";
        }
    }
}
