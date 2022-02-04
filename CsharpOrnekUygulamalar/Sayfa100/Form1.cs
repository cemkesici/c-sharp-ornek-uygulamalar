using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yenisayi = 0;
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenisayi++;
            Form2 cocuk = new Form2();
            cocuk.MdiParent = this;

            cocuk.Text = "Yeni Form" + yenisayi.ToString();
            cocuk.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
