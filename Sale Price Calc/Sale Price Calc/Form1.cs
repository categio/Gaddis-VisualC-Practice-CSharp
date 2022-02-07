using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calc
{
    public partial class Form1 : Form
    {
        //constant fields
        const decimal FIVE_CENTS_VAL = 0.05m;
        const decimal TEN_CENTS_VAL = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VAL = 0.25m;
        const decimal FIFTY_CENTS_VAL = 0.50m;
        decimal total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void fivePictureBox_Click(object sender, EventArgs e)
        {
            //add val of .05 to total
            total += FIVE_CENTS_VAL;
            //display total in currency format
            totOutputLabel.Text = total.ToString("c");
        }

        private void tenCentPictureBox_Click(object sender, EventArgs e)
        {
            //add val of .10 to total
            total += TEN_CENTS_VAL;
            //display total in currency format
            totOutputLabel.Text = total.ToString("c");
        }

        private void twenty5CentPictureBox_Click(object sender, EventArgs e)
        {
            //add val of .25 to total
            total += TWENTY_FIVE_CENTS_VAL;
            //display total in currency format
            totOutputLabel.Text = total.ToString("c");
        }

        private void fiftyCentPictureBox_Click(object sender, EventArgs e)
        {
            //add val of .50 to total
            total += FIFTY_CENTS_VAL;
            //display total in currency format
            totOutputLabel.Text = total.ToString("c");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clears the output box
            totOutputLabel.Text = "";
            //set focus back to the five cents box
            fivePictureBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
