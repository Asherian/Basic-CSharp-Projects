using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the month is it?");
            int date = Convert.ToInt32(Console.ReadLine());
            bool newMonth = date == 1;

            do
            {
                switch (date)
                {
                    case 15:
                        Console.WriteLine("It's halfway through the month, I hope its going well!");
                        Console.WriteLine("What day of the month is it?");
                        date = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 31:
                        Console.WriteLine("You're right at the end of the month!");
                        Console.WriteLine("What day of the month is it?");
                        date = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("Welcome to a new month!");
                        newMonth = true;
                        break;
                    default:
                        Console.WriteLine("It's not the start of the month.");
                        Console.WriteLine("What day " +
                            "of the month is it?");
                        date = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!newMonth);
            Console.Read();
        }
    }
}
