using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1SagarVaddoriya
{
    public partial class Form1 : Form
    {
        double subTotal = 0;
        double tax = 0;
        double total = 0;


        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAppetizer.SelectedIndex = 0;
            cmbBeverage.SelectedIndex = 0;
            cmbMainCourse.SelectedIndex = 0;
            cmbDessert.SelectedIndex = 0;
        }

        private void cmbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbBeverage.SelectedIndex > 0)
            {
                listBox1.Items.Add(cmbBeverage.SelectedItem);

                if(cmbBeverage.SelectedIndex == 1)
                {
                    subTotal += 1.95;

                }
                else if (cmbBeverage.SelectedIndex == 2)
                {
                    subTotal += 1.50;
                }
                else if (cmbBeverage.SelectedIndex == 3)
                {
                    subTotal += 1.25;
                }
                else if (cmbBeverage.SelectedIndex == 4)
                {
                    subTotal += 2.95;
                }
                else
                {
                    subTotal += 2.50;
                }
            }
            txtSubTotal.Text = subTotal.ToString();
            tax = subTotal*13/100;
            txtTax.Text = tax.ToString();
            total = subTotal + tax;
            txtTotal.Text = total.ToString();
        }

        private void cmbAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAppetizer.SelectedIndex > 0)
            {
                listBox1.Items.Add(cmbAppetizer.SelectedItem);
                if (cmbAppetizer.SelectedIndex == 1)
                {
                    subTotal += 5.95;

                }
                else if (cmbAppetizer.SelectedIndex == 2)
                {
                    subTotal += 6.95;
                }
                else if (cmbAppetizer.SelectedIndex == 3)
                {
                    subTotal += 8.95;
                }
                else if (cmbAppetizer.SelectedIndex == 4)
                {
                    subTotal += 10.95;
                }
                else
                {
                    subTotal += 6.95;
                }
            }
            txtSubTotal.Text = subTotal.ToString();
            tax = subTotal * 13 / 100;
            txtTax.Text = tax.ToString();
            total = subTotal + tax;
            txtTotal.Text = total.ToString();
        }

        private void cmbMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainCourse.SelectedIndex > 0)
            {
                listBox1.Items.Add(cmbMainCourse.SelectedItem);
                if (cmbMainCourse.SelectedIndex == 1)
                {
                    subTotal += 13.95;

                }
                else if (cmbMainCourse.SelectedIndex == 2)
                {
                    subTotal += 11.95;
                }
                else if (cmbMainCourse.SelectedIndex == 3)
                {
                    subTotal += 20.95;
                }
                else if (cmbMainCourse.SelectedIndex == 4)
                {
                    subTotal += 13.95;
                }
                else
                {
                    subTotal += 14.95;
                }
            }
            txtSubTotal.Text = subTotal.ToString();
            tax = subTotal * 13 / 100;
            txtTax.Text = tax.ToString();
            total = subTotal + tax;
            txtTotal.Text = total.ToString();
        }

        private void cmbDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDessert.SelectedIndex > 0)
            {
                listBox1.Items.Add(cmbDessert.SelectedItem);
                if (cmbDessert.SelectedIndex == 1)
                {
                    subTotal += 5.95;

                }
                else if (cmbDessert.SelectedIndex == 2)
                {
                    subTotal += 3.95;
                }
                else if (cmbDessert.SelectedIndex == 3)
                {
                    subTotal += 5.95;
                }
               
                else
                {
                    subTotal += 5.95;
                }
            }
            txtSubTotal.Text = subTotal.ToString();
            tax = subTotal * 13 / 100;
            txtTax.Text = tax.ToString();
            total = subTotal + tax;
            txtTotal.Text = total.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbAppetizer.SelectedIndex = 0;
            cmbBeverage.SelectedIndex = 0;
            cmbMainCourse.SelectedIndex = 0;
            cmbDessert.SelectedIndex = 0;
            listBox1.Items.Clear();
            subTotal = 0;
            tax = 0;
            total = 0;
            txtSubTotal.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";


        }
    }
}
