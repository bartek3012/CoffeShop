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
        private string coffeAddition;
        public string FullDescription { get; set; }
        public int Price { get;private set; }
        private SolidColorBrush ownBrown;
        private int quantity;
        private bool isType;
        private bool isSize;
        private Orders currentOrders;
        public NewCoffe(Orders orders)
        {
            InitializeComponent();
            currentOrders = orders;
            ownBrown = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF422207"));
            quantity = 1;
            Price = 0;
            isType = false;
            isSize = false;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if(isSize && isType)
            {
                if (Americano.Background == Brushes.Black)
                {
                    coffeDescription = "Americano/";
                    Price += 10;
                }
                else if(Cappuccino.Background == Brushes.Black)
                {
                    coffeDescription = "Cappuccino/";
                    Price += 11;
                }
                else if (Latte.Background == Brushes.Black)
                {
                    coffeDescription = "Latte/";
                    Price += 10;
                }
                else
                {
                    coffeDescription = "Espresso/";
                    Price += 8;
                }

                if(Small.Background == Brushes.Black)
                {
                    coffeDescription += "Small";
                }
                else if(Mid.Background == Brushes.Black)
                {
                    coffeDescription += "Mid";
                    Price += 2;
                }
                else
                {
                    coffeDescription += "Big";
                    Price += 4;
                }
                if (Syrup.Background == Brushes.Black) coffeDescription += "/Syrup";
                if (Chocolate.Background == Brushes.Black) coffeDescription += "/Choc";
                if (WhippedCream.Background == Brushes.Black) coffeDescription += "/Cream";
                if (Milk.Background == Brushes.Black) coffeDescription += "/Milk";

                currentOrders.CoffeesNumberOrder++;
                Price *= quantity;
                Orders.OrderedCoffeesTextBlock.Text +=$"{coffeDescription} x{quantity} \r\n";
                Orders.OrderedCoffeesCostTextBlock.Text += $"${Price}\r\n";
                currentOrders.FillTotalPay();
                NavigationService.Navigate(currentOrders);
            }
            
        }

        private void TypeButton_Click(object sender, RoutedEventArgs e)
        {
            Americano.Background = ownBrown;
            Cappuccino.Background = ownBrown;
            Latte.Background = ownBrown;
            Espresso.Background = ownBrown;
            (sender as Button).Background = Brushes.Black;
            isType = true;
        }

        private void SizeButton_Click(object sender, RoutedEventArgs e)
        {
            Small.Background = ownBrown;
            Mid.Background = ownBrown;
            Big.Background = ownBrown;
            (sender as Button).Background = Brushes.Black;
            isSize = true;
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
