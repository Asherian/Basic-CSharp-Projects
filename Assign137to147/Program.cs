using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Assignpg137to142
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part 1
            string[] colorArray = new string[] { "Blue", "Black", "Green", "Red", "Yellow" };

            Console.WriteLine("Please choose a color");
            string colorUser = Console.ReadLine();

            for (int c = 0; c < colorArray.Length; c++)
            {
                Console.WriteLine("What do you think of the result if we mix " + colorUser + " and " + colorArray[c]);
            }

            //Part 2 - Infinite Loop then fixed. Part 3, it is fixed.

            for (int l = 0; l < colorArray.Length; l++)
                {
                Console.WriteLine(colorArray[l]);
            }

            //Part 4 Create a loop using “<” 
            int num1 = 12;
            int num2 = 23;

            while (num1 < 15)
            {
                Console.WriteLine(num1 + "+" + num2 + ":");
                num1 = num1 + num2;
                Console.WriteLine(num1);
            }

            //Part 5 Create a loop using <=

            while (num1 <= 50)
            {
                num1 = num1 + num2;
                Console.WriteLine(num1);
            }

            //Part 6 Create a List of strings where each item in the list is unique. Ask the user to input text to search for 
            //in the List. Create a loop that iterates through the List and then displays on the screen the index of the List
            //item that matches the user input.
            //Part 7 - Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //Part 8 Add code to that above loop that stops it from executing once a match has been found.
            string[] weekDay = new string[] { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
            bool match = false;

            do
            {
                Console.WriteLine("What day of the week is it right now? Please use a 3 letter day.");
                string userDay = Console.ReadLine();
                userDay = userDay.ToLower();
                bool checkDay = false;

                for (int f = 0; f < weekDay.Length; f++)
                {
                    if (weekDay[f] == userDay)
                    {
                        checkDay = true;
                    }
                }
                if (checkDay == false)
                {
                    Console.WriteLine("That is not a 3 letter day, please try something like Mon or Wed.");
                    userDay = Console.ReadLine();
                    userDay = userDay.ToLower();
                }
                else
                    for (int d = 0; d < weekDay.Length; d++)
                    {
                        if (weekDay[d] == userDay)
                        {
                            Console.WriteLine(userDay + " is a great day to get some studying in!");
                            match = true;
                        }
                    }
            }
            while (match == false);
            //part 9: Create a List of strings that has at least two identical strings in the List. Ask the user to 
            //select text to search for in the List. Create a loop that iterates through the loop and then displays 
            //the indices of the array that contain matching text on the screen.
            //part 10: Add code to that above loop that tells a user if they put in text that isn’t in the List.
            List<string> lyric = new List<string>();
            lyric.Add("here");
            lyric.Add("we");
            lyric.Add("are");
            lyric.Add("born");
            lyric.Add("to");
            lyric.Add("be");
            lyric.Add("kings");
            lyric.Add("we");
            lyric.Add("are");
            lyric.Add("the");
            lyric.Add("princes");
            lyric.Add("of");
            lyric.Add("the");
            lyric.Add("universe");
            bool isMatch = false;

            Console.WriteLine("Pick one of the following words from the lyrics: Here we are born to be kings, we are the princes of the universe.");
            string que = Console.ReadLine();
            que = que.ToLower();

                for (int m = 0; m < lyric.Count; m++)
                    {
                if (lyric[m] == que)

                {
                    Console.WriteLine("The word " + que + " appears as the " + m + " word in the stanza.");
                    isMatch = true;
                }
                else if (isMatch == false)
                {
                    Console.WriteLine("That word is not in this part of the song, please try another word.");
                    que = Console.ReadLine();
                    que = que.ToLower();
                }
                    }
            // part 11, using same string as above - Create a List of strings that has at least two identical 
            // strings in the List. Create a foreach loop that evaluates each item in the list, and displays a 
            // message showing the string and whether or not it has already appeared in the list.
            List<string> dupLyric = new List<string>();
            foreach (string word in lyric)
            {

                if (dupLyric.Contains(word)==true)
                {
                   
                    Console.WriteLine(word+" is duplicated in the lyrics.");
                }
                else if(dupLyric.Contains(word)==false)
                {
                   
                   
                    dupLyric.Add(word);
                }
                else
                {
                    Console.WriteLine("This did not test");
                }
                                    

            }

            Console.ReadLine();

        }
    }
}
