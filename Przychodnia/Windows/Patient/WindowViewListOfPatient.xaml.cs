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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Przychodnia.Windows.Patient
{
    /// <summary>
    /// Logika interakcji dla klasy WindowViewListOfPatient.xaml
    /// </summary>
    public partial class WindowViewListOfPatient : Page
    {
        public WindowViewListOfPatient()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowPatientAddEdition windowPatientAddEdition = new WindowPatientAddEdition();
            windowPatientAddEdition.ShowDialog();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowPatientEdition windowPatientEdition = new WindowPatientEdition();
            windowPatientEdition.ShowDialog();
        }

        private void ButtonViewDetails_Click(object sender, RoutedEventArgs e)
        {
            
            WindowPatientEdition windowPatientEdition = new WindowPatientEdition();
            windowPatientEdition.ShowDialog();
           
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
