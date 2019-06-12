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
using System.Windows.Shapes;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.View
{
    /// <summary>
    /// Interaction logic for KontenView.xaml
    /// </summary>
    public partial class KontenView : Window
    {
        public KontenView()
        {
            InitializeComponent();

            this.DataContext = new ViewModel.KontenViewModel();
        }
    }
}
