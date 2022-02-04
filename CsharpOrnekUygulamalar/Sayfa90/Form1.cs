using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa90
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 ikinci_sayfa;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ikinci_sayfa == null)
            {
                ikinci_sayfa = new Form2();
                ikinci_sayfa.FormClosed += new FormClosedEventHandler(kapandı);
                ikinci_sayfa.Show();
            }
            else
            {
                ikinci_sayfa.Activate();
            }
        }
        public void kapandı(object sender, EventArgs e)
        {
            ikinci_sayfa = null;
        }
    }
}
