﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign187
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("I quit, I'm done here.");
        }
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.ID == emp2.ID)
            {
                bool result = true;
                return result;
            }
            else
            {
                bool result = false;
                return result;
            }
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return false;
        }


    }
}
