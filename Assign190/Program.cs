using System;
using System.Collections.Generic;
using System.Globalization;

namespace Assign190
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Employee<string> n = new Employee<string>();
            n.FirstName = "Sample";
            n.LastName = "Student";
            n.ID = 12;
            n.things = new List<string>();
            n.things.Add("Thimble");
            n.things.Add("String");

            Employee<int> m = new Employee<int>();
            m.FirstName = "Jesse";
            m.LastName = "James";
            m.ID = 23;
            m.things = new List<int>();
            m.things.Add(12);
            m.things.Add(23);
            m.things.Add(5);


            Employee<string> o = new Employee<string>();
            o.FirstName = "Serious";
            o.LastName = "Business";
            o.ID = 12;


            n.SayName();
            m.SayName();
            o.SayName();

            foreach (string Thing in n.things)
            {
                Console.WriteLine(Thing);
            }
            
            foreach (int num in m.things)
            {
                Console.WriteLine(num);
            }
            //if (n.ID == m.ID)
            //{
            //    Console.WriteLine(n.FirstName + " has the same Employee ID as " + m.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine(n.FirstName + " has a different employee ID then " + m.FirstName);
            //}

            //if (n.ID == o.ID)
            //{
            //    Console.WriteLine(n.FirstName + " has the same Employee ID as " + o.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine(n.FirstName + " has a different employee ID then " + o.FirstName);
            //}



            Console.Read();
        }
    }
}
