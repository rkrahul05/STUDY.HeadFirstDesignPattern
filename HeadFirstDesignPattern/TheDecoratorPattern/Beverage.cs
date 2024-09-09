namespace HeadFirstDesignPattern.TheDecoratorPattern
{
    public abstract class Beverage
    {
        public string Description { get; set; } = "Unknown Beverage";
        public virtual string GetDescription() { return Description; }
        public abstract double Cost();
    }
}
