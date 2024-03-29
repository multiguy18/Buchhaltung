﻿using Buchhaltung_Fabian_Zaniar_Noah_Amsel.Model;
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
    /// Interaktionslogik für ERBilanzView.xaml
    /// </summary>
    public partial class ERBilanzView : Window
    {
        public ERBilanzView(List<Konto> konten)
        {
            InitializeComponent();

            this.DataContext = new ViewModel.ERBilanzViewModel(konten);
        }
        private void btReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
