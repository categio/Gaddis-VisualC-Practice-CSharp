using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice; //holds entered val for orig. price
            decimal discountPercent; //holds entered val for disc %
            decimal discountAmt; //calculated amount of item's discount
            decimal salePrice; //calculated sale price
            //get original price entered by user and parse from txt to decimal
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            //get discount percent entered by user and parse text to decimal
            discountPercent = decimal.Parse(discountPercentTextBox.Text);
            //move decimal point 2 spaces 
            discountPercent /= 100;
            //calculate amount of discount
            discountAmt = originalPrice * discountPercent;
            //calculate sale price
            salePrice = originalPrice - discountAmt;
            //display sale price in output box
            outputSalePriceLabel.Text = salePrice.ToString("c");
                
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the entered data so user can use again
            originalPriceTextBox.Text = "";
            discountPercentTextBox.Text = "";
            outputSalePriceLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the program/form
            this.Close();
        }
    }
}
