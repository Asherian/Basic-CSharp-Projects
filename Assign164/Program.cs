﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign164
{
    class Program
    {
        static void Main(string[] args)
        {
            MathInt mathing = new MathInt();

            Console.WriteLine("Today we're going to play with numbers, please pick one.");
            mathing.num1 = Convert.ToInt32(Console.ReadLine());

            mathing.numResult = mathing.Mathy(mathing.num1);
            Console.WriteLine("The first thing we did was add 5 for: " + mathing.numResult);

            Console.WriteLine("Please pick a new number: ");
            mathing.num2 = Convert.ToDecimal(Console.ReadLine());

            decimal numResult2 = mathing.Mathy(mathing.num2);
            Console.WriteLine("We multiplied " + mathing.num2 + " by 2 to get: " + numResult2);

            Console.WriteLine("Now, for this one I want you to pick any word:");
            mathing.word = Console.ReadLine();

            int wordCount = mathing.Mathy(mathing.word);
            Console.WriteLine("That word is " + wordCount + " characters long.");

            Console.Read();
        }
    }
}