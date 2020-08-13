using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                new Employee { FirstName = "Robert", LastName = "Evans", ID = 2 },
                new Employee { FirstName = "Jesse", LastName = "James", ID = 6 },
                new Employee { FirstName = "Miles", LastName = "Vorkosigan", ID = 29 },
                new Employee { FirstName = "Cordelia", LastName = "Naismith", ID = 54 },
                new Employee { FirstName = "Jose", LastName = "DeNada", ID = 7 },
            };

            Console.WriteLine("All Employees named just Joe");
            List<Employee> empJoe = new List<Employee>();

            foreach (Employee person in EmpList)
            {
                if (person.FirstName == "Joe")
                {
                    Console.WriteLine(person.FirstName+ " "+person.LastName + " ID: "+person.ID);
                   
                }
            }

            empJoe = EmpList.FindAll(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("Employees who have IDs greater than 5: ");

            List<Employee> IDg5 = new List<Employee>();
            IDg5 = EmpList.FindAll(x => x.ID > 5).ToList();

            foreach (Employee person in IDg5)
            {
                Console.WriteLine(person.FirstName + " has an ID number of :" + person.ID);
            }
            Console.Read();
        }
    }
}
