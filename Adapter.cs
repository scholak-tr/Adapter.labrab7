using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.labrab7
{
    class Adapter:IDuck
    {
        Turkey turkey;
        public Adapter( Turkey t)
        {
            turkey = t;
        }
        public void Flight()
        {
            turkey.Flight();
        }
        public void Swim()
        {
            turkey.Swim();
        }
        public void Quack()
        {
            turkey.Gaga();
        }
    }
}
