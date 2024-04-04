using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.CreationalPatterns.BuilderPattern
{
   public interface IBuilder
    {
        void setColor(string color);
        void setWidth(double width);
        void setHeight(double height);
        void setSpeed(double speed);
       

    }
}
