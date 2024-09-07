using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior { get; set; }
        public QuackBehavior quackBehavior { get; set; }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack() 
        {
            quackBehavior.QuackSounc();
        }
    }
}
