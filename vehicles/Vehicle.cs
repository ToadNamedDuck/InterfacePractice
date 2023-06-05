using System;

namespace InterfacePractice
{
    public class Vehicle
    {
        public string MainColor {get; set;}

        public int PersonCapacity {get; set;}

        public virtual void Drive()
        {
            Console.WriteLine("Vroom vroom!");
        }
    }
}