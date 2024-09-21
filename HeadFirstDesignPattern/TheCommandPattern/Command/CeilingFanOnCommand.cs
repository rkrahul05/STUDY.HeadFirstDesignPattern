using HeadFirstDesignPattern.TheCommandPattern.VendorClasses;

namespace HeadFirstDesignPattern.TheCommandPattern.Command
{
    public class CeilingFanOnCommand : ICommand
    {
        CeilingFan ceilingFan;
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            ceilingFan.On();
        }
    }
}
