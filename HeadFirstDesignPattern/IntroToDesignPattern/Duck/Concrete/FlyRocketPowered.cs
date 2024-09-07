using HeadFirstDesignPattern.IntroToDesignPattern.Duck.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.IntroToDesignPattern.Duck.Concrete
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with rocket!");
        }
    }
}
