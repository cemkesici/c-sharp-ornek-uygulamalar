using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa125
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
            string ekle;
            ekle = textBox1.Text;
       
            if (listBox1.FindString(ekle)>-1)
            {
                MessageBox.Show("kelime var");
            }
            else if (listBox1.FindString(ekle) ==-1)
            {
                MessageBox.Show("kelime eklendi");
                listBox1.Items.Add(ekle);
            }
        }
    }
}
