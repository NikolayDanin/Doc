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
    public partial class Etiketka : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh07_Etik.docx");
        private string TemplateFileNameGOST => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\СТО МНЗ.docx");
        public Etiketka()
        {
            InitializeComponent();
        }

        void button1_Click_1(object sender, EventArgs e)
        {
            var Civr = CivrE.Text;
            var MT2 = MT02.Text;
            var MT3 = MT03.Text;
            var MT81E = MT81.Text;
            var name = NamePP.Text;
            var Kod = KodE.Text;
            var Date = DateE.Text;
            var NT = NomTomE.Text;

            // экспорт в word
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {

                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{civr}", Civr, wordDocument);
                ReplaceWordStub("{civr}", Civr, wordDocument);
                ReplaceWordStub("{civr}", Civr, wordDocument);
                ReplaceWordStub("{civr}", Civr, wordDocument);
                ReplaceWordStub("{civr}", Civr, wordDocument);
                ReplaceWordStub("{civr}", Civr, wordDocument);
                ReplaceWordStub("{mt02}", MT2, wordDocument);
                ReplaceWordStub("{mt02}", MT2, wordDocument);
                ReplaceWordStub("{mt03}", MT3, wordDocument);
                ReplaceWordStub("{mt03}", MT3, wordDocument);
                ReplaceWordStub("{mt81}", MT81E, wordDocument);
                ReplaceWordStub("{mt81}", MT81E, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{kod}", Kod, wordDocument);
                ReplaceWordStub("{kod}", Kod, wordDocument);
                ReplaceWordStub("{kod}", Kod, wordDocument);
                ReplaceWordStub("{kod}", Kod, wordDocument);
                ReplaceWordStub("{kod}", Kod, wordDocument);
                ReplaceWordStub("{kod}", Kod, wordDocument);
                ReplaceWordStub("{date}", Date, wordDocument);
                ReplaceWordStub("{date}", Date, wordDocument);
                ReplaceWordStub("{date}", Date, wordDocument);
                ReplaceWordStub("{date}", Date, wordDocument);
                ReplaceWordStub("{date}", Date, wordDocument);
                ReplaceWordStub("{date}", Date, wordDocument);
                ReplaceWordStub("{nt}", NT, wordDocument);
                ReplaceWordStub("{nt}", NT, wordDocument);
                ReplaceWordStub("{nt}", NT, wordDocument);
                ReplaceWordStub("{nt}", NT, wordDocument);
                ReplaceWordStub("{nt}", NT, wordDocument);
                ReplaceWordStub("{nt}", NT, wordDocument);

                //wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\Этикетки.docx"));
                string CivrName = CivrE.Text;
                wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + "             Этикетки.docx"));
                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка. {ex.Message}");
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void Etiketka_Load(object sender, EventArgs e)
        {
            DateE.CustomFormat = "yyMMdd";
            DateE.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileNameGOST);
            wordApp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Etik_Primer EtP = new Etik_Primer();
            EtP.Show();
        }
        private void NamePP_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
    }
}

