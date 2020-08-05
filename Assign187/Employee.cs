using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign187
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("I quit, I'm done here.");
        }
        public static operator= (Person person, Employee emp)
            {
            person.
        {

        }
            }
    }
}
