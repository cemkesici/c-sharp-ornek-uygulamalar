using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eksikkonular2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Left)
                {
                    textBox1.Left = textBox1.Left - 5;
                }
                if (e.KeyCode == Keys.Right)
                {
                    textBox1.Left = textBox1.Left + 5;
                }
                if (e.KeyCode == Keys.Up)
                {
                    textBox1.Top = textBox1.Top - 5;
                }
                if (e.KeyCode == Keys.Down)
                {
                    textBox1.Top = textBox1.Top + 5;
                }
            }
            if (e.Alt)
            {
                if (e.KeyCode == Keys.Left)
                {
                    textBox1.Width = textBox1.Width - 5;
                }
                if (e.KeyCode == Keys.Right)
                {
                    textBox1.Width = textBox1.Width + 5;
                }
                if (e.KeyCode == Keys.Up)
                {
                    textBox1.Height = textBox1.Height - 5;
                }
                if (e.KeyCode == Keys.Down)
                {
                    textBox1.Height = textBox1.Height + 5;
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                if (e.Alt)
                {
                    textBox1.Text = textBox1.Text.ToUpper();
                }
                if (e.Control)
                {
                    textBox1.Text = textBox1.Text.ToLower();
                }
            }
            if (e.Shift)
            {
                if (e.KeyCode == Keys.Back)
                {
                    textBox1.Text = "";
                }
            }
            if (e.KeyCode == Keys.F10)
            {
                Close();
            }
            this.Text = "Basılan tuş:" + e.KeyValue.ToString() + "Sembolik adi:" + e.KeyCode.ToString();


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                Close();

            }
        }
    }
}
