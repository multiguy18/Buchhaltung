using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model
{
    public class Konto
    {
        public readonly bool PassivAufwand;
        public readonly string Bezeichnung;
        private float _anfangsbestand;
        private List<float> _aeanderungen;

        public Konto(string bezeichnung, bool passivAufwand)
        {
            Bezeichnung = bezeichnung;
            PassivAufwand = passivAufwand;
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


        public List<float> Aenderungen
        {
            get { return new List<float>(_aeanderungen); }
        }

        public bool DoUebertrag(float betrag)
        {
            _aeanderungen.Add(betrag);

            Schlussbestand += betrag;

            if (Schlussbestand < 0)
            {
                return false;
            }

            return true;
        }

        public void ResetUebertraege()
        {
            _aeanderungen.Clear();
            Schlussbestand = _anfangsbestand;
        }
    }
}
