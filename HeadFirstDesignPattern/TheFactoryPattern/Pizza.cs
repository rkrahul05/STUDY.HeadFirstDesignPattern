using HeadFirstDesignPattern.TheAbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheFactoryPattern
{
    //Modifying the below one for supporting the Abstract factory
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce  Sauce { get; set; }
        public List<IVeggies> Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClam Clam { get; set; }

        public List<string> Topping { get; set; } = new List<string>();

        public abstract void Prepare();
        //The abstract class provides some basic defaults for baking, cutting, and boxing.
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in the official PizzaStore box");
        }
        public string GetName()
        {
            return Name;
        }

    }
}
