namespace HeadFirstDesignPattern.TheDecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Drak Roast Coffee";
        }

        public override double Cost()
        {
            return 2.89;
        }
    }
}
