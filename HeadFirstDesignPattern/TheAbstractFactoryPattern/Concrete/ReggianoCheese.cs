﻿using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    public class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("Reggiano Cheese");
        }
    }
}
