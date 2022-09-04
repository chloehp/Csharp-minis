using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_19_More_key_moving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left - 5;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 5;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                timer1.Enabled = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                timer2.Enabled = false;
            }
        }
    }
}
