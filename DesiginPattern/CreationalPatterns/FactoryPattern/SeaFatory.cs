using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.CreationalPatterns.FactoryPattern
{
    class SeaFatory : IFactory
    {
        public ITransport createTransport()
        {
            return new Ship();
        }
    }
}
