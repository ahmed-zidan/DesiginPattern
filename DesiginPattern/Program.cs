using DesiginPattern.CreationalPatterns.AbstractFactory;
using DesiginPattern.CreationalPatterns.FactoryPattern;
using System;

namespace DesiginPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Factory
            IFactory factory = new SeaFatory();
            var tr = factory.createTransport();
            tr.move();
            tr.stop();
            #endregion

            #region AbstractFactory
            CreationalPatterns.AbstractFactory.IFactory fact = new GasFactory();
            fact.createShip();
            fact.createTruck(); 
            #endregion



        }
    }
}
