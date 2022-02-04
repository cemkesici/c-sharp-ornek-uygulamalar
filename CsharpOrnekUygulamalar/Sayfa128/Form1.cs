using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayfa128
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            lstadsayad.Items.Add(txt_adısoyadı.Text);
            lstbolum.Items.Add(txt_bolum.Text);
            lstbabaad.Items.Add(txt_babaadi.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter bilgiyaz = System.IO.File.CreateText("C:\\bilgi_kayit.dat");
            for (int i = 0; i < lstadsayad.Items.Count; i++)
            {
                bilgiyaz.WriteLine(lstadsayad.Items[i]);
                bilgiyaz.WriteLine(lstbolum.Items[i]);
                bilgiyaz.WriteLine(lstbabaad.Items[i]);
            }
            bilgiyaz.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.TextReader bilgioku = System.IO.File.OpenText("C:\\bilgi_kayit.dat");
                String satir;
                while ((satir = bilgioku.ReadLine()) != null)
                {
                    lstadsayad.Items.Add(satir);
                    satir = bilgioku.ReadLine();
                    lstbolum.Items.Add(satir);
                    satir = bilgioku.ReadLine();
                    lstbabaad.Items.Add(satir);
                }
                bilgioku.Close();
            }
            catch
            {

            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            int indis;
            indis = lstadsayad.SelectedIndex;
            if (indis < 0)
            {
                MessageBox.Show("Eleman seçin");
            }
            else
            {
                lstadsayad.Items.RemoveAt(indis);
                lstbolum.Items.RemoveAt(indis);
                lstbabaad.Items.RemoveAt(indis);
            }
        }

        private void tiklanirsa(object sender, EventArgs e)
        {
            int indis;
            indis = (sender as ListBox).SelectedIndex;
            lstadsayad.SelectedIndex = indis;
            lstbolum.SelectedIndex = indis;
            lstbabaad.SelectedIndex = indis;
        }
    }
}
