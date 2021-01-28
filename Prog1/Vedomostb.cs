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
    public partial class Vedomostb : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh04_Vedom.docx");
        public Vedomostb()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                var CivrVED = CivrVE.Text;
                var NameVed = NameVe.Text;
                var V1 = kV1.Text;
                var V2 = kV2.Text;
                var V3 = kV3.Text;
                var V4 = kV4.Text;
                var MeV1 = MestoV1.Text;
                var MeV2 = MestoV2.Text;
                var MeV3 = MestoV3.Text;
                var MeV4 = MestoV4.Text;
                var LitV = LiteraVe.Text;

                // экспорт в word
                var wordApp = new Word.Application();
                wordApp.Visible = false;

                try
                {

                    var wordDocument = wordApp.Documents.Open(TemplateFileName);
                    ReplaceWordStub("{civrVe}", CivrVED, wordDocument);
                    ReplaceWordStub("{civrVe}", CivrVED, wordDocument);
                    ReplaceWordStub("{civrVe}", CivrVED, wordDocument);
                    ReplaceWordStub("{civrVe}", CivrVED, wordDocument);
                    ReplaceWordStub("{civrVe}", CivrVED, wordDocument);
                    ReplaceWordStub("{civrVe}", CivrVED, wordDocument);
                    ReplaceWordStub("{civrVe}", CivrVED, wordDocument);
                    ReplaceWordStub("{nameVe}", NameVed, wordDocument);
                    ReplaceWordStub("{nameVe}", NameVed, wordDocument);
                    ReplaceWordStub("{nameVe}", NameVed, wordDocument);
                    ReplaceWordStub("{nameVe}", NameVed, wordDocument);
                    ReplaceWordStub("{nameVe}", NameVed, wordDocument);
                    ReplaceWordStub("{nameVe}", NameVed, wordDocument);
                    ReplaceWordStub("{k1}", V1, wordDocument);
                    ReplaceWordStub("{k2}", V2, wordDocument);
                    ReplaceWordStub("{k3}", V3, wordDocument);
                    ReplaceWordStub("{k4}", V4, wordDocument);
                    ReplaceWordStub("{mV1}", MeV1, wordDocument);
                    ReplaceWordStub("{mV2}", MeV2, wordDocument);
                    ReplaceWordStub("{mV3}", MeV3, wordDocument);
                    ReplaceWordStub("{mV4}", MeV4, wordDocument);
                    ReplaceWordStub("{litVe}", LitV, wordDocument);
                    foreach (Word.Range rngC in wordDocument.StoryRanges)
                    {
                        Word.Range rng = rngC;
                        while (rng != null)
                        {
                            int rngc = rng.StoryLength;
                            string mt = rng.Text;

                            rng.Find.ClearFormatting();
                            rng.Find.Execute("{civrVe}", ReplaceWith: CivrVED, Replace: Word.WdReplace.wdReplaceAll);
                            rng = rng.NextStoryRange;
                        }
                    }

                    string CivrName = CivrVE.Text;
                    wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + " 20        Ведомость.docx"));
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
            Vedomostb_Primer VedP = new Vedomostb_Primer();
            VedP.Show();
        }
        private void NameVe_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
    }
}

