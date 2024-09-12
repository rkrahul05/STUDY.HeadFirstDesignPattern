using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    internal class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("Reggiano Cheese");
        }
    }
}
