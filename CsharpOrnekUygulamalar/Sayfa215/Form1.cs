using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayfa215
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn sutun;

            sutun = new DataColumn("Müşteri Adı", System.Type.GetType("System.String"));
            dt.Columns.Add(sutun);
            sutun = new DataColumn("Aldığı mal", System.Type.GetType("System.String"));
            dt.Columns.Add(sutun);
            sutun = new DataColumn("Adet", System.Type.GetType("System.Int32"));
            dt.Columns.Add(sutun);
            sutun = new DataColumn("Birim Fiyat", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(sutun);
            sutun = new DataColumn("odenen", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(sutun);
            sutun = new DataColumn("Toplam", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(sutun);
            sutun = new DataColumn("Kalan", System.Type.GetType("System.Decimal"));
            sutun.Expression = "Toplam-odenen";
            dt.Columns.Add(sutun);
            dataGridView1.DataSource = dt;
        }
    }
}
