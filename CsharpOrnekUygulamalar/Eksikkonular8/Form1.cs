using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eksikkonular8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Ankara gazi üni");
            treeView1.Nodes.Add("ddsfsdf üni");
            treeView1.Nodes.Add("sdgsghyh üni");
            treeView1.Nodes.Add("htrhrhfgn üni");
        }
    
    }
}
