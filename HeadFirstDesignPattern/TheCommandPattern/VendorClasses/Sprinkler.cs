using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class Sprinkler
    {
        public void WaterOn()
        {
            Console.WriteLine("Watering grass");
        }
        public void WaterOff() 
        { 
            Console.WriteLine("Sprinkler Off");
        }
    }
}
