using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_169
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy m = new Mathy();

            Console.WriteLine("Please choose a number to divide:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            m.div(num1);
        }
    }
}
