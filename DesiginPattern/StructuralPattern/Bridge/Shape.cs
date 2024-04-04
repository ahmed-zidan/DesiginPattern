using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.StructuralPattern.Bridge
{
  public abstract class Shape
    {
       protected IColor color;
        protected Shape(IColor color)
        {
            this.color = color;
        }
    }
}
