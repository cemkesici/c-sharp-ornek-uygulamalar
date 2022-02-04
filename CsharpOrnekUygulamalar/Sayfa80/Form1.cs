using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa80
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) + 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) - 1);
            }
            if (e.Button == MouseButtons.XButton1)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) + 10);
                if (e.Button == MouseButtons.XButton2)
                {
                    textBox1.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) -10);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Left = e.X;
            textBox1.Top = e.Y;
            textBox1.Text = e.X.ToString() + "," + e.Y.ToString();
        }
    }
}
