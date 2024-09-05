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
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS MESSAGE.", "MT TITLE", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool result = MessageBox.Show("Are you accept?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
            if (result) { MessageBox.Show("Ok"); }
            else { MessageBox.Show("Cancel"); }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool result = MessageBox.Show("Are you accept?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK;
            if (result) { MessageBox.Show("Ok"); }
            else { MessageBox.Show("Cancel"); }
        }
    }
}
