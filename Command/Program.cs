interface ICommand
{
    void Positive();
    void Negative();
}
class Conveyor
{
    public void On() => Console.WriteLine("tke pipeline is running");
    public void Off() => Console.WriteLine("the conveyor is stopped");
    public void SpeedIncrease() => Console.WriteLine("increased convoyer speed");
    public void SpeedDecrease() => Console.WriteLine("reduced convoyer speed");
}
class ConvoyorWorkCommand : ICommand
{
    private Conveyor convoyer;
    public ConvoyorWorkCommand(Conveyor _convoyer) => this.convoyer = _convoyer;
    public void Negative() => convoyer.On();
    public void Positive() => convoyer.Off();
}
class ConvoyerAdjustCommand : ICommand
{
    private Conveyor convoyer;
    public ConvoyerAdjustCommand(Conveyor _convoyer) => this.convoyer = _convoyer;
    public void Negative() => convoyer.SpeedIncrease();
    public void Positive() => convoyer.SpeedDecrease();
}
class Multipult
{
    public List<ICommand> commands;
    private Stack<ICommand> history;
    public Multipult()
    {
        commands = new List<ICommand>() { null, null };
        history = new Stack<ICommand>();
    }
    public void SetCommand(int button, ICommand command) =>
        commands[button] = command;
    public void PressOn(int button)
    {
        commands[button].Positive();
        history.Push(commands[button]);
    }
    public void PressCancel()
    {
        if (history.Count != 0) history.Pop().Negative();
    }
}
