using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assign222
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("How many hours do want to add to the current time?");
            int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime userTime = timeNow.AddHours(userNum);

            Console.WriteLine(userTime);
            Console.Read();

        }
    }
}
