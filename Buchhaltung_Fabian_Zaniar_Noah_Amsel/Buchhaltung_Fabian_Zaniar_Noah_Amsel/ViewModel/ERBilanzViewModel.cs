using Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.ViewModel
{
    public class ERBilanzViewModel : ViewModelBase
    {
        Model.ERBilanzModel model;

        private List<SBKontoDataGridEntry> _aktivKontenUmlauf;
        public List<SBKontoDataGridEntry> AktivKontenUmlauf
        {
            get { return this._aktivKontenUmlauf; }
            set { SetProperty(ref _aktivKontenUmlauf, value); }
        }

        private List<SBKontoDataGridEntry> _aktivKontenAnlage;
        public List<SBKontoDataGridEntry> AktivKontenAnlage
        {
            get { return this._aktivKontenAnlage; }
            set { SetProperty(ref _aktivKontenAnlage, value); }
        }

        private List<SBKontoDataGridEntry> _passivKontenFremd;
        public List<SBKontoDataGridEntry> PassivKontenFremd
        {
            get { return this._passivKontenFremd; }
            set { SetProperty(ref _passivKontenFremd, value); }
        }

        private List<SBKontoDataGridEntry> _passivKontenEigen;
        public List<SBKontoDataGridEntry> PassivKontenEigen
        {
            get { return this._passivKontenEigen; }
            set { SetProperty(ref _passivKontenEigen, value); }
        }

        private List<string> _aufwandKonten;
        public List<string> AufwandKonten
        {
            get { return this._aufwandKonten; }
            set { SetProperty(ref _aufwandKonten, value); }
        }

        private List<string> _ertragKonten;
        public List<string> ErtragKonten
        {
            get { return this._ertragKonten; }
            set { SetProperty(ref _ertragKonten, value); }
        }

        private float _summeAktiv;
        public float SummeAktiv
        {
            get { return this._summeAktiv; }
            set { SetProperty(ref _summeAktiv, value); }
        }

        private float _summePassiv;
        public float SummePassiv
        {
            get { return this._summePassiv; }
            set { SetProperty(ref _summePassiv, value); }
        }

        public ERBilanzViewModel(List<Konto> konten)
        {
            this.model = new Model.ERBilanzModel();

            AktivKontenUmlauf = new List<SBKontoDataGridEntry>();
            AktivKontenAnlage = new List<SBKontoDataGridEntry>();
            PassivKontenFremd = new List<SBKontoDataGridEntry>();
            PassivKontenEigen = new List<SBKontoDataGridEntry>();
            AufwandKonten = new List<string>();
            ErtragKonten = new List<string>();

            foreach (Konto umlaufKonto in konten.Where(k => k.Typ == Kontotyp.Umlaufvermoegen))
            {
                if (umlaufKonto.Schlussbestand != 0)
                {
                    AktivKontenUmlauf.Add(new SBKontoDataGridEntry() { Konto = umlaufKonto.Name.ToString("g"), Schlussbestand = umlaufKonto.Schlussbestand });
                    SummeAktiv += umlaufKonto.Schlussbestand;
                }
            }
            
            foreach (Konto anlageKonto in konten.Where(k => k.Typ == Kontotyp.Anlagevermoegen))
            {
                if (anlageKonto.Schlussbestand != 0)
                {
                    AktivKontenAnlage.Add(new SBKontoDataGridEntry() { Konto = anlageKonto.Name.ToString("g"), Schlussbestand = anlageKonto.Schlussbestand });
                    SummeAktiv += anlageKonto.Schlussbestand;
                }
            }

            foreach (Konto fremdKonto in konten.Where(k => k.Typ == Kontotyp.Fremdkapital))
            {
                if (fremdKonto.Schlussbestand != 0)
                {
                    PassivKontenFremd.Add(new SBKontoDataGridEntry() { Konto = fremdKonto.Name.ToString("g"), Schlussbestand = fremdKonto.Schlussbestand });
                    SummePassiv += fremdKonto.Schlussbestand;
                }

            }

            foreach (Konto eigenKonto in konten.Where(k => k.Typ == Kontotyp.Eigenkapital))
            {
                PassivKontenEigen.Add(new SBKontoDataGridEntry() { Konto = eigenKonto.Name.ToString("g"), Schlussbestand = eigenKonto.Schlussbestand });
                SummePassiv += eigenKonto.Schlussbestand;
            }
        }
    }
}
