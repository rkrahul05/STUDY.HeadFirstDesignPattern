using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class Onion : IVeggies
    {
        public Onion()
        {
            Console.WriteLine("Onion");
        }
    }
}
