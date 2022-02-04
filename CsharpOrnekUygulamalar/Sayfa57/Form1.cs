using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sinavnotu;
            sinavnotu = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Sınav notunu girin", "Not girişi", "0", 100, 100));
            if (sinavnotu >= 50)
            {
                MessageBox.Show("Geçtiniz");
            }
            else
                MessageBox.Show("Kladınız");
        }
    }
}
