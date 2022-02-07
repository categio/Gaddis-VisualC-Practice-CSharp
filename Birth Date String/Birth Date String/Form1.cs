using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            //declare string variable
            string output;
            //concatinate all inputs and build string
            //held in @output param
            output = dayOfWeekTextbox.Text + ", " +
                monthTextBox.Text + " " +
                dayOfMonthTextBox.Text + ", " +
                yearTextBox.Text;
            //display output string in label control
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears all text boxes
            dayOfWeekTextbox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";
            //clear dateOutputLabel control
            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close program/form
            this.Close();
        }
    }
}
