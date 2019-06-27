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

        private List<string> _aktivKontenUmlauf;
        public List<string> AktivKontenUmlauf
        {
            get { return this._aktivKontenUmlauf; }
            set { SetProperty(ref _aktivKontenUmlauf, value); }
        }

        private List<string> _aktivKontenAnlage;
        public List<string> AktivKontenAnlage
        {
            get { return this._aktivKontenAnlage; }
            set { SetProperty(ref _aktivKontenAnlage, value); }
        }

        private List<string> _passivKontenFremd;
        public List<string> PassivKontenFremd
        {
            get { return this._passivKontenFremd; }
            set { SetProperty(ref _passivKontenFremd, value); }
        }

        private List<string> _passivKontenEigen;
        public List<string> PassivKontenEigen
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

        public ERBilanzViewModel()
        {
            this.model = new Model.ERBilanzModel();

            AktivKontenUmlauf = new List<string>();
            AktivKontenAnlage = new List<string>();
            PassivKontenFremd = new List<string>();
            PassivKontenEigen = new List<string>();
            AufwandKonten = new List<string>();
            ErtragKonten = new List<string>();
        }
    }
}
