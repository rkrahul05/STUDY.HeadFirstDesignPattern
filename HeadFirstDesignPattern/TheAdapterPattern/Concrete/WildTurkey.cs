using HeadFirstDesignPattern.TheAdapterPattern.Interface;

namespace HeadFirstDesignPattern.TheAdapterPattern.Concrete
{
    internal class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
