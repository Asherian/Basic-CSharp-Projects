using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign164
{
    class MathInt
    {
        //properties required:
        public int num1 { get; set; }
        public decimal num2 { get; set; }
        public int numResult { get; set; }
        public decimal numResult2 { get; set; }
        public string word { get; set; }
        public int wordCount { get; set; }

        //Methods/constructs
        public int Mathy(int num1)
        {
            return num1 + 5;
        }
        public decimal Mathy(decimal num2)
        {
            numResult2 = Convert.ToInt32(num2 * 2);
            return numResult2;

        }

        public int Mathy(string word)
        {
            int wordCount = word.Count();
            return wordCount;
        }
    }
}
