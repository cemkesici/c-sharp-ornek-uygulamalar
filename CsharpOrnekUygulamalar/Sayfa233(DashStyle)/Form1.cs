using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa233_DashStyle_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem1 = new Pen(Color.Red, 10);
            e.Graphics.DrawLine(kalem1, 20, 20, 200, 20);

            Pen kalem2 = new Pen(new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Cross,Color.White),10);
            e.Graphics.DrawLine(kalem2, 20, 50, 200, 50);

            Pen kalem3 = new Pen(new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LightHorizontal, Color.White), 10);
            e.Graphics.DrawLine(kalem2, 20, 80, 200, 80);

            Pen kalem4=new Pen(Color.Red,10);
                kalem4.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            e.Graphics.DrawLine(kalem2, 110, 50, 200, 110);
        }
    }
}
