using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mustqang
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string Till { get; set; }
        public static List<User> General;
        public override string ToString()
        {
            return "";
        }
        public bool EqualsTo( User a)
        {
            if (this.Name == a.Name && this.From == a.From && this.Till == a.Till)
                return true;
            return false;
        }
        public static void Run()
        {
            
            using (var stt = new FileStream($"{ Directory.GetCurrentDirectory() }\\Mustang.txt", FileMode.OpenOrCreate))
                try
                {

                    if (stt.Length > 0)
                    {
                        object obj = new BinaryFormatter().Deserialize(stt);
                        User.General = (List<User>)obj;
                    }
                    else
                    {
                        
                        var temp  = new List<User>();
                        for(int i = 0; i < 1000; i++)
                        {
                            var c = new User();
                            c.Name = "DEDORUKAEV";
                            c.From = DateTime.Now.ToString("D");
                            c.Till = DateTime.Now.AddDays(800).ToString("D");
                            temp.Add(c);
                        }
                        User.General = temp;
                    }
                    stt.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            
        }
        public static void Stop(List<User> General)
        {

            var stt = new FileStream($"{Directory.GetCurrentDirectory()}\\Mustang.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                new BinaryFormatter().Serialize(stt, General);
                MessageBox.Show("Результат сохранен");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                stt.Close();
            }


        }
         public static void Remainder()
        {
            foreach(var cc in User.General)
            {
                DateTime temp = DateTime.Parse(cc.Till);
                int c = (int)(DateTime.Now - temp).TotalDays;
                if (temp.AddDays(3) > DateTime.Now)
                    MessageBox.Show($"у {cc.Name} искает период посещений через  {c} дней");
            }
        }
    }
}
