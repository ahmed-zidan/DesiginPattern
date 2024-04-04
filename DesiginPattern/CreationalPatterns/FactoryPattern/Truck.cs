
using System;

namespace DesiginPattern.CreationalPatterns.FactoryPattern
{
    class Truck : ITransport
    {
        public void move()
        {
            Console.WriteLine("Truck Move");
        }

        public void stop()
        {
            Console.WriteLine("Truck Stop");
        }
    }
}
