﻿#pragma checksum "..\..\..\View\ERBilanzView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37890BFEAB47532E8E96AD960EA29E707926CE9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Buchhaltung_Fabian_Zaniar_Noah_Amsel.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.View {
    
    
    /// <summary>
    /// ERBilanzView
    /// </summary>
    public partial class ERBilanzView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\View\ERBilanzView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BilanzGrid;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\View\ERBilanzView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSummeAktiv;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\View\ERBilanzView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSummePassiv;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\View\ERBilanzView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ERGrid;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\View\ERBilanzView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSummeAufwand;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\View\ERBilanzView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSummeErtrag;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\View\ERBilanzView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btReturn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Buchhaltung_Fabian_Zaniar_Noah_Amsel;component/view/erbilanzview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ERBilanzView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BilanzGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtSummeAktiv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtSummePassiv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ERGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.txtSummeAufwand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtSummeErtrag = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btReturn = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\View\ERBilanzView.xaml"
            this.btReturn.Click += new System.Windows.RoutedEventHandler(this.btReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

