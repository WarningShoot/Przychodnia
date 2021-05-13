using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Przychodnia.Windows.Patient
{
    /// <summary>
    /// Logika interakcji dla klasy WindowPatientEdition.xaml
    /// </summary>
    public partial class WindowPatientEdition : Window
    {
        public bool ReadOnly { get; internal set; }

        public WindowPatientEdition()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
