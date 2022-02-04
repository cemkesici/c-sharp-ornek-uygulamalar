using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa79
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Green;
            textBox3.BackColor = Color.Green;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.MouseEnter += new EventHandler(textBox1_MouseEnter);
            textBox3.MouseEnter += new EventHandler(textBox1_MouseEnter);
            textBox2.MouseLeave += new EventHandler(textBox1_MouseLeave);
            textBox3.MouseLeave += new EventHandler(textBox1_MouseLeave);
            textBox2.MouseHover += new EventHandler(textBox1_MouseHover);
            textBox3.MouseHover += new EventHandler(textBox1_MouseHover);
        }
    }
}
