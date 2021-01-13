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
using Mustqang;

namespace Mustqang
{
    /// <summary>
    /// Логика взаимодействия для Adding.xaml
    /// </summary>
    public partial class Adding : Window
    {
        public Adding()
        {
            InitializeComponent();

            for(int i = 1; i<13;i++)

                periodlist.Items.Add(i.ToString());
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var temp = new User();

            string Nameholder = addingname.Text;

            temp.Name = Nameholder;

            temp.From = DateTime.Today.ToString("D");
            
            if(periodlist.SelectedItem!=null)
            {

                temp.Till = DateTime.Today.AddMonths(Int32.Parse(periodlist.SelectedItem.ToString())).ToString("D");
                int cash = Int32.Parse(periodlist.SelectedItem.ToString());
                cash *= Money.Prices["Month"];
                Money.Prices["Current"] += cash;

                User.General.Add(temp);

                MainWindow mnn = Owner as MainWindow;

                mnn.mainlist.Items.Clear();

                foreach (var rec in User.General)

                    mnn.mainlist.Items.Add(rec);
                MessageBox.Show($"В кассу добавлено {cash} тысяч");

                this.Close();
            }
            else
            {

                MessageBox.Show("выберите период оплаты");

            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
