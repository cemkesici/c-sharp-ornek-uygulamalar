using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa147_ProgressBar_
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
            for(int i=0; i < 200; i++)
            {
                int rastgele = r.Next(100);
                listBox1.Items.Add(rastgele.ToString());

            }
            progressBar1.Maximum = 500;
            progressBar1.Minimum = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslamazaman, bitiszaman;
            TimeSpan fark;
            this.Text = "Lütfen bekleyin";
            baslamazaman = DateTime.Now;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                for(int j=0; i<listBox1.Items.Count; i++)
                {
                    int sayi1, sayi2;
                    sayi1 = Convert.ToInt16(listBox1.Items[i]);
                    sayi2 = Convert.ToInt16(listBox1.Items[j]);
               
                if (sayi2> sayi1)
                {
                    int c = sayi2;
                    sayi2 = sayi1;
                    sayi1 = c;
                    listBox1.Items[i] = sayi1.ToString();
                        listBox1.Items[j] = sayi2.ToString();
                    } 
                }
                progressBar1.Value = i;
            }
            bitiszaman = DateTime.Now;
            fark = bitiszaman - baslamazaman;
            this.Text = "İşlem süresi" + fark.ToString().Substring(0, 5);
        }

        
    }
}
