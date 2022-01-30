using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "This is Finland's Flag!";
        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "This is France's Flag!";
        }

        private void germanyPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "This is Germany's Flag!";
        }
    }
}
