using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    internal class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Marinara sauce");
        }

    }
}
