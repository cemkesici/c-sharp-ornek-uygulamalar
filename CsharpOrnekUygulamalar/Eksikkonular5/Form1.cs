using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eksikkonular5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Açılacak dosya";
            openFileDialog1.Filter = "Text | *.txt |" + 
                                     "Kelime | *.rtf |" + 
                                     "resim | *.png ";
           openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    textBox1.Text = "";
                }
                if (openFileDialog1.FilterIndex == 2)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                if (openFileDialog1.FilterIndex == 3)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }
    }
}
