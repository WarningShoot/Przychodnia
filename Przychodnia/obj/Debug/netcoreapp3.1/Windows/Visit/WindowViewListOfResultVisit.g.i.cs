﻿#pragma checksum "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "228618E219885C490886688279E6A9E9D2013E19"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Przychodnia.Windows.Visit;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Przychodnia.Windows.Visit {
    
    
    /// <summary>
    /// WindowViewListOfResultVisit
    /// </summary>
    public partial class WindowViewListOfResultVisit : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridListOfResultVisit;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEdit;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonViewDetails;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemove;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/windows/visit/windowviewlistofresultvisit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
            ((Przychodnia.Windows.Visit.WindowViewListOfResultVisit)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridListOfResultVisit = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
            this.ButtonEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonEdit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonViewDetails = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
            this.ButtonViewDetails.Click += new System.Windows.RoutedEventHandler(this.ButtonViewDetails_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonRemove = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\..\Windows\Visit\WindowViewListOfResultVisit.xaml"
            this.ButtonRemove.Click += new System.Windows.RoutedEventHandler(this.ButtonRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
