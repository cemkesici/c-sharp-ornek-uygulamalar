using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayfa129
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] isimler = { "Ahmet", "Serdar", "Cem", "Kesici" };
            listBox1.Items.AddRange(isimler);
        }
int yer=-1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            string aranan;
            aranan = textBox1.Text;
            yer = listBox1.FindStringExact(aranan,yer);
            if (yer < 0)
            {
                MessageBox.Show("bulunamadı");

            }
            else
            {
                MessageBox.Show((yer + 1).ToString() + ".eleman");
                listBox1.SelectedIndex = yer;
            }
        }
    }
}
