using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa235
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] partiler = new string[20];
        int[] oylar = new int[20];
        int sıra, toplam;

        private void button1_Click(object sender, EventArgs e)
        {
            if (sıra == 20)
            {
                MessageBox.Show("En çok 20 olabilir");
                return;
            }
            try
            {
                oylar[sıra] = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Hata olabilir");
                return;
            }
            partiler[sıra] = textBox1.Text;
            toplam += oylar[sıra];
            sıra++;
            Graphics gr;
            gr = this.CreateGraphics();
            int basla=0,yay = 0;
            Color renk;
            System.Drawing.Drawing2D.HatchBrush fırca;
            Random r = new Random();
            for (int i = 0; i < sıra; i++)
            {
                yay = 360 * oylar[i] / toplam;
                renk = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                fırca = new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)r.Next(50), renk);

                gr.FillPie(fırca, 0, 80, 200, 200, basla, yay);
                gr.FillRectangle(fırca, 210, 80 + i * 20, 18, 18);
                gr.DrawString(partiler[i] + "=" + oylar[i].ToString(),new Font ("Thoma",8,FontStyle.Regular),new SolidBrush(Color.Red),230,80+i*20);
                basla += yay;
            }

        }
    }
}
