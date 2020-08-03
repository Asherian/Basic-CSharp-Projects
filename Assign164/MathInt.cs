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
        ///public int num1 { get; set; }
        //public decimal num2 { get; set; }
        //public int numResult { get; set; }
        //public decimal numResult2 { get; set; }
        //public string word { get; set; }
        //public int wordCount { get; set; }

        //Methods/constructs
        public int Mathy(int x)
        {
            return x + 5;
        }
        public int Mathy(decimal x)
        {
            int numResult2 = Convert.ToInt32(x * 2);
            return numResult2;

        }

        public int Mathy(string x)
        {
            int num2 = Convert.ToInt32(x);
            return num2;
        }
    }
}
