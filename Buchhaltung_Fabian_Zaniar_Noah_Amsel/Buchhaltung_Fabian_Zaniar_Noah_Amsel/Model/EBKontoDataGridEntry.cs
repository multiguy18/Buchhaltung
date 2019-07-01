using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model
{
    public class EBKontoDataGridEntry : IEditableObject
    {
        public static event EventHandler OnRowChanged;

        public Kontoname Konto { get; set; }
        public float Anfangsbestand { get; set; }

        public void BeginEdit()
        {

        }

        public void CancelEdit()
        {

        }

        public void EndEdit()
        {
            OnRowChanged?.Invoke(this, new EventArgs());
        }
    }
}
