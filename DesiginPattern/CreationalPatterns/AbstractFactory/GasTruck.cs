using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.CreationalPatterns.AbstractFactory
{
    class GasTruck : ITruck
    {
        public void Charge()
        {
            Console.WriteLine("GasTruck charge");
        }

        public void move()
        {
            Console.WriteLine("GasTruck move");
        }

        public void stop()
        {
            Console.WriteLine("GasTruck move");
        }
    }
}
