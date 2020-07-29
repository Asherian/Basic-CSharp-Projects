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
            Console.WriteLine("What's the standard office tempature?");
            int temp = Convert.ToInt32(Console.ReadLine());
            bool tempature = temp == 68;

            while (!tempature)
            {
                switch (temp)
                {
                    case 65:
                        Console.WriteLine("Close but to cold!");
                        Console.WriteLine("What's the standard office tempature?");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 72:
                        Console.WriteLine("Just a bit to warm for someone in a suit.");
                        Console.WriteLine("What's the standard office tempatuire?");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 68:
                        Console.WriteLine("That is what most people use you're right!");
                        tempature = true;
                        break;
                    default:
                        Console.WriteLine("That's not what most offices use, maybe yours.");
                        Console.WriteLine("What's the standard office tempature?");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}
