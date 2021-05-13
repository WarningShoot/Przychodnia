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
using Przychodnia.Windows.Visit;

namespace Przychodnia.Windows.Visit
{
    /// <summary>
    /// Logika interakcji dla klasy WindowViewListOfVisit.xaml
    /// </summary>
    public partial class WindowViewListOfVisit : Page
    {
        public WindowViewListOfVisit()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowVisitAddEdition windowVisitAddEdition = new WindowVisitAddEdition();
            windowVisitAddEdition.ShowDialog();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowVisitAddEdition windowVisitAddEdition = new WindowVisitAddEdition();
            windowVisitAddEdition.ShowDialog();
        }

        private void ButtonViewDetails_Click(object sender, RoutedEventArgs e)
        {
            //Zmienić żeby wybrać konkretnego pacjęta i zmienić na read only
            WindowVisitAddEdition windowVisitAddEdition = new WindowVisitAddEdition();
            windowVisitAddEdition.ShowDialog();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonResultOfVisit_Click(object sender, RoutedEventArgs e)
        {
            
           
        }
    }
}
