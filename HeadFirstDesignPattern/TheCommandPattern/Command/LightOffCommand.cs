using HeadFirstDesignPattern.TheCommandPattern.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheCommandPattern.Command
{
    public class LightOffCommand : ICommand
    {
        Light light { get; set; }
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
           light.Off();
        }
    }
}
