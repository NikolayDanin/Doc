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
using DocumentFormat.OpenXml;

namespace Prog1
{
    public partial class Formulyar : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh09_Form.docx");
        public Formulyar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var CivrFO = CivrF.Text;
            var NameFO = NameF.Text;
            var IzdFO = IzdF.Text;
            var OrRazrabFO = OrRazrabF.Text;
            var NakopiFO = NakopiF.Text;
            var LitFO = LiteraF.Text;


            // экспорт в word
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {

                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{civrF}", CivrFO, wordDocument);
                ReplaceWordStub("{nameF}", NameFO, wordDocument);
                ReplaceWordStub("{nameF}", NameFO, wordDocument);
                ReplaceWordStub("{nameF}", NameFO, wordDocument);
                ReplaceWordStub("{nameF}", NameFO, wordDocument);
                ReplaceWordStub("{nameF}", NameFO, wordDocument);
                ReplaceWordStub("{nameF}", NameFO, wordDocument);
                ReplaceWordStub("{izdF}", IzdFO, wordDocument);
                ReplaceWordStub("{izdF}", IzdFO, wordDocument);
                ReplaceWordStub("{izdF}", IzdFO, wordDocument);
                ReplaceWordStub("{izdF}", IzdFO, wordDocument);
                ReplaceWordStub("{izdF}", IzdFO, wordDocument);
                ReplaceWordStub("{izdF}", IzdFO, wordDocument);
                ReplaceWordStub("{izdF}", IzdFO, wordDocument);
                ReplaceWordStub("{orrazrabF}", OrRazrabFO, wordDocument);
                ReplaceWordStub("{nakopF}", NakopiFO, wordDocument);
                ReplaceWordStub("{litF}", LitFO, wordDocument);
                foreach (Word.Range rngC in wordDocument.StoryRanges)
                {
                    Word.Range rng = rngC;
                    while (rng != null)
                    {
                        int rngc = rng.StoryLength;
                        string mt = rng.Text;

                        rng.Find.ClearFormatting();
                        rng.Find.Execute("{civrF}", ReplaceWith: CivrFO, Replace: Word.WdReplace.wdReplaceAll);
                        rng = rng.NextStoryRange;
                    }
                }

                string CivrName = CivrF.Text;
                wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + " 30        Формуляр.docx"));
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulyar_Primer FoP = new Formulyar_Primer();
            FoP.Show();
        }
        private void NameF_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
    }
}
