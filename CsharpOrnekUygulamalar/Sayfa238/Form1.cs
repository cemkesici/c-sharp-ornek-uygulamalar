using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa238
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image resim = Image.FromFile("c:\\serdarsouth.jpg");
            System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();
            p.AddEllipse(0, 0, resim.Width, resim.Height);
            e.Graphics.RotateTransform(315);
            e.Graphics.DrawImage(resim, -120, 120);
        }
    }
}
