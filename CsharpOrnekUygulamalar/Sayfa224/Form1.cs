using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa224
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string yol=openFileDialog1.FileName;
                listBox1.Items.Add("Bulunduğu klasör; " + Path.GetDirectoryName(yol));
                listBox1.Items.Add("Ad; " + Path.GetFileName(yol));
                listBox1.Items.Add("Uzantısı; " + Path.GetExtension(yol));
                listBox1.Items.Add("Uzantısız Dosya ad; " + Path.GetFileNameWithoutExtension(yol));
                listBox1.Items.Add("Tam yOL; " + Path.GetFullPath(yol));
                listBox1.Items.Add("kök Klasörü; " + Path.GetPathRoot(yol));
              
            }
        }
    }
}
