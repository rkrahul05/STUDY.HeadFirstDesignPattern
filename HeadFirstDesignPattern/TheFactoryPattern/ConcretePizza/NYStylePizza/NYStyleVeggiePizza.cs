using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheFactoryPattern.ConcretePizza.NYStylePizza
{
    public class NYStyleVeggiePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public NYStyleVeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name = "NY Style Veggie Pizza";
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
