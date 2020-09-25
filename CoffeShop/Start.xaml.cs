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
    /// Logika interakcji dla klasy Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();
            OrderNumber = 0;
        }
        public static int OrderNumber { get; private set; }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            OrderNumber++;
            NavigationService.Navigate(new Orders());
        }
    }
}
