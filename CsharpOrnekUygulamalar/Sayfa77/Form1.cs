using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa77
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Left)
                {
                    textBox1.Left = textBox1.Left - 5;
                }
                if (e.KeyCode == Keys.Right)
                {
                    textBox1.Left = textBox1.Left + 5;
                }
                if (e.KeyCode == Keys.Up)
                {
                    textBox1.Top= textBox1.Top - 5;
                }
                if (e.KeyCode == Keys.Down)
                {
                    textBox1.Top = textBox1.Top+5;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
        }
    }
}
