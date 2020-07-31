using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign161
{
    class Program
    {
        static void Main(string[] args)
        {

            mathing Mathy = new mathing();
            
            Console.WriteLine("Please chose a number to add 5:");
            Mathy.num1 = Convert.ToInt32(Console.ReadLine());
          
            Mathy.numResult = Mathy.plusplus(Mathy.num1);
            Console.WriteLine("The result is: " + Mathy.numResult);

            Console.WriteLine("Please chose a number to multiply by 10:");
            Mathy.num1 = Convert.ToInt32(Console.ReadLine());


            Mathy.numResult = Mathy.times(Mathy.num1);
            Console.WriteLine("The result is of: " + Mathy.numResult);

            Console.WriteLine("Please chose a number:");
            Mathy.num1 = Convert.ToInt32(Console.ReadLine());


            Mathy.numResult = Mathy.squares(Mathy.num1);
            Console.WriteLine("That number when squared is: " + Mathy.numResult);

            Console.Read();
            
        }
    }
}
