using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public abstract class Feline : Mammal
    {
        public Feline(string type, string name, double weight,  string livingRegion) 
            : base(name, type, weight, livingRegion)
        {
        }
    }
}
