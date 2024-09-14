using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheFactoryPattern.ConcretePizza.NYStylePizza
{
    public class NYStyleCheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public NYStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name = "NY Style Cheese Pizza";
        }

        public override void Prepare()
        {
           Console.WriteLine("Preparing "+ Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
