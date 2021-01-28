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
    public partial class Vedomostb_Primer : Form
    {
        private string TemplateFileName507 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.507-79 ЕСПД Ведомость эксплуатационных документов.docx");
        public Vedomostb_Primer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName507);
            wordApp.Visible = true;
        }
    }
}
