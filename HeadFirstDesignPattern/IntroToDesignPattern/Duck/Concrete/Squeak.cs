using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete
{
    public class Squeak : QuackBehavior
    {
        public void QuackSounc()
        {
            Console.WriteLine("Make Squeak Squeak sound.................\n");
        }
    }
}
