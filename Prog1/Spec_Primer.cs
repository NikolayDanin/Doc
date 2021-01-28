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
    public partial class Spec_Primer : Form
    {
        private string TemplateFileNameSP => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\Spec_Primer.docx");
        private string TemplateFileName202 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.202-78 ЕСПД Спецификация. Требования к содержанию и оформлению.docx");
        public Spec_Primer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileNameSP);
            wordApp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName202);
            wordApp.Visible = true;
        }
    }
}
