using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    internal class FreshClams : IClam
    {
        public FreshClams()
        {
            Console.WriteLine("Fresh clams");
        }
    }
}
