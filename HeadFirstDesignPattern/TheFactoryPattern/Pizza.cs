using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheFactoryPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string  Sauce { get; set; }
        public List<string> Topping { get; set; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough....");
            Console.WriteLine("Adding sauce");
            Console.WriteLine("Adding toppings: ");
            foreach(var item in Topping) Console.WriteLine(" "+item);
        }
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
