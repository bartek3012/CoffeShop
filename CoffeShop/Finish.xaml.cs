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
    /// Logika interakcji dla klasy Finish.xaml
    /// </summary>
    public partial class Finish : Page
    {
        public Finish()
        {
            InitializeComponent();
            NumberOrderTextBlock.Text = MainWindow.OrderNumber.ToString();
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Start());
        }
    }
}
