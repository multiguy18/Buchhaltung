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

            KasseSoll = new List<HBKontoDataGridEntry>();
            KasseHaben = new List<HBKontoDataGridEntry>();
            PostSoll = new List<HBKontoDataGridEntry>();
            PostHaben = new List<HBKontoDataGridEntry>();
            BankSoll = new List<HBKontoDataGridEntry>();
            BankHaben = new List<HBKontoDataGridEntry>();
            FLLSoll = new List<HBKontoDataGridEntry>();
            FLLHaben = new List<HBKontoDataGridEntry>();
            WarenbestandSoll = new List<HBKontoDataGridEntry>();
            WarenbestandHaben = new List<HBKontoDataGridEntry>();
            MobilienSoll = new List<HBKontoDataGridEntry>();
            MobilienHaben = new List<HBKontoDataGridEntry>();
            ImmobilienSoll = new List<HBKontoDataGridEntry>();
            ImmobilienHaben = new List<HBKontoDataGridEntry>();
            VLLSoll = new List<HBKontoDataGridEntry>();
            VLLHaben = new List<HBKontoDataGridEntry>();
            DarlehensschuldSoll = new List<HBKontoDataGridEntry>();
            DarlehensschuldHaben = new List<HBKontoDataGridEntry>();
            HypothekenSoll = new List<HBKontoDataGridEntry>();
            HypothekenHaben = new List<HBKontoDataGridEntry>();
            EigenkapitalSoll = new List<HBKontoDataGridEntry>();
            EigenkapitalHaben = new List<HBKontoDataGridEntry>();


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
        private List<HBKontoDataGridEntry> _kasseSoll;
        public List<HBKontoDataGridEntry> KasseSoll
        {
            get { return _kasseSoll; }
            set
            {
                SetProperty(ref _kasseSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _kasseHaben;
        public List<HBKontoDataGridEntry> KasseHaben
        {
            get { return _kasseHaben; }
            set
            {
                SetProperty(ref _kasseHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _postSoll;
        public List<HBKontoDataGridEntry> PostSoll
        {
            get { return _postSoll; }
            set
            {
                SetProperty(ref _postSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _postHaben;
        public List<HBKontoDataGridEntry> PostHaben
        {
            get { return _postHaben; }
            set
            {
                SetProperty(ref _postHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _bankSoll;
        public List<HBKontoDataGridEntry> BankSoll
        {
            get { return _bankSoll; }
            set
            {
                SetProperty(ref _bankSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _bankHaben;
        public List<HBKontoDataGridEntry> BankHaben
        {
            get { return _bankHaben; }
            set
            {
                SetProperty(ref _bankHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _fllSoll;
        public List<HBKontoDataGridEntry> FLLSoll
        {
            get { return _fllSoll; }
            set
            {
                SetProperty(ref _fllSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _fllHaben;
        public List<HBKontoDataGridEntry> FLLHaben
        {
            get { return _fllHaben; }
            set
            {
                SetProperty(ref _fllHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _warenbestandSoll;
        public List<HBKontoDataGridEntry> WarenbestandSoll
        {
            get { return _warenbestandSoll; }
            set
            {
                SetProperty(ref _warenbestandSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _warenbestandHaben;
        public List<HBKontoDataGridEntry> WarenbestandHaben
        {
            get { return _warenbestandHaben; }
            set
            {
                SetProperty(ref _warenbestandHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _mobilienSoll;
        public List<HBKontoDataGridEntry> MobilienSoll
        {
            get { return _mobilienSoll; }
            set
            {
                SetProperty(ref _mobilienSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _mobilienHaben;
        public List<HBKontoDataGridEntry> MobilienHaben
        {
            get { return _mobilienHaben; }
            set
            {
                SetProperty(ref _mobilienHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _immobilienSoll;
        public List<HBKontoDataGridEntry> ImmobilienSoll
        {
            get { return _immobilienSoll; }
            set
            {
                SetProperty(ref _immobilienSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _immobilienHaben;
        public List<HBKontoDataGridEntry> ImmobilienHaben
        {
            get { return _immobilienHaben; }
            set
            {
                SetProperty(ref _immobilienHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _vllSoll;
        public List<HBKontoDataGridEntry> VLLSoll
        {
            get { return _vllSoll; }
            set
            {
                SetProperty(ref _vllSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _vllHaben;
        public List<HBKontoDataGridEntry> VLLHaben
        {
            get { return _vllHaben; }
            set
            {
                SetProperty(ref _vllHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _darlehensschuldSoll;
        public List<HBKontoDataGridEntry> DarlehensschuldSoll
        {
            get { return _darlehensschuldSoll; }
            set
            {
                SetProperty(ref _darlehensschuldSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _darlehensschuldHaben;
        public List<HBKontoDataGridEntry> DarlehensschuldHaben
        {
            get { return _darlehensschuldHaben; }
            set
            {
                SetProperty(ref _darlehensschuldHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _hypothekenSoll;
        public List<HBKontoDataGridEntry> HypothekenSoll
        {
            get { return _hypothekenSoll; }
            set
            {
                SetProperty(ref _hypothekenSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _hypothekenHaben;
        public List<HBKontoDataGridEntry> HypothekenHaben
        {
            get { return _hypothekenHaben; }
            set
            {
                SetProperty(ref _hypothekenHaben, value);
            }
        }


        private List<HBKontoDataGridEntry> _eigenkapitalSoll;
        public List<HBKontoDataGridEntry> EigenkapitalSoll
        {
            get { return _eigenkapitalSoll; }
            set
            {
                SetProperty(ref _eigenkapitalSoll, value);
            }
        }

        private List<HBKontoDataGridEntry> _eigenkapitalHaben;
        public List<HBKontoDataGridEntry> EigenkapitalHaben
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
                object[] abRowParam = { new HBKontoDataGridEntry { Bezeichnung = "AB", Betrag = konto.Anfangsbestand} };

                sollListAddMethodInfo.Invoke(sollListobj, abRowParam);

                foreach (float wert in konto.AenderungenPositiv)
                {
                    object[] positiveEntryParam = { new HBKontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    sollListAddMethodInfo.Invoke(sollListobj, positiveEntryParam);
                }

                foreach (float wert in konto.AenderungenNegativ)
                {
                    object[] negativeEntryParam = { new HBKontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    habenListAddMethodInfo.Invoke(habenListobj, negativeEntryParam);
                }

                object[] sbRowParam = { new HBKontoDataGridEntry { Bezeichnung = "SB", Betrag = konto.Schlussbestand } };

                habenListAddMethodInfo.Invoke(habenListobj, sbRowParam);
            }

            if (konto.Typ == Kontotyp.Fremdkapital || konto.Typ == Kontotyp.Eigenkapital)
            {
                object[] abRowParam = { new HBKontoDataGridEntry { Bezeichnung = "AB", Betrag = konto.Anfangsbestand } };

                habenListAddMethodInfo.Invoke(habenListobj, abRowParam);

                foreach (float wert in konto.AenderungenPositiv)
                {
                    object[] positiveEntryParam = { new HBKontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    habenListAddMethodInfo.Invoke(habenListobj, positiveEntryParam);
                }

                foreach (float wert in konto.AenderungenNegativ)
                {
                    object[] negativeEntryParam = { new HBKontoDataGridEntry { Bezeichnung = "", Betrag = wert } };
                    sollListAddMethodInfo.Invoke(sollListobj, negativeEntryParam);
                }

                object[] sbRowParam = { new HBKontoDataGridEntry { Bezeichnung = "SB", Betrag = konto.Schlussbestand } };

                sollListAddMethodInfo.Invoke(sollListobj, sbRowParam);
            }
        }
    }
}
