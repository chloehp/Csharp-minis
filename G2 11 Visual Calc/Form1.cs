using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_11_Visual_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int theFirstNumber = Convert.ToInt16(textBox1.Text);
            int theSecondNumber = Convert.ToInt16(textBox2.Text);

            int theAddTotal = theFirstNumber + theSecondNumber;

            label1.Text = Convert.ToString(theAddTotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int theFirstNumber = Convert.ToInt16(textBox1.Text);
            int theSecondNumber = Convert.ToInt16(textBox2.Text);

            int theSubTotal = theFirstNumber - theSecondNumber;

            label1.Text = Convert.ToString(theSubTotal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int theFirstNumber = Convert.ToInt16(textBox1.Text);
            int theSecondNumber = Convert.ToInt16(textBox2.Text);

            int theMultTotal = theFirstNumber * theSecondNumber;

            label1.Text = Convert.ToString(theMultTotal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int theFirstNumber = Convert.ToInt16(textBox1.Text);
            int theSecondNumber = Convert.ToInt16(textBox2.Text);

            int theDivTotal = theFirstNumber / theSecondNumber;

            label1.Text = Convert.ToString(theDivTotal);
        }
    }
}
