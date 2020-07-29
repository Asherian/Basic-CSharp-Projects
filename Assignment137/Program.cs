using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment137
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayColors = new string[] { "green", "black", "red", "blue", "yellow", "white" };
            Console.WriteLine("Please share a color you like: ");
            string userColor = Console.ReadLine();

            for (int i = 0; i < arrayColors.Length; i++)
            {
                Console.WriteLine("Lets mix "+ arrayColors[i] + " and "+userColor);

            }

            Console.WriteLine("The colors I chose were:");
            for (int k = 0; k < arrayColors.Length; k++)
            {
                Console.WriteLine(arrayColors[k]);
            }

            //part 2 pg 138
            int[] arrayNum = new int[] { 12, 17, 23, 5, 42 };
            Console.WriteLine("Now to make some number loops and arrays");

            for (int n = 0; n <= 4; n++)
            {
                Console.WriteLine("The current number is: " + arrayNum[n]);
            }
            //pg 142
            List<string> listNames = new List<string>();
            listNames.Add("Jesse");
            listNames.Add("Krist");
            listNames.Add("Vlad");
            listNames.Add("David");
            listNames.Add("Eric");
            listNames.Add("Zeke");

            Console.WriteLine("I want you to choose a name to search my list of names, some examples are Eric, Jesse or Krist.");
            string name = Console.ReadLine();

            for (int a = 0; a <= 5; a++)
            {
                if (listNames[a] == name)
                {
                    Console.WriteLine("The name " + name + " is one of the ones on my list!");
                }
                else
                {
                    Console.WriteLine(name + "is not a name I listed, try again!");
                }
            }

            Console.Read();
        }
    }
}
