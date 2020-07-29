using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Please Provide the first person's hourly rate:");
            decimal P1hrRate = Convert.ToDecimal(Console.ReadLine()); 
            
            //Using decimal since dealing with money.

            Console.WriteLine("How many hours a week does that person work?");
            decimal P1hrWorked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What is the second person's hourly rate?");
            decimal P2hrRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How many hours a week does that person work?");
            decimal P2hrWorked = Convert.ToDecimal(Console.ReadLine());

            decimal P1annual = P1hrRate * P1hrWorked * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(P1annual);

            decimal P2annual = P2hrRate * P2hrWorked * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(P2annual);

            Console.WriteLine("Does person 1 make more money than person 2 in a year?");
            bool salaryComp = P1annual > P2annual;
            Console.WriteLine(salaryComp.ToString());
            
            Console.Read();
        }
    }
}
