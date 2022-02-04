using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            this.CancelButton = button2;
            this.AcceptButton = button1;
        }
        int hak = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            hak++;
            if (textBox1.Text == "1234")
            {
                MessageBox.Show("Ana menüye");
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Yanlış şifre");
                if (hak == 0)
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Şİfreyi 3 kere yanlış girdiniz." + "Program kapatılacak");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
