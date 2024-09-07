using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying with Wings\n");
        }
    }
}
