using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa70
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ifadeler= { "Yok", "Sağ", "Sol", "Üst", "Alt", "İçine" };
            comboBox1.Items.AddRange(ifadeler);
            comboBox2.Items.AddRange(ifadeler);
            comboBox3.Items.AddRange(ifadeler);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yok")
            {
                groupBox1.Dock = DockStyle.None;
            }
            if (comboBox1.Text == "Alt")
            {
                groupBox1.Dock = DockStyle.Bottom;
            }
            if (comboBox1.Text == "Üst")
            {
                groupBox1.Dock = DockStyle.Top;
            }
            if (comboBox1.Text == "Sağ")
            {
                groupBox1.Dock = DockStyle.Right;
            }
            if (comboBox1.Text == "Sol")
            {
                groupBox1.Dock = DockStyle.Left;
            }
            if (comboBox1.Text == "İçine")
            {
                groupBox1.Dock = DockStyle.Fill;
            }
                }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Yok")
            {
                groupBox2.Dock = DockStyle.None;
            }
            if (comboBox2.Text == "Alt")
            {
                groupBox2.Dock = DockStyle.Bottom;
            }
            if (comboBox2.Text == "Üst")
            {
                groupBox2.Dock = DockStyle.Top;
            }
            if (comboBox2.Text == "Sağ")
            {
                groupBox2.Dock = DockStyle.Right;
            }
            if (comboBox2.Text == "Sol")
            {
                groupBox2.Dock = DockStyle.Left;
            }
            if (comboBox2.Text == "İçine")
            {
                groupBox2.Dock = DockStyle.Fill;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Yok")
            {
                groupBox3.Dock = DockStyle.None;
            }
            if (comboBox3.Text == "Alt")
            {
                groupBox3.Dock = DockStyle.Bottom;
            }
            if (comboBox3.Text == "Üst")
            {
                groupBox3.Dock = DockStyle.Top;
            }
            if (comboBox3.Text == "Sağ")
            {
                groupBox3.Dock = DockStyle.Right;
            }
            if (comboBox3.Text == "Sol")
            {
                groupBox3.Dock = DockStyle.Left;
            }
            if (comboBox3.Text == "İçine")
            {
                groupBox3.Dock = DockStyle.Fill;
            }
        }
    }
}
