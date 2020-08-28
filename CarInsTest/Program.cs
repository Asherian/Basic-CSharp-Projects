using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Krist";
            string Lastname = "Asherian";
            DateTime DoB =  new DateTime(1985, 04, 10);
            int Age = CalculateAge(DoB);
            int CarYear = 2019;
            string CarModel = "Porsche";
            string CarMake = "911 Carrera";
            bool DUI = false;
            int Tickets = 3;
            bool Coverage = true;
            decimal QuoteBase = 50.00M;

            int CalculateAge(DateTime DateOfBirth)
            {
                int age = 0;
                age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                {
                    age = age - 1;
                }
                return age;
            }

            if (Age >=25)
            {
                
                QuoteBase = QuoteBase + 25.00M;
                Console.WriteLine("User over 25, adding 25 to quote");
            }
            else if (Age >18)
            {
                QuoteBase = QuoteBase + 50.00M;
                Console.WriteLine("User over 18, less than 25, adding 50 to quote");
            }
            else if (Age < 18)
            {
                QuoteBase = QuoteBase + 100M;
                Console.WriteLine("User under 18, adding 100 to quote");
            }
            if (CarYear > 2015)
            {
                QuoteBase = QuoteBase + 25M;

                Console.WriteLine("Car is newer than 2015, adding 25 to quote");
            }
            else if (CarYear < 2000)
            {
                QuoteBase = QuoteBase + 25M;

                Console.WriteLine("Car is older than 2000, adding 25 to quote");
            }
            if (Tickets >0)
            {
                QuoteBase = QuoteBase + (Tickets * 10);
                Console.WriteLine("User has {0} tikcets, that adds {1} to quote.", Tickets, (Tickets * 10));
            }
            if (CarModel == "Porsche")
            {
                QuoteBase = QuoteBase + 25M;
                Console.WriteLine("Car is a Porsche add 25 to quote");
                if (CarMake == "911 Carrera")
                {
                    QuoteBase = QuoteBase + 25M;
                    Console.WriteLine("Car is a 911 Carrera(Nice) add another 25 to quote.");
                }
            }
            if (DUI)
            {
                QuoteBase = QuoteBase * 1.25M;
                Console.WriteLine("You've had a DUI that adds 25% to the policy bringing it to {0}.", QuoteBase);
            }   
            if (Coverage)
            {
                QuoteBase = QuoteBase * 1.5M;
                Console.WriteLine("You need full coverage insurance, so you're quote will increase by 50% to {0}.", QuoteBase);
            }
            
            Console.WriteLine(QuoteBase);

            Console.Read();
        }
    }
}
