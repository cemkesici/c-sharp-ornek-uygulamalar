using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa88
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int org_x = 800,org_y=600;
        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle cozunurluk = new Rectangle();
            cozunurluk = Screen.GetBounds(cozunurluk);
            float oran_x, oran_y;
            oran_x = (float)cozunurluk.Width / org_x;
            oran_y = (float)cozunurluk.Height / org_y;
            this.Left = 0;
            this.Top = 0;
            this.Scale(oran_x, oran_y);
        }
    }
}
