using DesiginPattern.CreationalPatterns.FactoryPattern;
using System;

namespace DesiginPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IFactory factory = new SeaFatory();
            var tr= factory.createTransport();


            tr.move();
            tr.stop();


        }
    }
}
