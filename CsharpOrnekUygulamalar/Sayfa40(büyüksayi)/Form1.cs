using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa40_büyüksayi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int max(int sayi1,int sayi2)
        {
            int donendeger = 0;
            if (sayi1 > sayi2)
            {
                donendeger = sayi1;
            }
            else if (sayi2 > sayi1)
            {
                donendeger = sayi2;
            }
            return donendeger;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int gelensayi = max(5, 10);
            MessageBox.Show(gelensayi.ToString());
        }
    }
}
