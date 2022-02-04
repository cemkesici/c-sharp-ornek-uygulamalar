using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa123_eleman_sayı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = { "pzt", "salı", "çrş" };
            listBox1.Items.AddRange(gunler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan;
            aranan = textBox1.Text;
            int yer;
            yer = listBox1.Items.IndexOf(aranan);
            if (yer < 0)
            {
                MessageBox.Show("kelime yok");
            }
            else
            {
                MessageBox.Show("kelime "+(yer+1)+". sırada");
            }
        }
    }
}
