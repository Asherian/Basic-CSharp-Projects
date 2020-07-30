using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign152
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            numList.Add(12);
            numList.Add(23);
            numList.Add(17);
            numList.Add(5);
            numList.Add(42);
            try
            {
                Console.WriteLine("Please give a number to divide each number in our list.");
                int numUser = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numList)
                {
                    int numResult = num / numUser;
                    Console.WriteLine(num + " divided by " + numUser + " will equal " + numResult);
                }
                
            }
            catch (FormatException numNot)
            {
                Console.WriteLine("Please enter a whole number using numerals.");
                return;
            }
            catch (DivideByZeroException numNot)
            {
                Console.WriteLine("Please do not attempt to divide by zero");
            }
            catch (Exception numNot)
            {
                Console.WriteLine(numNot.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
