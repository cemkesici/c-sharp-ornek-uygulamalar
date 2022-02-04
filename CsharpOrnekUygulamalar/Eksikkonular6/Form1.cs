using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eksikkonular6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;
            openFileDialog1.ShowHelp = true;
            openFileDialog1.Filter = "Resim| *.jpg";
            openFileDialog1.Title = "resim seç";
            openFileDialog1.Multiselect = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                timer1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                DialogResult c;
                c = MessageBox.Show("dosya silinecek");
                if (c == DialogResult.OK)
                {
                    for(int i=0; i < openFileDialog2.FileName.Length; i++)
                    {
                        try
                        {
                            System.IO.FileInfo dosya = new System.IO.FileInfo(openFileDialog2.FileNames[i]);
                            dosya.Delete();
                        }
                        catch
                        {
                            MessageBox.Show("dosya silinemedi");
                        }
                    }
                }
            }
        }
    }
}
