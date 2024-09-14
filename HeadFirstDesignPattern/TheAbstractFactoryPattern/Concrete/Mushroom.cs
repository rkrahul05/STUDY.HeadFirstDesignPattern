using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class Mushroom:IVeggies
    {
        public Mushroom()
        {
            Console.WriteLine("Mushroom");
        }
    }
}
