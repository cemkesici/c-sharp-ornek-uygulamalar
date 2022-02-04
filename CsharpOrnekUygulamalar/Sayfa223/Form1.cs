﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(textBox2.Text))
            {
                listBox1.Items.Clear();
                ara(textBox2.Text);
            }
        }
        void ara(string yol)
        {
            string[] dosyalar;
            dosyalar = System.IO.Directory.GetDirectories(yol, textBox1.Text);
            listBox1.Items.AddRange(dosyalar);
            string[] klasörler;
            klasörler = System.IO.Directory.GetDirectories(yol);
            for(int i=0; i < klasörler.Length; i++)
            {
                ara(klasörler[i]);
                label1.Text = klasörler[i];
                Application.DoEvents();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   textBox1.Text = "*.jpg";
            textBox2.Text = "D:\\resimler";
            this.AcceptButton = button1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
