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
    public partial class PizzaForm : Form
    {
        public PizzaForm()
        {
            InitializeComponent();
        }
        string Size = "Small";
        string CrustType = "Thin Crust";
        string WhereToEat = "Eat In";
        bool ExtraChees = false;
        bool Mushrooms = false;
        bool Tomatoes = false;
        bool Onion = false;
        bool Olives = false;
        bool GreenPeppers = false;
        string toppings = "";
        string Total = "";
        private void TotalPrice()
        {
            double totalPrice = 0;
            ///////////////////////////////////////////////////
            if (Size == "Larg") { totalPrice += 60; }
            else if (Size == "Medium") { totalPrice += 40; }
            else { totalPrice += 20; }
            ///////////////////////////////////////////////////
            if (CrustType == "Think Crust") { totalPrice *= 2; }
            ///////////////////////////////////////////////////
            if (ExtraChees) totalPrice += 10;
            if (Mushrooms) totalPrice += 10;
            if (Tomatoes) totalPrice += 10;
            if (Onion) totalPrice += 10;
            if (Olives) totalPrice += 10;
            if (GreenPeppers) totalPrice += 10;
            Total = $"${totalPrice}";

        }
        private void ResetData()
        {
            Size = "Small";
            CrustType = "Thin";
            WhereToEat = "EatIn";
            ExtraChees = false;
            Mushrooms = false;
            Tomatoes = false;
            Onion = false;
            Olives = false;
            GreenPeppers = false;
            toppings = "";
        }
        private void UpdateData()
        {
            label4.Text = Size;
            label5.Text = CrustType;
            label8.Text = WhereToEat;
            toppings = "";
            if (ExtraChees) toppings += " Extra Chees ";
            if (Mushrooms) toppings += " Mushrooms ";
            if (Tomatoes) toppings += " Tomatoes ";
            if (Onion) toppings += " Onion ";
            if (Olives) toppings += " Olives ";
            if (GreenPeppers) toppings += " Green Peppers ";
            label10.Text = toppings;
            TotalPrice();
            label12.Text = Total;
        }
        private void UpdateUi()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            /////////////////////////////
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;//Thin Crust
            radioButton4.Checked = true;//Small
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = true;//Eat In
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ExtraChees = checkBox1.Checked;
            UpdateData();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Mushrooms = checkBox2.Checked;
            UpdateData();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Tomatoes = checkBox3.Checked;
            UpdateData();

        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Onion = checkBox6.Checked;
            UpdateData();

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Olives = checkBox5.Checked;
            UpdateData();

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            GreenPeppers = checkBox4.Checked;
            UpdateData();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) Size = "Small";
            UpdateData();

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) Size = "Medium";
            UpdateData();

        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) Size = "Larg";
            UpdateData();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked) CrustType = "Thin Crust";
            UpdateData();

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) CrustType = "Think Crust";
            UpdateData();

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked) WhereToEat = "Eat In";
            UpdateData();

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) WhereToEat = "Take Out";
            UpdateData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            ResetData();
            UpdateData();
            UpdateUi();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool result = MessageBox.Show("Are you confirm?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK;
            if (result)
            {
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                MessageBox.Show("Order Placed Successfully");
            }
            else
            {
                MessageBox.Show("Order Placed Canceled");
            };
        }
    }
}
