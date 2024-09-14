using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Thin crust dough");
        }
    }
}
