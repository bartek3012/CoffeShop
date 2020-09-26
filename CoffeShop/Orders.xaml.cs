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
            OrderedCoffeesTextBlock = OrdersTextBlock;
            OrderedCoffeesCostTextBlock = CoffeeCostTextBlock;
        }
        private List<NewCoffe> coffees;
        static public TextBlock OrderedCoffeesTextBlock { get; set; }
        static public TextBlock OrderedCoffeesCostTextBlock { get; set; }
        public int CoffeesNumberOrder { get; set; }
        private void AddCoffeButton_Click(object sender, RoutedEventArgs e)
        {
            if(CoffeesNumberOrder <= 18)
            {
            coffees.Add(new NewCoffe(this));
            NavigationService.Navigate(coffees[coffees.Count - 1]);
            }
            else
            {
                MessageBox.Show("You can not add more coffees in one order");
            }

        }

        public void FillTotalPay()
        {
            int totalPay = 0;
            foreach(NewCoffe coffe in coffees)
            {
                totalPay += coffe.Price;
            }
            AllCostTextBlock.Text = "$" + totalPay;
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if(CoffeesNumberOrder!=0)
            {
                NavigationService.Navigate(new Payment());
            }
            else
            {
                MessageBox.Show("You have to add coffe to your order");
            }
        }
    }
}
