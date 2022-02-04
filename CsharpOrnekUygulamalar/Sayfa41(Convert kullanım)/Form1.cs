using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa41_Convert_kullanım_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double carpım(int sayi1,int sayi2)
        {
            double sayi3 = sayi1 * sayi2;
            return sayi3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = carpım(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show(Convert.ToString(sonuc));
        }
    }
}
