using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa41_Overload_
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
        long islem(long sayi1 , long sayi2)
        {
            return sayi1 * sayi2;
        }
        int islem(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            long sonuc;
            int sayi1 = 2, sayi2 = 5;
            sonuc = islem(sayi1, sayi2);
            //sonuc = islem(sayi1,sayi2);
        }
    }
}
