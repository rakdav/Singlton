
void GiveCommand(IWorker worker,string command)
{
    string str = worker.Execute(command);
    if (str == "") Console.WriteLine("no one knows to do");
    else Console.WriteLine(str);
}
Designer designer = new Designer();
Carpenters carpenters = new Carpenters();
FinishingWorker finishWorker = new FinishingWorker();
designer.SetNextWorker(carpenters).SetNextWorker(finishWorker);
GiveCommand(designer, "design a house");
GiveCommand(designer, "laying a brick");
GiveCommand(designer, "glue wallpaper");
GiveCommand(designer, "conduct the transaction");
interface IWorker
{
    IWorker SetNextWorker(IWorker worker);
    string Execute(string command);
}
abstract class AbsWorker : IWorker
{
    private IWorker? _nextWorker;
    protected AbsWorker()
    {
        _nextWorker = null;
    }
    public virtual string Execute(string command)
    {
        if (_nextWorker != null)
            return _nextWorker.Execute(command);
        return string.Empty;
    }
    public IWorker SetNextWorker(IWorker worker)
    {
        _nextWorker = worker;
        return worker;
    }
}
class Designer : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "design a house")
            return "the designer executed the command: " + command;
        return base.Execute(command);
    }
}
class Carpenters : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "laying a brick")
            return "the carpenter executed the command: " + command;
        return base.Execute(command);
    }
}
class FinishingWorker : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "glue wallpaper")
            return "the interior decoration executed the command: " + command;
        return base.Execute(command);
    }
}