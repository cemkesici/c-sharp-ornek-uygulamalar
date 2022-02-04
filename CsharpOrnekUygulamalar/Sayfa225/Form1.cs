using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa225
{
    public partial class Form1 : FormS
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] suruculer = System.IO.Directory.GetLogicalDrives();
            for(int i=0; i <= suruculer.GetUpperBound(0); i++)
            {
                treeView1.Nodes.Add(suruculer[i]);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string[] klasörler = System.IO.Directory.GetDirectories(e.Node.FullPath + "\\");
                string[] k;
                if (e.Node.GetNodeCount(true) == 0)
                {
                    for(int i=0; i<= klasörler.GetUpperBound(0); i++)
                    {
                        k = klasörler[i].Split('\\');
                        e.Node.Nodes.Add(k[k.GetUpperBound(0)]);
                    }
                }
                listBox1.Items.Clear();
                string[] dosyalar = System.IO.Directory.GetFiles(e.Node.FullPath);
                for (int i = 0; i <= dosyalar.GetUpperBound(0); i++)
                {
                    k = dosyalar[i].Split('\\');
                    listBox1.Items.Add(k[k.GetUpperBound(0)]);
                }
            }
            catch
            {

            }
        }
    }
}
