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
    public partial class LinkLableForm : Form
    {
        public LinkLableForm()
        {
            InitializeComponent();
        }
        private void LinkClicked(LinkLabel linkLabel, string Url)
        {
            linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(Url);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://www.youtube.com/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://programmingadvices.com/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://www.w3schools.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://github.com/ahmed-eid-faried/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://www.google.com/");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://codebeautify.org/");

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://chatgpt.com/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked((LinkLabel)sender, "https://www.noor-book.com/");
        }
    }
}
