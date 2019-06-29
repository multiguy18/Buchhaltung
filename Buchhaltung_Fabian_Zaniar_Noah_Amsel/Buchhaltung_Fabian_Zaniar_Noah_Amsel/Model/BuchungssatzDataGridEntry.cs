using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model
{
    public class BuchungssatzDataGridEntry
    {
        public Kontoname Soll { get; set; }
        public Kontoname Haben { get; set; }
        public float Betrag { get; set; }
        public string Datum { get; set; }
    }
}
