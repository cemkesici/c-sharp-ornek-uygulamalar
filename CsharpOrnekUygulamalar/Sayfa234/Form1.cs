using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            e.Graphics.DrawString("CEM KESİCİ",new Font("Thoma",30,FontStyle.Bold),b,60,10);
            e.Graphics.FillRectangle(b, 0, 0, 50, 80);

            System.Drawing.Drawing2D.HatchBrush hb;
            hb = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LargeGrid, Color.Red);

            e.Graphics.DrawString("CEM KESİCİ", new Font("Thoma", 30, FontStyle.Bold), b, 60, 100);
            e.Graphics.FillRectangle(b, 0, 0, 50, 80);
            TextureBrush tb = new TextureBrush(Image.FromFile("C:\\POWER.ico"));
            e.Graphics.DrawString("CEM KESİCİ",new Font("Thoma", 30, FontStyle.Bold), b, 60, 190);
        }
    }
}
