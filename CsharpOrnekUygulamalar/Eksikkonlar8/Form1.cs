using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eksikkonlar8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Text = "başlası";

        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Text = "bitti";
        }
        int sayfano = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            sayfano += 1;
            e.Graphics.DrawString("Sayfa" + sayfano.ToString(), new Font("Thoma", 50, FontStyle.Regular), Brushes.Black, 100, 100);
            if (sayfano == 3)
            {
                e.HasMorePages = false;
                sayfano = 0;
            }
            else
                e.HasMorePages = true;
        }
    }
}
