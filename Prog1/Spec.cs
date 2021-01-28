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
    public partial class Spec : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh01_Spec.docx");
        public Spec()
        {
            InitializeComponent();
        }
        private void NamePPSp_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                var CivrSP = CivrSp.Text;
                var NameSP = NamePPSp.Text;
                var OcSP = OCSp.Text;
                var NakopSP = NakopiSp.Text;
                var LitSP = LiteraSp.Text;

                // экспорт в word
                var wordApp = new Word.Application();
                wordApp.Visible = false;

                try
                {

                    var wordDocument = wordApp.Documents.Open(TemplateFileName);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{civrS}", CivrSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{nameS}", NameSP, wordDocument);
                    ReplaceWordStub("{ocS}", OcSP, wordDocument);
                    ReplaceWordStub("{nakS}", NakopSP, wordDocument);
                    ReplaceWordStub("{nakS}", NakopSP, wordDocument);
                    ReplaceWordStub("{litS}", LitSP, wordDocument);
                    foreach (Word.Range rngC in wordDocument.StoryRanges)
                    {
                        Word.Range rng = rngC;
                        while (rng != null)
                        {
                            int rngc = rng.StoryLength;
                            string mt = rng.Text;

                            rng.Find.ClearFormatting();
                            rng.Find.Execute("{civrS}", ReplaceWith: CivrSP, Replace: Word.WdReplace.wdReplaceAll);
                            rng = rng.NextStoryRange;
                        }
                    }

                    string CivrName = CivrSp.Text;
                    wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + "             Спецификация.docx"));
                    wordApp.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка.");
                }
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
            Spec_Primer SpP = new Spec_Primer();
            SpP.Show();
        }
    }
}
