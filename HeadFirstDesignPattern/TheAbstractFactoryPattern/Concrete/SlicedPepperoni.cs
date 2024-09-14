using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class SlicedPepperoni : IPepperoni
    {
        public SlicedPepperoni()
        {
            Console.WriteLine("Sliced Pepperoni");
        }
    }
}
