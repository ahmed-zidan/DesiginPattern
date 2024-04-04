using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.StructuralPattern.Bridge
{
    class RedColor : IColor
    {
        public void draw()
        {
            Console.WriteLine("red Color");
        }
    }
}
