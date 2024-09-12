using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    internal class SlicedPepperoni : IPepperoni
    {
        public SlicedPepperoni()
        {
            Console.WriteLine("Sliced Pepperoni");
        }
    }
}
