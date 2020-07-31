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
        public int num1 { get; set; }
        public int numResult { get; set; }


        public int times(int x)
        {
            return x * 10;
        }
        public int plusplus(int x)
        {
            return x + 5;
        }
        public int squares(int x)
        {
            return x * x;
        }
    }
}
