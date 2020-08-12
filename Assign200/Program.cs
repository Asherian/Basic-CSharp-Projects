using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign200
{
    class Program
    {
        static void Main(string[] args)
        {
            Number ghoti = new Number();
            ghoti.Amount = 12.42M;
            Console.WriteLine(ghoti.Amount);
            Console.Read();
        }
    }
}
