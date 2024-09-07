using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(" This Duck can't fly.\n");
        }
    }
}
