﻿namespace HeadFirstDesignPattern.TheDecoratorPattern.ConcreteCondimentDecorator
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.10;
        }
    }
}
