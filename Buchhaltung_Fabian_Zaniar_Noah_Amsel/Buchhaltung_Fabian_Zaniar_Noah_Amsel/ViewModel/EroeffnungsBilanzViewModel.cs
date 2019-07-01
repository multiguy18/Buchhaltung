using Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.ViewModel
{
    public class EroeffnungsBilanzViewModel : ViewModelBase
    {
        public event Action<string> ErrorMessageDialog;
        private List<Konto> _konten;

        public EroeffnungsBilanzViewModel(List<Konto> konten)
        {
            Model.EroeffnungsBilanzModel model;
            _konten = konten;

            AktivKontenUmlauf = new ObservableCollection<EBKontoDataGridEntry>();
            AktivKontenAnlage = new ObservableCollection<EBKontoDataGridEntry>();
            PassivKontenFremd = new ObservableCollection<EBKontoDataGridEntry>();
            PassivKontenEigen = new ObservableCollection<EBKontoDataGridEntry>();

            GenerateKontenABs();

            AktivKontenUmlauf.CollectionChanged += CollectionChangedHandler;
            EBKontoDataGridEntry.OnRowChanged += RowChangedHandler;
        }

        private ObservableCollection<EBKontoDataGridEntry> _aktivKontenUmlauf;
        public ObservableCollection<EBKontoDataGridEntry> AktivKontenUmlauf
        {
            get { return this._aktivKontenUmlauf; }
            set { SetProperty(ref _aktivKontenUmlauf, value); }
        }

        private ObservableCollection<EBKontoDataGridEntry> _aktivKontenAnlage;
        public ObservableCollection<EBKontoDataGridEntry> AktivKontenAnlage
        {
            get { return this._aktivKontenAnlage; }
            set { SetProperty(ref _aktivKontenAnlage, value); }
        }

        private ObservableCollection<EBKontoDataGridEntry> _passivKontenFremd;
        public ObservableCollection<EBKontoDataGridEntry> PassivKontenFremd
        {
            get { return this._passivKontenFremd; }
            set { SetProperty(ref _passivKontenFremd, value); }
        }

        private ObservableCollection<EBKontoDataGridEntry> _passivKontenEigen;
        public ObservableCollection<EBKontoDataGridEntry> PassivKontenEigen
        {
            get { return this._passivKontenEigen; }
            set { SetProperty(ref _passivKontenEigen, value); }
        }

        private void GenerateKontenABs()
        {
            foreach (Konto konto in _konten.Where(k => k.Typ == Kontotyp.Umlaufvermoegen))
            {
                if (konto.Anfangsbestand != 0)
                {
                    AktivKontenUmlauf.Add(new EBKontoDataGridEntry { Konto = konto.Name, Anfangsbestand = konto.Anfangsbestand });
                }
            }

            foreach (Konto konto in _konten.Where(k => k.Typ == Kontotyp.Anlagevermoegen))
            {
                if (konto.Anfangsbestand != 0)
                {
                    AktivKontenAnlage.Add(new EBKontoDataGridEntry { Konto = konto.Name, Anfangsbestand = konto.Anfangsbestand });
                }
            }

            foreach (Konto konto in _konten.Where(k => k.Typ == Kontotyp.Fremdkapital))
            {
                if (konto.Anfangsbestand != 0)
                {
                    PassivKontenFremd.Add(new EBKontoDataGridEntry { Konto = konto.Name, Anfangsbestand = konto.Anfangsbestand });
                }
            }

            foreach (Konto konto in _konten.Where(k => k.Typ == Kontotyp.Eigenkapital))
            {
                PassivKontenEigen.Add(new EBKontoDataGridEntry { Konto = konto.Name, Anfangsbestand = konto.Anfangsbestand });
            }
        }

        private void CollectionChangedHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            DatagridChanged();
        }

        private void RowChangedHandler(object sender, EventArgs e)
        {
            DatagridChanged();
        }

        private void DatagridChanged()
        {
            float summeAktiven = 0;
            float summePassiven = 0;
            float eigenkapitalSumme = 0;

            foreach (EBKontoDataGridEntry kontoEntry in AktivKontenUmlauf)
            {
                Konto kontoAktivUmlauf = _konten.Single(k => k.Name == kontoEntry.Konto);
                kontoAktivUmlauf.Anfangsbestand = kontoEntry.Anfangsbestand;
                summeAktiven += kontoEntry.Anfangsbestand;
            }

            foreach (EBKontoDataGridEntry kontoEntry in AktivKontenAnlage)
            {
                Konto kontoAktivAnlage = _konten.Single(k => k.Name == kontoEntry.Konto);
                kontoAktivAnlage.Anfangsbestand = kontoEntry.Anfangsbestand;
                summeAktiven += kontoEntry.Anfangsbestand;
            }

            foreach (EBKontoDataGridEntry kontoEntry in PassivKontenFremd)
            {
                Konto kontoPassivFremd = _konten.Single(k => k.Name == kontoEntry.Konto);
                kontoPassivFremd.Anfangsbestand = kontoEntry.Anfangsbestand;
                summePassiven += kontoEntry.Anfangsbestand;
            }

            eigenkapitalSumme = summeAktiven - summePassiven;

            if (eigenkapitalSumme < 0)
            {
                ErrorMessageDialog("Das Eigenkapital hat den Wert von 0 unterschritten.");
            }

            Konto eigenkapitalKonto = _konten.Single(k => k.Name == Kontoname.Eigenkapital);
            eigenkapitalKonto.Anfangsbestand = eigenkapitalSumme;

            PassivKontenEigen.Clear();

            foreach (Konto konto in _konten.Where(k => k.Typ == Kontotyp.Eigenkapital))
            {
                PassivKontenEigen.Add(new EBKontoDataGridEntry { Konto = konto.Name, Anfangsbestand = konto.Anfangsbestand });
            }
        }
    }
}
