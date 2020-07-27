using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign130
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Array and choice.
            string[] sbBooks = new string[] { "Yendi", "Jhereg", "Taltos", "Phoenix Guard", "Dzur", "Dragon" };
            Console.WriteLine("Choose a number 0 to 5 and I'll recommend a Steven Brust novel to read:");
            int sbChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sbBooks[sbChoice]+" is a great book to start with!");

            //Int Array and choice/error message.
            int[] favNum = new int[] {12, 23, 17, 5, 42, 63 };
            Console.WriteLine("Choose a number 0 to 5 and it'll show you one of my favorite numbers.");
            int numChoice = Convert.ToInt32(Console.ReadLine());
            if (numChoice <=5)
            {
                Console.WriteLine(favNum[numChoice] + " has always meant a lot to me.");
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select 0-5");
            }
            //String List display
            List<string> ghoti = new List<string>();
            ghoti.Add("Way of Kings");
            ghoti.Add("A Civil Campaign");
            ghoti.Add("New Spring");
            ghoti.Add("The Warrior's Apprentice");
            ghoti.Add("Do Androids dream of Electric Sheep?");
            ghoti.Add("The Moon is a Harsh Mistress");

            Console.WriteLine("Please choose a number between 0 and 5 for a book title");
            int bookList = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ghoti[bookList] + " is a great book that means a lot to me.");
            Console.Read();
        }
    }
}
