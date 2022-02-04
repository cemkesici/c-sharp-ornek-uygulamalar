using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa54_Mesa_Başlık_Düğmeler_Simge_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
        }
    }
}
