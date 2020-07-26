using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign125
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me your favorite fruit:");
            string favFruit = Console.ReadLine();
            string myFruit = "Orange";
            string wFruit = "Kiwi";

            Console.WriteLine("I love " + myFruit + ", I hear " + favFruit + " is great too though! It's rare someone chooses " + wFruit + " though.");

            myFruit = myFruit.ToUpper();
            Console.WriteLine(myFruit + "! is also one of my favorite colors, sorry for shouting I got excited.");

            StringBuilder sentence = new StringBuilder("\t Hi, we just spoke about fruit with questionable grammar.");
            sentence.Append(" \nWhile we're here though I want to remind people that vegetables are delicious.");
            sentence.Append(" Especially as you \nget older and lose the sensitivity to bitter flavor many people have as children.");
            sentence.Append(" While fruit is a \ngreat source of fiber and other important nutriants, its also extremely high in sugar.");
            sentence.Append(" So if its \nbeen a while, give spinach or even kale a try, their amazing for you and taste great when cooked \nright.");

            Console.WriteLine(sentence);
            Console.Read();
        }
    }
}
