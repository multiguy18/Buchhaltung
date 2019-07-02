using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model
{
    public class BuchungsSatzModel
    {
        public void OpenEroeffnungsBilanzView(List<Konto> konten)
        {
            View.EroeffnungsBilanzView view = new View.EroeffnungsBilanzView(konten);
            view.ShowDialog();
        }

        public void OpenKontenView(List<Konto> konten)
        {
            View.KontenView view = new View.KontenView(konten);
            view.Show();
        }

        public void OpenERBilanzView(List<Konto> konten)
        {
            View.ERBilanzView view = new View.ERBilanzView(konten);
            view.Show();
        }
    }
}
