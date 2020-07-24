using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignpg88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That number multipled by 50 is " + num1*50);

            Console.WriteLine("Lets try a new number, what number would you like to use?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int numAdd = num2 + 25;
            Console.WriteLine("Great number! If we add 25 to it, then it will be "+ numAdd);

            Console.WriteLine("Give me a number you'd like to divide by 12.5");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + " is a great number! Divided by 12.5 it equals " + num3 / 12.5);

            Console.WriteLine("Now, we're going to check if the number you give is greater than 50.");
            int num4 = Convert.ToInt32(Console.ReadLine());
            if (num4 > 50)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
                    }

            Console.Read();
        }
    }
}
