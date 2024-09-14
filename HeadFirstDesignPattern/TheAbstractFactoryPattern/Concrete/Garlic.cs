using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class Garlic : IVeggies
    {
        public Garlic()
        {
            Console.WriteLine("Garlic");
        }
    }
}
