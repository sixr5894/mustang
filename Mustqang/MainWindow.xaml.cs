using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mustqang
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {


        public int EditorVar { get; set; }
        public User transWindowUser;
        public static void Start()
        {
            string messageBoxText = "сальник махкамми?";

            string caption = "proverka";

            MessageBoxButton button = MessageBoxButton.YesNo;

            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBoxResult rslt = MessageBox.Show(messageBoxText, caption, button, icon);
            if (rslt == MessageBoxResult.No)

                Start();
        }

        public MainWindow()
        {
            User.Run();
            Start();
            InitializeComponent();
            Money.Go();
            Closing += MainWindow_Closing;
            foreach (var cc in User.General)
                mainlist.Items.Add(cc);
            
            
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            User.Stop(User.General);
            Money.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var temp = new Adding();

            temp.Owner = this;

            temp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (mainlist.SelectedItem == null)

                MessageBox.Show("выберите клиента, для обновления");

            else
            {
                dynamic temp = mainlist.SelectedItem;

                transWindowUser = new User();

                transWindowUser.Name = temp.Name;

                transWindowUser.From = temp.From;

                transWindowUser.Till = temp.Till;

                var rec = new Editor();

                rec.Owner = this;

                rec.Show();
                
                //MessageBox.Show($"{weed.Name}{weed.From}{weed.Till}");

            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (mainlist.SelectedItem == null)

                MessageBox.Show("выберите клиентка, для удаления");

            else
            {
                var resullt = MessageBox.Show("Удалить выбранного клиента?", "подтвердите действие", MessageBoxButton.YesNo);

                if(resullt == MessageBoxResult.Yes)
                {
                    dynamic temp = mainlist.SelectedItem;

                    var cc = new User();

                    cc.Name = temp.Name;

                    cc.From = temp.From;

                    cc.Till = temp.Till;

                    for(int i = 0; i < User.General.Count; i++)
                    {
                        if (User.General[i].EqualsTo(cc))
                        {
                            User.General.RemoveAt(i);

                            break;
                        }
                    }
                    mainlist.Items.Clear();

                    foreach (var k in User.General)

                        mainlist.Items.Add(k);
                }
                
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var temp = new Bar();
            temp.Owner = this;
            temp.Show();
        }
    }
}
