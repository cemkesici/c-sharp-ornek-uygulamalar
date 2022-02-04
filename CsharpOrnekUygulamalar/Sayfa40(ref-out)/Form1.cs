using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa40_ref_out_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void deger(int sayi1, int sayi2,ref int sayi3)
              // void deger(int sayi1, int sayi2, out int sayi3)

        {
            sayi1 = 100;
            sayi2 = 200;
            sayi3 = 300;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = 5, s2 = 10, s3 = 15;
            deger(s2, s2, ref s3);
            //deger(s2, s2, out s3);
            MessageBox.Show(s1.ToString() + "\t" + s2.ToString() + "\t" + s3.ToString());
        }
    }
}
