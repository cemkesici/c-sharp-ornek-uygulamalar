using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;

            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            dateTimePicker3.ShowCheckBox = true;
           // listBox1.Font = new Font("Courier New", 10, FontSyle.Regular);
        }
        Boolean mezun;

        private void button1_Click(object sender, EventArgs e)
        {
            string ögrad, babaad, dogumyer;
            DateTime dogumtarih, kayittarih, mezuniyettarih;
            ögrad = textBox1.Text;
            babaad = textBox2.Text;
            dogumyer = textBox3.Text;

            dogumtarih = dateTimePicker1.Value;
            kayittarih = dateTimePicker2.Value;
            mezuniyettarih = dateTimePicker3.Value;
            if (dateTimePicker3.Checked)
            {
                mezun = true;
            }
            else
                mezun = false;

            if (dogumtarih >= kayittarih)
            {
                MessageBox.Show("Yanlış");
                return;
            }
            if (mezun == true)
            {
                if (kayittarih > mezuniyettarih)
                {
                    MessageBox.Show("Yanlış");
                    return;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
