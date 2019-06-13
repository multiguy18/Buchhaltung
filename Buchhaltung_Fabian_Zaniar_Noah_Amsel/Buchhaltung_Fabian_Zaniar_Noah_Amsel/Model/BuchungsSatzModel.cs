using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model
{
    public class BuchungsSatzModel
    {
        public void OpenKontenView()
        {
            View.KontenView view = new View.KontenView();
            view.Show();
        }

    }
}
