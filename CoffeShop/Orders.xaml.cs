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

namespace CoffeShop
{
    /// <summary>
    /// Logika interakcji dla klasy Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        public Orders()
        {
            InitializeComponent();
            coffees = new List<NewCoffe>();
        }
        private List<NewCoffe> coffees;
        private void AddCoffeButton_Click(object sender, RoutedEventArgs e)
        {
            coffees.Add(new NewCoffe());
            NavigationService.Navigate(coffees[coffees.Count - 1]);
        }
    }
}
