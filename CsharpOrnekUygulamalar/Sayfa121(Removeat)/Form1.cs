using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa121_Removeat_
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
            listBox1.Items.Insert(2,"sdgdsgs");
            listBox1.Items.RemoveAt(1);
        }
    }
}
