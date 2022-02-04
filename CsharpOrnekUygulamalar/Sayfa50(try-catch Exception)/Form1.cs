using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa50_try_catch_Exception_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi1 = 5, sayi2 = 0;
            decimal sonuc = 0;
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch(Exception hata)
            {
                MessageBox.Show("Program bir hatayla karşılaştı hata nedeni: "+"aşağıda belirtilmiştir. \r\n"+hata.Message);

            }
        }
    }
}
