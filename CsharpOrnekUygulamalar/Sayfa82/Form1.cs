﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(textBox2.Text) < 0 || Convert.ToInt16(textBox2.Text) > 100)
                {
                    MessageBox.Show("Sınav notu 0-100 olmalı");
                    e.Cancel = true;
                    textBox2.Text =" ";
                }
            }
            catch
            {
                textBox2.Text = "Sınav notu geçersiz";e.Cancel = true;
            }
        }
        int yer_at_isareti, yer_nokta_isareti;

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            yer_at_isareti = textBox3.Text.IndexOf("@", 1);
            if (yer_at_isareti > 0)
            {
                yer_nokta_isareti = textBox3.Text.IndexOf(".", yer_at_isareti + 1);

            }
            if (yer_at_isareti < 0 || yer_nokta_isareti < 0||yer_nokta_isareti==textBox3.Text.Length-1)
            {
                MessageBox.Show("Mail hatalı");
                e.Cancel = true;
            }
        }
 

    
        int yer_ilk_bosluk_bul, yer_ikinci_bosluk_bul;
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            yer_ilk_bosluk_bul = textBox4.Text.IndexOf(" ");
            if(yer_ilk_bosluk_bul>=0)
            { yer_ikinci_bosluk_bul = textBox4.Text.IndexOf(" ", yer_ilk_bosluk_bul + 1);

            }
            if (textBox4.Text.Length != 9 || yer_ilk_bosluk_bul < 0 || yer_ikinci_bosluk_bul < 0 || yer_ikinci_bosluk_bul == textBox4.Text.Length - 1)
            {
                MessageBox.Show("Plaka hatalı");
                e.Cancel = true;

            }
        }

           private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text.Length != 10)
            {
                MessageBox.Show("Tel hatalı");
                e.Cancel = true;
            }
        }

    }
}
