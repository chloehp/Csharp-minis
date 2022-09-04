using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_15_ClickGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int theScore = Convert.ToInt16(label1.Text);

            theScore = theScore + 1;

            label1.Text = Convert.ToString(theScore);
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int theTimer = Convert.ToInt16(label2.Text);

            theTimer = theTimer - 1;

            label2.Text = Convert.ToString(theTimer);

            if (theTimer == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
            }

        }
    }
}
