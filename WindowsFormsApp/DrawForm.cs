using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
        }

        private void DrawForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 10);
            //pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 0, 0, 100, 100);
            e.Graphics.DrawRectangle(pen, 150, 150, 100, 100);
            e.Graphics.DrawEllipse(pen, 320, 320, 200, 100);
        }
    }
}
