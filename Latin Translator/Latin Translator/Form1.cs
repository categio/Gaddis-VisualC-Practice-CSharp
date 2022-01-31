using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            meaningLabel.Text = "Sinister means Left in Latin.";
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            meaningLabel.Text = "Dexter means Right in Latin.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meaningLabel.Text = "Medium means Center in Latin";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
