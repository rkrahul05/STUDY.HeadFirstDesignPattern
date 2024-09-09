﻿namespace HeadFirstDesignPattern.TheDecoratorPattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
