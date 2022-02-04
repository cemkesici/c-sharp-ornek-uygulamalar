using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iller[] il ={
                new iller("izmit","41"),
                 new iller("ist","34"),
                  new iller("dzc","81"),
                   new iller("ankara","06")
            };
            comboBox1.Items.AddRange(il);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                return;
            }
            label1.Text = ((iller)comboBox1.SelectedItem).adi;
            label2.Text = ((iller)comboBox1.SelectedItem).plaka;
        }
    }
}
