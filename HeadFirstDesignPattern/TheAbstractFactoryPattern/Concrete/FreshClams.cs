using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class FreshClams : IClam
    {
        public FreshClams()
        {
            Console.WriteLine("Fresh clams");
        }
    }
}
