

namespace DesiginPattern.CreationalPatterns.FactoryPattern
{
    class RoadFactory : IFactory
    {
        public ITransport createTransport()
        {
            return new Truck();
        }
    }
}
