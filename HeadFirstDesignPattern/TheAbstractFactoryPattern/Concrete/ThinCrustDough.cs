using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    internal class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Thin crust dough");
        }
    }
}
