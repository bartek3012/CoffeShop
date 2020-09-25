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
    /// Logika interakcji dla klasy NewCoffe.xaml
    /// </summary>
    public partial class NewCoffe : Page
    {
        private string coffeDescription;
        public string FullDescription { get; set; }
        public int Price { get;private set; }
        private SolidColorBrush ownBrown;
        private int quantity;
        public NewCoffe()
        {
            InitializeComponent();
            ownBrown = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF422207"));
            quantity = 1;
            Price = 0;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Payment());
        }

        private void TypeButton_Click(object sender, RoutedEventArgs e)
        {
            Americano.Background = ownBrown;
            Cappuccino.Background = ownBrown;
            Latte.Background = ownBrown;
            Espresso.Background = ownBrown;
            (sender as Button).Background = Brushes.Black;
        }

        private void SizeButton_Click(object sender, RoutedEventArgs e)
        {
            Small.Background = ownBrown;
            Mid.Background = ownBrown;
            Big.Background = ownBrown;
            (sender as Button).Background = Brushes.Black;
        }

        private void AdditionButton_Click(object sender, RoutedEventArgs e)
        {
            if((sender as Button).Background == Brushes.Black)
            {
                (sender as Button).Background = ownBrown;
                Price -= 2;
            }
            else
            {
                (sender as Button).Background = Brushes.Black;
                Price += 2;
            }
        }

        private void QuantityButton_Click(object sender, RoutedEventArgs e)
        {
            if((sender as Button).Content.ToString() == "+" && quantity<100)
            {
                QuantityTextBlock.Text = (++quantity).ToString();
            }
            else
            {
                if(quantity>1)
                {
                    QuantityTextBlock.Text = (--quantity).ToString();
                }
            }
        }

    }
}
