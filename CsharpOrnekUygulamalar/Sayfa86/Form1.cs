using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa86
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.HelpButton = true;
        }
        private void textBox1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowPopup(textBox1, "Bu kutu bilgi girişi içindir", hlpevent.MousePos);
        }

    }
}
