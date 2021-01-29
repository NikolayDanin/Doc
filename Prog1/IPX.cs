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
using Prog1.Models;
using System.Data.Entity;

namespace Prog1
{
    public partial class IPX : Form
    {
        private string TemplateFileName => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Sh05_IPH.docx");
        private string TemplateFileNameGOST => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GOST\\СТО МНЗ.docx");
        private readonly MainDbContext _mainDbContext;
        private IpxModel _currentModel;
        public IPX()
        {
            InitializeComponent();
            _mainDbContext = new MainDbContext();
            _mainDbContext.Ipxes.Load();
            ipxGridView.DataSource = _mainDbContext.Ipxes.Local.ToBindingList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                var Civr02IPX = Civr02I.Text;
                var MT2IPX = MT02I.Text;
                var MT3IPX = MT03I.Text;
                var MT81IPX = MT81I.Text;
                var nameIPX = NamePPI.Text;
                var TemaIPX = TemaI.Text;
                var UseDIPX = UseDocI.Text;
                var AvtorIPX = AvtorI.Text;
                var OrRazrabIPX = OrRazrabI.Text;
                var IzgotIPX = IzgotI.Text;
                var VladelecIPX = VladelecI.Text;
                var OtvIspolIPX = OtvIspolnI.Text;
                var NachBMDIPX = NachBMDI.Text;
                var LitIPX = LiteraI.Text;

                // экспорт в word
                var wordApp = new Word.Application();
                wordApp.Visible = false;

                try
                {

                    var wordDocument = wordApp.Documents.Open(TemplateFileName);
                    ReplaceWordStub("{civr02I}", Civr02IPX, wordDocument);
                    ReplaceWordStub("{civr02I}", Civr02IPX, wordDocument);
                    ReplaceWordStub("{civr02I}", Civr02IPX, wordDocument);
                    ReplaceWordStub("{mt02I}", MT2IPX, wordDocument);
                    ReplaceWordStub("{mt03I}", MT3IPX, wordDocument);
                    ReplaceWordStub("{mt81I}", MT81IPX, wordDocument);
                    ReplaceWordStub("{nameI}", nameIPX, wordDocument);
                    ReplaceWordStub("{nameI}", nameIPX, wordDocument);
                    ReplaceWordStub("{nameI}", nameIPX, wordDocument);
                    ReplaceWordStub("{temaI}", TemaIPX, wordDocument);
                    ReplaceWordStub("{temaI}", TemaIPX, wordDocument);
                    ReplaceWordStub("{temaI}", TemaIPX, wordDocument);
                    ReplaceWordStub("{temaI}", TemaIPX, wordDocument);
                    ReplaceWordStub("{temaI}", TemaIPX, wordDocument);
                    ReplaceWordStub("{temaI}", TemaIPX, wordDocument);
                    ReplaceWordStub("{usedocI}", UseDIPX, wordDocument);
                    ReplaceWordStub("{usedocI}", UseDIPX, wordDocument);
                    ReplaceWordStub("{usedocI}", UseDIPX, wordDocument);
                    ReplaceWordStub("{avtorI}", AvtorIPX, wordDocument);
                    ReplaceWordStub("{avtorI}", AvtorIPX, wordDocument);
                    ReplaceWordStub("{avtorI}", AvtorIPX, wordDocument);
                    ReplaceWordStub("{orrazrabI}", OrRazrabIPX, wordDocument);
                    ReplaceWordStub("{orrazrabI}", OrRazrabIPX, wordDocument);
                    ReplaceWordStub("{orrazrabI}", OrRazrabIPX, wordDocument);
                    ReplaceWordStub("{izgotI}", IzgotIPX, wordDocument);
                    ReplaceWordStub("{izgotI}", IzgotIPX, wordDocument);
                    ReplaceWordStub("{izgotI}", IzgotIPX, wordDocument);
                    ReplaceWordStub("{vladelecI}", VladelecIPX, wordDocument);
                    ReplaceWordStub("{vladelecI}", VladelecIPX, wordDocument);
                    ReplaceWordStub("{vladelecI}", VladelecIPX, wordDocument);
                    ReplaceWordStub("{otvispolI}", OtvIspolIPX, wordDocument);
                    ReplaceWordStub("{otvispolI}", OtvIspolIPX, wordDocument);
                    ReplaceWordStub("{otvispolI}", OtvIspolIPX, wordDocument);
                    ReplaceWordStub("{nachBMDI}", NachBMDIPX, wordDocument);
                    ReplaceWordStub("{nachBMDI}", NachBMDIPX, wordDocument);
                    ReplaceWordStub("{nachBMDI}", NachBMDIPX, wordDocument);
                    ReplaceWordStub("{litI}", LitIPX, wordDocument);
                    ReplaceWordStub("{litI}", LitIPX, wordDocument);
                    ReplaceWordStub("{litI}", LitIPX, wordDocument);

                    string CivrName = Civr02I.Text;
                    wordDocument.SaveAs(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents\\ЦИВР." +  CivrName + "             ИПХ.docx"));
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
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(TemplateFileNameGOST);
            wordApp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPX_Primer IPXP = new IPX_Primer();
            IPXP.Show();
        }
        private void NamePPI_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void saveToDb_Click(object sender, EventArgs e)
        {
            var ipx = new IpxModel
            {
                DecimalNumber = Civr02I.Text,
                ProgramName = NamePPI.Text,
                Subject = TemaI.Text,
                DocumentUsage = UseDocI.Text,
                Letter = LiteraI.Text,
                Author = AvtorI.Text,
                Organization = OrRazrabI.Text,
                Producer = IzgotI.Text,
                Owner = VladelecI.Text,
                ResponsiblePerson = OtvIspolnI.Text,
                HeadOfBmd = NachBMDI.Text,
                SetupDisc = MT02I.Text,
                SourceDisc = MT03I.Text,
                Note = MT81I.Text
            };
            _mainDbContext.Ipxes.Add(ipx);
            _mainDbContext.SaveChanges();
        }

        private void ipxGridView_DoubleClick(object sender, EventArgs e)
        {
            _currentModel = (ipxGridView.SelectedRows[0].DataBoundItem as IpxModel);
            if (_currentModel == null)
                return;
            Civr02I.Text = _currentModel.DecimalNumber;
            NamePPI.Text = _currentModel.ProgramName;
            TemaI.Text = _currentModel.Subject;
            UseDocI.Text = _currentModel.DocumentUsage;
            LiteraI.Text = _currentModel.Letter;
            AvtorI.Text = _currentModel.Author;
            OrRazrabI.Text = _currentModel.Organization;
            IzgotI.Text = _currentModel.Producer;
            VladelecI.Text = _currentModel.Owner;
            OtvIspolnI.Text = _currentModel.ResponsiblePerson;
            NachBMDI.Text = _currentModel.HeadOfBmd;
            MT02I.Text = _currentModel.SetupDisc;
            MT03I.Text = _currentModel.SourceDisc;
            MT81I.Text = _currentModel.Note;
        }
    }
}
