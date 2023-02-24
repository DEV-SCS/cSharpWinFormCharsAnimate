using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Task s = new Task(harfgorevlisi);
            s.Start();
        }
        private void harfgorevlisi()
        {
            string kelime = "abcdefghlmn";
            char[] klm = kelime.ToCharArray();
            foreach (char item in klm)
            {
                H harf = new H();
                harf.harfi.Text = item.ToString();
                if (flowLayoutPanel1.InvokeRequired) //Forma gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                {
                    //Eğer farklı bir iş parçacığından talep gelmişse aşağıdaki Invoke metoduyla işlem gerçekleştiriliyor.
                    flowLayoutPanel1.Invoke((MethodInvoker)delegate ()
                    {
                        flowLayoutPanel1.Controls.Add(harf);
                    });
                }
            }
        }
    }
}
