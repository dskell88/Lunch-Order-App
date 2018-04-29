using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_200_Skelly_Daniel
{
    public partial class Lab10 : Form
    {
        public Lab10()
        {
            InitializeComponent();
            rdoHamburger.CheckedChanged += new EventHandler(Radio_CheckChanged);
            rdoPizza.CheckedChanged += new EventHandler(Radio_CheckChanged);
            rdoSalad.CheckedChanged += new EventHandler(Radio_CheckChanged);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {


            decimal subTotal1 = 0;                                  //assigns the values of subtotal, tax, and order total before user checks boxes and radio buttons
            decimal tax = 0.075m;
            decimal orderTotal = 0;

            if (rdoHamburger.Checked)                              //a series of if statements that calculates the subtotal, tax, and order total after the user places order
            {
                subTotal1 += 6.95m;

                if (chkAddOn1.Checked)
                {
                    subTotal1 += 0.75m;

                }
                if (chkAddOn2.Checked)
                {
                    subTotal1 += 0.75m;
                }
                if (chkAddOn3.Checked)
                {
                    subTotal1 += 0.75m;
                }

                tax *= subTotal1;
                orderTotal = tax + subTotal1;
                subTotal.Text = subTotal1.ToString("C");
                txtTax.Text = tax.ToString("C");
                txtOrderTotal.Text = orderTotal.ToString("C");
            }
            else if (rdoPizza.Checked)
            {
                subTotal1 += 5.95m;

                if (chkAddOn1.Checked)
                {
                    subTotal1 += 0.50m;

                }
                if (chkAddOn2.Checked)
                {
                    subTotal1 += 0.50m;
                }
                if (chkAddOn3.Checked)
                {
                    subTotal1 += 0.50m;
                }
                tax *= subTotal1;
                orderTotal = tax + subTotal1;
                subTotal.Text = subTotal1.ToString("C");
                txtTax.Text = tax.ToString("C");
                txtOrderTotal.Text = orderTotal.ToString("C");
            }
            else if (rdoSalad.Checked)
            {
                subTotal1 += 4.95m;

                if (chkAddOn1.Checked)
                {
                    subTotal1 += 0.25m;

                }
                if (chkAddOn2.Checked)
                {
                    subTotal1 += 0.25m;
                }
                if (chkAddOn3.Checked)
                {
                    subTotal1 += 0.25m;
                }
                tax *= subTotal1;
                orderTotal = tax + subTotal1;
                subTotal.Text = subTotal1.ToString("C");
                txtTax.Text = tax.ToString("C");
                txtOrderTotal.Text = orderTotal.ToString("C");
            }



        }

        private void ClearTotals()                                              //clears the order text fields after the user selects a radio button
        {
            subTotal.Text = "";
            txtTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void ClearAddOns()                                            //clears the add on check boxes after the user selects a radio button
        {

            chkAddOn1.Checked = false;
            chkAddOn2.Checked = false;
            chkAddOn3.Checked = false;
        }


       
        
        private void Radio_CheckChanged(object sender, EventArgs e)         //changes the text of the addons and group box after the user selects a radio button
        {
            if (rdoHamburger.Checked)
            {
                groupBox1.Text = "Add-On Items ($0.75 each)";
                chkAddOn1.Text = "Lettuce, Tomato, and Onions";
                chkAddOn2.Text = "Ketchup, Mustard, and Mayo";
                chkAddOn3.Text = "French Fries";
            }
            else if (rdoPizza.Checked)
            {

                groupBox1.Text = "Add-On Items ($0.50 each)";
                chkAddOn1.Text = "Pepperoni";
                chkAddOn2.Text = "Sausage";
                chkAddOn3.Text = "Olives";

            }
            else if (rdoSalad.Checked)
            {
                groupBox1.Text = "Add-On Items ($0.25 each)";
                chkAddOn1.Text = "Croutons";
                chkAddOn2.Text = "Bacon Bits";
                chkAddOn3.Text = "Bread Sticks";
            }
            ClearTotals();
            ClearAddOns();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
