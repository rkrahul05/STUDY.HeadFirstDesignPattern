using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Marinara sauce");
        }

    }
}
