namespace HeadFirstDesignPattern.TheDecoratorPattern.ConcreteCondimentDecorator
{
    //Mocha is a decorator, so we inherited CondimentDecorator.
    public class Mocha : CondimentDecorator
    {
        //We are going to instantiate Mocha with a reference to a Beverage. This class inherits the Beverage instance variable to hold the
        //beverage we are wrapping. we set this instance variable to the object we are wrapping. Here we are passing the beverage we are wapping
        // to the decorator's constructor
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override string GetDescription()
        {
            Console.WriteLine("Mocha");
            return Beverage.GetDescription()+", Mocha";
        }
        public override double Cost()
        {
            return Beverage.Cost()+0.20;
        }
    }
}
