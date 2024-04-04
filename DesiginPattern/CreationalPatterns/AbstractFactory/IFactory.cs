namespace DesiginPattern.CreationalPatterns.AbstractFactory
{
    public interface IFactory
    {
        ITruck createTruck();
        IShip createShip ();
        
    }
}
