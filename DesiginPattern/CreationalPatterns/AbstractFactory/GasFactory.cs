using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.CreationalPatterns.AbstractFactory
{
    public class GasFactory : IFactory
    {
        public IShip createShip()
        {
            return new GasShip();
        }

        public ITruck createTruck()
        {
            return new GasTruck();
        }
    }
}
