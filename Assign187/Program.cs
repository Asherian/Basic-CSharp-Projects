using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign187
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


            Console.Read();
        }
    }
}
