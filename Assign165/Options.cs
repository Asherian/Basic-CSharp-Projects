using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign165
{
    class Options
    {
        //Properties:
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int result { get; set; }

        public int Mathy(int num1, int num2 = 5)
        {
            result = num1 + num2;
            return result;
        }

    }
}
