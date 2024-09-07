using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete
{
    public class Quack : QuackBehavior
    {
        public void QuackSounc()
        {
            Console.WriteLine("Make Quack Quack sound.................\n");
        }
    }
}
