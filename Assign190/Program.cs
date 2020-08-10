using System;
using System.Collections.Generic;
using System.Globalization;

namespace Assign190
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> EmpList = new List<string>();
            List<int> EmpID = new List<int>();
            Employee<string> n = new Employee<string>();
            n.FirstName = "Sample";
            n.LastName = "Student";
            n.ID = 12;
            EmpList.Add("Sample Student");
            EmpID.Add(12);

            Employee<string> m = new Employee<string>();
            m.FirstName = "Jesse";
            m.LastName = "James";
            m.ID = 23;
            EmpList.Add("Jesse James");
            EmpID.Add(23);

            Employee<string> o = new Employee<string>();
            o.FirstName = "Serious";
            o.LastName = "Business";
            o.ID = 12;
            EmpList.Add("Serious Business");
            EmpID.Add(12);

            n.SayName();
            m.SayName();
            o.SayName();

            foreach (int i = 0; i >= EmpID.Count; i++)
            {
                Console.WriteLine(EmpID[i]);
            }

            foreach (int j = 0; j >= EmpList.Count; j++)
            {
                Console.WriteLine(EmpList[j]);
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
