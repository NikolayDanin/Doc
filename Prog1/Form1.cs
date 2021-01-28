using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Prog1.Properties;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Etiketka f = new Etiketka();
            f.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            VMNZ v = new VMNZ();
            v.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            IPX i = new IPX();
            i.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Vedomostb Ve = new Vedomostb();
            Ve.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Tekst T = new Tekst();
            T.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AllDoc A = new AllDoc();
            A.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Spec S = new Spec();
            S.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            LU L = new LU();
            L.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            test TE = new test();
            TE.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Formulyar F = new Formulyar();
            F.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            GOST GO = new GOST();
            GO.Show();
        }
    }
}
