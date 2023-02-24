using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efc
{
    public partial class H : UserControl
    {
        public H()
        {
            InitializeComponent();
        }
        List<Panel> cercevepanel = new List<Panel>();
        List<Panel> icipanel = new List<Panel>();
        private void H_Load(object sender, EventArgs e)
        {
            cercevepanel.Add(cevre_1_1);
            cercevepanel.Add(cevre_1_2);
            cercevepanel.Add(cevre_1_3);
            cercevepanel.Add(cevre_1_4);
            cercevepanel.Add(cevre_1_5);
            cercevepanel.Add(cevre_1_6);
            cercevepanel.Add(cevre_1_7);
            cercevepanel.Add(cevre_1_8);
            cercevepanel.Add(cevre_1_9);
            cercevepanel.Add(cevre_1_10);
            cercevepanel.Add(cevre_1_11);
            cercevepanel.Add(cevre_1_12);
            cercevepanel.Add(cevre_1_13);
            cercevepanel.Add(cevre_1_14);
            cercevepanel.Add(cevre_1_15);
            cercevepanel.Add(cevre_1_16);
            cercevepanel.Add(cevre_1_17);
            cercevepanel.Add(cevre_1_18);
            cercevepanel.Add(cevre_1_19);
            cercevepanel.Add(cevre_1_20);
            cercevepanel.Add(cevre_1_21);
            cercevepanel.Add(cevre_1_22);
            cercevepanel.Add(cevre_1_23);
            cercevepanel.Add(cevre_1_24);
            cercevepanel.Add(cevre_1_25);
            cercevepanel.Add(cevre_1_26);
            cercevepanel.Add(cevre_1_27);
            cercevepanel.Add(cevre_1_28);
            cercevepanel.Add(cevre_1_29);
            cercevepanel.Add(cevre_1_30);
            cercevepanel.Add(cevre_1_31);
            cercevepanel.Add(cevre_1_32);
            cercevepanel.Add(cevre_1_33);
            cercevepanel.Add(cevre_1_34);
            cercevepanel.Add(cevre_1_35);
            cercevepanel.Add(cevre_1_36);


            icipanel.Add(n7);
            icipanel.Add(n6);
            icipanel.Add(n5);
            icipanel.Add(n4);
            icipanel.Add(n3);
            icipanel.Add(n2);
            icipanel.Add(n1);
            icipanel.Add(n14);
            icipanel.Add(n13);
            icipanel.Add(n12);
            icipanel.Add(n11);
            icipanel.Add(n10);
            icipanel.Add(n9);
            icipanel.Add(n8);
            icipanel.Add(n21);
            icipanel.Add(n20);
            icipanel.Add(n19);
            icipanel.Add(n18);
            icipanel.Add(n17);
            icipanel.Add(n16);
            icipanel.Add(n15);
            icipanel.Add(n22);
            icipanel.Add(n23);
            icipanel.Add(n24);
            icipanel.Add(n25);
            icipanel.Add(n26);
            icipanel.Add(n27);
            icipanel.Add(n28);
            icipanel.Add(n30);
            icipanel.Add(n31);
            icipanel.Add(n32);
            icipanel.Add(n33);
            icipanel.Add(n34);
            icipanel.Add(n35);
            icipanel.Add(n36);
            icipanel.Add(n37);
            icipanel.Add(n38);
            icipanel.Add(n39);
            icipanel.Add(n40);
            icipanel.Add(n41);
            icipanel.Add(n42);
            icipanel.Add(n43);
            icipanel.Add(n44);
            icipanel.Add(n45);
            icipanel.Add(n46);
            icipanel.Add(n47);
            icipanel.Add(n48);
            icipanel.Add(n49);
            icipanel.Add(n50);
            icipanel.Add(n51);
            icipanel.Add(n52);
            icipanel.Add(n53);
            icipanel.Add(n54);
            icipanel.Add(n55);
            icipanel.Add(n56);
            icipanel.Add(n57);
            icipanel.Add(n58);
            icipanel.Add(n59);
            icipanel.Add(n60);
            icipanel.Add(n61);
            icipanel.Add(n62);
            icipanel.Add(n63);
            icipanel.Add(n64);

            Task cercevecal = new Task(effecktcer);
            cercevecal.Start();
        }
        private void effecktcer()
        {
            cerceveeffeckt();
        }
        int islmx = 0;
        private void cerceveeffeckt()
        {
            islmx++;
            int hz = 50;
            for (int i = 0; i <1; i++)
            {
                for (int ix = 0; ix < cercevepanel.Count; ix++)
                {
                    cercevepanel[ix].BackColor = Color.Black;
                    if (ix > 8)
                        cercevepanel[ix-9].BackColor = Color.Blue;
                    Thread.Sleep(hz);
                }
                for (int ix = cercevepanel.Count - 10; ix < cercevepanel.Count ; ix++)
                {
                    cercevepanel[ix].BackColor = Color.Blue;
                    Thread.Sleep(hz);
                }

            }
            icerileffeckt();
        }
        int islmx2 = 0;
        private void icerileffeckt()
        {
            islmx2++;
            int hz = 50;
            Color rnk = (islmx2 == 1 ? Color.Yellow : Color.Aqua);
            for (int ix = 0; ix < icipanel.Count; ix++)
            {
                icipanel[ix].BackColor = Color.Yellow;
                if (ix > 8)
                    icipanel[ix - 9].BackColor = Color.Aqua;
                Thread.Sleep(hz);
            }
            for (int ix = icipanel.Count - 10; ix < icipanel.Count; ix++)
            {
                icipanel[ix].BackColor = Color.Aqua;
                Thread.Sleep(hz);
            }
            islembaslat();
        }

        private void islembaslat()
        {
            if (harfi.Text == "a" || harfi.Text == "A")
                A();
            else if (harfi.Text == "b" || harfi.Text == "B")
                B();
            else if (harfi.Text == "c" || harfi.Text == "C")
                C();
            else if (harfi.Text == "d" || harfi.Text == "D")
                D();
            else if (harfi.Text == "e" || harfi.Text == "E")
                E();
            else if (harfi.Text == "f" || harfi.Text == "F")
                F();
            else if (harfi.Text == "g" || harfi.Text == "G")
                G();
            else if (harfi.Text == "h" || harfi.Text == "H")
                Hx();
            else if (harfi.Text == "l" || harfi.Text == "L")
                L();
            else if (harfi.Text == "m" || harfi.Text == "M")
                M();
            else if (harfi.Text == "n" || harfi.Text == "N")
                N();
        }

        private void A()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n11);
            harf.Add(n10);
            harf.Add(n12);
            harf.Add(n9);
            harf.Add(n13);
            harf.Add(n16);
            harf.Add(n20);
            harf.Add(n23);
            harf.Add(n27);
            harf.Add(n35);
            harf.Add(n31);
            harf.Add(n38);
            harf.Add(n42);
            harf.Add(n49);
            harf.Add(n45);
            harf.Add(n52);
            harf.Add(n56);
            harf.Add(n32);
            harf.Add(n34);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }

        private void B()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n13);
            harf.Add(n12);
            harf.Add(n11);
            harf.Add(n10);
            harf.Add(n9);
            harf.Add(n16);
            harf.Add(n20);
            harf.Add(n27);
            harf.Add(n23);
            harf.Add(n35);
            harf.Add(n34);
            harf.Add(n33);
            harf.Add(n32);
            harf.Add(n42);
            harf.Add(n38);
            harf.Add(n49);
            harf.Add(n45);
            harf.Add(n52);
            harf.Add(n56);
            harf.Add(n53);
            harf.Add(n55);
            harf.Add(n54);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void C()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n9);
            harf.Add(n10);
            harf.Add(n11);
            harf.Add(n12);
            harf.Add(n16);
            harf.Add(n23);
            harf.Add(n35);
            harf.Add(n38);
            harf.Add(n49);
            harf.Add(n53);
            harf.Add(n54);
            harf.Add(n55);
            harf.Add(n56);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void D()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n19);
            harf.Add(n10);
            harf.Add(n11);
            harf.Add(n12);
            harf.Add(n13);
            harf.Add(n16);
            harf.Add(n23);
            harf.Add(n35);
            harf.Add(n38);
            harf.Add(n49);
            harf.Add(n52);
            harf.Add(n53);
            harf.Add(n54);
            harf.Add(n55);
            harf.Add(n46);
            harf.Add(n45);
            harf.Add(n42);
            harf.Add(n31);
            harf.Add(n27);
            harf.Add(n20);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void E()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n9);
            harf.Add(n10);
            harf.Add(n11);
            harf.Add(n12);
            harf.Add(n13);
            harf.Add(n16);
            harf.Add(n23);
            harf.Add(n31);
            harf.Add(n35);
            harf.Add(n32);
            harf.Add(n38);
            harf.Add(n33);
            harf.Add(n49);
            harf.Add(n34);
            harf.Add(n52);
            harf.Add(n53);
            harf.Add(n54);
            harf.Add(n55);
            harf.Add(n56);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void F()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n9);
            harf.Add(n10);
            harf.Add(n11);
            harf.Add(n12);
            harf.Add(n13);
            harf.Add(n16);
            harf.Add(n23);
            harf.Add(n35);
            harf.Add(n38);
            harf.Add(n33);
            harf.Add(n49);
            harf.Add(n34);
            harf.Add(n52);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void G()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n9);
            harf.Add(n10);
            harf.Add(n11);
            harf.Add(n12);
            harf.Add(n13);
            harf.Add(n16);
            harf.Add(n23);
            harf.Add(n35);
            harf.Add(n38);
            harf.Add(n49);
            harf.Add(n52);
            harf.Add(n53);
            harf.Add(n54);
            harf.Add(n55);
            harf.Add(n56);
            harf.Add(n45);
            harf.Add(n42);
            harf.Add(n31);
            harf.Add(n32);
            harf.Add(n33);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void Hx()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n13);
            harf.Add(n9);
            harf.Add(n16);
            harf.Add(n20);
            harf.Add(n23);
            harf.Add(n27);
            harf.Add(n35);
            harf.Add(n31);
            harf.Add(n32);
            harf.Add(n38);
            harf.Add(n33);
            harf.Add(n42);
            harf.Add(n34);
            harf.Add(n49);
            harf.Add(n45);
            harf.Add(n52);
            harf.Add(n56);


            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void L()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n13);
            harf.Add(n16);
            harf.Add(n23);
            harf.Add(n35);
            harf.Add(n38);
            harf.Add(n49);
            harf.Add(n52);
            harf.Add(n53);
            harf.Add(n54);
            harf.Add(n55);
            harf.Add(n56);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void M()
        {
            List<Panel> harf = new List<Panel>();
            harf.Add(n13);
            harf.Add(n12);
            harf.Add(n11);
            harf.Add(n10);
            harf.Add(n9);

            harf.Add(n16);
            harf.Add(n20);
            harf.Add(n23);
            harf.Add(n27);
            harf.Add(n35);
            harf.Add(n31);
            harf.Add(n38);
            harf.Add(n42);
            harf.Add(n49);
            harf.Add(n45);

            harf.Add(n18);
            harf.Add(n25);
            harf.Add(n33);
            harf.Add(n40);

            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }
        private void N()
        {
            List<Panel> harf = new List<Panel>();

            harf.Add(n13);
            harf.Add(n12);
            harf.Add(n11);
            harf.Add(n10);
            harf.Add(n9);
            harf.Add(n16);
            harf.Add(n20);
            harf.Add(n23);
            harf.Add(n27);
            harf.Add(n35);
            harf.Add(n38);
            harf.Add(n31);
            harf.Add(n42);
            harf.Add(n49);
            harf.Add(n45);
            harf.Add(n52);
            harf.Add(n56);


            foreach (var item in harf)
            {
                Thread.Sleep(100);
                item.BackColor = Color.Red;
            }
        }

    }
}
