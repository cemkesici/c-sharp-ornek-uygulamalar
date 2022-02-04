using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eksikkonular7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rtf| *.rtf|metin |*.txt|" + "bütün dosyalar|*.*";
            saveFileDialog1.Filter = openFileDialog1.Filter;
            saveFileDialog1.DefaultExt = "rtf";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    MessageBox.Show("açılamadı");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);


            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);


                }

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);


            }
        }
    }
}
