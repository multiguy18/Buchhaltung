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

        private List<string> _aktivKonten;

        public List<string> AktivKonten
        {
            get { return this._aktivKonten; }
            set { SetProperty(ref _aktivKonten, value); }
        }

        private List<string> _passivKonten;
        public List<string> passivKonten
        {
            get { return this._passivKonten; }
            set { SetProperty(ref _passivKonten, value); }
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
        }
    }
}
