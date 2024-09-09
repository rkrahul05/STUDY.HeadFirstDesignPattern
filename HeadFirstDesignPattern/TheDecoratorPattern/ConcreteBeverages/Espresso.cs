namespace HeadFirstDesignPattern.TheDecoratorPattern.Beverages
{
    //We will inherite the Beverage class, since this is a Beverage
    public class Espresso : Beverage
    {
        //To take care of description we set this in the constructor for the class. The description instace variable is inherited from Beverage
        public Espresso()
        {
            Description = "Espresso";
        }
        //We need to compute the cost of an Espresso. We don't nedd to worry about adding condiments in this class.
        public override double Cost()
        {
            return 1.99;
        }
    }
}
