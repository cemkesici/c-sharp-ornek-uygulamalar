﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa76
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        decimal sayi1, sayi2, sonuc = 0;

   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDecimal(textBox1.Text);
            sayi2= Convert.ToDecimal(textBox2.Text);
            sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDecimal(textBox1.Text);
            sayi2 = Convert.ToDecimal(textBox2.Text);
            sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }

    }
}
