using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles; //holds miles driven entered by user
            double gallons; //holds gallons used entered by user
            double mpg; //holds the mpg calculated
            //retreive miles given and assign to the miles variable
            miles = double.Parse(milesTextBox.Text);
            //retrieve gallons used and assign to the gallons variable
            gallons = double.Parse(gallonsTextBox.Text);
            //calculate mpg with following formula: miles drive/gallons used
            mpg = miles / gallons;
            //display mpg calculated in teh mpgLabel control
            mpgLabel.Text = mpg.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            milesTextBox.Text = "";
            gallonsTextBox.Text = "";
            mpgLabel.Text = "";
        }
    }
}
