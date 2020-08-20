using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign230
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Fish = "Twenty Three";

            var Ghoti = 23;

            Console.WriteLine("{0}, or {1} are the same technically, but drastically different in functionality.",Fish, Ghoti);

            Doggo thomas = new Doggo("Thomas");
            Console.WriteLine(thomas.Weight);

            Console.Read();
        }
    }
}
