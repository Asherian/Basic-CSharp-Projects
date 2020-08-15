using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number: ");
            int uNum = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\TechAcademy\Basic-CSharp-Projects\Assign219\log.txt", true))
            {
                file.WriteLine("They chose : " + uNum);
            }
            string[] numList = File.ReadAllLines(@"C:\TechAcademy\Basic-CSharp-Projects\Assign219\log.txt");
            foreach (string line in numList)
            {
                Console.WriteLine(line + "\n");
            }

            Console.Read();
        }
    }
}
