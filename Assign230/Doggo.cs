using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign230
{
    public class Doggo
    {
        public Doggo(string name) : this(name, 25)
        {
        }
        public Doggo(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Breed { get; set; }
    }
}
