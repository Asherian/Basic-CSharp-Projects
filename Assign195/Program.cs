using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign195
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

                Console.WriteLine("What is the day of the week?");
                string userDay = Console.ReadLine();

                Dayz uDay = (Dayz)Enum.Parse(typeof(Dayz), userDay);

                Console.WriteLine("Thank you, I didn't know it was {0}", userDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();

        }
    }
}
