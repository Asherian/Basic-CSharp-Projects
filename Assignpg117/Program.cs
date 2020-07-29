using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight <= 50)
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());

                if ((height + length + width) < 50)
                     {
                    decimal quote = ((height * width * length) * weight) / 100;
                    Console.WriteLine("You're estimated total for shipping this package is: $" + quote + ".00");
                     }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.Read();
        }
    }
}

