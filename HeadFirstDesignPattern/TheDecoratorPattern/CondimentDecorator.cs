namespace HeadFirstDesignPattern.TheDecoratorPattern
{
    //We need to be interchangeable with a Beverage, so we extend the Beverage class
    public abstract class CondimentDecorator : Beverage
    {
        //This Beverage varilable is the Beverage that each Decorator will be wrapping.
        //Notice we are using the Beverage superType to refer to the Beverage so the Decorator can wrap ANY Beverage.
        public Beverage Beverage { get; set; }

        //We're also going to require that the condiment decorators all reimplement the GetDescription() method.
        public abstract string GetDescription();
    }
}
