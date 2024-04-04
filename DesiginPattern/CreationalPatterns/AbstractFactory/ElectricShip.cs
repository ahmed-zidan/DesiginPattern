using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.CreationalPatterns.AbstractFactory
{
    class ElectricShip: IShip
    {
        public void Charge()
        {
            Console.WriteLine("ElectricTruck charge");
        }

        public void move()
        {
            Console.WriteLine("ElectricTruck move");
        }

        public void stop()
        {
            Console.WriteLine("ElectricTruck move");
        }
    }
}
