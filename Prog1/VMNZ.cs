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
    public partial class VMNZ : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh06_VMNZ.docx");

        public VMNZ()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var MT2VMNZ = MT02V.Text;
            var MT3VMNZ = MT03V.Text;
            var MT81VMNZ = MT81V.Text;
            var ocVMNZ = OCV.Text;
            var DateVMNZ = DateV.Value.ToShortDateString();
            var Zan02VMNZ = Zanyato02V.Text;
            var Zan03VMNZ = Zanyato03V.Text;
            var Zan81VMNZ = Zanyato81V.Text;
            var NakopV2 = NakopiV2.Text;
            var NakopV3 = NakopiV3.Text;
            var NakopV81 = NakopiV81.Text;
            var ShiVMNZ = ShifrV.Text;
            var Civr1VMNZ = Civr1V.Text;
            var Civr2VMNZ = Civr2V.Text;
            var Civr3VMNZ = Civr3V.Text;
            var Civr4VMNZ = Civr4V.Text;
            var Civr5VMNZ = Civr5V.Text;
            var Civr6VMNZ = Civr6V.Text;
            var name1VMNZ = Name1PPV.Text;
            var name2VMNZ = Name2PPV.Text;
            var name3VMNZ = Name3PPV.Text;
            var name4VMNZ = Name4PPV.Text;
            var name5VMNZ = Name5PPV.Text;
            var name6VMNZ = Name6PPV.Text;
            var Imya21VMNZ = ImyaFV21.Text;
            var Imya22VMNZ = ImyaFV22.Text;
            var Imya23VMNZ = ImyaFV23.Text;
            var Imya24VMNZ = ImyaFV24.Text;
            var Imya25VMNZ = ImyaFV25.Text;
            var Imya26VMNZ = ImyaFV26.Text;
            var KSum21VMNZ = KonSumV21.Text;
            var KSum22VMNZ = KonSumV22.Text;
            var KSum23VMNZ = KonSumV23.Text;
            var KSum24VMNZ = KonSumV24.Text;
            var KSum25VMNZ = KonSumV25.Text;
            var KSum26VMNZ = KonSumV26.Text;
            var PO1VMNZ = POV1.Text;
            var PO2VMNZ = POV2.Text;
            var PO3VMNZ = POV3.Text;
            var PO4VMNZ = POV4.Text;
            var PO5VMNZ = POV5.Text;
            var PO6VMNZ = POV6.Text;
            var Imya31VMNZ = ImyaFV31.Text;
            var Imya32VMNZ = ImyaFV32.Text;
            var Imya33VMNZ = ImyaFV33.Text;
            var Imya34VMNZ = ImyaFV34.Text;
            var Imya35VMNZ = ImyaFV35.Text;
            var Imya36VMNZ = ImyaFV36.Text;
            var KSum31VMNZ = KonSumV31.Text;
            var KSum32VMNZ = KonSumV32.Text;
            var KSum33VMNZ = KonSumV33.Text;
            var KSum34VMNZ = KonSumV34.Text;
            var KSum35VMNZ = KonSumV35.Text;
            var KSum36VMNZ = KonSumV36.Text;
            var Imya811VMNZ = ImyaFV811.Text;
            var Imya812VMNZ = ImyaFV812.Text;
            var Imya813VMNZ = ImyaFV813.Text;
            var Imya814VMNZ = ImyaFV814.Text;
            var Imya815VMNZ = ImyaFV815.Text;
            var Imya816VMNZ = ImyaFV816.Text;
            var KSum811VMNZ = KonSumV811.Text;
            var KSum812VMNZ = KonSumV812.Text;
            var KSum813VMNZ = KonSumV813.Text;
            var KSum814VMNZ = KonSumV814.Text;
            var KSum815VMNZ = KonSumV815.Text;
            var KSum816VMNZ = KonSumV816.Text;

            // экспорт в word
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {

                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                //Общие данные
                ReplaceWordStub("{mt02V}", MT2VMNZ, wordDocument);
                ReplaceWordStub("{mt03V}", MT3VMNZ, wordDocument);
                ReplaceWordStub("{mt81V}", MT81VMNZ, wordDocument);
                ReplaceWordStub("{ocV}", ocVMNZ, wordDocument);
                ReplaceWordStub("{ocV}", ocVMNZ, wordDocument);
                ReplaceWordStub("{ocV}", ocVMNZ, wordDocument);
                ReplaceWordStub("{dateV}", DateVMNZ, wordDocument);
                ReplaceWordStub("{dateV}", DateVMNZ, wordDocument);
                ReplaceWordStub("{dateV}", DateVMNZ, wordDocument);
                ReplaceWordStub("{zan02V}", Zan02VMNZ, wordDocument);
                ReplaceWordStub("{zan03V}", Zan03VMNZ, wordDocument);
                ReplaceWordStub("{zan81V}", Zan81VMNZ, wordDocument);
                ReplaceWordStub("{nak2V}", NakopV2, wordDocument);
                ReplaceWordStub("{nak3V}", NakopV3, wordDocument);
                ReplaceWordStub("{nak81V}", NakopV81, wordDocument);
                ReplaceWordStub("{shiV}", ShiVMNZ, wordDocument);
                ReplaceWordStub("{shiV}", ShiVMNZ, wordDocument);
                ReplaceWordStub("{shiV}", ShiVMNZ, wordDocument);
                ReplaceWordStub("{civr1V}", Civr1VMNZ, wordDocument);
                ReplaceWordStub("{civr1V}", Civr1VMNZ, wordDocument);
                ReplaceWordStub("{civr1V}", Civr1VMNZ, wordDocument);
                ReplaceWordStub("{civr2V}", Civr2VMNZ, wordDocument);
                ReplaceWordStub("{civr2V}", Civr2VMNZ, wordDocument);
                ReplaceWordStub("{civr2V}", Civr2VMNZ, wordDocument);
                ReplaceWordStub("{civr3V}", Civr3VMNZ, wordDocument);
                ReplaceWordStub("{civr3V}", Civr3VMNZ, wordDocument);
                ReplaceWordStub("{civr3V}", Civr3VMNZ, wordDocument);
                ReplaceWordStub("{civr4V}", Civr4VMNZ, wordDocument);
                ReplaceWordStub("{civr4V}", Civr4VMNZ, wordDocument);
                ReplaceWordStub("{civr4V}", Civr4VMNZ, wordDocument);
                ReplaceWordStub("{civr5V}", Civr5VMNZ, wordDocument);
                ReplaceWordStub("{civr5V}", Civr5VMNZ, wordDocument);
                ReplaceWordStub("{civr5V}", Civr5VMNZ, wordDocument);
                ReplaceWordStub("{civr6V}", Civr6VMNZ, wordDocument);
                ReplaceWordStub("{civr6V}", Civr6VMNZ, wordDocument);
                ReplaceWordStub("{civr6V}", Civr6VMNZ, wordDocument);
                ReplaceWordStub("{name1V}", name1VMNZ, wordDocument);
                ReplaceWordStub("{name1V}", name1VMNZ, wordDocument);
                ReplaceWordStub("{name1V}", name1VMNZ, wordDocument);
                ReplaceWordStub("{name2V}", name2VMNZ, wordDocument);
                ReplaceWordStub("{name2V}", name2VMNZ, wordDocument);
                ReplaceWordStub("{name2V}", name2VMNZ, wordDocument);
                ReplaceWordStub("{name3V}", name3VMNZ, wordDocument);
                ReplaceWordStub("{name3V}", name3VMNZ, wordDocument);
                ReplaceWordStub("{name3V}", name3VMNZ, wordDocument);
                ReplaceWordStub("{name4V}", name4VMNZ, wordDocument);
                ReplaceWordStub("{name4V}", name4VMNZ, wordDocument);
                ReplaceWordStub("{name4V}", name4VMNZ, wordDocument);
                ReplaceWordStub("{name5V}", name5VMNZ, wordDocument);
                ReplaceWordStub("{name5V}", name5VMNZ, wordDocument);
                ReplaceWordStub("{name5V}", name5VMNZ, wordDocument);
                ReplaceWordStub("{name6V}", name6VMNZ, wordDocument);
                ReplaceWordStub("{name6V}", name6VMNZ, wordDocument);
                ReplaceWordStub("{name6V}", name6VMNZ, wordDocument);
                ReplaceWordStub("{po1V}", PO1VMNZ, wordDocument);
                ReplaceWordStub("{po1V}", PO1VMNZ, wordDocument);
                ReplaceWordStub("{po1V}", PO1VMNZ, wordDocument);
                ReplaceWordStub("{po2V}", PO2VMNZ, wordDocument);
                ReplaceWordStub("{po2V}", PO2VMNZ, wordDocument);
                ReplaceWordStub("{po2V}", PO2VMNZ, wordDocument);
                ReplaceWordStub("{po3V}", PO3VMNZ, wordDocument);
                ReplaceWordStub("{po3V}", PO3VMNZ, wordDocument);
                ReplaceWordStub("{po3V}", PO3VMNZ, wordDocument);
                ReplaceWordStub("{po4V}", PO4VMNZ, wordDocument);
                ReplaceWordStub("{po4V}", PO4VMNZ, wordDocument);
                ReplaceWordStub("{po4V}", PO4VMNZ, wordDocument);
                ReplaceWordStub("{po5V}", PO5VMNZ, wordDocument);
                ReplaceWordStub("{po5V}", PO5VMNZ, wordDocument);
                ReplaceWordStub("{po5V}", PO5VMNZ, wordDocument);
                ReplaceWordStub("{po6V}", PO6VMNZ, wordDocument);
                ReplaceWordStub("{po6V}", PO6VMNZ, wordDocument);
                ReplaceWordStub("{po6V}", PO6VMNZ, wordDocument);
                //12 02 Установочный диск
                ReplaceWordStub("{imya21V}", Imya21VMNZ, wordDocument);
                ReplaceWordStub("{imya22V}", Imya22VMNZ, wordDocument);
                ReplaceWordStub("{imya23V}", Imya23VMNZ, wordDocument);
                ReplaceWordStub("{imya24V}", Imya24VMNZ, wordDocument);
                ReplaceWordStub("{imya25V}", Imya25VMNZ, wordDocument);
                ReplaceWordStub("{imya26V}", Imya26VMNZ, wordDocument);
                ReplaceWordStub("{ksum21V}", KSum21VMNZ, wordDocument);
                ReplaceWordStub("{ksum22V}", KSum22VMNZ, wordDocument);
                ReplaceWordStub("{ksum23V}", KSum23VMNZ, wordDocument);
                ReplaceWordStub("{ksum24V}", KSum24VMNZ, wordDocument);
                ReplaceWordStub("{ksum25V}", KSum25VMNZ, wordDocument);
                ReplaceWordStub("{ksum26V}", KSum26VMNZ, wordDocument);
                //12 03 Диск исходных текстов
                ReplaceWordStub("{imya31V}", Imya31VMNZ, wordDocument);
                ReplaceWordStub("{imya32V}", Imya32VMNZ, wordDocument);
                ReplaceWordStub("{imya33V}", Imya33VMNZ, wordDocument);
                ReplaceWordStub("{imya34V}", Imya34VMNZ, wordDocument);
                ReplaceWordStub("{imya35V}", Imya35VMNZ, wordDocument);
                ReplaceWordStub("{imya36V}", Imya36VMNZ, wordDocument);
                ReplaceWordStub("{ksum31V}", KSum31VMNZ, wordDocument);
                ReplaceWordStub("{ksum32V}", KSum32VMNZ, wordDocument);
                ReplaceWordStub("{ksum33V}", KSum33VMNZ, wordDocument);
                ReplaceWordStub("{ksum34V}", KSum34VMNZ, wordDocument);
                ReplaceWordStub("{ksum35V}", KSum35VMNZ, wordDocument);
                ReplaceWordStub("{ksum36V}", KSum36VMNZ, wordDocument);
                //81 Приложение
                ReplaceWordStub("{imya811V}", Imya811VMNZ, wordDocument);
                ReplaceWordStub("{imya812V}", Imya812VMNZ, wordDocument);
                ReplaceWordStub("{imya813V}", Imya813VMNZ, wordDocument);
                ReplaceWordStub("{imya814V}", Imya814VMNZ, wordDocument);
                ReplaceWordStub("{imya815V}", Imya815VMNZ, wordDocument);
                ReplaceWordStub("{imya816V}", Imya816VMNZ, wordDocument);
                ReplaceWordStub("{ksum811V}", KSum811VMNZ, wordDocument);
                ReplaceWordStub("{ksum812V}", KSum812VMNZ, wordDocument);
                ReplaceWordStub("{ksum813V}", KSum813VMNZ, wordDocument);
                ReplaceWordStub("{ksum814V}", KSum814VMNZ, wordDocument);
                ReplaceWordStub("{ksum815V}", KSum815VMNZ, wordDocument);
                ReplaceWordStub("{ksum816V}", KSum816VMNZ, wordDocument);

                string CivrName = Civr1V.Text;
                wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + "             ВМНЗ.docx"));
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

        private void button3_Click(object sender, EventArgs e)
        {
            VMNZ_Primer VMNZP = new VMNZ_Primer();
            VMNZP.Show();
        }
        private void NamePP_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
    }
}
