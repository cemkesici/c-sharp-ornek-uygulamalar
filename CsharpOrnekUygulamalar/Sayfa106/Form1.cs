using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.HideSelection = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.SelectedText = textBox1.SelectedText.ToUpper();
            }
            else
            {
                textBox1.SelectedText = textBox1.Text.ToUpper();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.SelectedText = textBox1.SelectedText.ToLower();
            }
            else
            {
                textBox1.SelectedText = textBox1.Text.ToLower();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yer;
            string aranan_kelime;
            aranan_kelime = textBox2.Text;
            if (textBox2.SelectionLength > 0)
            {
                yer = textBox1.SelectionStart + textBox1.SelectedText.IndexOf(aranan_kelime);
            }
            else
            {
                yer = textBox1.Text.IndexOf(aranan_kelime);
            }
            if (yer == 0)
            {
                MessageBox.Show("Bulunamadı");
            }
            else
            {
                textBox1.Select(yer, aranan_kelime.Length);
                textBox1.ScrollToCaret();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
               textBox1.SelectedText="";
            }
            else
            {
                textBox1.Text = "";
            }
        }
        }
    }

