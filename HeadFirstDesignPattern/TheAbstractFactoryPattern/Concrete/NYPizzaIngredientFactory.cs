using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;

namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete
{
    internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public IClam CreateClam()
        {
            throw new NotImplementedException();
        }

        public IDough CreateDough()
        {
            throw new NotImplementedException();
        }

        public IPepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public ISauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public List<IVeggies> CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
