using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XmlConfiguration;

namespace Assign_169
{
    static class Mathy
    {
        public static void DivId(int x)
        {
            int result = x / 2;
            Console.WriteLine("The number divided by two is : " + result);
        }
        public static void DivId(out decimal x, decimal y)
        {
            decimal temp = y / 2 ;
            x = temp;
        }
    }
}
