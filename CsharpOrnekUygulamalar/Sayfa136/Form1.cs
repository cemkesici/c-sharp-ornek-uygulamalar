using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayfa136
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
            listBox2.Items.AddRange(listBox1.Items);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] list = { "asdas", "jkghkjg", "jhjgh", "kjghjv", "jkghjb" };
            listBox1.Items.AddRange(list);
        }
    }
}
