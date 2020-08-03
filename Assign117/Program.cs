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
            //string appWeight = weight >= 50 ? "The package can be shipped." : "Package too heavy to be shipped via Package Express. Have a good day.";
            Console.WriteLine(weight);

            Console.Read();
            }
        }
    }
}
