using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assign_169
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please choose a number to divide:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Mathy.DivId(num1);

            decimal y = 23;
            Console.WriteLine("Before the method the value is : {0}", y);

            decimal x = 0;
            Mathy.DivId(out x, y);
            Console.WriteLine("After method, the value is now : {0}", x);
            
            Console.Read();
        }
    }
}
