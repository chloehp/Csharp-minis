using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_18_Move_w_keys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char theKey = e.KeyChar;

            label1.Text = Convert.ToString(theKey);

            if ((theKey == 'd') || (theKey == 'D'))
            {
                pictureBox1.Left = pictureBox1.Left + 5;
            }
            
            else if ((theKey == 'a') || (theKey == 'A'))
            {
                pictureBox1.Left = pictureBox1.Left - 5;
            }

            else if ((theKey == 'w') || (theKey == 'W'))
            {
                pictureBox1.Top = pictureBox1.Top - 5;
            }

            else if ((theKey == 's') || (theKey == 'S'))
            {
                pictureBox1.Top = pictureBox1.Top + 5;
            }                
        }
    }
}
