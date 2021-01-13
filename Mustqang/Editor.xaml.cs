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
    /// Логика взаимодействия для Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public Editor()
        {
            InitializeComponent();
            for(int i= -3; i < 12; i++)
            {
                months.Items.Add(i);
            }
        }

        private void editorAdd_Click(object sender, RoutedEventArgs e)
        {
            
            if (months.SelectedItem == null)
                MessageBox.Show("выберите количество месяцев");
            else
            {
                MainWindow mnn = Owner as MainWindow;

                var date = DateTime.Parse(mnn.transWindowUser.Till);

                date = date.AddMonths(Int32.Parse(months.SelectedItem.ToString()));
                int cash = Int32.Parse(months.SelectedItem.ToString()) * Money.Prices["Month"];
                Money.Prices["Current"] += cash;
                MessageBox.Show($"разрешены посещения до {date.ToString("D")}");
                MessageBox.Show($"В кассу добавлено {cash} сум");
                for(int i=0;i<User.General.Count;i++)
                    if (User.General[i].EqualsTo(mnn.transWindowUser))
                    {
                        User.General.RemoveAt(i);
                        break;
                    }
                mnn.transWindowUser.Till = date.ToString("D");
                User.General.Add(mnn.transWindowUser);
                mnn.mainlist.Items.Clear();
                foreach (var cc in User.General)
                    mnn.mainlist.Items.Add(cc);
                this.Close();
            
            }
        }

        private void editorCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
