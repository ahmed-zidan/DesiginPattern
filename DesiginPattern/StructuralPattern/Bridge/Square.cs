using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.StructuralPattern.Bridge
{
    class Square :Shape
    {
       
        public Square(int x,IColor color):base(color)
        {
            
        }

    }
}
