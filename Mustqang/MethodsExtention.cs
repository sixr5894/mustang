using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mustqang
{
    public static class MethodsExtention
    {
        public static void Refresh( List<User> user,  ListView lst)
        {
            if (user!=null)
            {
                lst.Items.Clear();
                foreach (var temp in user)
                {
                    lst.Items.Add(user);
                }
            }
            
        }
    }
}
