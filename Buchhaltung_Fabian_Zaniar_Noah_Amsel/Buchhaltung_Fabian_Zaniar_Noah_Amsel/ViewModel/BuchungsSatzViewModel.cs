using Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model;
using EileMitWeile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.ViewModel
{
    public class BuchungsSatzViewModel : ViewModelBase
    {
        Model.BuchungsSatzModel model;

        public BuchungsSatzViewModel()
        {
            this.model = new Model.BuchungsSatzModel();
            BuchungsSaetze = new List<BuchungssatzDataGridEntry>();
        }

        private List<BuchungssatzDataGridEntry> _buchungsSaetze;
        public List<BuchungssatzDataGridEntry> BuchungsSaetze
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
