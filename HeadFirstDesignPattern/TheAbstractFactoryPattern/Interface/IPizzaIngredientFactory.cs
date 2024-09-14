﻿namespace HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public List<IVeggies> CreateVeggies();
        public IPepperoni CreatePepperoni();
        public IClam CreateClam();
    }
}
