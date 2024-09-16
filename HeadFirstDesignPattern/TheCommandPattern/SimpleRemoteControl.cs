namespace HeadFirstDesignPattern.TheCommandPattern
{
    public class SimpleRemoteControl
    {
        //For now we are creating only one slot
        ICommand slot;
        public SimpleRemoteControl()
        {
            
        }
        public void SetCommand(ICommand command)
        {
            this.slot = command;
        }
        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
