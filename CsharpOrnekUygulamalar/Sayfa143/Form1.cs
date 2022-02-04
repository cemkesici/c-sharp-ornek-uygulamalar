using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] renkler = { "Kırmızı", "yeşil", "sarı", "mavi", "pembe", "kahverengi" };
            comboBox1.Items.AddRange(renkler);
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color renk = Color.Black;
            string eleman;
            eleman = comboBox1.Items[e.Index].ToString();

            if (eleman == "Kırmızı")
            {
                renk = Color.Red;
            }
            if (eleman == "sarı")
            {
                renk = Color.Yellow;
            }
            if (eleman == "mavi")
            {
                renk = Color.Blue;
            }
            if (eleman == "pembe")
            {
                renk = Color.Pink;
            }
            if (e.State == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Turquoise), e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);

            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(renk), e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
            }
            e.Graphics.DrawString(eleman, e.Font, new SolidBrush(Color.White),e.Bounds.Left, e.Bounds.Top);
            e.DrawFocusRectangle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color renk = Color.Black;
            string eleman;
            eleman = comboBox1.SelectedItem.ToString();
            if (eleman == "Kırmızı")
            {
                renk = Color.Red;
            }
            if (eleman == "sarı")
            {
                renk = Color.Yellow;
            }
            if (eleman == "mavi")
            {
                renk = Color.Blue;
            }
            if (eleman == "pembe")
            {
                renk = Color.Pink;
            }
            this.BackColor = renk;
            comboBox1.BackColor = renk;
            comboBox1.ForeColor = Color.White;        }
    }
}
