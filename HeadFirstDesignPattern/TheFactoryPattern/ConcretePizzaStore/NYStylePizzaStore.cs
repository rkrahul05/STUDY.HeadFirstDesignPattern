using HeadFirstDesignPattern.TheAbstractFactoryPattern.Concrete;
using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;
using HeadFirstDesignPattern.TheFactoryPattern.ConcretePizza.NYStylePizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheFactoryPattern.ConcretePizzaStore
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();
            if (type.Equals("Cheese"))
            {
                return new NYStyleCheesePizza(pizzaIngredientFactory);
            }
            else if (type.Equals("Pepperoni"))
            {
                return new NYStylePepperoniPizza(pizzaIngredientFactory);
            }
            else if (type.Equals("Clam"))
            {
                return new NYStyleClamPizza(pizzaIngredientFactory);
            }
            else if (type.Equals("Veggie"))
            {
                return new NYStyleVeggiePizza(pizzaIngredientFactory);
            }
            else 
            {
                return null;
            }
        }
    }
}
