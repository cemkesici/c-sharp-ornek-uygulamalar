using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal sayi1, sayi2, hafiza_DEGER;
        Boolean sonuclandi;
        string islem;
        private void txt_sayi_giris_Keypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void rakam_girisleri(object sender, EventArgs e)
        {
            if (sonuclandi)
            {
                txt_sayi_giris_Keypress.Text = (sender as Button).Text;
                sonuclandi = false;
            }
            else
            {
                
            }
        }
    }
}
