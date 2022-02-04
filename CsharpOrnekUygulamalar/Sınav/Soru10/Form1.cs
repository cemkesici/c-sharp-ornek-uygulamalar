using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru10
{
    public partial class Form1 : Form
    {
        Graphics grafik;
        Graphics grafik1;
        Random rastgele = new Random();
        int x, y, x2, y2, kalinlik;
        Pen kalem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kalinlik = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kalinlik = 5;
        }
              

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            kalinlik = 9;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            label10.Text = e.X.ToString();
            label11.Text = e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            label10.Text = "0";
            label11.Text = "0";
            label13.Text = "0";
            label15.Text = "0";
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                grafik1.Clear(Color.FromArgb(rastgele.Next(0, 255), rastgele.Next(0, 255), rastgele.Next(0, 255)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grafik.Clear(pictureBox1.BackColor);

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            grafik1 = pictureBox2.CreateGraphics();
            label13.Text = e.X.ToString();
            label15.Text = e.Y.ToString();
            Rectangle daire = new Rectangle();
            Pen kalem = new Pen(Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value), kalinlik);
            if (e.Button != MouseButtons.Left) return;
            daire.X = e.X - 1;
            daire.Y = e.Y - 1;
            daire.Width = 5;
            daire.Height = 5;
            grafik1.DrawEllipse(kalem, daire);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Çizgi")
            {
                label3.Text = "X2";
                label4.Text = "Y2";
            }
            if (comboBox1.Text == "Daire")
            {
                label3.Text = "En";
                label4.Text = "Boy";
            }
            if (comboBox1.Text == "Dörtgen")
            {
                label3.Text = "En";
                label4.Text = "Boy";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Pen kalem = new Pen(Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value), kalinlik);
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            x2 = Convert.ToInt32(textBox3.Text);
            y2 = Convert.ToInt32(textBox4.Text);
            switch (comboBox1.Text)
            {
                case "Çizgi":
                    {
                        grafik = pictureBox1.CreateGraphics();
                        grafik.DrawLine(kalem, x, y, x2, y2);
                        break;
                    }
                case "Daire":
                    {
                        grafik = pictureBox1.CreateGraphics();
                        grafik.DrawEllipse(kalem, x, y, x2, y2);
                        break;
                    }
                case "Dörtgen":
                    {
                        grafik = pictureBox1.CreateGraphics();
                        grafik.DrawRectangle(kalem, x, y, x2, y2);
                        break;
                    }
            }
        }
    }
}
