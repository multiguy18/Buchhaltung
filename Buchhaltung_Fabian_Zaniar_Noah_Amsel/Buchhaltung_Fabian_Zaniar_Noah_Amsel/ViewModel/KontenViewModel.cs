using Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.ViewModel
{
    public class KontenViewModel : ViewModelBase
    {
        Model.BuchungsSatzModel model;

        public KontenViewModel(List<Konto> konten)
        {
            this.model = new Model.BuchungsSatzModel();

            KasseSoll = new List<KontoDataGridEntry>();
            KasseHaben = new List<KontoDataGridEntry>();
            PostSoll = new List<KontoDataGridEntry>();
            PostHaben = new List<KontoDataGridEntry>();
            BankSoll = new List<KontoDataGridEntry>();
            BankHaben = new List<KontoDataGridEntry>();
            FLLSoll = new List<KontoDataGridEntry>();
            FLLHaben = new List<KontoDataGridEntry>();
            WarenbestandSoll = new List<KontoDataGridEntry>();
            WarenbestandHaben = new List<KontoDataGridEntry>();
            MobilienSoll = new List<KontoDataGridEntry>();
            MobilienHaben = new List<KontoDataGridEntry>();
            ImmobilienSoll = new List<KontoDataGridEntry>();
            ImmobilienHaben = new List<KontoDataGridEntry>();
            VLLSoll = new List<KontoDataGridEntry>();
            VLLHaben = new List<KontoDataGridEntry>();
            DarlehensschuldSoll = new List<KontoDataGridEntry>();
            DarlehensschuldHaben = new List<KontoDataGridEntry>();
            HypothekenSoll = new List<KontoDataGridEntry>();
            HypothekenHaben = new List<KontoDataGridEntry>();
            EigenkapitalSoll = new List<KontoDataGridEntry>();
            EigenkapitalHaben = new List<KontoDataGridEntry>();


            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Kasse), "Kasse");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Post), "Post");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Bank), "Bank");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.FLL), "FLL");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Warenbestand), "Warenbestand");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Mobilien), "Mobilien");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Immobilien), "Immobilien");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.VLL), "VLL");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Darlehensschuld), "Darlehensschuld");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Hypotheken), "Hypotheken");
            GenerateKontoEntries(konten.Single(k => k.Name == Kontoname.Eigenkapital), "Eigenkapital");
        }

        #region ViewModelProperties
        private List<KontoDataGridEntry> _kasseSoll;
        public List<KontoDataGridEntry> KasseSoll
        {
            get { return _kasseSoll; }
            set
            {
                SetProperty(ref _kasseSoll, value);
            }
        }

        private List<KontoDataGridEntry> _kasseHaben;
        public List<KontoDataGridEntry> KasseHaben
        {
            get { return _kasseHaben; }
            set
            {
                SetProperty(ref _kasseHaben, value);
            }
        }


        private List<KontoDataGridEntry> _postSoll;
        public List<KontoDataGridEntry> PostSoll
        {
            get { return _postSoll; }
            set
            {
                SetProperty(ref _postSoll, value);
            }
        }

        private List<KontoDataGridEntry> _postHaben;
        public List<KontoDataGridEntry> PostHaben
        {
            get { return _postHaben; }
            set
            {
                SetProperty(ref _postHaben, value);
            }
        }


        private List<KontoDataGridEntry> _bankSoll;
        public List<KontoDataGridEntry> BankSoll
        {
            get { return _bankSoll; }
            set
            {
                SetProperty(ref _bankSoll, value);
            }
        }

        private List<KontoDataGridEntry> _bankHaben;
        public List<KontoDataGridEntry> BankHaben
        {
            get { return _bankHaben; }
            set
            {
                SetProperty(ref _bankHaben, value);
            }
        }


        private List<KontoDataGridEntry> _fllSoll;
        public List<KontoDataGridEntry> FLLSoll
        {
            get { return _fllSoll; }
            set
            {
                SetProperty(ref _fllSoll, value);
            }
        }

        private List<KontoDataGridEntry> _fllHaben;
        public List<KontoDataGridEntry> FLLHaben
        {
            get { return _fllHaben; }
            set
            {
                SetProperty(ref _fllHaben, value);
            }
        }


        private List<KontoDataGridEntry> _warenbestandSoll;
        public List<KontoDataGridEntry> WarenbestandSoll
        {
            get { return _warenbestandSoll; }
            set
            {
                SetProperty(ref _warenbestandSoll, value);
            }
        }

        private List<KontoDataGridEntry> _warenbestandHaben;
        public List<KontoDataGridEntry> WarenbestandHaben
        {
            get { return _warenbestandHaben; }
            set
            {
                SetProperty(ref _warenbestandHaben, value);
            }
        }


        private List<KontoDataGridEntry> _mobilienSoll;
        public List<KontoDataGridEntry> MobilienSoll
        {
            get { return _mobilienSoll; }
            set
            {
                SetProperty(ref _mobilienSoll, value);
            }
        }

        private List<KontoDataGridEntry> _mobilienHaben;
        public List<KontoDataGridEntry> MobilienHaben
        {
            get { return _mobilienHaben; }
            set
            {
                SetProperty(ref _mobilienHaben, value);
            }
        }


        private List<KontoDataGridEntry> _immobilienSoll;
        public List<KontoDataGridEntry> ImmobilienSoll
        {
            get { return _immobilienSoll; }
            set
            {
                SetProperty(ref _immobilienSoll, value);
            }
        }

        private List<KontoDataGridEntry> _immobilienHaben;
        public List<KontoDataGridEntry> ImmobilienHaben
        {
            get { return _immobilienHaben; }
            set
            {
                SetProperty(ref _immobilienHaben, value);
            }
        }


        private List<KontoDataGridEntry> _vllSoll;
        public List<KontoDataGridEntry> VLLSoll
        {
            get { return _vllSoll; }
            set
            {
                SetProperty(ref _vllSoll, value);
            }
        }

        private List<KontoDataGridEntry> _vllHaben;
        public List<KontoDataGridEntry> VLLHaben
        {
            get { return _vllHaben; }
            set
            {
                SetProperty(ref _vllHaben, value);
            }
        }


        private List<KontoDataGridEntry> _darlehensschuldSoll;
        public List<KontoDataGridEntry> DarlehensschuldSoll
        {
            get { return _darlehensschuldSoll; }
            set
            {
                SetProperty(ref _darlehensschuldSoll, value);
            }
        }

        private List<KontoDataGridEntry> _darlehensschuldHaben;
        public List<KontoDataGridEntry> DarlehensschuldHaben
        {
            get { return _darlehensschuldHaben; }
            set
            {
                SetProperty(ref _darlehensschuldHaben, value);
            }
        }


        private List<KontoDataGridEntry> _hypothekenSoll;
        public List<KontoDataGridEntry> HypothekenSoll
        {
            get { return _hypothekenSoll; }
            set
            {
                SetProperty(ref _hypothekenSoll, value);
            }
        }

        private List<KontoDataGridEntry> _hypothekenHaben;
        public List<KontoDataGridEntry> HypothekenHaben
        {
            get { return _hypothekenHaben; }
            set
            {
                SetProperty(ref _hypothekenHaben, value);
            }
        }


        private List<KontoDataGridEntry> _eigenkapitalSoll;
        public List<KontoDataGridEntry> EigenkapitalSoll
        {
            get { return _eigenkapitalSoll; }
            set
            {
                SetProperty(ref _eigenkapitalSoll, value);
            }
        }

        private List<KontoDataGridEntry> _eigenkapitalHaben;
        public List<KontoDataGridEntry> EigenkapitalHaben
        {
            get { return _eigenkapitalHaben; }
            set
            {
                SetProperty(ref _eigenkapitalHaben, value);
            }
        }
        #endregion

        void GenerateKontoEntries(Konto konto, string kontoProperties)
        {
            object sollListobj = this.GetType().GetProperty(kontoProperties + "Soll").GetValue(this);
            var sollListAddMethodInfo = sollListobj.GetType().GetMethod("Add");

            object habenListobj = GetType().GetProperty(kontoProperties + "Haben").GetValue(this);
            var habenListAddMethodInfo = sollListobj.GetType().GetMethod("Add");

            if (konto.Typ == Kontotyp.Anlagevermoegen || konto.Typ == Kontotyp.Umlaufvermoegen)
            {
                object[] firstRowParam = { new KontoDataGridEntry { Bezeichnung = "AB", Betrag = konto.Anfangsbestand} };

                sollListAddMethodInfo.Invoke(sollListobj, firstRowParam);

                foreach (float wert in konto.AenderungenPositiv)
                {
                    object[] positiveValue = { new KontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    sollListAddMethodInfo.Invoke(sollListobj, positiveValue);
                }

                foreach (float wert in konto.AenderungenNegativ)
                {
                    object[] negativeValue = { new KontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    habenListAddMethodInfo.Invoke(habenListobj, negativeValue);
                }
            }

            if (konto.Typ == Kontotyp.Fremdkapital || konto.Typ == Kontotyp.Eigenkapital)
            {
                object[] values = { new KontoDataGridEntry { Bezeichnung = "AB", Betrag = konto.Anfangsbestand } };

                habenListAddMethodInfo.Invoke(habenListobj, values);

                foreach (float wert in konto.AenderungenPositiv)
                {
                    object[] positiveValue = { new KontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    habenListAddMethodInfo.Invoke(habenListobj, positiveValue);
                }

                foreach (float wert in konto.AenderungenNegativ)
                {
                    object[] negativeValue = { new KontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    sollListAddMethodInfo.Invoke(sollListobj, negativeValue);
                }
            }
        }
    }
}
