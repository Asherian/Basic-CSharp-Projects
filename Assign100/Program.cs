using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acme Insurance, a few questions to see if you qualify:");
            
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI, True or False");
            string DUI = Console.ReadLine();
            bool DUIBool = Convert.ToBoolean(DUI);
            bool DUIStatus = !DUIBool;

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool result = (age > 15) && tickets < 3 && DUIStatus;
            Console.WriteLine("Qualified?");
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
