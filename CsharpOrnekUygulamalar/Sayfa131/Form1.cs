using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayfa131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meslekler = { "Mühendis", "polis", "doktor", "avukat", "güvenlik", "işsiz" };
            comboBox1.Items.AddRange(meslekler);

            string[] birim = { "Mühendislik", "polislik", "doktorlik", "lik", "güvenliklik", "işsizlik" };
            comboBox2.Items.AddRange(birim);
            try
            {
                System.IO.TextReader dosya_ac = System.IO.File.OpenText("C:\\personel.dat");
                string satir;
                while((satir=dosya_ac.ReadLine())!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = dosya_ac.ReadLine();
                    listBox2.Items.Add(satir);
                    satir = dosya_ac.ReadLine();
                    listBox3.Items.Add(satir);
                }
                dosya_ac.Close();
            }
            catch
            {

            }
            label9.Text = listBox1.Items.Count.ToString();
            label7.Text = (listBox1.SelectedIndex + 1).ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter dosya_kaydet = System.IO.File.CreateText("C:\\personel.dat");
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                dosya_kaydet.WriteLine(listBox1.Items[i]);
                dosya_kaydet.WriteLine(listBox2.Items[i]);
                dosya_kaydet.WriteLine(listBox3.Items[i]);
            }
            dosya_kaydet.Close();

        }

        private void secim(object sender, EventArgs e)
        {
            int indis;
            indis = (sender as ListBox).SelectedIndex;
            listBox1.SelectedIndex = indis;
            listBox2.SelectedIndex = indis;
            listBox3.SelectedIndex = indis;
            int top_indis;
            top_indis = (sender as ListBox).TopIndex;
            listBox1.TopIndex = top_indis;
            listBox2.TopIndex = top_indis;
            listBox3.TopIndex = top_indis;
            textBox2.Text = listBox1.Text;
            comboBox1.Text = listBox2.Text;
            comboBox2.Text = listBox3.Text;
            label7.Text = (listBox1.SelectedIndex + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yer;
            yer = listBox1.FindStringExact(textBox2.Text);
            if (yer < 0)
            {
                listBox1.Items.Add(textBox2.Text);
                listBox2.Items.Add(comboBox1.Text);
                listBox3.Items.Add(comboBox2.Text);
                label9.Text = listBox1.Items.Count.ToString();
            }
            else
            {
                listBox1.SelectedIndex = yer;
                MessageBox.Show("Eleman listede var");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("eleman seç");
                return;
            }
        }
        int yer=1;
        string aranan;
        private void button5_Click(object sender, EventArgs e)
        {
            if (yer < listBox1.Items.Count + 1)
            {
                yer = listBox1.FindString(aranan, yer);
                if (yer >= 0)
                {
                    listBox1.SelectedIndex = yer;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int indis;
            indis = listBox1.SelectedIndex;
            if (indis < 0)
            {
                MessageBox.Show("yer seçin");
            }
            else
            {
                int yer;
                yer = listBox1.FindStringExact(textBox2.Text);
                if (yer < 0)
                {
                    listBox1.Items.Insert(indis, textBox2.Text);

                    listBox2.Items.Insert(indis, comboBox1.Text);
                    listBox3.Items.Insert(indis, comboBox2.Text);
                }
                else
                {
                    listBox1.SelectedIndex = yer;
                    MessageBox.Show("zaten var");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}
