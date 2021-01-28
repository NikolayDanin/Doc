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
    public partial class Tekst : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh02_Tekst_1201.docx");
        public Tekst()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                var CivrTPP = CivrT.Text;
                var NamePPT = NameT.Text;
                var OCTe = OCT.Text;
                var LGT = LangT.Text;
                var NUsT = NaUsT.Text;
                var NIsT = NaIsT.Text;
                var NakT = NakopiT.Text;
                var LitT = LiteraT.Text;


                // экспорт в word
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(TemplateFileName);

                try
                {
                                       
                    ReplaceWordStub("{civrT}", CivrTPP, wordDocument);
                    ReplaceWordStub("{civrT}", CivrTPP, wordDocument);
                    ReplaceWordStub("{civrT}", CivrTPP, wordDocument);
                    ReplaceWordStub("{civrT}", CivrTPP, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{nameT}", NamePPT, wordDocument);
                    ReplaceWordStub("{ocT}", OCTe, wordDocument);
                    ReplaceWordStub("{lgT}", LGT, wordDocument);
                    ReplaceWordStub("{nusT}", NUsT, wordDocument);
                    ReplaceWordStub("{nisT}", NIsT, wordDocument);
                    ReplaceWordStub("{nakopT}", NakT, wordDocument);
                    ReplaceWordStub("{nakopT}", NakT, wordDocument);
                    ReplaceWordStub("{litT}", LitT, wordDocument);

                    foreach (Word.Range rngC in wordDocument.StoryRanges)
                    {
                        Word.Range rng = rngC;
                        while (rng != null)
                        {
                            int rngc = rng.StoryLength;
                            string mt = rng.Text;

                            rng.Find.ClearFormatting();
                            rng.Find.Execute("{civrT}", ReplaceWith: CivrTPP, Replace: Word.WdReplace.wdReplaceAll);
                            rng = rng.NextStoryRange;
                        }
                    }

                    string CivrName = CivrT.Text;
                    wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + " 12 01   Текст.docx"));
                    wordApp.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка.");
                    wordDocument.Close();//проверить
                    wordApp.Quit();//проверить
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
            Tekst_Primer TeP = new Tekst_Primer();
            TeP.Show();
        }
        private void NameT_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
    }
}