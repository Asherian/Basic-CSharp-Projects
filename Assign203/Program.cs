using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign203
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmpList = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Snow", ID = 2 },
                new Employee { FirstName = "Joe", LastName = "Ghoti", ID = 43 },
                new Employee { FirstName = "Shallan", LastName = "Davar", ID = 1 },
                new Employee { FirstName = "Krist", LastName = "Asherian", ID = 23 },
                new Employee { FirstName = "Adolin", LastName = "Kholin", ID = 4 },
                new Employee { FirstName = "Robert", LastName = "Evans", ID = 121 },
                new Employee { FirstName = "Jesse", LastName = "James", ID = 5 },
                new Employee { FirstName = "Miles", LastName = "Vorkosigan", ID = 29 },
                new Employee { FirstName = "Cordelia", LastName = "Naismith", ID = 54 },
                new Employee { FirstName = "Jose", LastName = "DeNada", ID = 7 },
            };
            

            foreach (Employee person in EmpList)
            {
                if (person.FirstName == "Joe")
                {
                    Console.WriteLine(person.FirstName+ " "+person.LastName + " ID: "+person.ID);
                }
            }



            List<int>IDGet = EmpList.Where(Employee.ID => 5);


            Console.Read();
        }
    }
}
