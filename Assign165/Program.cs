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
            opt.num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please pick a 2nd number if you'd like, else it will default to another number.");
            int numUser = Convert.ToInt32(Console.ReadLine());
            if (input.Length==0) 
            {
                opt.result = opt.Mathy(opt.num1, opt.num2 = 7);
                Console.WriteLine("The result with the current default 7 is: " + opt.result);
            }
            else
            {
                opt.result = opt.Mathy(opt.num1, opt.num2 = numUser);
                Console.WriteLine("The result with your number " + numUser + " is: " + opt.result);
            }
            Console.Read();
        }
    }
}
