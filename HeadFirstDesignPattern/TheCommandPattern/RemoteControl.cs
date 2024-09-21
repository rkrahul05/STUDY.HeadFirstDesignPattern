using HeadFirstDesignPattern.TheCommandPattern.Command;

namespace HeadFirstDesignPattern.TheCommandPattern
{
    public class RemoteControl
    {
        public ICommand[] onCommands;
        public ICommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for(int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot]= onCommand;
            offCommands[slot]= offCommand;
        }
        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
        }
        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
        }
    }
}
