using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi1 = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma" };
            string[] dizi2 = { "Ocak", "şubat", "mart", "nisan", "mayıs" };
            listBox1.Items.Add("GÜNLER ");
            listBox1.Items.Add(" ");
            listBox1.Items.AddRange(dizi1);
            listBox2.Items.Add("AYLAR ");
            listBox2.Items.Add(" ");
            listBox2.Items.AddRange(dizi2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object[] x = new object[listBox1.Items.Count + listBox2.Items.Count];
            listBox1.Items.CopyTo(x, 0);
            listBox2.Items.CopyTo(x, listBox1.Items.Count);
            listBox3.Items.Add("karışık ");
            listBox3.Items.Add(" ");
            listBox3.Items.AddRange(x);
        }
    }
}
