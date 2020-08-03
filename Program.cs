using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign174
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee n = new Employee();
            n.FirstName = "Sample";
            n.LastName = "Student";

            n.SayName();

            Console.Read();

        }
    }
}
