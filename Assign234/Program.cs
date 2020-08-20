using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign234
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, what is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Please enter a valid age.");
                   
                }
                else
                {
                    DateTime currentTime = DateTime.Now;

                    Console.WriteLine("You were born in {0}", currentTime.Year - age);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter in how old you are in digits.");
            }

            Console.Read();
        }
    }
}
