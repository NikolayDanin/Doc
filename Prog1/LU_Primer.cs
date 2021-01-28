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
    public partial class LU_Primer : Form
    {
        private string TemplateFileName104 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.104-78 ЕСПД Основные надписи.docx");
        public LU_Primer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName104);
            wordApp.Visible = true;
        }
    }
}
