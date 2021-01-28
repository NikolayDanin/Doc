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
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Prog1
{

    public partial class AllDoc : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\ShAll.docx");
        private string TemplateFileNameFP => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\Formulyar_Primer.docx");
        private string TemplateFileNameSP => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\Spec_Primer.docx");
        public AllDoc()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                var CivrAll = CivrA.Text;
                var NameAll = NameA.Text;
                var MTAll02 = MTA02.Text;
                var MTAll03 = MTA03.Text;
                var MTAll81 = MTA81.Text;
                var OCAll = OCA.Text;
                var LangAll = LangA.Text;
                var ShTAll = ShTA.Text;
                var DateAll = DateA.Text;
                var UseDocAll = UseDocA.Text;
                var AvtorAll = AvtorA.Text;
                var OrRazrabAll = OrRazrabA.Text;
                var IzgotAll = IzgotA.Text;
                var VladelecAll = VladelecA.Text;
                var OtvIspolnAll = OtvIspolnA.Text;
                var NachBMDAll = NachBMDA.Text;
                var Name02All = Name02A.Text;
                var Name03All = Name03A.Text;
                var Name81All = Name81A.Text;
                var Zanyato02All = Zanyato02A.Text;
                var Zanyato03All = Zanyato03A.Text;
                var Zanyato81All = Zanyato81A.Text;
                var KonSum02All = KonSum02A.Text;
                var KonSum03All = KonSum03A.Text;
                var KonSum81All = KonSum81A.Text;
                var NakAll = NakopiA.Text;
                //Ведомость
                var kA1 = kAll1.Text;
                var kA2 = kAll2.Text;
                var kA3 = kAll3.Text;
                var kA4 = kAll41.Text;
                var MeAll1 = MestoA1.Text;
                var MeAll2 = MestoA2.Text;
                var MeAll3 = MestoA3.Text;
                var MeAll4 = MestoA41.Text;
                //Формуляр
                var IzAll = IzdAll.Text;
                //Листы утверждения
                var RukRazrAll = RukRazrA.Text;
                var SoglAll = SoglA.Text;
                var SoglFAll = SoglFIOA.Text;
                var UtverDAll = UtverDolgA.Text;
                var UtverFIOAll = UtverFIOA.Text;
                var IspolAll = IspolnA.Text;
                var NormAll = NormA.Text;
                var PredstAll = PredstA.Text;
                //Этикетки
                var KodAll = KodA.Text;
                var DateEAll = DateAE.Text;
                var NTAll = NomTomA.Text;


                // экспорт в word
                var wordApp = new Word.Application();
                wordApp.Visible = false;

                try
                {

                    var wordDocument = wordApp.Documents.Open(TemplateFileName);
                    //Общее
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{civrAll}", CivrAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{nameAll}", NameAll, wordDocument);
                    ReplaceWordStub("{mtAll02}", MTAll02, wordDocument);
                    ReplaceWordStub("{mtAll02}", MTAll02, wordDocument);
                    ReplaceWordStub("{mtAll02}", MTAll02, wordDocument);
                    ReplaceWordStub("{mtAll02}", MTAll02, wordDocument);
                    ReplaceWordStub("{mtAll03}", MTAll03, wordDocument);
                    ReplaceWordStub("{mtAll03}", MTAll03, wordDocument);
                    ReplaceWordStub("{mtAll03}", MTAll03, wordDocument);
                    ReplaceWordStub("{mtAll03}", MTAll03, wordDocument);
                    ReplaceWordStub("{mtAll81}", MTAll81, wordDocument);
                    ReplaceWordStub("{mtAll81}", MTAll81, wordDocument);
                    ReplaceWordStub("{mtAll81}", MTAll81, wordDocument);
                    ReplaceWordStub("{mtAll81}", MTAll81, wordDocument);
                    ReplaceWordStub("{ocAll}", OCAll, wordDocument);
                    ReplaceWordStub("{ocAll}", OCAll, wordDocument);
                    ReplaceWordStub("{ocAll}", OCAll, wordDocument);
                    ReplaceWordStub("{ocAll}", OCAll, wordDocument);
                    ReplaceWordStub("{ocAll}", OCAll, wordDocument);
                    ReplaceWordStub("{lgAll}", LangAll, wordDocument);
                    ReplaceWordStub("{lgAll}", LangAll, wordDocument);
                    ReplaceWordStub("{lgAll}", LangAll, wordDocument);
                    ReplaceWordStub("{lgAll}", LangAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{nakAll}", NakAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{shteAll}", ShTAll, wordDocument);
                    ReplaceWordStub("{name02All}", Name02All, wordDocument);
                    ReplaceWordStub("{name02All}", Name02All, wordDocument);
                    ReplaceWordStub("{name03All}", Name03All, wordDocument);
                    ReplaceWordStub("{name03All}", Name03All, wordDocument);
                    ReplaceWordStub("{name81All}", Name03All, wordDocument);
                    ReplaceWordStub("{name81All}", Name03All, wordDocument);
                    //ИПХ
                    ReplaceWordStub("{usedAll}", UseDocAll, wordDocument);
                    ReplaceWordStub("{usedAll}", UseDocAll, wordDocument);
                    ReplaceWordStub("{usedAll}", UseDocAll, wordDocument);
                    ReplaceWordStub("{avtAll}", AvtorAll, wordDocument);
                    ReplaceWordStub("{avtAll}", AvtorAll, wordDocument);
                    ReplaceWordStub("{avtAll}", AvtorAll, wordDocument);
                    ReplaceWordStub("{orazAll}", OrRazrabAll, wordDocument);
                    ReplaceWordStub("{orazAll}", OrRazrabAll, wordDocument);
                    ReplaceWordStub("{orazAll}", OrRazrabAll, wordDocument);
                    ReplaceWordStub("{orazAll}", OrRazrabAll, wordDocument);
                    ReplaceWordStub("{izgAll}", IzgotAll, wordDocument);
                    ReplaceWordStub("{izgAll}", IzgotAll, wordDocument);
                    ReplaceWordStub("{izgAll}", IzgotAll, wordDocument);
                    ReplaceWordStub("{vladAll}", VladelecAll, wordDocument);
                    ReplaceWordStub("{vladAll}", VladelecAll, wordDocument);
                    ReplaceWordStub("{vladAll}", VladelecAll, wordDocument);
                    ReplaceWordStub("{otvispolAll}", OtvIspolnAll, wordDocument);
                    ReplaceWordStub("{otvispolAll}", OtvIspolnAll, wordDocument);
                    ReplaceWordStub("{otvispolAll}", OtvIspolnAll, wordDocument);
                    ReplaceWordStub("{nachBMDAll}", NachBMDAll, wordDocument);
                    ReplaceWordStub("{nachBMDAll}", NachBMDAll, wordDocument);
                    ReplaceWordStub("{nachBMDAll}", NachBMDAll, wordDocument);
                    //ВМНЗ
                    ReplaceWordStub("{dateAll}", DateAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateAll, wordDocument);
                    ReplaceWordStub("{zan02All}", Zanyato02All, wordDocument);
                    ReplaceWordStub("{zan03All}", Zanyato03All, wordDocument);
                    ReplaceWordStub("{zan81All}", Zanyato81All, wordDocument);
                    ReplaceWordStub("{ksum02All}", KonSum02All, wordDocument);
                    ReplaceWordStub("{ksum03All}", KonSum03All, wordDocument);
                    ReplaceWordStub("{ksum81All}", KonSum81All, wordDocument);
                    //Ведомость
                    ReplaceWordStub("{kA1}", kA1, wordDocument);
                    ReplaceWordStub("{kA2}", kA2, wordDocument);
                    ReplaceWordStub("{kA3}", kA3, wordDocument);
                    ReplaceWordStub("{kA4}", kA4, wordDocument);
                    ReplaceWordStub("{mAll1}", MeAll1, wordDocument);
                    ReplaceWordStub("{mAll2}", MeAll2, wordDocument);
                    ReplaceWordStub("{mAll3}", MeAll3, wordDocument);
                    ReplaceWordStub("{mAll4}", MeAll4, wordDocument);
                    //Формуляр
                    ReplaceWordStub("{izdAll}", IzAll, wordDocument);
                    ReplaceWordStub("{izdAll}", IzAll, wordDocument);
                    ReplaceWordStub("{izdAll}", IzAll, wordDocument);
                    ReplaceWordStub("{izdAll}", IzAll, wordDocument);
                    ReplaceWordStub("{izdAll}", IzAll, wordDocument);
                    ReplaceWordStub("{izdAll}", IzAll, wordDocument);
                    ReplaceWordStub("{izdAll}", IzAll, wordDocument);
                    //Листы утверждения
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{rurazrAll}", RukRazrAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglAll}", SoglAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{soglfAll}", SoglFAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvDAll}", UtverDAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{utvFAll}", UtverFIOAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{ispAll}", IspolAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{norAll}", NormAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    ReplaceWordStub("{predAll}", PredstAll, wordDocument);
                    //Этикетки
                    ReplaceWordStub("{kodAll}", KodAll, wordDocument);
                    ReplaceWordStub("{kodAll}", KodAll, wordDocument);
                    ReplaceWordStub("{kodAll}", KodAll, wordDocument);
                    ReplaceWordStub("{kodAll}", KodAll, wordDocument);
                    ReplaceWordStub("{kodAll}", KodAll, wordDocument);
                    ReplaceWordStub("{kodAll}", KodAll, wordDocument);
                    ReplaceWordStub("{kodAll}", KodAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateEAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateEAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateEAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateEAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateEAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateEAll, wordDocument);
                    ReplaceWordStub("{dateAll}", DateEAll, wordDocument);
                    ReplaceWordStub("{ntAll}", NTAll, wordDocument);
                    ReplaceWordStub("{ntAll}", NTAll, wordDocument);
                    ReplaceWordStub("{ntAll}", NTAll, wordDocument);
                    ReplaceWordStub("{ntAll}", NTAll, wordDocument);
                    ReplaceWordStub("{ntAll}", NTAll, wordDocument);
                    ReplaceWordStub("{ntAll}", NTAll, wordDocument);

                    foreach (Word.Range rngC in wordDocument.StoryRanges)
                    {
                        Word.Range rng = rngC;
                        while (rng != null)
                        {
                            int rngc = rng.StoryLength;
                            string mt = rng.Text;

                            rng.Find.ClearFormatting();
                            rng.Find.Execute("{civrAll}", ReplaceWith: CivrAll, Replace: Word.WdReplace.wdReplaceAll);
                            rng = rng.NextStoryRange;
                        }
                    }

                    string CivrName = CivrA.Text;
                    wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." + CivrName + "             Полный Комплект.docx"));
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

        private void AllDoc_Load(object sender, EventArgs e)
        {
            DateAE.CustomFormat = "yyMMdd";
            DateAE.Format = DateTimePickerFormat.Custom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Etik_Primer EtP = new Etik_Primer();
            EtP.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VMNZ_Primer VMNZP = new VMNZ_Primer();
            VMNZP.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IPX_Primer IPXP = new IPX_Primer();
            IPXP.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tekst_Primer TeP = new Tekst_Primer();
            TeP.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LU_Primer LUP = new LU_Primer();
            LUP.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Vedomostb_Primer VedP = new Vedomostb_Primer();
            VedP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileNameFP);
            wordApp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileNameSP);
            wordApp.Visible = true;
        }
        private void NameA_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
    }
}
