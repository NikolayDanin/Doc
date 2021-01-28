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
    public partial class LU : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh08_LU.docx");
        public LU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CivrLU = CivrL.Text;
            var NameLU = NameL.Text;
            var RukRazrLU = RukRazrL.Text;
            var SoglLU = SoglL.Text;
            var SoglFLU = SoglFIOL.Text;
            var UtverDLU = UtverDolgL.Text;
            var UtverFIOLU = UtverFIOL.Text;
            var IspolLU = IspolnL.Text;
            var NormLU = NormL.Text;
            var PredstLU = PredstL.Text;
            var LitLU = LiteraL.Text;

            // экспорт в word
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {

                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{civrLu}", CivrLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{nameLu}", NameLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{rurazrLu}", RukRazrLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglLu}", SoglLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{soglfLu}", SoglFLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvDLu}", UtverDLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{utvFLu}", UtverFIOLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{ispLu}", IspolLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{norLu}", NormLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{predLu}", PredstLU, wordDocument);
                ReplaceWordStub("{liteLu}", LitLU, wordDocument);
                foreach (Word.Range rngL in wordDocument.StoryRanges)
                {
                    Word.Range rng = rngL;
                    while (rng != null)
                    {
                        int rngc = rng.StoryLength;
                        string mt = rng.Text;

                        rng.Find.ClearFormatting();
                        rng.Find.Execute("{LiteLu}", ReplaceWith: LitLU, Replace: Word.WdReplace.wdReplaceAll);
                        rng = rng.NextStoryRange;
                    }
                }

                string CivrName = CivrL.Text;
                wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + "             ЛУ.docx"));
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

        private void CivrL_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LU_Primer LUP = new LU_Primer();
            LUP.Show();
        }
        private void NameL_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
    }
}
