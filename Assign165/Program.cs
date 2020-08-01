using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign165
{
    class Program
    {
        static void Main(string[] args)
        {
            Options opt = new Options();

            Console.WriteLine("Please pick a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please pick a 2nd number if you'd like, else it will default to another number.");
            string numUser = Console.ReadLine();

            if (numUser == "")
            {
                int result = opt.Mathy(num1);
                Console.WriteLine(num1 + " + 5 = " + result);
            }

            else 
            {
                int num2 = Convert.ToInt32(numUser);
                int result = opt.Mathy(num1, num2);
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
            }
               
            Console.Read();
        }
    }
}
