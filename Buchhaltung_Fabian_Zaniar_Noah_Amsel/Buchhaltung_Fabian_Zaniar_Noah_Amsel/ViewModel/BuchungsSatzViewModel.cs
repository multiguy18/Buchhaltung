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
        }
    }
}
