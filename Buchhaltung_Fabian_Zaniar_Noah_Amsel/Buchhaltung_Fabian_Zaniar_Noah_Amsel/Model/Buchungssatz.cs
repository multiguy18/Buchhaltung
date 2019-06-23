using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model
{
    public class Buchungssatz
    {
        public int Nummer; //Brauchts das?
        public Konto Soll;
        public Konto Haben;
        public float Betrag;
        public DateTime Zeitpunkt;

        public bool Kalkuliere()
        {
            //TODO: Logik für Passiv- bzw. Aufwandskonto
            if (Soll.DoUebertrag(Betrag) && Haben.DoUebertrag(Betrag))
            {
                return false;
            }

            return true;
        }
    }
}
