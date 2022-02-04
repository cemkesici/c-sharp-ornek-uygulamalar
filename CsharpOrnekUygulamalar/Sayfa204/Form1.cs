using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayfa204
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ad Soyad", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("Üni", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("Bölüm", -1, HorizontalAlignment.Left);

            listView1.Items.Add("Uğur");
            listView1.Items[0].SubItems.Add("Muğla");
            listView1.Items[0].SubItems.Add("Bilgisayar");


            listView1.Items.Add("Ali");
            listView1.Items[1].SubItems.Add("Düzce");
            listView1.Items[1].SubItems.Add("Bilgisayar");

            listView1.Items.Add("Ahmet");
            listView1.Items[2].SubItems.Add("Mersin");
            listView1.Items[2].SubItems.Add("Bilgisayar");
            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
        }
    }
}
