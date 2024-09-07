using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I am mallard duck");
        }
    }
}
