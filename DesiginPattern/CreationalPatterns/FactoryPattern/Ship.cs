using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.CreationalPatterns.FactoryPattern
{
    class Ship : ITransport
    {
        public void move()
        {
            Console.WriteLine("Ship Move");
        }

        public void stop()
        {
            Console.WriteLine("Ship Stop");
        }
    }
}
