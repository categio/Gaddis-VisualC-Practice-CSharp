﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1; //holds test one score
                double test2; //holds test two score
                double test3; //holds test three score
                double average; //holds the average score
                //collect user entered scores
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                //calculate average from user collected scores
                average = (test1 + test2 + test3) / 3.0;
                //display avg test score, output rounded to 1 decimal pt.
                averageLabel.Text = average.ToString("n1");
            } catch (Exception ex)
            {
                //display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all the data entered and printed
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close program/form
            this.Close();
        }
    }
}
