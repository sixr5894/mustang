using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Mustqang
{
    class Money
    {
        //public static int Cash { get; set; }

        public static void Cear()
        {
            if (MessageBox.Show("Хотите забрать деньги из кассы?", "внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Money.Prices["Current"] = 0;
        }

        public static Dictionary<string, int> Prices;
        //public static int Dialy { get; set; }
        //public static int Snikers { get; set; }
        //public static int Xplode {get ; set;}
        //public static int Bcaa { get; set; }
        //public static int Water { get; set; }
        //public static int Juise { get; set; }
        //public static int Month { get; set; } 
        public static void Go()
        {
            using (var stt = new FileStream($"{ Directory.GetCurrentDirectory() }\\Prices.txt", FileMode.OpenOrCreate))
                try
                {

                    if (stt.Length > 0)
                    {
                        object obj = new BinaryFormatter().Deserialize(stt);
                        Money.Prices = (Dictionary<string , int>)obj;
                    }
                    else
                    {
                        var dick = new Dictionary<string, int> () ;
                        dick.Add("Daily" , 10000);
                        dick.Add("Snikers", 5000);
                        dick.Add("Xplode", 10000);
                        dick.Add("Water", 2000);
                        dick.Add("Bcaa", 10000);
                        dick.Add("Juice", 8000);
                        dick.Add("Month", 100000);
                        dick.Add("Current", 0);
                        Money.Prices = dick;
                    }
                    stt.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
        }
        public static void Stop() 
        {
            var stt = new FileStream($"{Directory.GetCurrentDirectory()}\\Prices.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                new BinaryFormatter().Serialize(stt, Money.Prices);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                stt.Close();
            }
        }

    }
}
