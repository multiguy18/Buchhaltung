using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model
{
    public class Konto
    {
        public readonly Kontoname Name;
        public readonly Kontotyp Typ;
        public readonly int RahmenNr;
        private float _anfangsbestand;
        private List<float> _aeanderungenPositiv;
        private List<float> _aeanderungenNegativ;

        public Konto(Kontoname name, Kontotyp typ, int rahmenNr)
        {
            Name = name;
            Typ = typ;
            RahmenNr = rahmenNr;
            _anfangsbestand = 0;
            _aeanderungenPositiv = new List<float>();
            _aeanderungenNegativ = new List<float>();
        }

        public float Schlussbestand { get; private set; }

        public float Anfangsbestand
        {
            get { return _anfangsbestand; }
            set
            {
                _anfangsbestand = value;
                ResetUebertraege();
            }
        }

        public List<float> AenderungenPositiv
        {
            get { return new List<float>(_aeanderungenPositiv); }
        }

        public List<float> AenderungenNegativ
        {
            get { return new List<float>(_aeanderungenNegativ); }
        }

        public bool DoUebertrag(float betrag)
        {
            if (betrag > 0)
            {
                _aeanderungenPositiv.Add(betrag);
            }
            else if (betrag < 0)
            {
                _aeanderungenNegativ.Add(betrag);
            }

            Schlussbestand += betrag;

            if (Schlussbestand < 0)
            {
                return false;
            }

            return true;
        }

        public void ResetUebertraege()
        {
            _aeanderungenPositiv.Clear();
            _aeanderungenNegativ.Clear();
            Schlussbestand = _anfangsbestand;
        }
    }
}
