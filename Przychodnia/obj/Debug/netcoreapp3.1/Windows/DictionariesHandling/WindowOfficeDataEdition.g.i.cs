﻿#pragma checksum "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C0698296D677D85BF408AE299989E640D27D732C"
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
using Przychodnia.Windows.DictionariesHandling;
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


namespace Przychodnia.Windows.DictionariesHandling {
    
    
    /// <summary>
    /// WindowOfficeDataEdition
    /// </summary>
    public partial class WindowOfficeDataEdition : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxOffice;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxOfficeDescription;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSubmit;
        
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/windows/dictionarieshandling/windowofficedataedition.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml"
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
            
            #line 9 "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml"
            ((Przychodnia.Windows.DictionariesHandling.WindowOfficeDataEdition)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxOffice = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml"
            this.TextBoxOffice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxOfficeDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ButtonSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\..\Windows\DictionariesHandling\WindowOfficeDataEdition.xaml"
            this.ButtonSubmit.Click += new System.Windows.RoutedEventHandler(this.ButtonSubmit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
