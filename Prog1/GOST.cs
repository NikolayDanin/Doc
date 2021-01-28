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
    public partial class GOST : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\СТО МНЗ.docx");
        private string TemplateFileName001 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.001-77 ЕСПД Общие положения.docx");
        private string TemplateFileName101 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.101 ЕСПД Виды программ и программных документов.docx");
        private string TemplateFileName104 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.104-78 ЕСПД Основные надписи.docx");
        private string TemplateFileName105 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.105-78 ЕСПД Общие требования к программным документам.docx");
        private string TemplateFileName106 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.106-78 ЕСПД Требования к ПД выполненым печатным способом.docx");
        private string TemplateFileName202 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.202-78 ЕСПД Спецификация. Требования к содержанию и оформлению.docx");
        private string TemplateFileName401 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.401-78 ЕСПД Текст программы. Требования к содержанию и оформлению.docx");
        private string TemplateFileName501 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.501-78 ЕСПД Формуляр. Требования к содержанию и оформлению.docx");
        private string TemplateFileName507 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.507-79 ЕСПД Ведомость эксплуатационных документов.docx");
        private string TemplateFileName603 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.603-78 ЕСПД Общие правила внесения изменений");
        private string TemplateFileName604 => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\ГОСТ 19.604-78 ЕСПД Правила внесения изменений в ПД, выполненные печатным способом");
        public GOST()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName);
            wordApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName001);
            wordApp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName101);
            wordApp.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName104);
            wordApp.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName105);
            wordApp.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName106);
            wordApp.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName202);
            wordApp.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName401);
            wordApp.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName501);
            wordApp.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName507);
            wordApp.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName603);
            wordApp.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileName604);
            wordApp.Visible = true;
        }
    }
}
