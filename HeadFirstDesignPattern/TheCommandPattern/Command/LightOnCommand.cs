using HeadFirstDesignPattern.TheCommandPattern.VendorClasses;

namespace HeadFirstDesignPattern.TheCommandPattern.Command
{
    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light light) 
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
