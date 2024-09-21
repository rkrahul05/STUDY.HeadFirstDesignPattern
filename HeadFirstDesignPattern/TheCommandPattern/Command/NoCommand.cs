using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.TheCommandPattern.Command
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command");
        }
    }
}
