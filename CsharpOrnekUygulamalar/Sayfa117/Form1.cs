using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yas;
  private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            yas = Convert.ToInt16(textBox2.Text);
            if ((radioButton1.Checked == true) && (yas < 30))
            {
                groupBox1.Visible = true;
            }
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton2.Checked == true))
            {
                groupBox1.Visible = false;
            }
        }
    }
}
