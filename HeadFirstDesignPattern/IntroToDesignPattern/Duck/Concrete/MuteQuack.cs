using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete
{
    public class MuteQuack : QuackBehavior
    {
        public void QuackSounc()
        {
            Console.WriteLine("This Duck can't quack.");
        }
    }
}
