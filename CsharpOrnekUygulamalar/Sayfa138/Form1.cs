using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayfa138
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for(int İ = 0; İ < 1000; İ++)
            {
                int rastgele = r.Next(100);
                listBox1.Items.Add(rastgele.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslama, bitis;
            TimeSpan fark;
            this.Text = "Lütfen bekleyin";
            baslama = DateTime.Now;
            listBox1.BeginUpdate();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for(int j=i; j < listBox1.Items.Count; j++)
                {
                    int sayi1, sayi2;
                    sayi1 = Convert.ToInt16(listBox1.Items[i]);
                    sayi2 = Convert.ToInt16(listBox1.Items[j]);
                    if (sayi1 > sayi2)
                    {
                        int c = sayi2;
                        sayi2 = sayi1;
                        sayi1 = c;
                        listBox1.Items[i] = sayi1.ToString();
                        listBox1.Items[j] = sayi2.ToString();
                    }
                }
            }
            listBox1.EndUpdate();
            bitis = DateTime.Now;
            fark = bitis - baslama;
            this.Text = "İşlem süresi" + fark.ToString().Substring(0, 8);
        }
    }
}
