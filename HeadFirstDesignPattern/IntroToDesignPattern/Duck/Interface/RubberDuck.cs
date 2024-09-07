using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay(); // Rubber ducks can't fly
            quackBehavior = new Squeak(); // Rubber ducks squeak instead of quacking
        }

        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck");
        }
    }
}
