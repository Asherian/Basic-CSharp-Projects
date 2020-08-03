using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign182
{
    interface IQuittable
    {
        void Quit(Employee employee)
        {
            Console.WriteLine("I quit.");
        }
    }
}
