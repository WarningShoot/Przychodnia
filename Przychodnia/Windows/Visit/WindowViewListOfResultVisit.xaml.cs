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

namespace Przychodnia.Windows.Visit
{
    /// <summary>
    /// Logika interakcji dla klasy WindowViewListOfResultVisit.xaml
    /// </summary>
    public partial class WindowViewListOfResultVisit : Page
    {
        public WindowViewListOfResultVisit()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            //Formatka powina nazwyać się  WindowResultVisitAddEdition ale zmieniuałem nazwę więc jest WindowResultVisitAdd 
            WindowResultVisitAdd windowResultVisitAdd = new WindowResultVisitAdd();
            windowResultVisitAdd.ShowDialog();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            //Formatka powina nazwyać się  WindowResultVisitAddEdition ale zmieniuałem nazwę więc jest WindowResultVisitAdd 
            WindowResultVisitAdd windowResultVisitAdd = new WindowResultVisitAdd();
            windowResultVisitAdd.ShowDialog();
        }

        private void ButtonViewDetails_Click(object sender, RoutedEventArgs e)
        {
            //Zmienić żeby wybrać konkretnego pacjęta i zmienić na read only
            WindowResultVisitAdd windowResultVisitAdd = new WindowResultVisitAdd();
            windowResultVisitAdd.ShowDialog();
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
