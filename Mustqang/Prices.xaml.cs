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
    /// Логика взаимодействия для Prices.xaml
    /// </summary>
    public partial class Prices : Window
    {
        public Prices()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var temp = Owner as Bar;
            
            if (Dialy_Text.Text.Length > 0)
            {
                Money.Prices["Daily"] = Int32.Parse(Dialy_Text.Text);
                temp.Dialy_price.Content = Money.Prices["Daily"];
            }
                
            if (Snikers_Text.Text.Length > 0)
            {
                Money.Prices["Snikers"] = Int32.Parse(Snikers_Text.Text);
                temp.Snikers_Price.Content = Money.Prices["Snikers"];
            }
                
            if (Juice_Text.Text.Length > 0)
            {
                Money.Prices["Juice"] = Int32.Parse(Juice_Text.Text);
                temp.Juice_Price.Content = Money.Prices["Juice"];
            }
                
            if (Xplode_Text.Text.Length > 0)
            {
                Money.Prices["Xplode"] = Int32.Parse(Xplode_Text.Text);
                temp.Xplode_price.Content = Money.Prices["Xplode"];
            }
                
            if (Water_Text.Text.Length > 0)
            {
                Money.Prices["Water"] = Int32.Parse(Water_Text.Text);
                temp.Water_Price.Content = Money.Prices["Water"];
            }
                
            if (Bcaa_Text.Text.Length > 0)
            {
                Money.Prices["Bcaa"] = Int32.Parse(Bcaa_Text.Text);
                temp.Bcaa_Price.Content = Money.Prices["Bcaa"];

            }
                
            if (Month_Text.Text.Length > 0)
            {
                Money.Prices["Month"] = Int32.Parse(Month_Text.Text);
            }
            

            this.Close();
        }
    }
}
