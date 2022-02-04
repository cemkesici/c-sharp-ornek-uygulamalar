using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 kayı = new Form2();
            DialogResult c;
            kayı.Text = "Çıkış ekranı";
            c = kayı.ShowDialog();
            if (c == DialogResult.Yes)
            {
                System.IO.TextWriter dosya = System.IO.File.CreateText("c:\\kayıt.dat");
                dosya.Close();
            }
            if (c == DialogResult.No)
            {

            }
            if (c == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
