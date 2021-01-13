using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mustqang
{
    /// <summary>
    /// Логика взаимодействия для Bar.xaml
    /// </summary>
    public partial class Bar : Window
    {
        public Bar()
        {
            InitializeComponent();
            Dialy_price.Content = Money.Prices["Daily"];
            Snikers_Price.Content = Money.Prices["Snikers"];
            Juice_Price.Content = Money.Prices["Juice"];
            Xplode_price.Content = Money.Prices["Xplode"];
            Water_Price.Content = Money.Prices["Water"];
            Bcaa_Price.Content = Money.Prices["Bcaa"];
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Добавить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"]+=Money.Prices["Daily"];
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Добавить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"] += Money.Prices["Snikers"];
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Добавить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"] += Money.Prices["Juice"];
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Добавить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"] += Money.Prices["Xplode"];
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Добавить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"] += Money.Prices["Water"];
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Добавить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"] += Money.Prices["Bcaa"];
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Хотите забрать все деньги?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"] = 0;
            Total.Content = Money.Prices["Current"];
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var temp = new Prices();
            temp.Owner = this;
            temp.Show();
        }
    }
}
