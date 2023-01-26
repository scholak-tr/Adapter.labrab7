using System;

namespace Adapter.labrab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Turkey t = new Turkey();
            IDuck[] ducks = { new Adapter(t), new DomesticDuck("Домашняя утка"), new WildDuck("Дикая утка") };

            foreach (var duck in ducks)
            {
                duck.Flight();
                duck.Swim();
                duck.Quack();
            } 
            Console.ReadKey();
        }
       
    }
}
