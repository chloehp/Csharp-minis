using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_17_Move_Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left - 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top + 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top - 5;
        }
    }
}
