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
            if (type.Equals("Cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else if (type.Equals("Clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (type.Equals("Veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else 
            {
                return null;
            }
        }
    }
}
