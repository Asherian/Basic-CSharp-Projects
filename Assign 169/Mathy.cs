﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XmlConfiguration;

namespace Assign_169
{
    class Mathy
    {
        public void divid(int x)
        {
            int result = x / 2;
        }
        public void divid(out decimal x)
        {
            decimal temp = x / 2 ;
            x = temp;
        }
        public static class CreatedDate
        {
            public static string purpose = "To have a static class and fields in it.";
            public static DateTime Today = new DateTime(2020, 08, 01);
        }

    }
}
