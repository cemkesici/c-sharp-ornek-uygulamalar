using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa56_ÇokSatirliPencere_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemin çalışması uzun sürecektir.\r\n" +
                "Bunun sonucunda aşağıdaki sorunlarla karşılaşabilirsiniz.\r\n" +
                "1- Bilgisayar kitlenebilir\r\n" +
                "2- İşlem bitene kadar beklemek zorunda kalabilirsiniz\r\n" +
                "3- Program kendini kapatabilir.", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }
    }
}
