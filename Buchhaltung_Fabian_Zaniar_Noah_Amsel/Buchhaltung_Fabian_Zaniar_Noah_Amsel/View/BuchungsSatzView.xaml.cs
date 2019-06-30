using Buchhaltung_Fabian_Zaniar_Noah_Amsel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.View
{
    public partial class BuchungsSatzView : Window
    {
        public BuchungsSatzView()
        {
            InitializeComponent();

            this.DataContext = new ViewModel.BuchungsSatzViewModel();
            (DataContext as BuchungsSatzViewModel).ErrorMessageDialog += BuchungsSatzView_ErrorMessage;
        }

        private void BuchungsSatzView_ErrorMessage(string message)
        {
            MessageBox.Show(message, "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
