using HeadFirstDesignPattern.TheCommandPattern.VendorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheCommandPattern.Command
{
    public class StereoOffCommand : ICommand
    {
        Stereo stereo { get; set; }
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
        }
    }
}
