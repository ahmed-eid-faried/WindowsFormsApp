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
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Resources.Boy;
                    break;
                case 1:
                    pictureBox1.Image = Resources.Girl;
                    break;
                case 2:
                    pictureBox1.Image = Resources.Pen;
                    break;
                case 3:
                    pictureBox1.Image = Resources.Book;
                    break;

                default:
                    pictureBox1.Image = Resources.Boy;
                    break;

            }
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1_SelectedIndexChanged(sender, e);
        }
    }
}
