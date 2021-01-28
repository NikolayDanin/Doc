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
    public partial class VMNZ_Primer : Form
    {
        private string TemplateFileNameGOST => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\СТО МНЗ.docx");
        public VMNZ_Primer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileNameGOST);
            wordApp.Visible = true;
        }
    }
}
