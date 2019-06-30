﻿using Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model;
using EileMitWeile.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.ViewModel
{
    public class BuchungsSatzViewModel : ViewModelBase
    {
        private List<Buchungssatz> _buchungssaetzeKalkulation;
        private List<Konto> _konten;
        Model.BuchungsSatzModel model;

        public BuchungsSatzViewModel()
        {
            this.model = new Model.BuchungsSatzModel();
            BuchungsSaetze = new ObservableCollection<BuchungssatzDataGridEntry>();

            BuchungsSaetze.CollectionChanged += BuchungsSaetze_CollectionChanged;
            BuchungssatzDataGridEntry.OnRowChanged += BuchungssatzDataGridEntry_OnRowChanged;

            _buchungssaetzeKalkulation = new List<Buchungssatz>();
            _konten = new List<Konto>();

            _konten.Add(new Konto(Kontoname.Kasse, Kontotyp.Umlaufvermoegen, 1000));
            _konten.Add(new Konto(Kontoname.Post, Kontotyp.Umlaufvermoegen, 1020));
            _konten.Add(new Konto(Kontoname.Bank, Kontotyp.Umlaufvermoegen, 1021));
            _konten.Add(new Konto(Kontoname.FLL, Kontotyp.Umlaufvermoegen, 1100));
            _konten.Add(new Konto(Kontoname.Warenbestand, Kontotyp.Anlagevermoegen, 1200));
            _konten.Add(new Konto(Kontoname.Mobilien, Kontotyp.Umlaufvermoegen, 1510));
            _konten.Add(new Konto(Kontoname.Immobilien, Kontotyp.Umlaufvermoegen, 1600));
            _konten.Add(new Konto(Kontoname.VLL, Kontotyp.Fremdkapital, 2000));
            _konten.Add(new Konto(Kontoname.Darlehensschuld, Kontotyp.Fremdkapital, 2400));
            _konten.Add(new Konto(Kontoname.Hypotheken, Kontotyp.Fremdkapital, 2401));
        }

        

        private ObservableCollection<BuchungssatzDataGridEntry> _buchungsSaetze;
        public ObservableCollection<BuchungssatzDataGridEntry> BuchungsSaetze
        {
            get { return this._buchungsSaetze; }
            set { SetProperty(ref _buchungsSaetze, value); }
        }

        public Command OpenKontenPlanCmd
        {
            get
            {
                return new Command(() =>
                {
                    OpenKtPlan();
                });
            }
        }

        public Command OpenBilanzERCmd
        {
            get
            {
                return new Command(() =>
                {
                    OpenBilanzER();
                });
            }
        }

        private void DataGridChanged()
        {
            foreach (BuchungssatzDataGridEntry buchungssatzEntry in BuchungsSaetze)
            {
                bool hit;

                Konto kontoSoll = _konten.Single(k => k.Name == buchungssatzEntry.Soll);
                Konto kontoHaben = _konten.Single(k => k.Name == buchungssatzEntry.Haben);

                float betragSoll = buchungssatzEntry.Betrag;
                float betragHaben = -buchungssatzEntry.Betrag;

                if (kontoSoll.Typ == Kontotyp.Fremdkapital || kontoSoll.Typ == Kontotyp.Eigenkapital)
                {
                    betragSoll = -betragSoll;
                }

                if (kontoHaben.Typ == Kontotyp.Fremdkapital || kontoHaben.Typ == Kontotyp.Eigenkapital)
                {
                    betragHaben = -betragHaben;
                }

                if (kontoSoll.DoUebertrag(betragSoll) && kontoHaben.DoUebertrag(betragHaben))
                {
                    hit = false;
                }


                hit = false;
            }
        }

        private void BuchungsSaetze_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DataGridChanged();
        }

        private void BuchungssatzDataGridEntry_OnRowChanged(object sender, EventArgs e)
        {
            DataGridChanged();
        }

        private void OpenKtPlan()
        {
            this.model.OpenKontenView();
        }

        private void OpenBilanzER()
        {
            this.model.OpenERBilanzView();
        }
    }
}
