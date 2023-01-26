using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.labrab7
{
    class WildDuck:IDuck
     { 
        public string Name { get; }
        public WildDuck(string Name)
        {
            this.Name = Name;
        }
        public void Flight() => Console.WriteLine($"{Name} летит");
        public void Swim() => Console.WriteLine($"{Name} плавает");
        public void Quack() => Console.WriteLine($"{Name} крякает");
    }
}
