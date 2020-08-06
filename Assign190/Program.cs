using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign190
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> EmpList = new List<int>();
            Employee n = new Employee();
            n.FirstName = "Sample";
            n.LastName = "Student";
            n.ID = 12;

            Employee m = new Employee();
            m.FirstName = "Jesse";
            m.LastName = "James";
            m.ID = 23;

            Employee o = new Employee();
            o.FirstName = "Serious";
            o.LastName = "Business";
            o.ID = 12;

            n.SayName();
            m.SayName();
            o.SayName();

            if (n.ID == m.ID)
            {
                Console.WriteLine(n.FirstName + " has the same Employee ID as " + m.FirstName);
            }
            else
            {
                Console.WriteLine(n.FirstName + " has a different employee ID then " + m.FirstName);
            }

            if (n.ID == o.ID)
            {
                Console.WriteLine(n.FirstName + " has the same Employee ID as " + o.FirstName);
            }
            else
            {
                Console.WriteLine(n.FirstName + " has a different employee ID then " + o.FirstName);
            }



            Console.Read();
        }
    }
}
