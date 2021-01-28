using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Prog1
{
    public partial class Formulyar_Primer : Form
    {
        private string TemplateFileNameFP => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\Formulyar_Primer.docx");
        private string TemplateFileName501 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.501-78 ЕСПД Формуляр. Требования к содержанию и оформлению.docx");
        public Formulyar_Primer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileNameFP);
            wordApp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName501);
            wordApp.Visible = true;
        }
    }
}
