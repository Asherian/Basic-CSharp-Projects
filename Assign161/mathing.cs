using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assign161
{
    class mathing
    {
        //properties of class:
        public decimal num1 { get; set; }
        public decimal num2 { get; set; }
        public decimal numResult { get; set; }


        public decimal times(decimal x, decimal y)
        {
            return x * y;
        }
        public decimal plusplus(decimal x, decimal y)
        {
            return x + y;
        }
        public decimal squares(decimal x)
        {
            return x * x;
        }
    }
}
