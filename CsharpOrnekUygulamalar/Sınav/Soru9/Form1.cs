using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked)
            {
                label1.Top = label1.Top - 1;
            }
            if (radioButton2.Checked)
            {
                label1.Top = label1.Top -5;
            }
            if (radioButton3.Checked)
            {
                label1.Top = label1.Top - 10;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Left = label1.Left + 1;
            }
            if (radioButton2.Checked)
            {
                label1.Left = label1.Left +5;
            }
            if (radioButton3.Checked)
            {
                label1.Left = label1.Left + 10;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Left = label1.Left - 1;
            }
            if (radioButton2.Checked)
            {
                label1.Left = label1.Left - 5;
            }
            if (radioButton3.Checked)
            {
                label1.Left = label1.Left - 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Top = label1.Top + 1;
            }
            if (radioButton2.Checked)
            {
                label1.Top = label1.Top +5;
            }
            if (radioButton3.Checked)
            {
                label1.Top = label1.Top+10;
            }
        }
    }
}
