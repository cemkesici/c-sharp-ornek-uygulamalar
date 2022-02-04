using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel.Links.Add(30, 8, "www.yahoo.com");
            linkLabel.LinkColor = Color.Blue;
            linkLabel.VisitedLinkColor = Color.Red;
            linkLabel.ActiveLinkColor = Color.Brown;
            linkLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }
    }
}
