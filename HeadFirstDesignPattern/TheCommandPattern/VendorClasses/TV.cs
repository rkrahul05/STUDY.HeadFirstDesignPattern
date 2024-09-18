using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheCommandPattern.VendorClasses
{
    public class TV
    {
        public void ON()
        {
            Console.WriteLine("Turning on the TV");
        }
        public void OFF() 
        { 
            Console.WriteLine("TV is turned off");
        }

    }
}
