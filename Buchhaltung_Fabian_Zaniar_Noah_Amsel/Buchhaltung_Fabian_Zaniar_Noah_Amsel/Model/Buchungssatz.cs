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
            float betragSoll = Betrag;
            float betragHaben = -Betrag;

            if (Soll.Typ == Kontotyp.Fremdkapital || Soll.Typ == Kontotyp.Eigenkapital)
            {
                betragSoll = -betragSoll;
            }

            if (Haben.Typ == Kontotyp.Fremdkapital || Haben.Typ == Kontotyp.Eigenkapital)
            {
                betragHaben = -betragHaben;
            }

            if (Soll.DoUebertrag(betragSoll) && Haben.DoUebertrag(betragHaben))
            {
                return false;
            }

            return true;
        }
    }
}
