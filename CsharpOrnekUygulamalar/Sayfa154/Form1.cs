using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa154
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyadanyükle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Reism dosyaları | *.bmp;*.jpeg;*.gif;*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            radioButton1.Checked = true;
        }

        private void panodanyükle_Click(object sender, EventArgs e)
        {
            IDataObject panoresim = Clipboard.GetDataObject();
            if (panoresim.GetDataPresent(DataFormats.Bitmap))
            {
                pictureBox1.Image = (Bitmap)panoresim.GetData(DataFormats.Bitmap);
            }
            else
            {
                MessageBox.Show("Resim yok");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.BackgroundImage = pictureBox1.Image;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }
        }
    }
}
