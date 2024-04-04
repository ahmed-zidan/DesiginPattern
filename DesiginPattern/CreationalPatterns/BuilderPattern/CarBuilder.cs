using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.CreationalPatterns.BuilderPattern
{
    class CarBuilder : IBuilder
    {
        Car car;
        public CarBuilder()
        {
            car = new Car();
        }
        public void setColor(string color)
        {
            car.color = color;
        }

        public void setHeight(double height)
        {
            car.height = height;
        }

        public void setSpeed(double speed)
        {
            car.speed = speed;
        }

        public void setWidth(double width)
        {
            car.width = width;
        }
        public Car getProduct()
        {
            return car;
        }
    }
}
